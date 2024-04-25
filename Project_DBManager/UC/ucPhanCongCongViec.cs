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
    public partial class ucPhanCongCongViec : UserControl
    {
        public ucPhanCongCongViec()
        {
            InitializeComponent();
            cb_ViTri.SelectedIndex = 0;
        }

        private void btn_TaoCongViec_Click(object sender, EventArgs e)
        {
            string dept = cb_ViTri.Text;
            string taskName = tb_TenCongViec.Text;
            string deadline = dtpk_Deadline.Value.ToString("MM-dd-yyyy");
            string description = tb_GhiChu.Text;
            bool isSucceed = TaskDAO.Instance.createTask(dept, taskName, deadline, description);
            if (isSucceed)
            {
                MessageBox.Show("Tạo công việc thành công");
            }
            else
            {
                MessageBox.Show("Tạo công việc thất bại");
            }
        }
    }
}
