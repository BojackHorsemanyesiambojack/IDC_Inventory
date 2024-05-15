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

namespace IDC_inventory
{
    public partial class IDC_inventory : Form
    {
        MySqlConnection connection_to_database = new MySqlConnection(
            "datasource = 127.0.0.1;" +
            " port = 3306;" +
            " username = root;" +
            " password = MITSURI;" +
            " database = idc_tienda");
        DataTable data_box = new DataTable();

        public IDC_inventory()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            get_data_services();
        }
                
        private void get_data_services()
        {
            MySqlDataAdapter get_from_database = new MySqlDataAdapter("SELECT * FROM camisetas", connection_to_database);
            get_from_database.Fill(data_box);
            this.dataGridView1.DataSource = data_box;
            this.dataGridView1.ReadOnly = true;
        }


        private void insert_data_services(string arg1, string arg2,string arg3, string table = "")
        {
            connection_to_database.Open();
            MySqlCommand insert_to_database = new MySqlCommand(
                $"INSERT INTO {table}" +
                $" VALUES ('{arg1}','{arg2}','{arg3}')", connection_to_database);
            int insertFiles = insert_to_database.ExecuteNonQuery();
            connection_to_database.Close();
        }

        private void show_insert_data_form ()
        {
            formInsert.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            show_insert_data_form();
        }

        private void clean_data_box()
        {
            data_box.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = connection_to_database;
            formInsert.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            insert_data_services(Color_input.Text, type_input.Text, cant_input.Text);
            clean_data_box();
            get_data_services();

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
