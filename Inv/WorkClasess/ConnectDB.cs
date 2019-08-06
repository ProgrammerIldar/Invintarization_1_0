using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Inv.WorkClasess
{
    public class ConnectDB:Connections
    {
        private string DataSource { get; set; }
        //public string DataBaseName { get; set; }
        private string InitialCatalog { get; set; }
        private string Login { get; set; }
        private string PassWord { get; set; }


        public ConnectDB(string dataSource, string initialCatalog, string login, string passWord)
        {
            DataSource = dataSource;
            InitialCatalog = initialCatalog;
            // DataBaseName = dataBaseName;
            Login = login;
            PassWord = passWord;
        }

       // проверка подключения к Базе данных
            public void checkConection(Button btn, Panel panel, Label connectInfo)
        {
            string connectionString = string.Format("Data Source={0}; Initial Catalog={1}; User ID={2}; Password={3}", DataSource, InitialCatalog, Login, PassWord);

            try
            {
                SqlHelper helper = new SqlHelper(connectionString);
                if (helper.Isconnection)
                    MessageBox.Show("Тест подключения прошел успешно", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn.Enabled = true;
                panel.BackColor = Color.Green;
                connectInfo.Text = "Подключение к базе данных установлено";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                panel.BackColor = Color.Red;
                connectInfo.Text = "Подключение к базе данных не установлено";
            }
        }
     

    }

    
}
