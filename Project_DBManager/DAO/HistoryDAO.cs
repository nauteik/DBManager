using Project_DBManager.DTO;
using System.Collections.Generic;
using System.Data;

namespace Project_DBManager.DAO
{
    public class HistoryDAO
    {
        private static HistoryDAO instance;
        public static HistoryDAO Instance
        {
            get { if (instance == null) instance = new HistoryDAO(); return instance; }
            set { HistoryDAO.instance = value; }
        }

        public void insertIntoHistory(HistoryEditBrandInfo his)
        {
            string query = "EXEC INSERT_INTO_HISTORY @User_ID, @Brand_ID, @Username, @Contents_Changed";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { his.UserID, his.BrandID, his.Username, his.ContentsChanged });
        }

        public List<string> loadHistory(int brandID)
        {
            List<string> lst = new List<string>();
            string query = "SELECT History_Time, Name, Contents_Changed FROM History_Brand WHERE Brand_ID = @Brand_ID";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { brandID });
            foreach (DataRow row in dt.Rows)
            {
                lst.Add(row["History_Time"].ToString() + " - " + row["Name"].ToString() + " - " + row["Contents_Changed"].ToString());
            }
            return lst;
        }
    }

}
