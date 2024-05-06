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
        public int getDepartmentIDByName(string name)
        {
            switch (name)
            {
                case "Ăn uống": return 1;
                case "Du lịch": return 2;
                case "Mua sắm": return 3;
                case "Giải trí": return 4;
                case "Quà tặng": return 5;
                case "Làm đẹp": return 6;
            }
            return 1;
        }
    }
}
