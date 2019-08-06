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
    public partial class LogOnForm : MetroFramework.Forms.MetroForm
    {
        public LogOnForm()
        {
            InitializeComponent();
        }

        private void LogOn_Load(object sender, EventArgs e)
        {
        }

        private void MetroCancaleBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            LogOn logOn = new LogOn(loginTB.Text, passWordTb.Text);

            logOn.PressLogin();
            this.Hide();
        }
    }
}
