using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DBManager.DTO
{
    public class PostInfo
    {
        private bool isChecked;
        private string userId;
        private string brandName;
        private string phoneNumber;
        private string address;
        private string facebook;
        private string status;
        private string content;

        public PostInfo (DataRow row)
        {
            isChecked = false;
            userId = row[0].ToString();
            brandName = row[1].ToString();
            phoneNumber = row[2].ToString();
            address = row[3].ToString();
            facebook = row[4].ToString();
            status = row[5].ToString();
            content = row[6].ToString();
        }

        public PostInfo (string userId, string brandName, string phoneNumber, string address, string facebook, string status, string content) 
        {
            this.isChecked = false;
            this.userId = userId;
            this.brandName = brandName;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.facebook = facebook;
            this.status = status;
            this.content = content;
        }

        public bool IsChecked {  get => isChecked; set => isChecked = value; }
        public string UserId { get =>  userId; set => userId = value; }
        public string BrandName { get => brandName; set => brandName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Address { get => address; set => address = value; }
        public string Facebook { get => facebook; set => facebook = value; }
        public string Status { get => status; set => status = value; }
        public string Content { get => content; set => content = value; }
    }
}
