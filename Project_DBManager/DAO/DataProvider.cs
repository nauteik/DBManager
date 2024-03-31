using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing.Text;
namespace Project_DBManager.DAO
{
    internal class DataProvider
    {
        private readonly string connectString = "Data Source =.\\PINOCHIO; Initial Catalog = DBManager; Integrated Security = True";
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return instance; }
            private set { DataProvider.instance = value; }
        }
        private DataProvider() { }

        public DataTable ExecuteQuery(string query, object[] para = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connect = new SqlConnection(connectString))
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand(query, connect);
                if(para != null)
                {
                    int i = 0;
                    foreach (string item in query.Split(' '))
                    {
                        
                        if (item.Contains("@"))
                        {
                            
                            item.Replace(",", ""); // Dành cho trường hợp tham số bị dính giấu ,
                            cmd.Parameters.AddWithValue(item, para[i++]);
                        }
                    }
                    
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                connect.Close();
            }
            return data;
        }
        public int ExecuteNonQuery(string query, string[] para = null)
        {
            using (SqlConnection connect = new SqlConnection(connectString))
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand(query, connect);
                if (para != null)
                {
                    int i = 0;
                    foreach (string item in query.Split(' '))
                    {

                        if (item.Contains("@"))
                        {

                            item.Replace(",", ""); // Dành cho trường hợp tham số bị dính giấu ,
                            cmd.Parameters.AddWithValue(item, para[i++]);
                        }
                    }

                }

                return cmd.ExecuteNonQuery();
            }
        }
    }

}
