using GMap.NET;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
using System.Security.Policy;
using Project_DBManager.DTO;

namespace Project_DBManager.UC
{
   
    public partial class ucThuThapThongTin : UserControl
    {
        GMap.NET.WindowsForms.GMapControl gmap;
        public Account acc;
        public ucThuThapThongTin()
        {
            InitializeComponent();
            initGMap();
            loadMapAttribute();
            gmap.OnMapZoomChanged += Gmap_OnMapZoomChanged;
            gmap.OnPositionChanged += Gmap_OnPositionChanged;
        }
        private void Gmap_OnPositionChanged(PointLatLng point)
        {
        
            loadMapAttribute();
        }
        private void Gmap_OnMapZoomChanged()
        {
            gmap.Update();
            gmap.Refresh();
            loadMapAttribute();
        }
       
        public void loadMapAttribute()
        {
            tb_ZoomLevel.Text = gmap.Zoom.ToString();
            tb_TrucNgang.Text = Math.Round(gmap.Position.Lat, 5).ToString();
            tb_TrucDoc.Text = Math.Round(gmap.Position.Lng, 5).ToString();
        }
        public void initGMap()
        {
            gmap = new GMap.NET.WindowsForms.GMapControl();
            gmap.MapProvider = GMap.NET.MapProviders.GMapProviders.GoogleMap;
            gmap.Dock = DockStyle.Fill;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gmap.ShowCenter = true;
            gmap.Position = new PointLatLng(15.93, 108.07);
            gmap.MinZoom = 1;
            gmap.MaxZoom = 20;
            gmap.Zoom = 7;
            gmap.DragButton = MouseButtons.Left;
            gmap.Update();
            gmap.Refresh();
            pn_Map.Controls.Add(gmap);
        }

        private void btn_ThuThap_Click(object sender, EventArgs e)
        {
            if (tb_NoiDungThuThap.Text == "") { MessageBox.Show("Nội dung thu thập không được để trống"); return; }
            DialogResult result = MessageBox.Show("Xác nhận thu thập thông tin thương hiệu", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) { return; }
            string[] searchElement = Regex.Replace(tb_NoiDungThuThap.Text.Trim(), @"\s+", " ").Split(' ');
            string searchText = string.Join("+", searchElement);
            double trucNgang = Convert.ToDouble(tb_TrucNgang.Text);
            double trucDoc = Convert.ToDouble(tb_TrucDoc.Text);
            int zoomLevel = Convert.ToInt32(tb_ZoomLevel.Text);
            string googleURL = string.Format("https://www.google.com/maps/search/{0}/@{1},{2},{3}z?entry=ttu", searchText, trucNgang, trucDoc, zoomLevel);
            formThuThap form = new formThuThap(googleURL, this.acc);
            form.Show();
        }
    }
}
