using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace RapidCase.Common.SpecFlow
{
    public class WebConfigHelper
    {
        public static void SetAppSettingValue(string appSetting, string newValue)
        {
            string text;
            using(StreamReader reader = System.IO.File.OpenText(@"..\..\..\RapidCase.GUI\web.config"))
            {
                text = reader.ReadToEnd();
            }
            string appSettingReplaceString = "<add key=\"" + appSetting + "\" value=\"(.*)\" />";
            string appSettingNewValue ="<add key=\"" + appSetting + "\" value=\""+newValue+"\" />";
            text = Regex.Replace(text, appSettingReplaceString, appSettingNewValue, RegexOptions.IgnoreCase);
            using (StreamWriter writer = new StreamWriter(System.IO.File.Create(@"..\..\..\RapidCase.GUI\web.config")))
            {                
                writer.Write(text);
            }               
        }

        public static string GetAppSettingValue(string appSetting)
        {
            string text;
            using (StreamReader reader = System.IO.File.OpenText(@"..\..\..\RapidCase.GUI\web.config"))
            {
                text = reader.ReadToEnd();
            }
            string appSettingMatchString = "<add key=\"" + appSetting + "\" value=\"(?<appValue>.*)\" />";
            Match match = Regex.Match(text, appSettingMatchString);
            if (match.Success)
            {
                return match.Groups["appValue"].Value;
            }

            return "";
        }
    }
}
