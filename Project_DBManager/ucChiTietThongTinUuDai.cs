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
    public partial class ucChiTietThongTinUuDai : UserControl
    {
        public ucChiTietThongTinUuDai()
        {
            InitializeComponent();
        }

        public void loadInfo(OfferInfo oi)
        {
            string query = "SELECT Brand_ID FORM Post WHERE Post_ID = @Post"
        }
    }
}
