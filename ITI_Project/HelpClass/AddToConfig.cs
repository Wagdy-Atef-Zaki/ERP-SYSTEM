using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItI_Project.HelpClass
{
    class AddToConfig
    {

        public static void CreateAppSettings(string sectionName,
                              string key, string value)
        {
            try
            {
                Configuration config =
                 ConfigurationManager.OpenExeConfiguration
                                       (ConfigurationUserLevel.None);

                config.AppSettings.Settings.Add(key, value);
                config.Save();
                ConfigurationManager.RefreshSection(sectionName);
            }
            catch (ConfigurationErrorsException e)
            {
                Console.WriteLine("[CreateAppSettings: {0}]",
                                  e.ToString());
                Console.WriteLine();
            }
        }


        public static string GetAppSettingValue(string key)
        {
            try
            {
                NameValueCollection appSettings =
                     ConfigurationManager.AppSettings;

                string[] arr = appSettings.GetValues(key);
                return arr[0];
            }
            catch (ConfigurationErrorsException e)
            {
                Console.WriteLine("[CreateAppSettings: {0}]",
                                  e.ToString());
                Console.WriteLine();
                return e.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine("[CreateAppSettings: {0}]",
                                  e.ToString());
                Console.WriteLine();
                return e.ToString();
            }
        }
    }
}
