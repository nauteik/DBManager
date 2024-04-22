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

        public List<string> getTypeList()
        {
            List<string> typeList = new List<string>();
            string query = "SELECT Type FROM Brand";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                typeList.Add(row["Type"].ToString());
            }
            return typeList;
        }

        public int getBrandIdDoNotHaveContract()
        {
            List<int> brandIdList = new List<int>();
            string query = "SELECT Brand_ID FROM Contract";
            DataTable dtBrand = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in dtBrand.Rows)
            {
                brandIdList.Add(Convert.ToInt32(row["Brand_ID"].ToString()));
            }
            query = "SELECT Brand_ID FROM Brand";
            DataTable dtContract = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in dtContract.Rows)
            {
                if (!brandIdList.Contains(Convert.ToInt32(row["Brand_ID"].ToString())))
                {
                    return Convert.ToInt32(row["Brand_ID"].ToString());
                }
            }
            return -1;
        }

        public void createNewBrand(string brandName, string type, string representPhoneNumber)
        {
            string query = "INSERT INTO Brand (Brand_Name, Type, Brand_Represent, Status) VALUES ( @Brand_Name, @Type, @Brand_Represent, N'Chưa tạo bài đăng' )";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] {brandName, type, representPhoneNumber});
        }
    }
}
