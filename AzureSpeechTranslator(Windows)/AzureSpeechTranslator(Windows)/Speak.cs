using System.Net;
using System.IO;
using System.Web;
using System.Media;

namespace AzureSpeechTranslator_Windows_
{
    class Speak
    {
        public static void Run(string authToken)
        {
            string uri = "https://api.microsofttranslator.com/v2/Http.svc/Speak?text=welcome&language=en&format=" + HttpUtility.UrlEncode("audio/wav") + "&options=MaxQuality";
            WebRequest webRequest = WebRequest.Create(uri);
            webRequest.Headers.Add("Authorization", authToken);
            using (WebResponse response = webRequest.GetResponse())
            using (Stream stream = response.GetResponseStream())
            {
                using (SoundPlayer player = new SoundPlayer(stream))
                {
                    player.PlaySync();
                }
            }
        }
    }
}
