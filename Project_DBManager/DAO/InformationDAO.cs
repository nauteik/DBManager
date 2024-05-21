namespace Project_DBManager.DAO
{
    public class InformationDAO
    {
        private static InformationDAO instance;

        public static InformationDAO Instance { get => instance == null ? new InformationDAO() : instance; set => instance = value; }

        public int getLevelByPosition(string position)
        {
            if (position.Equals("Tổ trưởng"))
                return 1;
            if (position.Equals("Quản lý"))
                return 2;
            if (position.Equals("CEO"))
                return 3;
            return 0;
        }
        public string getPositionByLevel(int level)
        {
            switch (level)
            {
                case 1: return "Tổ trưởng";
                case 2: return "Quản lý";
                case 3: return "CEO";
            }
            return "Nhân viên";
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
        public string getDepartmenNameByID(int deptID)
        {
            switch (deptID)
            {
                case 1: return "Ăn uống";
                case 2: return "Du lịch";
                case 3: return "Mua sắm";
                case 4: return "Giải trí";
                case 5: return "Quà tặng";
                case 6: return "Làm đẹp";
            }
            return "Ăn uống";
        }
    }
}
