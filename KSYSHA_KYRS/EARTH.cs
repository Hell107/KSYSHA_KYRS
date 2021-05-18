using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KSYSHA_KYRS
{
    public partial class Form3 : Form
    {
        int k = 1;
        public Form3()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            void timer_Tick(object sender, EventArgs e)
            {
                date.Text = DateTime.Now.ToShortDateString() + "\n" + DateTime.Now.ToLongTimeString();
            }
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Tick += new EventHandler(timer_Tick);
        }

        private void mars_Click(object sender, EventArgs e)
        {
            MARS f = new MARS();
            f.Opacity = 0;
            f.Show();
            for (int i = 0; i <= 100; i++)
            {
                f.Opacity = i / 100.0;
                System.Threading.Thread.Sleep(1);//чем меньше число, тем быстрее появится
            }
            Hide();
            for (int i = 100; i >= 0; i--)
            {
                Opacity = i / 100.0;
                System.Threading.Thread.Sleep(1); //чем меньше число, тем быстрее исчезнет

            }
        }

        private void jupiter_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Opacity = 0;
            f.Show();
            for (int i = 0; i <= 100; i++)
            {
                f.Opacity = i / 100.0;
                System.Threading.Thread.Sleep(1);//чем меньше число, тем быстрее появится
            }
            Hide();
            for (int i = 100; i >= 0; i--)
            {
                Opacity = i / 100.0;
                System.Threading.Thread.Sleep(1); //чем меньше число, тем быстрее исчезнет

            }
        }

        private void saturn_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Opacity = 0;
            f.Show();
            for (int i = 0; i <= 100; i++)
            {
                f.Opacity = i / 100.0;
                System.Threading.Thread.Sleep(1);//чем меньше число, тем быстрее появится
            }
            Hide();
            for (int i = 100; i >= 0; i--)
            {
                Opacity = i / 100.0;
                System.Threading.Thread.Sleep(1); //чем меньше число, тем быстрее исчезнет

            }
        }

        private void mercury_Click(object sender, EventArgs e)
        {
            MERCURY f = new MERCURY();
            f.Opacity = 0;
            f.Show();
            for (int i = 0; i <= 100; i++)
            {
                f.Opacity = i / 100.0;
                System.Threading.Thread.Sleep(1);//чем меньше число, тем быстрее появится
            }
            Hide();
            for (int i = 100; i >= 0; i--)
            {
                Opacity = i / 100.0;
                System.Threading.Thread.Sleep(1); //чем меньше число, тем быстрее исчезнет

            }
        }

        private void label31_Click(object sender, EventArgs e)
        {
            URAN f = new URAN();
            f.Opacity = 0;
            f.Show();
            for (int i = 0; i <= 100; i++)
            {
                f.Opacity = i / 100.0;
                System.Threading.Thread.Sleep(2);//чем меньше число, тем быстрее появится
            }

            for (int i = 100; i >= 0; i--)
            {
                Opacity = i / 100.0;
                System.Threading.Thread.Sleep(1); //чем меньше число, тем быстрее исчезнет

            }
            Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
            k++;
            if (k % 2 == 0)
            {
                pictureBox1.Image = Properties.Resources.EARTH_CLOUD_SOLO1;

            }
            else pictureBox1.Image = Properties.Resources.EARTH_SOLO;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            
            k++;
            if (k % 2 == 0)
            {
                pictureBox1.Image = Properties.Resources.EARTH_N_SOLO;

            } else pictureBox1.Image = Properties.Resources.EARTH_SOLO;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MOON f = new MOON();
            f.Opacity = 0;
            f.Show();
            for (int i = 0; i <= 100; i++)
            {
                f.Opacity = i / 100.0;
                System.Threading.Thread.Sleep(1);//чем меньше число, тем быстрее появится
            }
            Hide();
            for (int i = 100; i >= 0; i--)
            {
                Opacity = i / 100.0;
                System.Threading.Thread.Sleep(1); //чем меньше число, тем быстрее исчезнет

            }
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MAIN f = new MAIN();
            f.Opacity = 0;
            f.Show();
            for (int i = 0; i <= 100; i++)
            {
                f.Opacity = i / 100.0;
                System.Threading.Thread.Sleep(2);//чем меньше число, тем быстрее появится
            }

            for (int i = 100; i >= 0; i--)
            {
                Opacity = i / 100.0;
                System.Threading.Thread.Sleep(1); //чем меньше число, тем быстрее исчезнет

            }
            Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void venus_Click(object sender, EventArgs e)
        {
            VENUS f = new VENUS();
            f.Opacity = 0;
            f.Show();
            for (int i = 0; i <= 100; i++)
            {
                f.Opacity = i / 100.0;
                System.Threading.Thread.Sleep(2);//чем меньше число, тем быстрее появится
            }

            for (int i = 100; i >= 0; i--)
            {
                Opacity = i / 100.0;
                System.Threading.Thread.Sleep(1); //чем меньше число, тем быстрее исчезнет

            }
            Hide();
        }

        private void neptune_Click(object sender, EventArgs e)
        {
            NEPTUN f = new NEPTUN();
            f.Opacity = 0;
            f.Show();
            for (int i = 0; i <= 100; i++)
            {
                f.Opacity = i / 100.0;
                System.Threading.Thread.Sleep(2);//чем меньше число, тем быстрее появится
            }

            for (int i = 100; i >= 0; i--)
            {
                Opacity = i / 100.0;
                System.Threading.Thread.Sleep(1); //чем меньше число, тем быстрее исчезнет

            }
            Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
