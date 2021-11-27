using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Expenses_Tracker
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            DayLbl.Text = DateTime.Today.Day.ToString();
            MonthLbl.Text = DateTime.Today.Month.ToString();
            YearLbl.Text = DateTime.Today.Year.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Expenses Obj = new Expenses();
            Obj.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            ViewExpenses Obj = new ViewExpenses();
            Obj.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Reports Obj = new Reports();
            Obj.Show();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void MonthLbl_Click(object sender, EventArgs e)
        {

        }

        private void DayLbl_Click(object sender, EventArgs e)
        {

        }

        private void YearLbl_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox5_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
