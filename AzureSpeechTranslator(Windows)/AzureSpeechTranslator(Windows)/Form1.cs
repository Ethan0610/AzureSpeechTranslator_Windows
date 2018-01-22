﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzureSpeechTranslator_Windows_
{
    public partial class Form1 : Form
    {
        // private static object waveFile;
        Stopwatch stopwatch = new Stopwatch();
                string inputJson = "{\"speech\":{\"ar-EG\":{\"name\":\"Arabic\",\"language\":\"ar\"},\"de-DE\":{\"name\":\"German\",\"language\":\"de\"},\"en-US\":{\"name\":\"English\",\"language\":\"en\"},\"es-ES\":{\"name\":\"Spanish\",\"language\":\"es\"},\"fr-FR\":{\"name\":\"French\",\"language\":\"fr\"},\"it-IT\":{\"name\":\"Italian\",\"language\":\"it\"},\"ja-JP\":{\"name\":\"Japanese\",\"language\":\"ja\"},\"pt-BR\":{\"name\":\"Portuguese\",\"language\":\"pt\"},\"ru-RU\":{\"name\":\"Russian\",\"language\":\"ru\"},\"zh-CN\":{\"name\":\"Chinese Simplified\",\"language\":\"zh-Hans\"},\"zh-TW\":{\"name\":\"Chinese Traditional\",\"language\":\"zh-Hant\"}},\"text\":{\"af\":{\"name\":\"Afrikaans\",\"dir\":\"ltr\"},\"ar\":{\"name\":\"Arabic\",\"dir\":\"rtl\"},\"bg\":{\"name\":\"Bulgarian\",\"dir\":\"ltr\"},\"bn\":{\"name\":\"Bangla\",\"dir\":\"ltr\"},\"bs\":{\"name\":\"Bosnian\",\"dir\":\"ltr\"},\"ca\":{\"name\":\"Catalan\",\"dir\":\"ltr\"},\"cs\":{\"name\":\"Czech\",\"dir\":\"ltr\"},\"cy\":{\"name\":\"Welsh\",\"dir\":\"ltr\"},\"da\":{\"name\":\"Danish\",\"dir\":\"ltr\"},\"de\":{\"name\":\"German\",\"dir\":\"ltr\"},\"el\":{\"name\":\"Greek\",\"dir\":\"ltr\"},\"en\":{\"name\":\"English\",\"dir\":\"ltr\"},\"es\":{\"name\":\"Spanish\",\"dir\":\"ltr\"},\"et\":{\"name\":\"Estonian\",\"dir\":\"ltr\"},\"fa\":{\"name\":\"Persian\",\"dir\":\"rtl\"},\"fi\":{\"name\":\"Finnish\",\"dir\":\"ltr\"},\"fil\":{\"name\":\"Filipino\",\"dir\":\"ltr\"},\"fj\":{\"name\":\"Fijian\",\"dir\":\"ltr\"},\"fr\":{\"name\":\"French\",\"dir\":\"ltr\"},\"he\":{\"name\":\"Hebrew\",\"dir\":\"rtl\"},\"hi\":{\"name\":\"Hindi\",\"dir\":\"ltr\"},\"hr\":{\"name\":\"Croatian\",\"dir\":\"ltr\"},\"ht\":{\"name\":\"Haitian Creole\",\"dir\":\"ltr\"},\"hu\":{\"name\":\"Hungarian\",\"dir\":\"ltr\"},\"id\":{\"name\":\"Indonesian\",\"dir\":\"ltr\"},\"it\":{\"name\":\"Italian\",\"dir\":\"ltr\"},\"ja\":{\"name\":\"Japanese\",\"dir\":\"ltr\"},\"ko\":{\"name\":\"Korean\",\"dir\":\"ltr\"},\"lt\":{\"name\":\"Lithuanian\",\"dir\":\"ltr\"},\"lv\":{\"name\":\"Latvian\",\"dir\":\"ltr\"},\"mg\":{\"name\":\"Malagasy\",\"dir\":\"ltr\"},\"ms\":{\"name\":\"Malay\",\"dir\":\"ltr\"},\"mt\":{\"name\":\"Maltese\",\"dir\":\"ltr\"},\"mww\":{\"name\":\"Hmong Daw\",\"dir\":\"ltr\"},\"nb\":{\"name\":\"Norwegian\",\"dir\":\"ltr\"},\"nl\":{\"name\":\"Dutch\",\"dir\":\"ltr\"},\"otq\":{\"name\":\"Querétaro Otomi\",\"dir\":\"ltr\"},\"pl\":{\"name\":\"Polish\",\"dir\":\"ltr\"},\"pt\":{\"name\":\"Portuguese\",\"dir\":\"ltr\"},\"ro\":{\"name\":\"Romanian\",\"dir\":\"ltr\"},\"ru\":{\"name\":\"Russian\",\"dir\":\"ltr\"},\"sk\":{\"name\":\"Slovak\",\"dir\":\"ltr\"},\"sl\":{\"name\":\"Slovenian\",\"dir\":\"ltr\"},\"sm\":{\"name\":\"Samoan\",\"dir\":\"ltr\"},\"sr-Cyrl\":{\"name\":\"Serbian (Cyrillic)\",\"dir\":\"ltr\"},\"sr-Latn\":{\"name\":\"Serbian (Latin)\",\"dir\":\"ltr\"},\"sv\":{\"name\":\"Swedish\",\"dir\":\"ltr\"},\"sw\":{\"name\":\"Kiswahili\",\"dir\":\"ltr\"},\"ta\":{\"name\":\"Tamil\",\"dir\":\"ltr\"},\"th\":{\"name\":\"Thai\",\"dir\":\"ltr\"},\"tlh\":{\"name\":\"Klingon\",\"dir\":\"ltr\"},\"to\":{\"name\":\"Tongan\",\"dir\":\"ltr\"},\"tr\":{\"name\":\"Turkish\",\"dir\":\"ltr\"},\"ty\":{\"name\":\"Tahitian\",\"dir\":\"ltr\"},\"uk\":{\"name\":\"Ukrainian\",\"dir\":\"ltr\"},\"ur\":{\"name\":\"Urdu\",\"dir\":\"rtl\"},\"vi\":{\"name\":\"Vietnamese\",\"dir\":\"ltr\"},\"yua\":{\"name\":\"Yucatec Maya\",\"dir\":\"ltr\"},\"yue\":{\"name\":\"Cantonese (Traditional)\",\"dir\":\"ltr\"},\"zh-Hans\":{\"name\":\"Chinese Simplified\",\"dir\":\"ltr\"},\"zh-Hant\":{\"name\":\"Chinese Traditional\",\"dir\":\"ltr\"}},\"tts\":{\"ar-EG-Hoda\":{\"gender\":\"female\",\"locale\":\"ar-EG\",\"languageName\":\"Arabic\",\"displayName\":\"Hoda\",\"regionName\":\"Egypt\",\"language\":\"ar\"},\"ar-SA-Naayf\":{\"gender\":\"male\",\"locale\":\"ar-SA\",\"languageName\":\"Arabic\",\"displayName\":\"Naayf\",\"regionName\":\"Saudi Arabia\",\"language\":\"ar\"},\"ca-ES-Herena\":{\"gender\":\"female\",\"locale\":\"ca-ES\",\"languageName\":\"Catalan\",\"displayName\":\"Herena\",\"regionName\":\"Spain\",\"language\":\"ca\"},\"cs-CZ-Vit\":{\"gender\":\"male\",\"locale\":\"cs-CZ\",\"languageName\":\"Czech\",\"displayName\":\"Vit\",\"regionName\":\"Czech Republic\",\"language\":\"cs\"},\"da-DK-Helle\":{\"gender\":\"female\",\"locale\":\"da-DK\",\"languageName\":\"Danish\",\"displayName\":\"Helle\",\"regionName\":\"Denmark\",\"language\":\"da\"},\"de-AT-Michael\":{\"gender\":\"male\",\"locale\":\"de-AT\",\"languageName\":\"German\",\"displayName\":\"Michael\",\"regionName\":\"Austria\",\"language\":\"de\"},\"de-CH-Karsten\":{\"gender\":\"male\",\"locale\":\"de-CH\",\"languageName\":\"German\",\"displayName\":\"Karsten\",\"regionName\":\"Switzerland\",\"language\":\"de\"},\"de-DE-Hedda\":{\"gender\":\"female\",\"locale\":\"de-DE\",\"languageName\":\"German\",\"displayName\":\"Hedda\",\"regionName\":\"Germany\",\"language\":\"de\"},\"de-DE-Stefan\":{\"gender\":\"male\",\"locale\":\"de-DE\",\"languageName\":\"German\",\"displayName\":\"Stefan\",\"regionName\":\"Germany\",\"language\":\"de\"},\"de-DE-Katja\":{\"gender\":\"female\",\"locale\":\"de-DE\",\"languageName\":\"German\",\"displayName\":\"Katja\",\"regionName\":\"Germany\",\"language\":\"de\"},\"el-GR-Stefanos\":{\"gender\":\"male\",\"locale\":\"el-GR\",\"languageName\":\"Greek\",\"displayName\":\"Stefanos\",\"regionName\":\"Greece\",\"language\":\"el\"},\"en-AU-Catherine\":{\"gender\":\"female\",\"locale\":\"en-AU\",\"languageName\":\"English\",\"displayName\":\"Catherine\",\"regionName\":\"Australia\",\"language\":\"en\"},\"en-AU-James\":{\"gender\":\"male\",\"locale\":\"en-AU\",\"languageName\":\"English\",\"displayName\":\"James\",\"regionName\":\"Australia\",\"language\":\"en\"},\"en-CA-Linda\":{\"gender\":\"female\",\"locale\":\"en-CA\",\"languageName\":\"English\",\"displayName\":\"Linda\",\"regionName\":\"Canada\",\"language\":\"en\"},\"en-CA-Richard\":{\"gender\":\"male\",\"locale\":\"en-CA\",\"languageName\":\"English\",\"displayName\":\"Richard\",\"regionName\":\"Canada\",\"language\":\"en\"},\"en-GB-George\":{\"gender\":\"male\",\"locale\":\"en-GB\",\"languageName\":\"English\",\"displayName\":\"George\",\"regionName\":\"United Kingdom\",\"language\":\"en\"},\"en-GB-Susan\":{\"gender\":\"female\",\"locale\":\"en-GB\",\"languageName\":\"English\",\"displayName\":\"Susan\",\"regionName\":\"United Kingdom\",\"language\":\"en\"},\"en-IN-Heera\":{\"gender\":\"female\",\"locale\":\"en-IN\",\"languageName\":\"English\",\"displayName\":\"Heera\",\"regionName\":\"India\",\"language\":\"en\"},\"en-IN-Ravi\":{\"gender\":\"male\",\"locale\":\"en-IN\",\"languageName\":\"English\",\"displayName\":\"Ravi\",\"regionName\":\"India\",\"language\":\"en\"},\"en-US-BenjaminRUS\":{\"gender\":\"male\",\"locale\":\"en-US\",\"languageName\":\"English\",\"displayName\":\"BenjaminRUS\",\"regionName\":\"United States\",\"language\":\"en\"},\"en-US-JessaRUS\":{\"gender\":\"female\",\"locale\":\"en-US\",\"languageName\":\"English\",\"displayName\":\"JessaRUS\",\"regionName\":\"United States\",\"language\":\"en\"},\"en-US-Mark\":{\"gender\":\"male\",\"locale\":\"en-US\",\"languageName\":\"English\",\"displayName\":\"Mark\",\"regionName\":\"United States\",\"language\":\"en\"},\"en-US-Zira\":{\"gender\":\"female\",\"locale\":\"en-US\",\"languageName\":\"English\",\"displayName\":\"Zira\",\"regionName\":\"United States\",\"language\":\"en\"},\"en-US-ZiraRUS\":{\"gender\":\"female\",\"locale\":\"en-US\",\"languageName\":\"English\",\"displayName\":\"ZiraRUS\",\"regionName\":\"United States\",\"language\":\"en\"},\"es-ES-Laura\":{\"gender\":\"female\",\"locale\":\"es-ES\",\"languageName\":\"Spanish\",\"displayName\":\"Laura\",\"regionName\":\"Spain\",\"language\":\"es\"},\"es-ES-Pablo\":{\"gender\":\"male\",\"locale\":\"es-ES\",\"languageName\":\"Spanish\",\"displayName\":\"Pablo\",\"regionName\":\"Spain\",\"language\":\"es\"},\"es-MX-Raul\":{\"gender\":\"male\",\"locale\":\"es-MX\",\"languageName\":\"Spanish\",\"displayName\":\"Raul\",\"regionName\":\"Mexico\",\"language\":\"es\"},\"es-MX-Sabina\":{\"gender\":\"female\",\"locale\":\"es-MX\",\"languageName\":\"Spanish\",\"displayName\":\"Sabina\",\"regionName\":\"Mexico\",\"language\":\"es\"},\"fi-FI-Heidi\":{\"gender\":\"female\",\"locale\":\"fi-FI\",\"languageName\":\"Finnish\",\"displayName\":\"Heidi\",\"regionName\":\"Finland\",\"language\":\"fi\"},\"fr-CA-Caroline\":{\"gender\":\"female\",\"locale\":\"fr-CA\",\"languageName\":\"French\",\"displayName\":\"Caroline\",\"regionName\":\"Canada\",\"language\":\"fr\"},\"fr-CA-Claude\":{\"gender\":\"male\",\"locale\":\"fr-CA\",\"languageName\":\"French\",\"displayName\":\"Claude\",\"regionName\":\"Canada\",\"language\":\"fr\"},\"fr-FR-Julie\":{\"gender\":\"female\",\"locale\":\"fr-FR\",\"languageName\":\"French\",\"displayName\":\"Julie\",\"regionName\":\"France\",\"language\":\"fr\"},\"fr-FR-Paul\":{\"gender\":\"male\",\"locale\":\"fr-FR\",\"languageName\":\"French\",\"displayName\":\"Paul\",\"regionName\":\"France\",\"language\":\"fr\"},\"he-IL-Asaf\":{\"gender\":\"male\",\"locale\":\"he-IL\",\"languageName\":\"Hebrew\",\"displayName\":\"Asaf\",\"regionName\":\"Israel\",\"language\":\"he\"},\"hi-IN-Hemant\":{\"gender\":\"male\",\"locale\":\"hi-IN\",\"languageName\":\"Hindi\",\"displayName\":\"Hemant\",\"regionName\":\"India\",\"language\":\"hi\"},\"hi-IN-Kalpana\":{\"gender\":\"female\",\"locale\":\"hi-IN\",\"languageName\":\"Hindi\",\"displayName\":\"Kalpana\",\"regionName\":\"India\",\"language\":\"hi\"},\"hu-HU-Szabolcs\":{\"gender\":\"male\",\"locale\":\"hu-HU\",\"languageName\":\"Hungarian\",\"displayName\":\"Szabolcs\",\"regionName\":\"Hungary\",\"language\":\"hu\"},\"id-ID-Andika\":{\"gender\":\"male\",\"locale\":\"id-ID\",\"languageName\":\"Indonesian\",\"displayName\":\"Andika\",\"regionName\":\"Indonesia\",\"language\":\"id\"},\"it-IT-Cosimo\":{\"gender\":\"male\",\"locale\":\"it-IT\",\"languageName\":\"Italian\",\"displayName\":\"Cosimo\",\"regionName\":\"Italy\",\"language\":\"it\"},\"it-IT-Elsa\":{\"gender\":\"female\",\"locale\":\"it-IT\",\"languageName\":\"Italian\",\"displayName\":\"Elsa\",\"regionName\":\"Italy\",\"language\":\"it\"},\"ja-JP-Ayumi\":{\"gender\":\"female\",\"locale\":\"ja-JP\",\"languageName\":\"Japanese\",\"displayName\":\"Ayumi\",\"regionName\":\"Japan\",\"language\":\"ja\"},\"ja-JP-Ichiro\":{\"gender\":\"male\",\"locale\":\"ja-JP\",\"languageName\":\"Japanese\",\"displayName\":\"Ichiro\",\"regionName\":\"Japan\",\"language\":\"ja\"},\"ja-JP-Watanabe\":{\"gender\":\"female\",\"locale\":\"ja-JP\",\"languageName\":\"Japanese\",\"displayName\":\"Watanabe\",\"regionName\":\"Japan\",\"language\":\"ja\"},\"ko-KR-Minjoon\":{\"gender\":\"male\",\"locale\":\"ko-KR\",\"languageName\":\"Korean\",\"displayName\":\"Minjoon\",\"regionName\":\"Korea\",\"language\":\"ko\"},\"ko-KR-Seohyun\":{\"gender\":\"female\",\"locale\":\"ko-KR\",\"languageName\":\"Korean\",\"displayName\":\"Seohyun\",\"regionName\":\"Korea\",\"language\":\"ko\"},\"nb-NO-Jon\":{\"gender\":\"male\",\"locale\":\"nb-NO\",\"languageName\":\"Norwegian\",\"displayName\":\"Jon\",\"regionName\":\"Norway\",\"language\":\"nb\"},\"nb-NO-Nina\":{\"gender\":\"female\",\"locale\":\"nb-NO\",\"languageName\":\"Norwegian\",\"displayName\":\"Nina\",\"regionName\":\"Norway\",\"language\":\"nb\"},\"nl-NL-Frank\":{\"gender\":\"male\",\"locale\":\"nl-NL\",\"languageName\":\"Dutch\",\"displayName\":\"Frank\",\"regionName\":\"Netherlands\",\"language\":\"nl\"},\"nl-NL-Marijke\":{\"gender\":\"female\",\"locale\":\"nl-NL\",\"languageName\":\"Dutch\",\"displayName\":\"Marijke\",\"regionName\":\"Netherlands\",\"language\":\"nl\"},\"pl-PL-Adam\":{\"gender\":\"male\",\"locale\":\"pl-PL\",\"languageName\":\"Polish\",\"displayName\":\"Adam\",\"regionName\":\"Poland\",\"language\":\"pl\"},\"pl-PL-Paulina\":{\"gender\":\"female\",\"locale\":\"pl-PL\",\"languageName\":\"Polish\",\"displayName\":\"Paulina\",\"regionName\":\"Poland\",\"language\":\"pl\"},\"pt-BR-Daniel\":{\"gender\":\"male\",\"locale\":\"pt-BR\",\"languageName\":\"Portuguese\",\"displayName\":\"Daniel\",\"regionName\":\"Brazil\",\"language\":\"pt\"},\"pt-BR-Maria\":{\"gender\":\"female\",\"locale\":\"pt-BR\",\"languageName\":\"Portuguese\",\"displayName\":\"Maria\",\"regionName\":\"Brazil\",\"language\":\"pt\"},\"pt-PT-Helia\":{\"gender\":\"female\",\"locale\":\"pt-PT\",\"languageName\":\"Portuguese\",\"displayName\":\"Helia\",\"regionName\":\"Portugal\",\"language\":\"pt\"},\"ro-RO-Andrei\":{\"gender\":\"male\",\"locale\":\"ro-RO\",\"languageName\":\"Romanian\",\"displayName\":\"Andrei\",\"regionName\":\"Romania\",\"language\":\"ro\"},\"ru-RU-Irina\":{\"gender\":\"female\",\"locale\":\"ru-RU\",\"languageName\":\"Russian\",\"displayName\":\"Irina\",\"regionName\":\"Russia\",\"language\":\"ru\"},\"ru-RU-Pavel\":{\"gender\":\"male\",\"locale\":\"ru-RU\",\"languageName\":\"Russian\",\"displayName\":\"Pavel\",\"regionName\":\"Russia\",\"language\":\"ru\"},\"sk-SK-Filip\":{\"gender\":\"male\",\"locale\":\"sk-SK\",\"languageName\":\"Slovak\",\"displayName\":\"Filip\",\"regionName\":\"Slovakia\",\"language\":\"sk\"},\"sv-SE-Bengt\":{\"gender\":\"male\",\"locale\":\"sv-SE\",\"languageName\":\"Swedish\",\"displayName\":\"Bengt\",\"regionName\":\"Sweden\",\"language\":\"sv\"},\"sv-SE-Karin\":{\"gender\":\"female\",\"locale\":\"sv-SE\",\"languageName\":\"Swedish\",\"displayName\":\"Karin\",\"regionName\":\"Sweden\",\"language\":\"sv\"},\"th-TH-Pattara\":{\"gender\":\"male\",\"locale\":\"th-TH\",\"languageName\":\"Thai\",\"displayName\":\"Pattara\",\"regionName\":\"Thailand\",\"language\":\"th\"},\"tr-TR-Seda\":{\"gender\":\"female\",\"locale\":\"tr-TR\",\"languageName\":\"Turkish\",\"displayName\":\"Seda\",\"regionName\":\"Turkey\",\"language\":\"tr\"},\"tr-TR-Tolga\":{\"gender\":\"male\",\"locale\":\"tr-TR\",\"languageName\":\"Turkish\",\"displayName\":\"Tolga\",\"regionName\":\"Turkey\",\"language\":\"tr\"},\"zh-CN-Kangkang\":{\"gender\":\"male\",\"locale\":\"zh-CN\",\"languageName\":\"Chinese Simplified\",\"displayName\":\"Kangkang\",\"regionName\":\"People's Republic of China\",\"language\":\"zh-Hans\"},\"zh-CN-Yaoyao\":{\"gender\":\"female\",\"locale\":\"zh-CN\",\"languageName\":\"Chinese Simplified\",\"displayName\":\"Yaoyao\",\"regionName\":\"People's Republic of China\",\"language\":\"zh-Hans\"},\"zh-HK-Danny\":{\"gender\":\"male\",\"locale\":\"zh-HK\",\"languageName\":\"Cantonese (Traditional)\",\"displayName\":\"Danny\",\"regionName\":\"Hong Kong S.A.R.\",\"language\":\"yue\"},\"zh-HK-Tracy\":{\"gender\":\"female\",\"locale\":\"zh-HK\",\"languageName\":\"Cantonese (Traditional)\",\"displayName\":\"Tracy\",\"regionName\":\"Hong Kong S.A.R.\",\"language\":\"yue\"},\"zh-TW-Yating\":{\"gender\":\"female\",\"locale\":\"zh-TW\",\"languageName\":\"Chinese Traditional\",\"displayName\":\"Yating\",\"regionName\":\"Taiwan\",\"language\":\"zh-Hant\"},\"zh-TW-Zhiwei\":{\"gender\":\"male\",\"locale\":\"zh-TW\",\"languageName\":\"Chinese Traditional\",\"displayName\":\"Zhiwei\",\"regionName\":\"Taiwan\",\"language\":\"zh-Hant\"}}}";
        List<string> langList;
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

        }

        private void Timer_Click(object sender, EventArgs e)
        {
            //Timer.Text = timeSpan;
        }

        private void TranslateFrom1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void Tranlateto1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var languageSelected = TranlatetoAudio.SelectedItem;


            dynamic jsonObject = JObject.Parse(inputJson);

            foreach (var s in jsonObject.speech)
            {
                
            }

            foreach (var s in jsonObject.tts)
            {
                langList.Add();

            }


            for (int i = 0; i < s.Value.language.count; i++)
                if (languageSelected == s.Value.language)
                {
                    var name = s.Value.DisplayName;

                    comboBox1.Items.Add(name);
                }
        }
        

        private void TranslateFrom2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TranslateTo2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void SendAudio_Click(object sender, EventArgs e)
        {
            //@"wss://dev.microsofttranslator.com/speech/translate?from={from}&to={to}{2}&api-version=1.0"
            var from = TranslateFromAudio;
            var to = TranlatetoAudio;
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}