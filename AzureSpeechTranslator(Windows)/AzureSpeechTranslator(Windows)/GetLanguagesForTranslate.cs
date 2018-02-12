using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization;

namespace AzureSpeechTranslator_Windows_
{
    class GetLanguagesForTranslate
    {

        public static void Run(string authToken)
        {
            
            string uri = "https://api.microsofttranslator.com/v2/Http.svc/GetLanguagesForTranslate";
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(uri);
            httpWebRequest.Headers.Add("Ocp-Apim-Subscription-Key", authToken);
            using (WebResponse response = httpWebRequest.GetResponse())
            using (Stream stream = response.GetResponseStream())
            {   
                DataContractSerializer dcs = new DataContractSerializer(typeof(List<string>));
                List<string> languagesForTranslate = (List<string>)dcs.ReadObject(stream);

            }
        }
    }
}

