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
    public partial class MOON : Form
    {

        int dR, dG, dB, sign;
        public MOON()
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

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

        private void date_Click(object sender, EventArgs e)
        {

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

        private void label29_Click(object sender, EventArgs e)
        {

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void label23_Click(object sender, EventArgs e)
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            //
            dR = label1.BackColor.R - label1.ForeColor.R;
            dG = label1.BackColor.G - label1.ForeColor.G;
            dB = label1.BackColor.B - label1.ForeColor.B;
            sign = 1;
            Timer timer1 = new Timer();
            timer1.Interval = 100;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (Math.Abs(leftText1.ForeColor.R - leftText1.BackColor.R) < Math.Abs(dR / 10))
            {
                sign *= -1;
                leftText1.Text = "Единственный естественный спутник Земли называется просто Луна, потому что люди не знали о существовании других лун, пока Галилео Галилей не обнаружил четыре луны, вращающиеся вокруг Юпитера в 1610 году. По - латыни Луна называется Луной, что является основным прилагательным для всех вещей, связанных с Луной: лунный. \n\n Давным-давно на Луне были активные вулканы, но сегодня все они бездействуют и не извергались в течение миллионов лет.";
            }
            leftText1.ForeColor = Color.FromArgb(255, leftText1.ForeColor.R + sign * dR / 10, leftText1.ForeColor.G + sign * dG / 10, leftText1.ForeColor.B + sign * dB / 10);
            if (leftText1.BackColor.R == leftText1.ForeColor.R + dR)
            {
                ((Timer)sender).Stop();
            }
        }
    }
}
