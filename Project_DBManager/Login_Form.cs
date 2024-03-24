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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel_staff_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_leader_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel_staff_MouseEnter(object sender, EventArgs e)
        {
            panel_staff.BackColor = Color.FromArgb(173, 185, 201);
        }
        private void panel_staff_MouseLeave(object sender, EventArgs e)
        {
            panel_staff.BackColor = Color.FromArgb(228, 231, 238);
        }

        private void panel_leader_MouseEnter(object sender, EventArgs e)
        {
            panel_leader.BackColor = Color.FromArgb(173, 185, 201);
        }
        private void panel_leader_MouseLeave(object sender, EventArgs e)
        {
            panel_leader.BackColor = Color.FromArgb(228, 231, 238);
        }

        private void panel_manager_MouseEnter(object sender, EventArgs e)
        {
            panel_manager.BackColor = Color.FromArgb(173, 185, 201);
        }
        private void panel_manager_MouseLeave(object sender, EventArgs e)
        {
            panel_manager.BackColor = Color.FromArgb(228, 231, 238);
        }


        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void panel_leader_Click(object sender, EventArgs e)
        {
            Login_Form_Leader newForm = new Login_Form_Leader();
            newForm.Show();
            this.Hide();
        }

        private void panel_manager_Click(object sender, EventArgs e)
        {
            Login_Form_Manager newForm = new Login_Form_Manager();
            newForm.Show();
            this.Hide();
        }

        private void panel_staff_Click(object sender, EventArgs e)
        {
            Login_Form_Staff newForm = new Login_Form_Staff();
            newForm.Show();
            this.Hide();
        }
    }
}
