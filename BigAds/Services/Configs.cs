using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigAds.Services
{
    class Configs
    {
        public static string ConnectionString = Properties.Settings.Default.ConnectionString.Trim();

        public static string ServerSQL = Properties.Settings.Default.ServerSQL.Trim();

        public static string UserSQL = Properties.Settings.Default.UserSQL.Trim();

        public static string PassSQL = Properties.Settings.Default.PassSQL.Trim();

        public static string DataBase = Properties.Settings.Default.DataBase.Trim();

        public static string UserLogin = Properties.Settings.Default.UserLogin.Trim();

        public static string PassLogin = Properties.Settings.Default.PassLogin.Trim();

        public static string Editmode = Properties.Settings.Default.Editmode.Trim();

        public static string permission = Properties.Settings.Default.permission.Trim();

        public static string remember = Properties.Settings.Default.remember.Trim();

        public static int saveCountHeader = Properties.Settings.Default.saveCountHeader;

        public static int saveCountContent = Properties.Settings.Default.saveCountContent;

        public static string dataGrid = Properties.Settings.Default.dataGrid;


        public static void UpdateSettingAppConfig(string key, string value)
        {
            switch (key)
            {
                case "ConnectionString":
                    Properties.Settings.Default.ConnectionString = value; break;
                case "ServerSQL":
                    Properties.Settings.Default.ServerSQL = value; break;
                case "UserSQL":
                    Properties.Settings.Default.UserSQL = value; break;
                case "PassSQL":
                    Properties.Settings.Default.PassSQL = value; break;
                case "DataBase":
                    Properties.Settings.Default.DataBase = value; break;
                case "UserLogin":
                    Properties.Settings.Default.UserLogin = value; break;
                case "PassLogin":
                    Properties.Settings.Default.PassLogin = value; break;
                case "Editmode":
                    Properties.Settings.Default.Editmode = value; break;
                case "permission":
                    Properties.Settings.Default.permission = value; break;
                case "remember":
                    Properties.Settings.Default.remember = value; break;
                case "saveCountHeader":
                    Properties.Settings.Default.saveCountHeader = int.Parse(value); break;
                case "saveCountContent":
                    Properties.Settings.Default.saveCountContent = int.Parse(value); break;
                case "dataGrid":
                    Properties.Settings.Default.dataGrid = value; break;

            }

            Properties.Settings.Default.Save();
        }
    }
}

