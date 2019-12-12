using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ItI_Project
{
    class DataBaseConnection
    {
       private static string connetionString;
       private static SqlConnection cnn;
       public static string ServerName { get; set; }
       public static string UserName { get; set; }
       public static string Password { get; set; }
       public static bool ISLocal { get; set; }

       static System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        static public void StartConn()
        {
            if (ISLocal == false)
            {
                connetionString = @"Data Source=" + ServerName + ";Initial Catalog=Project_DB; User ID=" + UserName + ";Password=" + Password + ";";
                cnn = new SqlConnection(connetionString);
                config.AppSettings.Settings.Add("Project_DBEntities", "Data Source=" + ServerName + ";Initial Catalog=Project_DB;User ID=" + UserName + ";Password=" + Password + ";");
                config.AppSettings.Settings.Add("Project_DBConnectionString", "Data Source=" + ServerName + ";Initial Catalog=Project_DB;User ID=" + UserName + ";Password=" + Password + ";");

            }
            else
            {
                connetionString = @"Data Source=.;Initial Catalog=Project_DB;Integrated Security=True;";
                cnn = new SqlConnection(connetionString);
                config.AppSettings.Settings.Add("Project_DBEntities", "Data Source=.;Initial Catalog=Project_DB;Integrated Security=True" + "providerName=System.Data.SqlClient");
                config.AppSettings.Settings.Add("Project_DBConnectionString", "Data Source=.;Initial Catalog=Project_DB;Integrated Security=True" + "providerName=System.Data.SqlClient");
            }

           
            if (cnn.State.ToString()=="Closed")
            {
                cnn.Open();    
            }
        }
        static public void CloseConn()
        {
            if (ISLocal == false)
            {
                connetionString = @"Data Source=" + ServerName + ";Initial Catalog=Project_DB; User ID=" + UserName + ";Password=" + Password + ";";
                cnn = new SqlConnection(connetionString);
                config.AppSettings.Settings.Add("Project_DBEntities", "Data Source=" + ServerName + ";Initial Catalog=Project_DB;User ID=" + UserName + ";Password=" + Password + ";");
                config.AppSettings.Settings.Add("Project_DBConnectionString", "Data Source=" + ServerName + ";Initial Catalog=Project_DB;User ID=" + UserName + ";Password=" + Password + ";");

            }
            else
            {
                connetionString = @"Data Source=.;Initial Catalog=Project_DB;Integrated Security=True;";
                cnn = new SqlConnection(connetionString);
                config.AppSettings.Settings.Add("Project_DBEntities", "Data Source=.;Initial Catalog=Project_DB;Integrated Security=True" + "providerName=System.Data.SqlClient");
                config.AppSettings.Settings.Add("Project_DBConnectionString", "Data Source=.;Initial Catalog=Project_DB;Integrated Security=True" + "providerName=System.Data.SqlClient");
            }

            if (cnn.State.ToString()=="Open")
            {
                cnn.Close();
            }
        }
        static public string ConnectionState()
        {
           
            return cnn.State.ToString();
           
        }
        static public SqlConnection Connection ()
        {
            return  cnn;
        }


    }
}
