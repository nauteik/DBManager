using Project_DBManager.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DBManager
{
    public partial class ucThongTinCaNhan : UserControl
    {
        public ucThongTinCaNhan()
        {
            InitializeComponent();
        }
        public void loadAccount(string username)
        {
            DataTable data = AccountDAO.Instance.getAccountInfoByUsername(username);
            DataRow row = data.Rows[0];
            tbHoTen.Text = row["Name"].ToString();
            lbTitleName.Text = tbHoTen.Text;
            tbIDC.Text = row["ID_Card"].ToString();
            tbEmail.Text = row["User_Email"].ToString();
            tbPosition.Text = row["Pos_Name"].ToString();
            lbTitlePosition.Text = tbPosition.Text;
            tbAddress.Text = row["Address"].ToString();
            tbDepartment.Text = row["Department_Name"].ToString();
            tbNgaySinh.Text = row["Birth"].ToString();
            tbGioiTinh.Text = row["Gender"].ToString();
            int status = int.Parse(row["IsEnable"].ToString());
            switch (status)
            {
                case 0: tbTrangThai.Text = "Vô hiệu hoá"; break;
                case 1: tbTrangThai.Text = "Hoạt động"; break;
            }
        }
    }
}
