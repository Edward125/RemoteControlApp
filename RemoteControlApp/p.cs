using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms ;
using Edward;
using System.Diagnostics;

namespace RemoteControlApp
{
    class p
    {

        #region 参数

        //
        public static string AppFolder = Application.StartupPath + @"\RemoteControlApp";
        public static string IniFilePath = AppFolder + @"\SysConfig.ini";
        public static string SysLogFolder = AppFolder + @"\SysLog"; //存放所有信息的文件夹
        public static string SysLogFile = SysLogFolder + @"\Sys_" + DateTime.Now.ToString("yyyyMMdd") + @".log";
        //
        public static AppType CurrentAppType = AppType.Null;

        #endregion

        /// <summary>
        /// define current run mode,server or client
        /// </summary>
        public enum AppType
        {
            Server,
            Client,
            Null
        }

        /// <summary>
        /// define ini file section
        /// </summary>
        public enum IniSection
        {
            SysConfig,
            Server,
            Client
        }


        #region createIniFile

        /// <summary>
        /// create ini file,write the default value
        /// </summary>
        /// <param name="inifilepath">ini path</param>
        public static void createIniFile(string inifilepath)
        {
            IniFile.CreateIniFile(inifilepath);
            //IniFile.IniFilePath = inifilepath;
            //
            IniFile.IniWriteValue(IniSection.SysConfig.ToString(),"CurrentAppType", p.CurrentAppType.ToString () , inifilepath);
           
        }


        #endregion

        #region readConfigValue

        /// <summary>
        /// read value from config file
        /// </summary>
        /// <param name="inifilepath">ini file path</param>
        private static void readConfigValue(string inifilepath)
        {

            string _CurrentAppType = IniFile.IniReadValue(IniSection.SysConfig.ToString(), "CurrentAppType", inifilepath);
            if (!string.IsNullOrEmpty(_CurrentAppType))
                p.CurrentAppType = (AppType)Enum.Parse(typeof(AppType), _CurrentAppType);


        }


        #endregion







        #region 延時子程式

        /// <summary>
        /// 延時子程序
        /// </summary>
        /// <param name="interval">延時的時間，單位毫秒</param>
        public static  void Delay(double interval)
        {
            DateTime time = DateTime.Now;
            double span = interval * 10000;
            while (DateTime.Now.Ticks - time.Ticks < span)
            {
                Application.DoEvents();
            }

        }

        #endregion

        #region delme

        /// <summary>
        /// delete myselef
        /// </summary>
        public static void  DelMe()
        {
            string fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "remove.bat");
            
            StreamWriter bat = new StreamWriter(fileName, false, Encoding.Default);
            bat.WriteLine(string.Format("del \"{0}\" /q", Application.ExecutablePath));
            bat.WriteLine(string.Format("del \"{0}\" /q", fileName));
            bat.Close();
            File.SetAttributes(fileName, FileAttributes.Hidden);
            ProcessStartInfo info = new ProcessStartInfo(fileName);
            info.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(info);
            Environment.Exit(0);
        }


        #endregion




    }
}
