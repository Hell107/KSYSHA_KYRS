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
    public partial class SUN : Form
    {
        public SUN()
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

        private void mercury_Click(object sender, EventArgs e)
        {
            MERCURY f = new MERCURY();
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

        private void earth_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
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

        private void mars_Click(object sender, EventArgs e)
        {
            MARS f = new MARS();
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

        private void jupiter_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
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

        private void saturn_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
