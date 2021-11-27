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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        int StartP = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            StartP += 2;
            Myprogress.Value = StartP;
            if(Myprogress.Value == 100)
            {
                Myprogress.Value = 0;
                timer1.Stop();
                MainMenu Obj = new MainMenu();
                this.Hide();
                Obj.Show();
            }
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Myprogress_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
