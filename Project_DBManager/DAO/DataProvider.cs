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
        private readonly string connectString = "Server=cnpm12.cl842wcy40x2.ap-southeast-2.rds.amazonaws.com,1433;Database=DBManager;User Id=admin;Password=congnghephanmem;";
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
        public int ExecuteNonQuery(string query, object[] para = null)
        {
            using (SqlConnection connect = new SqlConnection(connectString))
            {
                connect.Open();
                SqlCommand cmd = new SqlCommand(query, connect);
                if (para != null)
                {
                    int i = 0;
                    foreach (string temp in query.Split(' '))
                    {
                        if (temp.Contains("@"))
                        {
                            string item = temp.Replace(",", ""); // Dành cho trường hợp tham số bị dính giấu ,
                            cmd.Parameters.AddWithValue(item, para[i++]);
                        }
                    }

                }
                return cmd.ExecuteNonQuery();
            }
        }
    }

}
