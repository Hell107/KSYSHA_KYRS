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
    public partial class SS_Prewiev : Form
    {
        public SS_Prewiev()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            timer1.Interval = 3300; // 500 миллисекунд
        }

        private void SS_Prewiev_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MAIN f = new MAIN();
            f.Show();
            Hide();
            timer1.Stop();
        }
    }
}
