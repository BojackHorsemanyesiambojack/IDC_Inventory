using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data.OleDb;

namespace IDC_inventory
{
    public partial class IDC_inventory : Form
    {
        OleDbConnection conn = new OleDbConnection(
            @"Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=\"C:\\Users\\LENOVO THINKPAD\\Documents\\IDC inventory\\IDC inventory\\DataBases\\Poo-Inventario.accdb\";" +
            "Persist Security Info=True");

        string actualTable;

        DataTable data_box = new DataTable();

        public IDC_inventory()
        {
            InitializeComponent();
        }

        private void get_data (string table)
        {
                conn.Open();
                string sqlGetCommand = $"SELECT Almacen.* FROM Almacen";
                OleDbDataAdapter adapter = new OleDbDataAdapter(sqlGetCommand, conn);
                render_data(adapter);
                conn.Close();

        }

        private void render_data(OleDbDataAdapter data)
        {
            data.Fill(data_box);
            dataGridView1.DataSource = data_box;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            actualTable = "Almacen";
            get_data(actualTable);
        }

        private void show_insert_data_form ()
        {
            formInsert.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            show_insert_data_form();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        //-----------------------------------------------------------------------------------------------------------//


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }

    //======================================================================================================================//
}
