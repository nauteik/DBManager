using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DBManager.DTO
{
    public class HistoryEditBrandInfo
    {
        private DateTime time;
        private string userID;
        private string brandID;
        private string username;
        private string contentsChanged;

        public DateTime Time { get { return time; } set { time = value; } }
        public string UserID {  get { return userID; } set {  userID = value; } }
        public string BrandID { get { return brandID; } set {  brandID = value; } }
        public string Username { get { return username; } set { username = value; } }
        public string ContentsChanged { get { return contentsChanged; } set {  contentsChanged = value; } }

        public HistoryEditBrandInfo(DataRow dt) 
        {
            this.time = Convert.ToDateTime(dt["History_Time"]);
            this.userID = dt["User_ID"].ToString();
            this.brandID = dt["Brand_ID"].ToString() ;
            this.username = dt["username"].ToString();
            this.contentsChanged = dt["Contents_Changed"].ToString();
        }

        public HistoryEditBrandInfo(string userID, string brandID, string username, string contentsChanged)
        {
            this.userID = userID;
            this.brandID = brandID;
            this.username = username;
            this.contentsChanged = contentsChanged;
        }
    }
}
