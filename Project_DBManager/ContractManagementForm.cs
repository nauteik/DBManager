using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project_DBManager
{
    public partial class ContractManagementForm : Form
    {
        SqlConnection connection;
        SqlCommand command;
        String connectString = "Data Source =.\\;Initial Catalog = DBManager; Integrated Security = True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        private void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "SELECT Contract_ID, Brand_Name, Signed_date, Duration FROM Contract, Brand_Info WHERE Contract.Brand_ID = Brand_Info.Brand_ID";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dtgv.DataSource = table;
        }

        public ContractManagementForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ContractManagementForm_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectString);
            connection.Open();
            loadData();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbQLHD_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
