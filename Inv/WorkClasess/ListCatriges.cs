using Inv.Models;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Inv.WorkClasess
{
   public class ListCatriges
    {
        //Выводит список картриджей
        public void ListCatrigesAll(DataGridView dgv)
        {
            using (SqlConnection con = new SqlConnection(Connections.connection))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter("CatrigeAll", con);
                    sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    dgv.DataSource = dtbl;

                }
                catch (SqlException ex)
                {

                    throw;
                }
                finally
                {
                    con.Close();
                }
            }

        }
   }
}

