using System.Data;

namespace Project_DBManager.DAO
{
    public class UserInfoDAO
    {
        private static UserInfoDAO instance;
        public static UserInfoDAO Instance
        {
            get { if (instance == null) instance = new UserInfoDAO(); return instance; }
            set { UserInfoDAO.instance = value; }
        }

        public string getNamebyUsername(string username)
        {
            string query = "SELECT Name FROM User_Info Where Username = @Username";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { username });
            return dt.Rows[0]["Name"].ToString();
        }
    }
}
