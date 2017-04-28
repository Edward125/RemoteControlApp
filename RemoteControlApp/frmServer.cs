using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace RemoteControlApp
{
    public partial class frmServer : Form
    {
        public frmServer()
        {
            InitializeComponent();
        }

        private void frmServer_Load(object sender, EventArgs e)
        {
            loadUI();
        }


        private void loadUI()
        {
            foreach (var item in p.getIP (Dns.GetHostName (),p.IpType.IPV4 ))
            {
                this.txtIP.Text = item;
            }
        }



    }
}
