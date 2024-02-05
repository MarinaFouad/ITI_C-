using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;


namespace Lab8
{
    public partial class Form1 : Form
    {
        SqlConnection sqlConnection;
        SqlCommand command01;
        public Form1()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection();
            command01 = new SqlCommand();

            sqlConnection.ConnectionString = "Data Source = DESKTOP-1T6LFVE\\SQLEXPRESS ; Initial Catalog = Company; Integrated Security= true ;";

            command01.Connection = sqlConnection;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataReader Reader01;
            if (listBox1.Items.Count > 0)
            {
                listBox1.Items.Clear();
            }
            command01.CommandText = "Select ID, Name From Employee";
            sqlConnection.Open();
            Reader01 = command01.ExecuteReader();
            while (Reader01.Read())
            {
                string str = ((int)Reader01[0]).ToString() + "   " + Reader01[1].ToString();
                listBox1.Items.Add(str);
            }
            Reader01.Close();
            sqlConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "Insert Into Employee Values(" + textBox1.Text + ", '" + textBox2.Text + "')";
            command01.CommandText = str;
            sqlConnection.Open();
            int affectedRows = command01.ExecuteNonQuery();
            sqlConnection.Close();
            textBox1.Text = textBox2.Text = "";

        }



        private void button4_Click(object sender, EventArgs e)
        {
            string str = "Update Employee Set Name = '" + textBox2.Text + "' Where ID = " + textBox1.Text;
            command01.CommandText = str;
            sqlConnection.Open();
            int affectedRows = command01.ExecuteNonQuery();
            sqlConnection.Close();
            textBox1.Text = textBox2.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = "Delete From Employee Where ID = '" + textBox1.Text + "'";
            command01.CommandText = str;
            sqlConnection.Open();
            int affectedRows = command01.ExecuteNonQuery();
            sqlConnection.Close();
            textBox1.Text = textBox2.Text = "";
        }
    }
}
