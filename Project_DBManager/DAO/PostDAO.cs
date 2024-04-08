using Project_DBManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DBManager.DAO
{
    public class PostDAO
    {
        private static PostDAO instance;
        public static PostDAO Instance
        {
            get { if (instance == null) instance = new PostDAO(); return instance; }
            set { PostDAO.instance = value; }
        }
        
        public bool isBrandNameExist(string brandName)
        {
            string query = "SELECT Brand_Name FROM Brand_Info WHERE Brand_Name = @Brand_Name";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { brandName });
            return dt.Rows.Count > 0;
        }

        public int getBrandIdByBrandName(string brandName)
        {
            string query = "SELECT * FROM Brand_Info WHERE Brand_Name = @Brand_Name";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { brandName });
            return Convert.ToInt32(dt.Rows[0][0].ToString());
        }

        public void insertValueIntoPost(int userId, string brandName, string content) 
        {
            int brandId = getBrandIdByBrandName(brandName);
            DateTime uploadDate = DateTime.Now;
            DateTime lastChangeDate = DateTime.Now;
            string query = "INSERT INTO Post(Brand_ID, User_ID, Content, Upload_Date, LastChange_Date) VALUES ( @Brand_ID, @User_ID, @Content, @Upload_Date, @LastChange_Date )";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { brandId, userId, content, uploadDate, lastChangeDate });
        }

        public string getStatusByBrandName(string brandName)
        {
            int brandId = getBrandIdByBrandName(brandName);
            string query = "SELECT * FROM Brand WHERE Brand_ID = @Brand_ID";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { brandId });
            MessageBox.Show(dt.Rows[0]["Status"].ToString());
            return dt.Rows[0]["Status"].ToString();
        }

        public List<PostInfo> getPostInfo()
        {
            List<PostInfo> postInfoList = new List<PostInfo>();
            string query = "SELECT User_ID, Brand_Name, Phone_Number, Address, Facebook, Status, Content FROM POST P, Brand B, Brand_Info BI WHERE P.Brand_ID = BI.Brand_ID AND BI.Brand_ID = B.Brand_ID";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                postInfoList.Add(new PostInfo(row));
            }
            return postInfoList;
        }
    }
}
