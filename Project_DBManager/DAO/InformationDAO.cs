using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DBManager.DAO
{
    public class InformationDAO
    {
        private static InformationDAO instance;

        public static InformationDAO Instance { get => instance == null ? new InformationDAO() : instance; set => instance = value; }

        public bool validateGender(string gender)
        {
            if (gender == "Nam" || gender == "Nữ")
            {
                return true;
            }
            return false;
        }
        public bool validateDept(string dept)
        {
            if (dept == "Ăn uống" || dept == "Làm đẹp" || dept == "Mua sắm" || dept == "Quà tặng" || dept == "Du lịch" || dept == "Giải trí")
            {
                return true;
            }
            return false;
        }
        public bool validatePos(string pos)
        {
            if (pos == "Manager" || pos == "Leader" || pos == "Employee")
            {
                return true;
            }
            return false;
        }
    }
}
