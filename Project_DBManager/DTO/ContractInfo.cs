using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project_DBManager.DTO
{
    public class ContractInfo
    {
        private bool isChecked;
        private string contractID;
        private string brandName;
        private string signedDate;
        private string duration;
        private string content;

        public ContractInfo(DataRow row)
        {
            isChecked = false;
            contractID = row[0].ToString();
            brandName = row[1].ToString();
            signedDate = row[2].ToString();
            duration = row[3].ToString();
            content = row[4].ToString();
        }

        public bool IsChecked { get => isChecked; set => isChecked = value; }
        public string ContractID { get => contractID; set => contractID = value; }
        public string BrandName { get => brandName; set => brandName = value; }
        public string SignedDate { get => signedDate; set => signedDate = value; }
        public string Duration { get => duration; set => duration = value; }
        public string Content { get => content; set => content = value; }


         public void ToString()
        {
            MessageBox.Show("ID: " + contractID + "\nTên thương hiệu: " + brandName + "\nNgày ký: " + signedDate + "\nNgày hết hạn: " + duration + "\nNội dung: " + content);
        }
    }
}
