using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace MysqlTesting
{
    public partial class formMYSQL : Form
    {
        string connectionString = @"Server=localHost;Database=librarytesting; Uid=root; pwd= ";
       
        
        public formMYSQL()
        {
            InitializeComponent();
            datafill();
            normal();
            clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlcmd = new MySqlCommand("BookAddOrEdit", mysqlCon);
                mysqlcmd.CommandType = CommandType.StoredProcedure;
                mysqlcmd.Parameters.AddWithValue("_BookID", 0);
                mysqlcmd.Parameters.AddWithValue("_BookName", txtBookName.Text);
                mysqlcmd.Parameters.AddWithValue("_Author", txtAuthor.Text);
                mysqlcmd.Parameters.AddWithValue("_Description",txtDescription.Text);
                mysqlcmd.ExecuteNonQuery();
                datafill();
                clear();
                MessageBox.Show("Successfully Updated");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlcmd = new MySqlCommand("BookDeleteByID", mysqlCon);
                mysqlcmd.CommandType = CommandType.StoredProcedure;
                mysqlcmd.Parameters.AddWithValue("_BookID", txtBookID.Text);
                mysqlcmd.ExecuteNonQuery();
                datafill();
                clear();
                MessageBox.Show("Successfully deleted");

                normal();
            }


        }
        private void datafill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqldata = new MySqlDataAdapter("BookViewAll", mysqlCon);
                sqldata.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dttable = new DataTable();
                sqldata.Fill(dttable);
                dataGridView1.DataSource = dttable;
                dataGridView1.Columns[0].HeaderText = "Book ID";
                dataGridView1.Columns[1].HeaderText = "Book Name";
                dataGridView1.Columns[2].HeaderText = "Book Author";
                dataGridView1.Columns[3].HeaderText = "Description";
               

            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqldata = new MySqlDataAdapter("BookSearchByValue", mysqlCon);
                sqldata.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqldata.SelectCommand.Parameters.AddWithValue("_SearchValue", txtsearch.Text);
                DataTable dttable = new DataTable();
                sqldata.Fill(dttable);
                dataGridView1.DataSource = dttable;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            txtAuthor.Clear();
            txtBookID.Clear();
            txtBookName.Clear();
            txtDescription.Clear();
            txtsearch.Clear();

        }

        private void txtBookID_MouseClick(object sender, MouseEventArgs e)
        {
            txtBookID.ReadOnly = false;
            txtAuthor.ReadOnly = true; 
            txtBookName.ReadOnly = true;
            txtDescription.ReadOnly = true;
            txtsearch.ReadOnly = true;
        }

        void normal()
        {
            txtAuthor.ReadOnly = false;
            txtBookName.ReadOnly = false;
            txtDescription.ReadOnly = false;
            txtsearch.ReadOnly = false;
            txtBookID.ReadOnly = true;
        }
        private void txtBookName_MouseClick(object sender, MouseEventArgs e)
        {
            normal();
        }

        private void txtAuthor_MouseClick(object sender, MouseEventArgs e)
        {
            normal();
        }

        private void txtDescription_MouseClick(object sender, MouseEventArgs e)
        {
            normal();
        }

        
    }
}
