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
using Mysqlx.Crud;
using IDC_inventory.Querys;

namespace IDC_inventory
{
    public partial class IDC_inventory : Form
    {
        OleDbConnection conn = new OleDbConnection(
            @"Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=\"C:\\Users\\LENOVO THINKPAD\\Documents\\IDC inventory\\IDC inventory\\DataBases\\Poo-Inventario.accdb\";" +
            "Persist Security Info=True");
        string actualTable;
        List <String> actualColumnsInfo = new List<string>();
        List<String> actualColumnsTypes = new List<string>();
        DataTable data_box = new DataTable();

        bool isInsertFormOpen = false;
        string actualClickedRowID;
        string actualCLickedCellRow;
        bool isUpdateFormOpen = false;
        string updateData;
        string clickedColumnName;
        string clickedRowIdName;
        string searchData;
        string actualClickedColumnType;

        public IDC_inventory()
        {
            InitializeComponent();
        }

        private void get_data (string element = "")
        {
                clean_box();
                conn.Open();
                string sqlGetCommand = $"SELECT * FROM {actualTable} ";

                if(element != "")
                {
                sqlGetCommand += "WHERE";
                for(int i = 0; i < actualColumnsInfo.Count(); i++)
                {
                    sqlGetCommand += $" [{actualColumnsInfo[i]}] LIKE '%{element}%' OR ";
                }
                sqlGetCommand = sqlGetCommand.Remove(sqlGetCommand.Length - 3);
                }
                OleDbDataAdapter adapter = new OleDbDataAdapter(sqlGetCommand, conn);
                OleDbCommand getCommand = new OleDbCommand(sqlGetCommand, conn);
                if (isInsertFormOpen) updateForm();
                get_column_names(getCommand);
                render_data(adapter);
                conn.Close();
                
        }

        private void convert_data(List <string> data)
        {

                if(data.Count() != actualColumnsInfo.Count())
            {
                throw new ArgumentException("No pueden haber Espacios  en blanco");
            }

                string columns = "[" + string.Join("], [", actualColumnsInfo);
                string values = "";

                for(int i = 0; i < data.Count(); i++)
                {
                if (actualColumnsTypes[i].ToLower().Contains("char"))
                {
                    values += $"'{data[i]}', ";
                }
                else
                {
                    values += $"{data[i]}, ";
                }
                }
            columns += "]";
            values = values.Remove(values.Length - 2);
           
            string cmd = $"INSERT INTO [{actualTable}] ({columns}) VALUES ({values})";
            MessageBox.Show(cmd);
                OleDbCommand insertCommand = new OleDbCommand(cmd, conn);
                     insert_data (insertCommand);
            
        }

