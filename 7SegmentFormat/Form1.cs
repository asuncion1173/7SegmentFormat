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
            button1.BackColor = System.Drawing.Color.Black;
            var time = DateTime.Now.ToString("HH:mm:ss");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
