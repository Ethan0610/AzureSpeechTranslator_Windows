using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureSpeechTranslator_Windows_
{
    /*
{
  speech: [
    localeName: {
        name : string
        language: string
    }
  ],
  text: [
    languageAbbr: {
      name: string
      dir: string
    }
  ],
  tts: [
    languageDesc: {
      gender: string
      locale: string
      languageName: string
      displayName: string
      regionName: string
      language: string
    }
  ]
}

         */

    public class SpeechObject
    {
        //public (string localeName, LocaleInfo localeInfo)[] Speech { get; set; }
        //public (string languageAbbreviation, LanguageAbbreviationInfo languageAbbreviationInfo)[] Text { get; set; }
        //public (string languageDescription, LanguageDescriptionInfo languageDescriptionInfo)[] TTS { get; set; }

        //[JsonProperty("speech")]
        //public SpeechInfo Speech { get; set; }

        //[JsonProperty("text")]
        //public TextInfo Text { get; set; }

        [JsonProperty("tts")]
        public TTSInfo TTS { get; set; }

        //public class SpeechInfo
        //{
        //    [JsonProperty("ar-EG")]
        //    public LocaleInfo EgyptianArabic { get; set; }

        //    [JsonProperty("en-US")]
        //    public LocaleInfo AmericanEnglish { get; set; }

        //    public class LocaleInfo
        //    {
        //        public string Name { get; set; }
        //        public string Language { get; set; }
        //    }
        //}

        //public class TextInfo
        //{
        //    [JsonProperty("ar")]
        //    public LanguageAbbreviationInfo Arabic { get; set; }

        //    [JsonProperty("en")]
        //    public LanguageAbbreviationInfo English { get; set; }

        //    public class LanguageAbbreviationInfo
        //    {
        //        public string Name { get; set; }
        //        public string Dir { get; set; }
        //    }

        //}

        public class TTSInfo
        {
            [JsonProperty("en-US-BenjaminRUS")]
            public LanguageDescriptionInfo enUSBenjaminRUS { get; set; }

            [JsonProperty("en-US-JessaRUS")]
            public LanguageDescriptionInfo enUSJessaRUS {get; set;}


            //en-US-Mark
            //en-US-Zira
            //en-US-ZiraRUS
            //es-ES-Laura
            //es-ES-Pablo

            public class LanguageDescriptionInfo
            {
                public string Gender { get; set; }
                public string Locale { get; set; }
                public string LanguageName { get; set; }
                public string DisplayName { get; set; }
                public string RegionName { get; set; }
                public string Language { get; set; }
            }
        }
    }
}
