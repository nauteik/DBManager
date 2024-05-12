using System.Data;

namespace Project_DBManager.DTO
{
    public class AccountWithPhone
    {
        private int userID;
        private bool isChecked;
        private string name;
        private string username;
        private string password;
        private string email;
        private string sdt;
        public AccountWithPhone(DataRow row)
        {
            UserID = int.Parse(row["User_ID"].ToString());
            username = row["Username"].ToString();
            password = row["Password"].ToString();
            email = row["User_Email"].ToString();
            Sdt = row["PhoneNum"].ToString();
            name = row["Name"].ToString();
            isChecked = false;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public int UserID { get => userID; set => userID = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public bool IsChecked { get => isChecked; set => isChecked = value; }
        public string Name { get => name; set => name = value; }
    }
}
