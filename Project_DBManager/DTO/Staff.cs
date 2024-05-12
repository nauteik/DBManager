using System;
using System.Data;

namespace Project_DBManager.DTO
{
    public class Staff
    {
        private bool isChecked;
        private string name;
        private string position;
        private string dept;
        private string phone;
        private string email;
        private int userID;


        public bool IsChecked { get => isChecked; set => isChecked = value; }
        public string Name { get => name; set => name = value; }
        public string Position { get => position; set => position = value; }
        public string Dept { get => dept; set => dept = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public int UserID { get => userID; set => userID = value; }

        public Staff(DataRow row)
        {
            isChecked = false;
            name = row["Name"].ToString();
            switch (row["Pos_Name"].ToString())
            {
                case "Employee": position = "Nhân viên"; break;
                case "Leader": position = "Tổ trưởng"; break;
                case "Manager": position = "Quản lý"; break;
                case "CEO": position = "CEO"; break;
            }
           
            dept = row["Department_Name"].ToString();
            phone = row["phoneNum"].ToString();
            email = row["User_Email"].ToString();
            userID = Convert.ToInt32(row["User_ID"].ToString());

        }

    }
}
