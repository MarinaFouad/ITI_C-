using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Lab7

{
    public partial class Form1 : Form
    {
        SqlDataAdapter dataAdapter;
        SqlConnection sqlConnection;

        SqlCommand sqlSelect;
        SqlCommand sqlDelete;
        SqlCommand sqlInsert;
        SqlCommand sqlUpdate;

        DataSet dataSet01;

        public Form1()
        {
            InitializeComponent();
            dataAdapter = new SqlDataAdapter();
            sqlConnection = new SqlConnection();
            dataSet01 = new DataSet();
            sqlConnection.ConnectionString = "Data Source = DESKTOP-1T6LFVE\\SQLEXPRESS ; Initial Catalog = Company; Integrated Security= true ;";

            sqlSelect = new SqlCommand();
            sqlInsert = new SqlCommand();
            sqlUpdate = new SqlCommand();
            sqlDelete = new SqlCommand();

            sqlSelect.Connection = sqlConnection;
            sqlInsert.Connection = sqlConnection;
            sqlUpdate.Connection = sqlConnection;
            sqlDelete.Connection = sqlConnection;

            sqlSelect.CommandText = "Select Name , ID from Employee";
            dataAdapter.SelectCommand = sqlSelect;
            dataAdapter.DeleteCommand = sqlDelete;
            dataAdapter.InsertCommand = sqlInsert;
            dataAdapter.UpdateCommand = sqlUpdate;

            sqlInsert.CommandText = "Insert Into Employee (Name, ID) values(@Name, @ID);";
            SqlParameter s_Name = new SqlParameter("@Name", SqlDbType.NVarChar,255, "Name");
            SqlParameter s_ID = new SqlParameter("@ID", SqlDbType.Int, 0, "ID");
            sqlInsert.Parameters.Add(s_Name);
            sqlInsert.Parameters.Add(s_ID);


            sqlDelete.CommandText = "delete from Employee where ID = @ID";
            SqlParameter s_DeleteID = new SqlParameter("@ID", SqlDbType.Int, 0, "ID");
            sqlDelete.Parameters.Add(s_DeleteID);



        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataAdapter.Fill(dataSet01);
            dataGridView1.DataSource = dataSet01.Tables[0];
            button1.BackColor = SystemColors.ActiveCaption;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataRow row01 = dataSet01.Tables[0].NewRow();
            row01[0] = textBox1.Text;
            row01[1] = textBox2.Text;
            dataSet01.Tables[0].Rows.Add(row01);
            textBox1.Text = textBox2.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataAdapter.Update(dataSet01);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
                dataSet01.Tables[0].Rows[dataSet01.Tables[0].Rows.Count - 1].Delete();
                dataAdapter.Update(dataSet01);
         
        }
    }
}
