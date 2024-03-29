using Project_DBManager.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project_DBManager
{
    public partial class ThongTinHopDong : UserControl
    {
        public ThongTinHopDong()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            string query = "SELECT Contract_ID AS ID, Brand_Name AS 'Tên thương hiệu', Signed_date AS 'Ngày ký', Duration AS 'Ngày hết hạn', Content AS 'Nội dung' FROM Contract, Brand_Info WHERE Contract.Brand_ID = Brand_Info.Brand_ID";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            dtgv.DataSource = table;
        }

        private void lb_TaiXuong_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cb_SapXep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_SapXep_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem.ToString() == "ID tăng dần")
            {
                string query = "SELECT Contract_ID AS ID, Brand_Name AS 'Tên thương hiệu', Signed_date AS 'Ngày ký', Duration AS 'Ngày hết hạn', Content AS 'Nội dung' FROM Contract, Brand_Info WHERE Contract.Brand_ID = Brand_Info.Brand_ID ORDER BY Contract_ID";
                DataTable table = DataProvider.Instance.ExecuteQuery(query);
                dtgv.DataSource = table;
            }
            else if (cb.SelectedItem.ToString() == "ID giảm dần")
            {
                string query = "SELECT Contract_ID AS ID, Brand_Name AS 'Tên thương hiệu', Signed_date AS 'Ngày ký', Duration AS 'Ngày hết hạn', Content AS 'Nội dung' FROM Contract, Brand_Info WHERE Contract.Brand_ID = Brand_Info.Brand_ID ORDER BY Contract_ID DESC";
                DataTable table = DataProvider.Instance.ExecuteQuery(query);
                dtgv.DataSource = table;
            }
            else if (cb.SelectedItem.ToString() == "Tên thương hiệu tăng dần")
            {
                string query = "SELECT Contract_ID AS ID, Brand_Name AS 'Tên thương hiệu', Signed_date AS 'Ngày ký', Duration AS 'Ngày hết hạn', Content AS 'Nội dung' FROM Contract, Brand_Info WHERE Contract.Brand_ID = Brand_Info.Brand_ID ORDER BY Brand_Name";
                DataTable table = DataProvider.Instance.ExecuteQuery(query);
                dtgv.DataSource = table;
            }
            else if (cb.SelectedItem.ToString() == "Tên thương hiệu giảm dần")
            {
                string query = "SELECT Contract_ID AS ID, Brand_Name AS 'Tên thương hiệu', Signed_date AS 'Ngày ký', Duration AS 'Ngày hết hạn', Content AS 'Nội dung' FROM Contract, Brand_Info WHERE Contract.Brand_ID = Brand_Info.Brand_ID ORDER BY Brand_Name DESC";
                DataTable table = DataProvider.Instance.ExecuteQuery(query);
                dtgv.DataSource = table;
            }
            else if (cb.SelectedItem.ToString() == "Ngày ký tăng dần")
            {
                string query = "SELECT Contract_ID AS ID, Brand_Name AS 'Tên thương hiệu', Signed_date AS 'Ngày ký', Duration AS 'Ngày hết hạn', Content AS 'Nội dung' FROM Contract, Brand_Info WHERE Contract.Brand_ID = Brand_Info.Brand_ID ORDER BY Signed_date";
                DataTable table = DataProvider.Instance.ExecuteQuery(query);
                dtgv.DataSource = table;
            }
            else if (cb.SelectedItem.ToString() == "Ngày ký giảm dần")
            {
                string query = "SELECT Contract_ID AS ID, Brand_Name AS 'Tên thương hiệu', Signed_date AS 'Ngày ký', Duration AS 'Ngày hết hạn', Content AS 'Nội dung' FROM Contract, Brand_Info WHERE Contract.Brand_ID = Brand_Info.Brand_ID ORDER BY Signed_date DESC";
                DataTable table = DataProvider.Instance.ExecuteQuery(query);
                dtgv.DataSource = table;
            }
            else if (cb.SelectedItem.ToString() == "Ngày hết hạn tăng dần")
            {
                string query = "SELECT Contract_ID AS ID, Brand_Name AS 'Tên thương hiệu', Signed_date AS 'Ngày ký', Duration AS 'Ngày hết hạn', Content AS 'Nội dung' FROM Contract, Brand_Info WHERE Contract.Brand_ID = Brand_Info.Brand_ID ORDER BY Duration";
                DataTable table = DataProvider.Instance.ExecuteQuery(query);
                dtgv.DataSource = table;
            }
            else if (cb.SelectedItem.ToString() == "Ngày hết hạn giảm dần")
            {
                string query = "SELECT Contract_ID AS ID, Brand_Name AS 'Tên thương hiệu', Signed_date AS 'Ngày ký', Duration AS 'Ngày hết hạn', Content AS 'Nội dung' FROM Contract, Brand_Info WHERE Contract.Brand_ID = Brand_Info.Brand_ID ORDER BY Duration DESC";
                DataTable table = DataProvider.Instance.ExecuteQuery(query);
                dtgv.DataSource = table;
            }
        }

        private void tb_TimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_TimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string value = tb_TimKiem.Text;
                string query;
                DataTable table;
                if (int.TryParse(value, out _))
                {
                    query = "SELECT Contract_ID AS ID, Brand_Name AS 'Tên thương hiệu', Signed_date AS 'Ngày ký', Duration AS 'Ngày hết hạn', Content AS 'Nội dung' FROM Contract, Brand_Info WHERE Contract.Brand_ID = Brand_Info.Brand_ID AND Contract_ID like '%' + @value + '%'";
                    table = DataProvider.Instance.ExecuteQuery(query, new object[] { value });
                    dtgv.DataSource = table;
                }
                else
                {
                    query = "SELECT Contract_ID AS ID, Brand_Name AS 'Tên thương hiệu', Signed_date AS 'Ngày ký', Duration AS 'Ngày hết hạn', Content AS 'Nội dung' FROM Contract, Brand_Info WHERE Contract.Brand_ID = Brand_Info.Brand_ID AND Brand_Name like '%' + @value + '%'";
                    table = DataProvider.Instance.ExecuteQuery(query, new object[] { value });
                    dtgv.DataSource = table;
                }
                tb_TimKiem.Text = "";
            }
        }
    }
}
