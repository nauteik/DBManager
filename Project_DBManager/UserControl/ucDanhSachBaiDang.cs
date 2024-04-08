using Project_DBManager.DAO;
using Project_DBManager.DTO;
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
    public partial class ucDanhSachBaiDang : UserControl
    {
        private List<PostInfo> postInfoList;

        public ucDanhSachBaiDang()
        {
            InitializeComponent();
            loadBaiDang();
        }

        private void loadBaiDang()
        {
            //postInfoList = PostDAO.Instance.getPostInfo();
            //dtgv.DataSource = postInfoList;
        }

        private void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
