using System.Data;

namespace Project_DBManager.DTO
{
    public class OfferInfo
    {
        public bool isChecked { get; set; }
        public string Brand_Name { get; set; }
        public string Upload_Date { get; set; }
        public string LastChange_Date { get; set; }
        public string Content { get; set; }
        public string Status { get; set; }
        public string Post_ID { get; set; }

        public OfferInfo(DataRow row)
        {
            this.isChecked = false;
            this.Brand_Name = row[0].ToString();
            this.Upload_Date = row[1].ToString();
            this.LastChange_Date = row[2].ToString();
            this.Content = row[3].ToString();
            this.Status = row[4].ToString();
            this.Post_ID = row[5].ToString();
        }
    }
}
