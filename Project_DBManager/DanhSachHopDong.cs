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
    public partial class DanhSachHopDong : UserControl
    {
        private DataTable table;
        private string query;
        private List<ContractInfo> contractInfoList = new List<ContractInfo>();

        public DanhSachHopDong()
        {
            InitializeComponent();
            loadData();
        }

        internal class ContractInfo
        {
            public bool isChecked { get; set; }
            public string contractID { get; set; }
            public string brandName { get; set; }
            public string signedDate { get; set; }
            public string duration { get; set; }
            public string content { get; set; }

            public ContractInfo(bool isChecked, string contractID, string brandName, string signedDate, string duration, string content)
            {
                this.isChecked = isChecked;
                this.contractID = contractID;
                this.brandName = brandName;
                this.signedDate = signedDate;
                this.duration = duration;
                this.content = content;
            }

            public void ToString()
            {
                MessageBox.Show("ID: " + contractID + "\nTên thương hiệu: " + brandName + "\nNgày ký: " + signedDate + "\nNgày hết hạn: " + duration + "\nNội dung: " + content);
            }
        }

        private void loadData()
        {
            query = "SELECT Contract_ID AS ID, Brand_Name AS 'Tên thương hiệu', Signed_date AS 'Ngày ký', Duration AS 'Ngày hết hạn', Content AS 'Nội dung' FROM Contract, Brand_Info WHERE Contract.Brand_ID = Brand_Info.Brand_ID";
            table = DataProvider.Instance.ExecuteQuery(query);
            
            foreach (DataRow row in table.Rows)
            {
                ContractInfo contractInfo = new ContractInfo(false, row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString());
                contractInfoList.Add(contractInfo);
            }
            dtgv.DataSource = contractInfoList;
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
            List<ContractInfo> sortedList;
            if (cb.SelectedItem.ToString() == "ID tăng dần")
            {
                sortedList = contractInfoList.OrderBy(ci => ci.contractID).ToList();
                dtgv.DataSource = sortedList;
            }
            else if (cb.SelectedItem.ToString() == "ID giảm dần")
            {
                sortedList = contractInfoList.OrderByDescending(ci => ci.contractID).ToList();
                dtgv.DataSource = sortedList;
            }
            else if (cb.SelectedItem.ToString() == "Tên thương hiệu tăng dần")
            {
                sortedList = contractInfoList.OrderBy(ci => ci.brandName).ToList();
                dtgv.DataSource = sortedList;
            }
            else if (cb.SelectedItem.ToString() == "Tên thương hiệu giảm dần")
            {
                sortedList = contractInfoList.OrderByDescending(ci => ci.brandName).ToList();
                dtgv.DataSource = sortedList;
            }
            else if (cb.SelectedItem.ToString() == "Ngày ký tăng dần")
            {
               sortedList = contractInfoList.OrderBy(ci => ci.signedDate).ToList();
                dtgv.DataSource = sortedList;
            }
            else if (cb.SelectedItem.ToString() == "Ngày ký giảm dần")
            {
                sortedList = contractInfoList.OrderByDescending(ci => ci.signedDate).ToList();
                dtgv.DataSource = sortedList;
            }
            else if (cb.SelectedItem.ToString() == "Ngày hết hạn tăng dần")
            {
                sortedList = contractInfoList.OrderBy(ci => ci.duration).ToList();
                dtgv.DataSource = sortedList;
            }
            else if (cb.SelectedItem.ToString() == "Ngày hết hạn giảm dần")
            {
                sortedList = contractInfoList.OrderByDescending(ci => ci.duration).ToList();
                dtgv.DataSource = sortedList;
            }
        }

        private void tb_TimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_TimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                List<ContractInfo> searchList;
                string value = tb_TimKiem.Text;
                if (int.TryParse(value, out _))
                {
                    searchList = contractInfoList.Where(ci => (ci.contractID).Equals(value)).ToList();
                    dtgv.DataSource = searchList;
                }
                else
                {
                    searchList = contractInfoList.Where(ci => (ci.brandName.ToLower()).Contains(value.ToLower())).ToList();
                    dtgv.DataSource = searchList;
                }
                tb_TimKiem.Text = "";
            }
        }

        private void DanhSachHopDong_Load(object sender, EventArgs e)
        {

        }

        private void btn_XuatDuLieu_Click(object sender, EventArgs e)
        {
            List<ContractInfo> checkedContract = ((List<ContractInfo>)dtgv.DataSource).Where(ci => ci.isChecked).ToList();
            checkedContract.ForEach(ci => ci.ToString());
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_XoaDuLieu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn xóa các dòng dữ liệu đã được chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                List<string> contractIDList = new List<string>();
                List<ContractInfo> tempList = new List<ContractInfo>();
                dtgv.DataSource = tempList;
                query = "DELETE FROM Contract WHERE Contract_ID = ";
                foreach (ContractInfo ci in contractInfoList)
                {
                    if (ci.isChecked)
                    {
                        contractIDList.Add(ci.contractID);
                    }
                }
                contractInfoList.RemoveAll(ci => ci.isChecked);
                foreach (string id in contractIDList)
                {
                    DataProvider.Instance.ExecuteQuery(query + id);
                }
                dtgv.DataSource = contractInfoList;

                MessageBox.Show("Dữ liệu đã được xóa.");
            }
        }

        private void btn_TaiXuong_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn tải xuống tất cả dữ liệu?", "Tải xuống", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                List<ContractInfo> downLoadList = ((List<ContractInfo>)dtgv.DataSource).ToList();
                downLoadList.ForEach(ci => ci.ToString());
            }
        }
    }
}

