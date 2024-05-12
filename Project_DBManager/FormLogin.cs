using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project_DBManager
{
    public partial class FormLogin : Form
    {
        public FormLogin()
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
            FormLoginAuth newForm = new FormLoginAuth("leader,", 1, Properties.Resources.fig_Leader1);
            this.Hide();
            newForm.ShowDialog();
            if (newForm.isLogOut == true)
            {
                this.Show();
                return;
            }
            if (!newForm.succeedLogin())
                this.Show();
            else
                this.Close();
        }

        private void panel_manager_Click(object sender, EventArgs e)
        {
            FormLoginAuth newForm = new FormLoginAuth("MANAGER,", 2, Properties.Resources.fig_QL);
            this.Hide();
            newForm.ShowDialog();
            if (newForm.isLogOut == true)
            {
                this.Show();
                return;
            }
            if (!newForm.succeedLogin())
                this.Show();
            else
                this.Close();
        }

        private void panel_staff_Click(object sender, EventArgs e)
        {
            FormLoginAuth newForm = new FormLoginAuth("EMPLOYEE,", 0, Properties.Resources.fig_NV);
            this.Hide();
            newForm.ShowDialog();
            if(newForm.isLogOut == true)
            {
                this.Show();
                return;
            }
            if (!newForm.succeedLogin())
                this.Show();
            else
                this.Close();
        }
    }
}
