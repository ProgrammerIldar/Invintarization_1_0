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
    public class SearchCatriges
    {

        /// <summary>
        /// 
        /// Универсальный метод для поиска по разным критериям. Метод принимает следующие параметры
        /// процедуру для выполнения, параметр SQL например @Param, параметр откуда будут поступать данные 
        /// и DataGridView для вывода
        /// </summary>

        private string ParamSql { get; set;}
            private string Param { get; set;}
            private  string StoregeProcedure { get; set;}
            private  DataGridView Dgv { get; set;}
            


        public SearchCatriges(string storegeProcedure, string paramSql, string param,DataGridView dgv)
        {
            Param = param;
            ParamSql = paramSql;
            StoregeProcedure = storegeProcedure;
            Dgv = dgv;
        }

        public void CatrigeSearch()
        {

            using (SqlConnection con = new SqlConnection(Connections.connection))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter sqlDa = new SqlDataAdapter(StoregeProcedure, con);
                    sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sqlDa.SelectCommand.Parameters.AddWithValue(ParamSql, Param);
                    DataTable dtbl = new DataTable();
                    sqlDa.Fill(dtbl);
                    Dgv.DataSource = dtbl;

                }
                catch (Exception)
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
