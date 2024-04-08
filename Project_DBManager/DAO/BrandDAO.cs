using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
