using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Edward;

namespace RemoteControlApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //
            this.Text = Application.ProductName + ", Ver:" + Application.ProductVersion + ", Author:edward_song@yeah.net";
            checkFolder();
            if (!File.Exists(p.IniFilePath))
                p.createIniFile(p.IniFilePath);
            p.readConfigValue(p.IniFilePath);
            
            
        }



        #region OnlyRunOne

        /// <summary>
        /// only run one,if not,return false,if yes,retun true
        /// </summary>
        /// <returns></returns>
        private bool CheckOnlyRunOne()
        {

            Process current = Process.GetCurrentProcess();
            Process[] processes = Process.GetProcessesByName(current.ProcessName);
            foreach (Process process in processes)
            {
                if (process.Id != current.Id)
                {
                    if (process.MainModule.FileName == current.MainModule.FileName)
                        return false;

                }
            }     

            return true;
        }



        #endregion


        #region savelog

        /// <summary>
        /// 保存log
        /// </summary>
        /// <param name="logcontents">log內容</param>
        public static void saveLog(string logcontents)
        {
            //根据logtype获取对应的文件路徑以及文件名
            string logpath = string.Empty;

            //判斷文件是否存在，不存在就创建文件，存在就写入文件
            if (!File.Exists(@logpath))
            {
                FileStream fs = File.Create(@logpath);
                fs.Close();
            }
            try
            {

                File.AppendAllText(@logpath, DateTime.Now.ToString("yyyyMMddHHmmss") + " " + @logcontents + "\r\n");
            }
            catch (Exception)
            {
                //wait

            }


        }

        #endregion

        #region checkFoder
        private void checkFolder()
        {

            if (!Directory.Exists(p.AppFolder))
                Directory.CreateDirectory(p.AppFolder);
            if (!Directory.Exists(p.SysLogFolder))
                Directory.CreateDirectory(p.SysLogFolder);
        }
        #endregion

        private void btnServer_Click(object sender, EventArgs e)
        {
            p.CurrentAppType = p.AppType.Server;
            IniFile.IniWriteValue(p.IniSection.SysConfig.ToString(), "CurrentAppType", p.CurrentAppType.ToString(), p.IniFilePath);
            Form f = new frmServer();
            f.Show();
            this.Hide();


        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            p.CurrentAppType = p.AppType.Client;
            IniFile.IniWriteValue(p.IniSection.SysConfig.ToString(), "CurrentAppType", p.CurrentAppType.ToString(), p.IniFilePath);
            Form f = new frmClient();
            f.Show();
            this.Hide();
        }
    }
}
