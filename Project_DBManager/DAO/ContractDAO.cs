using Project_DBManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DBManager.DAO
{
    public class ContractDAO
    {
        private static ContractDAO instance;
        public static ContractDAO Instance
        {
            get { if (instance == null) instance = new ContractDAO(); return instance; }
            set { ContractDAO.instance = value; }
        }
        
        public int getUserLevelCreateContract(string contractId)
        {
            string query = "SELECT Pos_ID FROM Contract C, Users U WHERE C.User_ID = U.User_ID AND Contract_ID = @Contract_ID";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { contractId });
            return Convert.ToInt32(dt.Rows[0]["Pos_ID"]);
        }
    }
}
