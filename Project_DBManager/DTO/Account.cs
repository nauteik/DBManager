using System;
using System.Data;

namespace Project_DBManager.DTO
{
    public class Account
    {
        private int userID;
        private string username;
        private string password;
        private string email;
        private int level;
        public Account(DataRow row)
        {
            UserID = int.Parse(row["User_ID"].ToString());
            username = row["Username"].ToString();
            password = row["Password"].ToString();
            email = row["User_Email"].ToString();
            level = Convert.ToInt32(row["Level"]);
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public int Level { get => level; set => level = value; }
        public int UserID { get => userID; set => userID = value; }
    }
}
