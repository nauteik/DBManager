using System;
using System.Data;

namespace Project_DBManager.DTO
{
    public class HistoryEditBrandInfo
    {
        private DateTime time;
        private string userID;
        private int brandID;
        private string username;
        private string contentsChanged;

        public DateTime Time { get { return time; } set { time = value; } }
        public string UserID { get { return userID; } set { userID = value; } }
        public int BrandID { get { return brandID; } set { brandID = value; } }
        public string Username { get { return username; } set { username = value; } }
        public string ContentsChanged { get { return contentsChanged; } set { contentsChanged = value; } }

        

        public HistoryEditBrandInfo(string userID, int brandID, string username, string contentsChanged)
        {
            this.userID = userID;
            this.brandID = brandID;
            this.username = username;
            this.contentsChanged = contentsChanged;
        }
    }
}
