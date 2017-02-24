using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gokkers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Value_bet_ValueChanged(object sender, EventArgs e)
        {
            Value_bet.Maximum = 15;
            Value_bet.Minimum = 5;
        }

        private void Zebra_num_ValueChanged(object sender, EventArgs e)
        {
            Zebra_num.Maximum = 5;
            Zebra_num.Minimum = 1;
        }

        private void zebra1_Click(object sender, EventArgs e)
        {
            //Zebra1.Location.X = 100;
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int number = rnd.Next(10, 15);
            int speed = 23;
            if (speed == 100)
            {
                for (int i = 0; i < 100; i++)
                            {
                                speed += number;
                                Zebra1.Location = new Point(speed, 28);
                            }
            }
            
        }
    }
}
