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
                clean_box();
                conn.Open();
                string sqlGetCommand = $"SELECT * FROM {table};";
                OleDbDataAdapter adapter = new OleDbDataAdapter(sqlGetCommand, conn);
                render_data(adapter);
                conn.Close();
                
        }

        private void insert_data(string table)
        {
            
        }

        private void clean_box()
        {
            dataGridView1.DataSource = null;
            data_box.Rows.Clear();
            data_box.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = data_box;
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            show_insert_data_form();
        }

        private void change_actual_table()
        {
            string choosenOption = comboBox1.SelectedItem.ToString();
            actualTable = choosenOption;
            get_data(actualTable);
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

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            change_actual_table();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }

    //======================================================================================================================//
}
