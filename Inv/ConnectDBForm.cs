using Inv.WorkClasess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inv
{
    public partial class ConnectDBForm : MetroFramework.Forms.MetroForm
    {
        public ConnectDBForm()
        {
            InitializeComponent();
        }

        private void LogOnForm_Load(object sender, EventArgs e)
        {
            ServerCB.Items.Add(".");
            ServerCB.Items.Add("(local)");
            ServerCB.Items.Add(@".\SQLEXPRESS");
            // comboBoxServer.Items.Add(string.Format(@"{0}\SQLEXPRESS", Environment.MachineName));
            ServerCB.SelectedIndex = 2;
            metroConectbtn.Enabled = false;
        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {


        }

        private void MetroButton3_Click(object sender, EventArgs e)
        {
            ConnectDB log = new ConnectDB(ServerCB.Text, InitialCatalogTB.Text, LoginTB.Text, passWordTB.Text);
            log.checkConection(metroConectbtn,panelConect, ConectInfo);
            
        }
    }
}
