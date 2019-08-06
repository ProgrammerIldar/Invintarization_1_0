using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inv.WorkClasess
{
    public class LogOn
    {
        private string Login { get; set; }
        private string PassWord { get; set; }

        public LogOn()
        {

        }
        public LogOn(string login, string passWord)
        {
            Login = login;
            PassWord = passWord;
        }

       
        public void PressLogin()
        {
            string query = "Select * from LoginUser Where UserLogin = '" + Login + "' and UserPassword = '" + PassWord + "'";
            using (SqlConnection con = new SqlConnection(Connections.connection))
            {
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if(dtbl.Rows.Count==1)
                {
                    MainForm mainForm = new MainForm();            
                    mainForm.Show();
                  
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Введите ваше имя и пароль");
                }

            }
        }
        
    }
}
