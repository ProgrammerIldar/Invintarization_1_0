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
    public class OperationOfCatrige
    {
       public DataGridView gridView { get; set; }

        //Изменение статуса картриджа
        public void UppdateByCatrigeStatus(int catrigeID, int statusID)
        {
            using (SqlConnection con = new SqlConnection(Connections.connection))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UpdateStatusCatrige", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@CatrigeID", catrigeID);
                    cmd.Parameters.AddWithValue("@CatrigeStatus", statusID);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Статус обновлен");
                    
                    
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
