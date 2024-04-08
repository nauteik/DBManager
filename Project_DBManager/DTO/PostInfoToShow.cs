using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DBManager.DTO
{
    public class PostInfoToShow
    {
        private bool isChecked;
        private string postID;
        private string brandName;
        private string uploadDate;
        private string type;
        private string name;
        private string content;

        public PostInfoToShow(DataRow row) 
        {
            this.isChecked = false;
            this.postID = row[0].ToString();
            this.brandName = row[1].ToString();
            this.uploadDate = Convert.ToDateTime(row[2]).ToString("dd-MM-yyyy");
            this.type = row[3].ToString();
            this.name = row[4].ToString();
            this.content = row[5].ToString();
        }

        public bool IsChecked { get => isChecked; set => isChecked = value; }
        public string PostId { get => postID; set => postID = value; }
        public string BrandName { get => brandName; set => brandName = value; }
        public string UploadDate { get => uploadDate; set => uploadDate = value; }
        public string Type { get => type; set => type = value; }
        public string Name { get => name; set => name = value; }
        public string Content { get => content; set => content = value; }
    }
}
