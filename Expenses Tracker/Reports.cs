using System;
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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
            GetMaxExp();
            GetMinExp();
            GetTotExp();
            GetAvgExp();
            GetBestCat();
            GetMinCat();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\aurel\Dropbox\PC\Documents\ExpenseDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void GetMaxExp()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Max(ExpAmt) from ExpenseTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            MaxLbl.Text = "R$" + dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void GetMinExp()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Min(ExpAmt) from ExpenseTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            MinLbl.Text = "R$" + dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void GetTotExp()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Sum(ExpAmt) from ExpenseTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            TotLbl.Text = "R$" + dt.Rows[0][0].ToString();
            Con.Close();
        }
        
        private void GetAvgExp()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Sum(ExpAmt) from ExpenseTbl", Con);
            SqlDataAdapter sda1 = new SqlDataAdapter("select Count(*) from ExpenseTbl", Con);
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            sda.Fill(dt);
            sda1.Fill(dt1);
            double Avg = Convert.ToDouble(dt.Rows[0][0].ToString()) / Convert.ToDouble(dt1.Rows[0][0].ToString());
            AvgLbl.Text = "R$" + ((int)Avg);
            CountLbl.Text = dt1.Rows[0][0].ToString() + " Expenses";
            Con.Close();
        }

        private void GetBestCat()
        {
            Con.Open();
            string InnerQuery = "select Max(ExpAmt) from ExpenseTbl";
            DataTable dt1 = new DataTable();
            SqlDataAdapter sda1 = new SqlDataAdapter(InnerQuery, Con);
            sda1.Fill(dt1);
            string Query = "select ExpCat from ExpenseTbl where ExpAmt = '" + dt1.Rows[0][0].ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            HighCatLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void GetMinCat()
        {
            Con.Open();
            string InnerQuery = "select Min(ExpAmt) from ExpenseTbl";
            DataTable dt1 = new DataTable();
            SqlDataAdapter sda1 = new SqlDataAdapter(InnerQuery, Con);
            sda1.Fill(dt1);
            string Query = "select ExpCat from ExpenseTbl where ExpAmt = '" + dt1.Rows[0][0].ToString() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            LowCatLbl.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void GetTotExpByCat()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Sum(ExpAmt) from ExpenseTbl where ExpCat ='"+Catcb.SelectedItem.ToString()+"'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            TotByCatLbl.Text = "R$" + dt.Rows[0][0].ToString();
            TotByCatLbl.Visible = true;
            Con.Close();
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Catcb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetTotExpByCat();
        }

        private void AvgLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
