using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace Shabes_Gast
{
    internal class DBConnection
    {
        static SqlConnection sqlConnection;
        static string connectionString = "server = ARI-GOTLIB\\SQLSERVER; initial catalog = Shabat; user id = sa; password = 1234; TrustServerCertificate = Yes";

        public static bool Connect()
        {
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                
                sqlConnection.Open();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }    
        }
        public static SqlDataReader RunSqlAllResult(string sql, string[] parameters = null, string[] values = null)
        {
            if (Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.CommandText = sql;
                    // Add parameters
                    if (parameters != null)
                    {
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            cmd.Parameters.AddWithValue(parameters[i], values[i]);
                        }
                    }
                   
                    return cmd.ExecuteReader();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
            return null;
        }
        public static DataTable RunSqlDataResult(string sql, string[] parameters = null, string[] values = null)
        {
            if (Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.CommandText = sql;
                    // Add parameters
                    if (parameters != null)
                    {
                        for (int i = 0; i < parameters.Length; i++)
                        {
                            cmd.Parameters.AddWithValue(parameters[i], values[i]);
                        }
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter (cmd);
                    DataTable dataTable = new DataTable ();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
            return null;
        }
        public static void RunSqlNoReturn(string sql, string[] parmeters = null, string[] values = null)
        {
            if (Connect())
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = sqlConnection;
                    cmd.CommandText = sql;
                    if (parmeters != null && values != null)
                    {
                        for (int i = 0; i < parmeters.Length; i++)
                        {
                            cmd.Parameters.AddWithValue(parmeters[i], values[i]);
                        }
                    }
                    cmd.ExecuteNonQuery();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}
