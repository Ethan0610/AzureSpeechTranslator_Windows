using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzureSpeechTranslator_Windows_
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //SoundPlayer sound = new SoundPlayer("audioFile.wav");

            //var client = new HttpClient();
            ////client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(""));
            //client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "da59809d501942fcac0b109fa83552a0");
            //client.BaseAddress = new Uri("wss://dev.microsofttranslator.com/");

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://dev.microsofttranslator.com/languages?api-version=1.0&scope=text,tts,speech");
                


            
        }
    }
}