        private void insert_data(OleDbCommand cmd)
        {
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            get_data();
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

        private void updateForm()
        {
            groupBox1.Controls.Clear();
            show_insert_data_form();
        }

        private void render_data(OleDbDataAdapter data)
        {
            data.Fill(data_box);
            dataGridView1.DataSource = data_box;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            actualTable = "Almacen";
            get_data();
        }

        private  void get_column_names(OleDbCommand cmd)
        {
            actualColumnsInfo.Clear();
            var reader = cmd.ExecuteReader();

            for (int i = 0; i < reader.FieldCount; i++)
            {
                    actualColumnsInfo.Add(reader.GetName(i));            
            }

            for(int i = 0; i < reader.FieldCount;i++)
            {
                actualColumnsTypes.Add(reader.GetDataTypeName(i));
            }
        }

        private void show_insert_data_form()
        {
            groupBox1.Controls.Clear();
            isUpdateFormOpen = false;
            isInsertFormOpen = true;
            int startX = 10;
            int startY = 10;
            int spacingY = 25;

            for (int i = 0; i < actualColumnsInfo.Count(); i++)
            {
                Label label = new Label();
                label.ForeColor = Color.White;
                label.Text = actualColumnsInfo[i];
                label.Location = new System.Drawing.Point(startX, startY + (i * spacingY));
                label.AutoSize = true;
                TextBox textBox = new TextBox();
                textBox.Name = actualColumnsInfo[i];
                textBox.Location = new System.Drawing.Point(startX + 120, startY + (i * spacingY));
                groupBox1.Controls.Add(label);
                groupBox1.Controls.Add(textBox);
            }
   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            show_insert_data_form();
        }

        private void change_actual_table()
        {
            string choosenOption = comboBox1.SelectedItem.ToString();
            actualTable = choosenOption;
            get_data();
        }  

        private void render_delete_info(string data)
        {
            string actualData = actualClickedRowID;
            if (actualColumnsTypes[0].ToLower().Contains("char"))
            {
                actualData = $"'{actualData}'";
            }
            string query = $"DELETE FROM [{actualTable}] WHERE [{actualColumnsInfo[0]}] = {actualData}";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            delete_data(cmd);
            get_data();
        }

        private void delete_data (OleDbCommand cmd)
        {
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            show_insert_data_form();
        }

        private List <string> collectInfoData()
        {
            List<string> dataList = new List<string>();

            foreach(Control control in groupBox1.Controls)
            {
                if(control is TextBox textBox)
                {
                    dataList.Add(textBox.Text);
                }
            }

            return dataList;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (isInsertFormOpen)
            {
                List<string> dataCollected = collectInfoData();
                convert_data(dataCollected);
            }
            if (isUpdateFormOpen)
            {
                foreach(Control control in groupBox1.Controls)
                {
                    if(control is TextBox textBox)
                    {
                        updateData = textBox.Text;
                        update_data_convert();
                    }
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                Console.WriteLine("Nel perro");
            }
            else {

                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                if (e.ColumnIndex > 0)
                {
                    actualClickedRowID = selectedRow.Cells[0].Value.ToString();
                    actualCLickedCellRow = selectedRow.Cells[e.ColumnIndex].Value.ToString();
                    clickedColumnName = dataGridView1.Columns[e.ColumnIndex].Name;
                    clickedRowIdName = dataGridView1.Columns[0].Name;
                    actualClickedColumnType = dataGridView1.Columns[e.ColumnIndex].ValueType.ToString();
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            render_delete_info(actualClickedRowID);
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void open_update_form()
        {
            groupBox1.Controls.Clear();
            isInsertFormOpen = false;
            isUpdateFormOpen = true;
            int startX = 10;
            int startY = 10;
            int spacingY = 25;

                Label label = new Label();
                label.ForeColor = Color.White;
                label.Text = "Introduzca el valor de reemplazo";
                label.Location = new System.Drawing.Point(startX, startY + (1 * spacingY));
                label.AutoSize = true;
                TextBox textBox = new TextBox();
                textBox.Name = "actualizador";
            textBox.Location = new System.Drawing.Point(startX + 180, startY + (1 * spacingY));
                groupBox1.Controls.Add(label);
                groupBox1.Controls.Add(textBox);

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            open_update_form();
        }

        private void update_data_convert()
        {
            string data = updateData;
            if (actualClickedColumnType.ToLower().Contains("char") || actualClickedColumnType.ToLower().Contains("string"))
            {
                data = $"'{data}'";
            }

            string query = $"UPDATE [{actualTable}] SET [{clickedColumnName}] = {data}" +
                $" WHERE [{clickedRowIdName}] = {actualClickedRowID}";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            update_data(cmd);
            get_data();
        }

        private void correctData ()
        {

        }

        private void update_data (OleDbCommand cmd)
        {
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            searchElement();
        }

        private void searchElement()
        {
            searchData = search.Text;
            get_data(searchData);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            DataGridView dgv = dataGridView1;

            int currentColumnIndex = dgv.CurrentCell.ColumnIndex;
            int currentRowIndex = dgv.CurrentCell.RowIndex;

                if (currentRowIndex + 1 < dgv.Rows.Count)
                {
                    dgv.CurrentCell = dgv.Rows[currentRowIndex + 1].Cells[currentColumnIndex];
                }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            DataGridView dgv = dataGridView1;
            int counter = dgv.Rows.Count;

            dgv.ClearSelection();
            dgv.Rows[counter -1].Selected = true;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            DataGridView dgv = dataGridView1;

            int currentColumnIndex = dgv.CurrentCell.ColumnIndex;
            int currentRowIndex = dgv.CurrentCell.RowIndex;

            if (currentRowIndex - 1 >= 0)
            {
                dgv.CurrentCell = dgv.Rows[currentRowIndex - 1].Cells[currentColumnIndex];
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            DataGridView dgv = dataGridView1;

            dgv.ClearSelection();
            dgv.Rows[0].Selected = true;
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            searchElement();
        }
    }

    //======================================================================================================================//
}
