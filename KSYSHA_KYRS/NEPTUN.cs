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
    public partial class NEPTUN : Form
    {

        int dR, dG, dB, sign;
        public NEPTUN()
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

        private void label4_Click(object sender, EventArgs e)
        {
            dR = leftText1.BackColor.R - leftText1.ForeColor.R;
            dG = leftText1.BackColor.G - leftText1.ForeColor.G;
            dB = leftText1.BackColor.B - leftText1.ForeColor.B;
            sign = 1;
            Timer timer1 = new Timer();
            timer1.Interval = 100;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (Math.Abs(leftText1.ForeColor.R - leftText1.BackColor.R) < Math.Abs(dR / 10))
            {
                sign *= -1;
                leftText1.Text = "Уран-один из двух ледяных гигантов во внешней солнечной системе (другой-Нептун). Большая часть (80 процентов или более) массы планеты состоит из горячей плотной жидкости ледяных материалов — воды, метана и аммиака — над небольшим скалистым ядром. Вблизи ядра он нагревается до 9000 градусов по Фаренгейту (4982 градуса Цельсия)./n/nУран получает свой сине-зеленый цвет от метана в атмосфере.Солнечный свет проходит через атмосферу и отражается обратно верхушками облаков Урана.Газ метан поглощает красную часть света, в результате чего получается сине-зеленый цвет.";
            }
            leftText1.ForeColor = Color.FromArgb(255, leftText1.ForeColor.R + sign * dR / 10, leftText1.ForeColor.G + sign * dG / 10, leftText1.ForeColor.B + sign * dB / 10);
            if (leftText1.BackColor.R == leftText1.ForeColor.R + dR)
            {
                ((Timer)sender).Stop();
            }
        }
    }
}
