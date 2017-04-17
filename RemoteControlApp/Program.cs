using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using Edward;

namespace RemoteControlApp
{
    static class Program
    {
        private static System.Threading.Mutex mutex;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mutex = new System.Threading.Mutex(true, "OnlyRun");
            if (mutex .WaitOne (0,false ))
            {
                if (!File.Exists(p.IniFilePath))
                    Application.Run(new frmMain());

                else
                {
                    string _CurrentAppType = IniFile.IniReadValue(p.IniSection.SysConfig.ToString(), "CurrentAppType", p.IniFilePath);
                    if (!string.IsNullOrEmpty(_CurrentAppType))
                        p.CurrentAppType = (p.AppType)Enum.Parse(typeof(p.AppType), _CurrentAppType);

                    if(p.CurrentAppType == p.AppType.Null )
                        Application.Run(new frmMain());
                    if (p.CurrentAppType == p.AppType.Server)
                        Application.Run(new frmServer());
                    if (p.CurrentAppType == p.AppType.Client)
                        Application.Run(new frmClient());
                }
            }
            else 
            {
                MessageBox.Show("Program already run！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Application.Exit();
            }
        }
    }
}
