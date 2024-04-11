using Project_DBManager.DTO;
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
    public class PostDAO
    {
        private static PostDAO instance;
        public static PostDAO Instance
        {
            get { if (instance == null) instance = new PostDAO(); return instance; }
            set { PostDAO.instance = value; }
        }

        public void insertValueIntoPost(int userId, string brandName, string content) 
        {
            int brandId = BrandDAO.Instance.getBrandIdByBrandName(brandName);
            DateTime uploadDate = DateTime.Now;
            DateTime lastChangeDate = DateTime.Now;
            string query = "INSERT INTO Post(Brand_ID, User_ID, Content, Upload_Date, LastChange_Date) VALUES ( @Brand_ID, @User_ID, @Content, @Upload_Date, @LastChange_Date )";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { brandId, userId, content, uploadDate, lastChangeDate });
        }

        public List<PostInfo> getPostInfo()
        {
            List<PostInfo> postInfoList = new List<PostInfo>();
            string query = "SELECT User_ID, Brand_Name, Phone_Number, Address, Facebook, Status, Content, Upload_Date, Type, Post_ID FROM POST P, Brand B, Brand_Info BI WHERE P.Brand_ID = BI.Brand_ID AND BI.Brand_ID = B.Brand_ID";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                postInfoList.Add(new PostInfo(row));
            }
            return postInfoList;
        }

        public List<PostInfoToShow> getPostInfoToShow()
        {
            List<PostInfoToShow> postInfoToShowList = new List<PostInfoToShow>();
            string query = "SELECT Post_ID, Brand_Name, Upload_Date, Type, Name, Content FROM Post P, Brand B, User_Info UI WHERE P.Brand_ID = B.Brand_ID AND P.User_ID = UI.User_ID";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                postInfoToShowList.Add(new PostInfoToShow(row));
            }
            return postInfoToShowList;
        }

        public void deletePostById(int id)
        {
            string query = "DELETE FROM Post WHERE Post_ID = @Post_ID";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
        }

        public void updatePostContentById(string postId, string content)
        {
            DateTime dateTime = DateTime.Now;
            string query = "UPDATE Post SET Content = @Content, LastChange_Date = @LastChange_Date WHERE Post_ID = @Post_ID";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { content, dateTime, Convert.ToInt32(postId) });
        }

        public int getUserLevelCreatePost(string postId)
        {
            string query = "SELECT Pos_ID FROM Post P, Users U WHERE P.User_ID = U.User_ID AND Post_ID = @Post_ID";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { postId });
            return Convert.ToInt32(dt.Rows[0]["Pos_ID"]);
        }
    }
}
