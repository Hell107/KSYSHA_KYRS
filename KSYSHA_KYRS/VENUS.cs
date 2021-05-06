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
    public partial class VENUS : Form
    {
        int dR, dG, dB, sign;
        public VENUS()
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label30_Click(object sender, EventArgs e)
        {

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

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void label4_Click(object sender, EventArgs e)
        {
            dR = label4.BackColor.R - label4.ForeColor.R;
            dG = label4.BackColor.G - label4.ForeColor.G;
            dB = label4.BackColor.B - label4.ForeColor.B;
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
                leftText1.Text = "Венера имеет сокрушительное давление воздуха на своей поверхности – более чем в 90 раз больше, чем на Земле, – аналогичное давлению, с которым вы столкнетесь в миле ниже океана на Земле.\n\nВенера была первой планетой, которую исследовал космический корабль – 14 декабря 1962 года 'Маринер-2' НАСА успешно пролетел мимо и просканировал покрытый облаками мир.С тех пор многочисленные космические аппараты из США и других космических агентств исследовали Венеру, в том числе 'Магеллан' НАСА, который нанес на карту поверхность планеты с помощью радара.Бывший Советский Союз - единственная страна, которая на сегодняшний день приземлилась на поверхность Венеры, хотя космический корабль недолго продержался в суровых условиях.";
            }
            leftText1.ForeColor = Color.FromArgb(255, leftText1.ForeColor.R + sign * dR / 10, leftText1.ForeColor.G + sign * dG / 10, leftText1.ForeColor.B + sign * dB / 10);
            if (leftText1.BackColor.R == leftText1.ForeColor.R + dR)
            {
                ((Timer)sender).Stop();
            }
        }
    }
}
