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

namespace Project_DBManager.UC
{
    public partial class ucBaoCaoThongKeHopDong : UserControl
    {
        public ucBaoCaoThongKeHopDong()
        {
            InitializeComponent();
        }

        private void ucBaoCaoThongKeHopDong_Load(object sender, EventArgs e)
        {
            c_HopDong.Visible = false;
            lb_Chon.Visible = false;
            cb_Chon.Visible = false;
        }

        private void cb_ThongKeTheo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_Chon.Visible = true;
            cb_Chon.Visible = true;
            cb_Chon.Text = "";
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem.ToString() == "Người tạo")
            {
                cb_Chon.Items.Clear();
                lb_Chon.Text = "Chọn người tạo";
                List<string> nameList = AccountDAO.Instance.getNameList();
                foreach (string name in nameList)
                {
                    cb_Chon.Items.Add(name);
                }
            }
            else if (cb.SelectedItem.ToString() == "Trạng thái")
            {
                cb_Chon.Items.Clear();
                lb_Chon.Text = "Chọn trạng thái";
                cb_Chon.Items.Add("Còn hiệu lực");
                cb_Chon.Items.Add("Hết hiệu lực");
            }
        }

        private void btn_TaoBaoCao_Click(object sender, EventArgs e)
        {
            // Kiểm tra đã điền đủ thông tin hay chưa
            if (cb_ThongKeTheo.Text == "" || cb_Chon.Text == "")
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Reset date trong chart
            c_HopDong.ResetAutoValues();
            // Thực hiện thống kê
            c_HopDong.Visible = true;
            c_HopDong.Titles.Add("");
            c_HopDong.ChartAreas[0].AxisX.Title = "Ngày";
            c_HopDong.ChartAreas[0].AxisY.Title = "Số lượng hợp đồng";
            c_HopDong.ChartAreas[0].AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            c_HopDong.ChartAreas[0].AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            c_HopDong.Series["Số lượng hợp đồng"].Points.Clear();
            DateTime startDate = dtpk_NgayBatDau.Value;
            DateTime endDate = dtpk_NgayKetThuc.Value;
            if (cb_ThongKeTheo.SelectedItem.ToString() == "Người tạo")
            {
                foreach (DateTime date in ContractDAO.Instance.getSignedDateByName(cb_Chon.SelectedItem.ToString(), startDate.ToString("yyyy-MM-dd"), endDate.ToString("yyyy-MM-dd")))
                {
                    c_HopDong.Titles[0].Text = "Thống kê hợp đồng theo người tạo";
                    c_HopDong.Series["Số lượng hợp đồng"].Points.AddXY(date.ToString("dd-MM-yyyy"), ContractDAO.Instance.contractPerDayByName(cb_Chon.SelectedItem.ToString(), date.ToString("yyyy-MM-dd")));
                }
            }
            else if (cb_ThongKeTheo.SelectedItem.ToString() == "Trạng thái")
            {
                foreach (DateTime date in ContractDAO.Instance.getContractSignedDate(cb_Chon.SelectedItem.ToString(), (DateTime.Now).ToString("yyyy-MM-dd"), startDate.ToString("yyyy-MM-dd"), endDate.ToString("yyyy-MM-dd")))
                {
                    c_HopDong.Titles[0].Text = "Thống kê hợp đồng theo trạng thái";
                    c_HopDong.Series["Số lượng hợp đồng"].Points.AddXY(date.ToString("dd-MM-yyyy"), ContractDAO.Instance.contractPerDayByStatus(cb_Chon.SelectedItem.ToString(), (DateTime.Now).ToString("yyyy-MM-dd"), date.ToString("yyyy-MM-dd")));
                }
            }
        }
    }
}
