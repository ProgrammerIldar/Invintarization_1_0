using System;
using System.Data;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace Inv.WorkClasess
{
    public class AddEditCatriges
    {
        private int CatrigeID;
        public void AddEdit(Button btnSave, string serialNumber, int printerModelID, int modelColorID, int catrigeStatusID)
        {
            using (SqlConnection con = new SqlConnection(Connections.connection))
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    if (btnSave.Text == "Сохранить")
                    {
                        SqlCommand sqlCmd = new SqlCommand("CatrigeAddOrEdit", con);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@mode", "Add");
                        sqlCmd.Parameters.AddWithValue("@CatrigeID", 0);
                        sqlCmd.Parameters.AddWithValue("@SerialNumber", serialNumber);
                        sqlCmd.Parameters.AddWithValue("@PrinterModelID", printerModelID);
                        sqlCmd.Parameters.AddWithValue("@ColorModelID", modelColorID);
                        sqlCmd.Parameters.AddWithValue("@CatrigeStatusID", catrigeStatusID);

                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Картридж добавлен");
                    }
                    else
                    {
                        SqlCommand sqlCmd = new SqlCommand("CatrigeAddOrEdit", con);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                        sqlCmd.Parameters.AddWithValue("@ContactId", CatrigeID);
                        sqlCmd.Parameters.AddWithValue("@SerialNumber", serialNumber);
                        sqlCmd.Parameters.AddWithValue("@PrinterModelID", printerModelID);
                        sqlCmd.Parameters.AddWithValue("@ColorModelID", modelColorID);
                        sqlCmd.Parameters.AddWithValue("@CatrigeStatusID", catrigeStatusID);
                        MessageBox.Show("Данные о картридже обновлены");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message");
                }
                finally
                {
                    con.Close();
                }
            }
        }

    }
}
