using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DBOracleGlobal
{
    public class GlobalConfig
    {
        public static string ConnStr { get; set; }

        public static int SleepTime { get; set; }


        public static int TableSize { get; set; }
        /// <summary>
        /// 获取配置文件.
        /// </summary>
        /// <returns>ConfigXmlDocument.</returns>

        public static void ConfigInit()
        {
            ConfigXmlDocument cxd = GetConfigXmlDocument();
            GetGlobalConfiguration(cxd);
        }


        public static ConfigXmlDocument GetConfigXmlDocument(string configUrl = "")
        {
            string file = configUrl;
            if (string.IsNullOrEmpty(file))
            {
                file = Application.StartupPath + @"\GlobalAppConfig.config";
            }
            if (File.Exists(file))
            {
                ConfigXmlDocument cxd = new ConfigXmlDocument();
                cxd.Load(file);
                return cxd;
            }
            return null;
        }


        public static void GetGlobalConfiguration(ConfigXmlDocument cxd)
        {
            try
            {
                if (cxd == null) return;
                ConnStr = GetConfiguration(cxd, "ConnStr");
                SleepTime = int.Parse(GetConfiguration(cxd, "SleepTime"));
                TableSize = int.Parse(GetConfiguration(cxd, "TableSize"));
            }
            catch (Exception e)
            {

            }
        }

        private static string GetConfiguration(ConfigXmlDocument cxd, string key)
        {
            if (string.IsNullOrEmpty(key)) return string.Empty;
            /*XmlNodeList xns = cxd.GetElementsByTagName("appSettings");*/
            XmlNode xn = cxd.SelectSingleNode(@"//add[@key='" + key + "']");
            if (xn == null || xn.Attributes == null) return string.Empty;
            string value = xn.Attributes["value"].Value;
            return value;
        }
    }
}
