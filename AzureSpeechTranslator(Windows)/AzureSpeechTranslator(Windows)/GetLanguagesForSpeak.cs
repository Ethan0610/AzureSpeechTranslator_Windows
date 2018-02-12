using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization;

namespace Microsoft.Translator.Samples
{
    class GetLanguagesForSpeakSample
    {
        public static void Run(string authToken)
        {
            string uri = "https://api.microsofttranslator.com/v2/Http.svc/GetLanguagesForSpeak";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(uri);
            httpWebRequest.Headers.Add("Authorization", authToken);
            using (WebResponse response = httpWebRequest.GetResponse())
            using (Stream stream = response.GetResponseStream())
            {
                DataContractSerializer dcs = new DataContractSerializer(typeof(List<string>));
                List<string> languagesForSpeak = (List<string>)dcs.ReadObject(stream);
                
            }
        }
    }
}