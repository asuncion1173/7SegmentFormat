using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7SegmentFormat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var time = DateTime.Now.ToString("ss");
            int onceSecond = Convert.ToInt32(time.Substring(time.Length - 1));
            if (onceSecond == 1)
            {
                btn1SB.PerformClick();
                btn1SC.PerformClick();
            }
            else if (onceSecond == 2)
            {
                btn1SA.PerformClick();
                btn1SB.PerformClick();
                btn1SG.PerformClick();
                btn1SE.PerformClick();
                btn1SD.PerformClick();
            }
        }

        private void all(object sender, EventArgs e)
        {
            Button btnAll = (Button)sender;
            btnAll.BackColor = System.Drawing.Color.Black;
        }
    }
}
