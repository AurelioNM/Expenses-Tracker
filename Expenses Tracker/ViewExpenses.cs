﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expenses_Tracker
{
    public partial class ViewExpenses : Form
    {
        public ViewExpenses()
        {
            InitializeComponent();
            ShowExp();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aurel\Dropbox\PC\Documents\ExpenseDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void ShowExp()
        {
            Con.Open();
            string Query = "select * from ExpenseTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ExpensesDGV.DataSource = ds.Tables[0];
            Con.Close();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
