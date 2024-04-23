using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DBManager.DAO
{
    public class BrandDAO
    {
        private static BrandDAO instance;
        public static BrandDAO Instance
        {
            get { if (instance == null) instance = new BrandDAO(); return instance; }
            set { BrandDAO.instance = value; }
        }

        public List<string> getBrandNameList()
        {
            List<string> brandNameList = new List<string>();
            string query = "SELECT Brand_Name FROM Brand";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                brandNameList.Add(row[0].ToString());
            }
            return brandNameList;
        }

        public DataRow getBrandInfoByBrandName(string brandName)
        {
            string query = "SELECT Phone_Number, Address, Facebook, Status FROM Brand_Info BI, Brand B WHERE BI.Brand_ID = B.Brand_ID AND Brand_Name = @Brand_Name";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { brandName });
            return dt.Rows[0];
        }

        public void updateBrandStatus(string brandName)
        {
            string query = "UPDATE Brand SET Status = N'Đã tạo bài đăng' WHERE Brand_Name = @Brand_Name";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] {brandName});
        }

        public string getStatusByBrandName(string brandName)
        {
            string query = "SELECT * FROM Brand WHERE Brand_ID = @Brand_ID";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { brandName });
            MessageBox.Show(dt.Rows[0]["Status"].ToString());
            return dt.Rows[0]["Status"].ToString();
        }

        public int getBrandIdByBrandName(string brandName)
        {
            string query = "SELECT * FROM Brand WHERE Brand_Name = @Brand_Name";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { brandName });
            return Convert.ToInt32(dt.Rows[0][0].ToString());
        }

        public bool isBrandNameExist(string brandName)
        {
            string query = "SELECT Brand_Name FROM Brand WHERE Brand_Name = @Brand_Name";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { brandName });
            return dt.Rows.Count > 0;
        }

        public DataTable getBrandDetails(string postID)
        {
            string query = "SELECT BI.Brand_ID, B.Brand_Name, BI.Phone_Number, BI.Facebook, BI.Introduction, BI.Address, B.Status " +
                "FROM Post P, Brand_Info BI, Brand B WHERE P.Post_ID = @Post_ID AND B.Brand_ID = P.Brand_ID AND BI.Brand_ID = P.Brand_ID";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { postID });
            return dt;
        }

        public bool updateBrandDetails(string brandID, string phoneNumber, string facebook, string introduction, string address, string status)
        {
            string query_1 = "UPDATE Brand_Info SET Phone_Number = @Phone_Number, Facebook = @Facebook, Introduction = @Introduction, " +
                "Address = @Address WHERE Brand_ID = @Brand_ID";
            DataProvider.Instance.ExecuteNonQuery(query_1, new object[] {phoneNumber, facebook, introduction, address, brandID });

            string query_2 = "UPDATE Brand SET Status = @Status WHERE Brand_ID = @Brand_ID";
            DataProvider.Instance.ExecuteNonQuery(query_2, new object[] { status, brandID });
            return true;
        }
    }
}
