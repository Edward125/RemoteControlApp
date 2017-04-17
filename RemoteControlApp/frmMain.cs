using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
    }
}
