using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string Name { get => name; set => name = value; }
        public string Position { get => position; set => position = value; }
        public string Dept { get => dept; set => dept = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public bool IsChecked { get => isChecked; set => isChecked = value; }

        public Staff(DataRow row) 
        {
            isChecked = false;
            name = row["Name"].ToString();
            position = row["Pos_Name"].ToString();
            dept = row["Department_Name"].ToString();
            phone = row["phoneNum"].ToString();
            email = row["User_Email"].ToString();
            
        }

    }
}
