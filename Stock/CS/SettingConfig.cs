using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.CS
{
    public class SettingConfig
    {
        /// <summary>
        /// 新增項目到設定檔[AppSettings]
        /// </summary>
        /// <param name="KeyName"></param>
        /// <param name="Value"></param>
        public static void additem(string KeyName, string Value)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.AppSettings.Settings.Add(KeyName, Value);

            config.Save(ConfigurationSaveMode.Modified);

            ConfigurationManager.RefreshSection("appSettings");
        }

        /// <summary>
        /// 刪除設定檔中的Key[AppSettings]
        /// </summary>
        /// <param name="KeyName"></param>
        public static void delete(string[] KeyName)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            foreach (string key in KeyName)
            {
                config.AppSettings.Settings.Remove(key);
            }
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        /// <summary>
        /// 確認設定檔中有沒有Key存在[AppSettings]
        /// </summary>
        /// <param name="KeyName"></param>
        /// <returns></returns>
        public static bool existkeyname(string KeyName)
        {
            foreach (string key in ConfigurationManager.AppSettings)
            {
                if (key == KeyName)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 取得設定檔的值[AppSettings]
        /// </summary>
        /// <param name="KeyName"></param>
        /// <returns></returns>
        public static string getitemvalue(string KeyName)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            string info = "";
            if (existkeyname(KeyName))
            {
                info = config.AppSettings.Settings[KeyName].Value;
            }

            return info;
        }

        /// <summary>
        /// 修改設定檔中的值[AppSettings]
        /// </summary>
        /// <param name="KeyName"></param>
        /// <param name="Value"></param>
        public static void modifyitem(string KeyName, string Value)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            // 存在時修改,不存在時新增
            if (existkeyname(KeyName))
            {
                config.AppSettings.Settings[KeyName].Value = Value;
                config.Save(ConfigurationSaveMode.Modified);
            }
            else
            {
                additem(KeyName, Value);
            }

            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
