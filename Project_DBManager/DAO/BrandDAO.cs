using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Contracts;
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

        public DataRow getTypeAndPhoneOfBrandByContractId(string contractId)
        {
            string query = "SELECT Type, Brand_Represent FROM Contract C, Brand B WHERE C.Brand_ID = B.Brand_ID AND C.Contract_ID = @Contract_ID";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] {contractId});
            return dt.Rows[0];
        }

        public int getBrandIdByContractId(string contractId)
        {
            string query = "SELECT Brand_ID FROM Contract WHERE Contract_ID = @Contract_ID";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { contractId });
            return Convert.ToInt32(dt.Rows[0]["Brand_ID"].ToString());
        }

        public void updateTypeAndBrandRepresentAndBrandName(string brandName, string type, string representPhoneNumber, int brandId)
        {
            string query = "UPDATE Brand SET Brand_Name = @Brand_Name, Type = @Type, Brand_Represent = @Brand_Represent WHERE Brand_ID = @Brand_ID";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { brandName, type, representPhoneNumber, brandId });
        }
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

        public string getBrandIdByPostId(string postId)
        {
            string query = "SELECT Brand_ID FROM Post WHERE Post_ID = @Post_ID";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { postId });
            return dt.Rows[0]["Brand_ID"].ToString();
        }
}
