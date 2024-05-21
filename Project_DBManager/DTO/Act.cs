using Project_DBManager.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DBManager.DTO
{
    public class Act
    {
        private string name;
        private string position;
        private string dept;
        private string date;
        private string content;
        private int actID;

        public string Name { get => name; set => name = value; }
        public string Position { get => position; set => position = value; }
        public string Dept { get => dept; set => dept= value; }
        public string Date { get => date; set => date = value; }
        public string Content { get => content; set => content = value; }
        public int ActID { get => actID; set => actID = value; }

        public Act(DataRow row)
        {
            name = row["Name"].ToString();
            position = InformationDAO.Instance.getPositionByLevel(Convert.ToInt32(row["Pos_ID"].ToString()));
            dept = InformationDAO.Instance.getDepartmenNameByID(Convert.ToInt32(row["Department_ID"].ToString()));
            date = ((DateTime)row["ActTime"]).ToString("dd-MM-yyyy HH:mm:ss");
            content = row["Content"].ToString();
            actID = Convert.ToInt32(row["Act_ID"].ToString());
        }
    }
}
