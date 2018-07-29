using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using System.IO;
using System.Data;


namespace RandomExtract
{
    public class Config
    {
        public static string Mode = "A1";//模式
        public static int MIN = 1;//最小值
        public static int MAX = 99;//最大值
        public static List<string> name = new List<string>();//抽取名单
        public static List<string> AllNameList = new List<string>();//所有名单
        public static string NameList = "";//配置名单
        #region 操作XML
        public static string ReadSetting(string key)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings[key] ?? "Not Found";
                return result;
            }
            catch (ConfigurationErrorsException)
            {
                return "Error reading app settings";
            }
        }

        public static int AddUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
                return 1;//修改成功
            }
            catch (ConfigurationErrorsException)
            {
                return 0;//修改失败
            }
        }
        #endregion

        #region 获取配置
        public static void GetConfig()
        {
            //获取当前模式
            if(ReadSetting("Mode")== "Not Found")
            {
                AddUpdateAppSettings("Mode", "A1");
            }else if(ReadSetting("Mode")== "Error reading app settings")
            {
                MessageBox.Show("Error reading app settings");
            }
            else
            {
                Mode = ReadSetting("Mode");
            }
            //获取最小值
            if (ReadSetting("MIN") == "Not Found")
            {
                AddUpdateAppSettings("MIN", "1");
            }
            else if (ReadSetting("MIN") == "Error reading app settings")
            {
                MessageBox.Show("Error reading app settings");
            }
            else
            {
                MIN = Convert.ToInt32(ReadSetting("MIN"));
                if (MIN <= 0)
                {
                    MIN = 1;
                }
            }
            //获取最大值
            if (ReadSetting("MAX") == "Not Found")
            {
                AddUpdateAppSettings("MAX", "100");
            }
            else if (ReadSetting("MAX") == "Error reading app settings")
            {
                MessageBox.Show("Error reading app settings");
            }
            else
            {
                MAX = Convert.ToInt32(ReadSetting("MAX"));
                if (MAX<=MIN)
                {
                    MAX = MIN + 1;
                }
            }
            //获取名单
            if (ReadSetting("NameList") == "Not Found")
            {
                AddUpdateAppSettings("NameList", "");
            }
            else if (ReadSetting("NameList") == "Error reading app settings")
            {
                MessageBox.Show("Error reading app settings");
            }
            else
            {
                NameList = ReadSetting("NameList");
            }
            GetNameList();
        }
        #endregion

        #region 保存配置
        public static void SaveSetting()
        {
            AddUpdateAppSettings("Mode", Mode);
            AddUpdateAppSettings("MIN", MIN.ToString());
            AddUpdateAppSettings("MAX", MAX.ToString());
            AddUpdateAppSettings("NameList", NameList);
        }
        #endregion

        #region 获取名单目录下所有文件名（名单）
        public static void GetAllNameList()
        {
            for (int i = AllNameList.Count - 1; i >= 0; i--)
            {
                AllNameList.RemoveAt(i);
            }
            String path = System.AppDomain.CurrentDomain.BaseDirectory+@"NameList";
            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] fileInfo = dir.GetFiles();
            foreach (FileInfo item in fileInfo)
            {
                AllNameList.Add(item.Name);
            }
        }
        #endregion

        #region 读取名单
        public static int GetNameList()
        {
            if (NameList=="")
            {
                return 0;
            }
            for (int i = name.Count - 1; i >= 0; i--)
            {
                name.RemoveAt(i);
            }
            string sFilePath = String.Format(@"NameList\{0}", NameList);//名单文件路径
            //// 判断学生名单是否存在
            if (!File.Exists(sFilePath))
            {
                return 0;//名单文件不存在
            }
            string sName = string.Empty;
            FileStream fs = new FileStream(sFilePath, FileMode.Open);
            //// "GB2312"用于显示中文字符，写其他的，中文会显示乱码
            StreamReader reader = new StreamReader(fs, UnicodeEncoding.GetEncoding("GB2312"));
            //// 一行一行读取
            while ((sName = reader.ReadLine()) != null)
            {
                sName = sName.Trim().ToString();
                name.Add(sName);
            }
            //// 关闭文件流
            fs.Close();
            return 1;//成功
        }
        #endregion
    }
}
