using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using NAudio.Wave;

namespace AzureSpeechTranslator_Windows_
{
    public partial class Form1 : Form
    {
        string authToken = "1263cdd8ad3049a6b545d6ad9bb50ca6";
        Stopwatch stopwatch = new Stopwatch();

        public WaveIn waveSource = null;
        public WaveFileWriter waveFile = null;

        public Form1()
        {
            InitializeComponent();

        }

        private void RecordStart(object sender, EventArgs e)
        {

            stopwatch.Start();
        }

        public void RecordStop(object sender, EventArgs e)
        {
            stopwatch.Stop();
            TimeSpan timeSpan = stopwatch.Elapsed;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> langs = GetLanguagesForTranslate();

            foreach (string lang in langs)
            {
                TranslateFromText.Items.Add(lang);
                TranslateToText.Items.Add(lang);
            }

        }


        private void SendText_Click(object sender, EventArgs e)
        {
            speakButton.Enabled = false;
            //grab to and from language codes from drop down boxes
            string toLang = TranslateToText.Text;
            textOutputLabel.Text = TextTranslate(TextInput.Text, TranslateFromText.Text, toLang);

            List<string> langsForSpeak = GetLanguagesForSpeak();

            foreach (string lang in langsForSpeak)
            {
                if (toLang == lang)
                {
                    speakButton.Enabled = true;
                    break;
                }
                if (toLang == "zh-CHS" || toLang == "zh-CHT")
                {
                    speakButton.Enabled = true;
                    toLang = "zh-chs";
                }
            }
            if (TextInput.Text != "")
            {
                textOutputLabel.Text = TextTranslate(TextInput.Text, TranslateFromText.Text, toLang);
            }
            else
            {
                AudioToText();
            }



        }


        public string TextTranslate(string text, string from, string to)// take in to and from language codes
        {
            string uri = "https://api.microsofttranslator.com/v2/Http.svc/Translate?text=" + HttpUtility.UrlEncode(text) + "&from=" + from + "&to=" + to;
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(uri);
            httpWebRequest.Headers.Add("Ocp-Apim-Subscription-Key", authToken);
            using (WebResponse response = httpWebRequest.GetResponse())
            using (Stream stream = response.GetResponseStream())
            {
                DataContractSerializer dcs = new DataContractSerializer(Type.GetType("System.String"));
                string translation = (string)dcs.ReadObject(stream);
                return translation;
            }
        }

        public List<string> GetLanguagesForTranslate()
        {

            string uri = "https://api.microsofttranslator.com/v2/Http.svc/GetLanguagesForTranslate";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(uri);
            httpWebRequest.Headers.Add("Ocp-Apim-Subscription-Key", authToken);
            using (WebResponse response = httpWebRequest.GetResponse())
            using (Stream stream = response.GetResponseStream())
            {
                DataContractSerializer dcs = new DataContractSerializer(typeof(List<string>));
                List<string> languagesForTranslate = (List<string>)dcs.ReadObject(stream);
                return languagesForTranslate;

            }

        }
        public List<string> GetLanguagesForSpeak()
        {
            string uri = "https://api.microsofttranslator.com/v2/Http.svc/GetLanguagesForSpeak";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(uri);
            httpWebRequest.Headers.Add("Ocp-Apim-Subscription-Key", authToken);
            using (WebResponse response = httpWebRequest.GetResponse())
            using (Stream stream = response.GetResponseStream())
            {
                DataContractSerializer dcs = new DataContractSerializer(typeof(List<string>));
                List<string> languagesForSpeak = (List<string>)dcs.ReadObject(stream);
                return languagesForSpeak;
            }
        }

        public void Speak()
        {

            string lang = TranslateToText.Text;
            string words = textOutputLabel.Text;
            string uri = $"https://api.microsofttranslator.com/v2/Http.svc/Speak?text={words}&language={lang}&format={HttpUtility.UrlEncode("audio/wav")}&options=MaxQuality";
            WebRequest webRequest = WebRequest.Create(uri);
            webRequest.Headers.Add("Ocp-Apim-Subscription-Key", authToken);
            using (WebResponse response = webRequest.GetResponse())
            using (Stream stream = response.GetResponseStream())
            {

                using (SoundPlayer player = new SoundPlayer(stream))
                {
                    player.PlaySync();
                }
            }
        }

      

        void waveSource_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (waveFile != null)
            {
                waveFile.Write(e.Buffer, 0, e.BytesRecorded);
                waveFile.Flush();
            }
        }

        void waveSource_RecordingStopped(object sender, StoppedEventArgs e)
        {
            if (waveSource != null)
            {
                waveSource.Dispose();
                waveSource = null;
            }

            if (waveFile != null)
            {
                waveFile.Dispose();
                waveFile = null;
            }

            StartBtn.Enabled = true;
        }

        private void speakButton_Click(object sender, EventArgs e)
        {
            Speak();
        }


        public void AudioToText()
        {
            //string requestUri = $"https://speech.platform.bing.com/speech/recognition/interactive/cognitiveservices/v1?language={TranslateFromText.Text}&format=detailed";
            string requestUri = "https://speech.platform.bing.com/speech/recognition/interactive/cognitiveservices/v1?language=en-US&format=detailed";

            HttpWebRequest request = null;
            request = (HttpWebRequest)HttpWebRequest.Create(requestUri);
            request.SendChunked = true;
            request.Accept = @"application/json;text/xml";
            request.Method = "POST";
            request.ProtocolVersion = HttpVersion.Version11;
            request.ContentType = @"audio/wav; codec=audio/pcm; samplerate=16000";
            request.Headers["Ocp-Apim-Subscription-Key"] = "c5f65b8e00814055ba10d275ea8facdd";

            // Send an audio file by 1024 byte chunks
            using (FileStream fs = new FileStream("Test0001.wav", FileMode.Open, FileAccess.Read))
            {

                /*
                * Open a request stream and write 1024 byte chunks in the stream one at a time.
                */
                byte[] buffer = null;
                int bytesRead = 0;
                using (Stream requestStream = request.GetRequestStream())
                {
                    /*
                    * Read 1024 raw bytes from the input audio file.
                    */
                    buffer = new Byte[checked((uint)Math.Min(1024, (int)fs.Length))];
                    while ((bytesRead = fs.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        requestStream.Write(buffer, 0, bytesRead);
                    }

                    // Flush
                    requestStream.Flush();
                }

                string responseString = "";
               
                using (WebResponse response = request.GetResponse())
                {
                    //Console.WriteLine(((HttpWebResponse)response).StatusCode);

                    using (StreamReader sr = new StreamReader(response.GetResponseStream()))
                    {
                        responseString = sr.ReadToEnd();
                    }
                    //result = JsonConvert.DeserializeObject<AudioToTextResult>.responseString;
                    TextInput.Text = responseString;

                }
            }
        }
        private void StartBtn_Click(object sender, EventArgs e)
        {
            TextInput.Enabled = false;
            StartBtn.Enabled = false;
            StopBtn.Enabled = true;

            waveSource = new WaveIn();
            waveSource.WaveFormat = new WaveFormat(44100, 1);

            waveSource.DataAvailable += new EventHandler<WaveInEventArgs>(waveSource_DataAvailable);
            waveSource.RecordingStopped += new EventHandler<StoppedEventArgs>(waveSource_RecordingStopped);

            waveFile = new WaveFileWriter(@"Test0001.wav", waveSource.WaveFormat);

            waveSource.StartRecording();
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            StopBtn.Enabled = false;

            waveSource.StopRecording();


        }


    }// end of form class
} //end of namespace