using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DBManager.DTO
{
    class BrandInfo
    {
        private int brand_ID;
        private string brandName;
        private string phoneNumber;
        private string facebook;
        private string introduction;
        private string address;
        private string status;

        public int Brand_ID { get => brand_ID; set => brand_ID = value; }
        public string BrandName { get => brandName; set => brandName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Facebook { get => facebook; set => facebook = value; }
        public string Introduction { get => introduction; set => introduction = value; }
        public string Address { get => address; set => address = value; }
        public string Status { get => status; set => status = value; }

        public BrandInfo(int brand_ID, string brandName, string phoneNumber, string facebook, string introduction, string address, string status)
        {
            this.brand_ID = brand_ID;
            this.brandName = brandName;
            this.phoneNumber = phoneNumber;
            this.facebook = facebook;
            this.introduction = introduction;
            this.address = address;
            this.status = status;
        }

    }
}
