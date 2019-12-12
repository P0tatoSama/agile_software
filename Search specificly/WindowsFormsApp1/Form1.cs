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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\location.mdf;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'locationDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.locationDataSet.Table);
            //comboBox1.SelectedIndex = 1;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    if (string.IsNullOrEmpty(textBox1.Text))
            //        tableBindingSource.Filter = string.Empty;
            //    else
            //        tableBindingSource.Filter = string.Format("{0}='{1}'", comboBox1.Text, textBox1.Text);


            //}
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Id")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select Id, Street, Suburb, City FROM [Table] WHERE Id LIKE '%" + textBox1.Text+"%'",con);
                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView1.DataSource = data;
            }
            //else if (comboBox1.Text == "Place")
            //{
            //    SqlDataAdapter sda = new SqlDataAdapter("Select Id, Place, Street, Suburb, City FROM [Table] WHERE Place LIKE '%" + textBox1.Text + "%'", con);
            //    DataTable data = new DataTable();
            //    sda.Fill(data);
            //    dataGridView1.DataSource = data;
            //}
            else if (comboBox1.Text == "Street")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select Id, Street, Suburb, City FROM [Table] WHERE Street LIKE '%" + textBox1.Text + "%'", con);
                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView1.DataSource = data;
            }
            else if (comboBox1.Text == "Suburb")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select Id, Street, Suburb, City FROM [Table] WHERE Suburb LIKE '%" + textBox1.Text + "%'", con);
                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView1.DataSource = data;
            }
            else if (comboBox1.Text == "City")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select Id, Street, Suburb, City FROM [Table] WHERE City LIKE '%" + textBox1.Text + "%'", con);
                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView1.DataSource = data;
            }
        }
    }
}
