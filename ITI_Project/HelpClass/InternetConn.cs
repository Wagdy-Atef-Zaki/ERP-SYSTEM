using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ItI_Project.HelpClass
{
   public  class InternetConn
    {

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://www.google.com/generate_204"))
                    return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
