using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DBManager.DTO
{
    public class TempBrand
    {
        private bool isChecked;
        private string brandName;
        private string rate;
        private string review;
        private string category;
        private string address;
        private string website;
        private string phone;
        private string googleURL;

        public string BrandName { get => brandName; set => brandName = value; }
        public string Rate { get => rate; set => rate = value; }
        public string Review { get => review; set => review = value; }
        public string Category { get => category; set => category = value; }
        public string Address { get => address; set => address = value; }
        public string Website { get => website; set => website = value; }
        public string Phone { get => phone; set => phone = value; }
        public string GoogleURL { get => googleURL; set => googleURL = value; }
        public bool IsChecked { get => isChecked; set => isChecked = value; }

        public TempBrand(string[] item)
        {
            isChecked = false;
            BrandName = item[0];
            Rate = item[1];
            Review = item[2];
            Category = item[3];
            Address = item[4];
            Website = item[5];
            Phone = item[6];
            GoogleURL = item[7];
        }
    }
}
