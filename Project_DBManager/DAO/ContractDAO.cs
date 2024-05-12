using Project_DBManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;

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

        public bool isContractExistByBrandID(int brandID)
        {
            string query = "SELECT * FROM Contract WHERE Brand_ID = " + brandID;
            return DataProvider.Instance.ExecuteQuery(query).Rows.Count > 0;
        }
        public int getUserLevelCreateContract(string contractId)
        {
            string query = "SELECT Pos_ID FROM Contract C, Users U WHERE C.User_ID = U.User_ID AND Contract_ID = @Contract_ID";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { contractId });
            return Convert.ToInt32(dt.Rows[0]["Pos_ID"]);
        }

        public List<DateTime> getSignedDateByName(string name, string startDate, string endDate)
        {
            List<DateTime> signedDateList = new List<DateTime>();
            string query = "SELECT CONVERT(date, Signed_Date) AS Signed_Date FROM Contract C, User_Info UI WHERE C.User_ID = UI.User_ID AND UI.Name = @Name AND Signed_Date BETWEEN @Start_Date AND @End_Date";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { name, startDate, endDate });
            foreach (DataRow row in dt.Rows)
            {
                if (!signedDateList.Contains(Convert.ToDateTime(row["Signed_Date"].ToString())))
                {
                    signedDateList.Add(Convert.ToDateTime(row["Signed_Date"].ToString()));
                }
            }
            return signedDateList;
        }

        public List<DateTime> getContractSignedDate(string status, string now, string startDate, string endDate)
        {
            List<DateTime> signedDateList = new List<DateTime>();
            string query;
            if (status == "Còn hiệu lực")
            {
                query = "SELECT CONVERT(date, Signed_Date) AS Signed_Date FROM Contract C, User_Info UI WHERE C.User_ID = UI.User_ID AND C.Duration >= @Now AND Signed_Date BETWEEN @Start_Date AND @End_Date";
            }
            else
            {
                query = "SELECT CONVERT(date, Signed_Date) AS Signed_Date FROM Contract C, User_Info UI WHERE C.User_ID = UI.User_ID AND C.Duration < @Now AND Signed_Date BETWEEN @Start_Date AND @End_Date";
            }
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { now, startDate, endDate });
            foreach (DataRow row in dt.Rows)
            {
                if (!signedDateList.Contains(Convert.ToDateTime(row["Signed_Date"].ToString())))
                {
                    signedDateList.Add(Convert.ToDateTime(row["Signed_Date"].ToString()));
                }
            }
            return signedDateList;
        }

        public int contractPerDayByStatus(string status, string now, string signedDate)
        {
            string query;
            if (status == "Còn hiệu lực")
            {
                query = "SELECT COUNT(*) AS Sum_Contract FROM Contract C, User_Info UI WHERE C.User_ID = UI.User_ID AND C.Duration >= @Now AND CONVERT(date, C.Signed_Date) = @Signed_Date";
            }
            else
            {
                query = "SELECT COUNT(*) AS Sum_Contract FROM Contract C, User_Info UI WHERE C.User_ID = UI.User_ID AND C.Duration < @Now AND CONVERT(date, C.Signed_Date) = @Signed_Date";
            }
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { now, signedDate });
            return Convert.ToInt32(dt.Rows[0]["Sum_Contract"].ToString());
        }

        public int contractPerDayByName(string name, string signedDate)
        {
            string query = "SELECT COUNT(*) AS Sum_Contract FROM Contract C, User_Info UI WHERE C.User_ID = UI.User_ID AND UI.Name = @Name AND CONVERT(date, C.Signed_Date) = @Signed_Date";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { name, signedDate });
            return Convert.ToInt32(dt.Rows[0]["Sum_Contract"].ToString());
        }

        public bool createNewContract(string signedDate, string duration, string content, string userId, int brandId)
        {
            string query = "INSERT INTO Contract (Signed_date, Duration, Content, User_ID, Brand_ID) VALUES ( @Signed_date, @Duration, @Content, @User_ID, @Brand_ID )";
            bool succeed = DataProvider.Instance.ExecuteNonQuery(query, new object[] { signedDate, duration, content, userId, brandId }) > 0;
            return succeed;
        }

        public void updateContract(string duration, string content, string contractId)
        {
            string query = "UPDATE Contract SET Duration = @Duration, Content = @Content WHERE Contract_ID = @Contract_ID";
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { duration, content, contractId });
        }
        public List<ContractInfo> getListContract()
        {
            string query = "SELECT Contract_ID AS ID, Brand_Name AS 'Tên thương hiệu', Signed_date AS 'Ngày ký', Duration AS 'Ngày hết hạn', Content AS 'Nội dung' FROM Contract, Brand WHERE Contract.Brand_ID = Brand.Brand_ID";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            List<ContractInfo> listContract = new List<ContractInfo>();
            foreach (DataRow row in table.Rows)
            {
                ContractInfo contractInfo = new ContractInfo(row);
                listContract.Add(contractInfo);
            }
            return listContract;
        }
    }
}
