using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace RapidCase.Common.SpecFlow
{
    public class ChangeWebConfig
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
            using (StreamWriter writer = new StreamWriter(System.IO.File.OpenWrite(@"..\..\..\RapidCase.GUI\web.config")))
            {
                writer.Write(text);
            }               
        }
    }
}
