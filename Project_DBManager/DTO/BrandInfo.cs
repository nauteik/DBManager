using System;
using System.Data;

namespace Project_DBManager.DTO
{
    public class BrandInfo
    {

        private bool isChecked;
        private string brandName;
        private string type;
        private string status;
        private string phoneNumber;
        private string address;
        private string facebook;
        private string introduction;
        private string google;
        private int brand_ID;

        public bool IsChecked { get => isChecked; set => isChecked = value; }
        public string BrandName { get => brandName; set => brandName = value; }
        public string Type { get => type; set => type = value; }
        public string Status { get => status; set => status = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Address { get => address; set => address = value; }
        public string Facebook { get => facebook; set => facebook = value; }
        public string Introduction { get => introduction; set => introduction = value; }
        

        public int Brand_ID { get => brand_ID; set => brand_ID = value; }

        public string Google { get => google; set => google = value; }

        public BrandInfo(DataRow row)
        {
            this.isChecked = false;
            this.brand_ID = Convert.ToInt32(row["Brand_ID"].ToString());
            this.brandName = row["Brand_Name"].ToString();
            this.Type = row["Type"].ToString();
            this.status = row["Status"].ToString();
            this.phoneNumber = row["Phone_Number"].ToString();
            this.facebook = row["Facebook"].ToString();
            this.address = row["Address"].ToString();
            this.introduction = row["Introduction"].ToString();
            this.google = row["Google"].ToString();
        }

    }
}
