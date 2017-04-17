using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms ;
using Edward;

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
        public static AppType CurrentAppType = AppType.Server;

        #endregion

        /// <summary>
        /// define current run mode,server or client
        /// </summary>
        public enum AppType
        {
            Server,
            Client
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

        #region 延時子程式

        /// <summary>
        /// 延時子程序
        /// </summary>
        /// <param name="interval">延時的時間，單位毫秒</param>
        public void Delay(double interval)
        {
            DateTime time = DateTime.Now;
            double span = interval * 10000;
            while (DateTime.Now.Ticks - time.Ticks < span)
            {
                Application.DoEvents();
            }

        }

        #endregion






    }
}
