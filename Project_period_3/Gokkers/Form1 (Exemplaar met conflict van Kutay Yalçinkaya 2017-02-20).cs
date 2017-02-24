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
        private int i;

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
            tmr_run_Zebra.Start();

            //int beginning = 23;
            //int progress = 0;
            //int finish = 838;

            //PictureBox[] zebraArray = new PictureBox[]
            //{
            //    Zebra1,
            //    Zebra2,
            //    Zebra3,
            //    Zebra4,
            //    Zebra5
            //};

            //Random rnd = new Random();

            //do
            //{
            //    for (int i = 0; i < zebraArray.Length; i++)
            //    {
            //        int speed = rnd.Next(10, 15);
            //        int pos_y = 0 + (i * 65);

            //        beginning += speed;
            //        progress = beginning;
            //        progress += speed;
            //        zebraArray[i].Location = new Point(progress, pos_y);
            //    }
            //} while (progress <= finish);
        }

        private void tmr_run_Zebra_Tick(object sender, EventArgs e)
        {
            int beginning = 23;
            int progress = 0;
            int finish = 838;

            PictureBox[] zebraArray = new PictureBox[]
            {
                Zebra1,
                Zebra2,
                Zebra3,
                Zebra4,
                Zebra5
            };

            Random rnd = new Random();
            int speed = rnd.Next(10, 15);
            int pos_y = 0 + (i * 65);

            beginning += speed;
            progress = beginning;
            progress += speed;
            zebraArray[i].Location = new Point(progress, pos_y);
        }
    }
}
