﻿using System;
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
            var timeSecond = DateTime.Now.ToString("ss");
            int onceSecond = Convert.ToInt32(timeSecond.Substring(timeSecond.Length - 1));

            // For once place (Seconds)
            if (onceSecond == 1)
            {
                btn1SA.BackColor = System.Drawing.Color.Black;
                btn1SF.BackColor = System.Drawing.Color.Black;
                btn1SE.BackColor = System.Drawing.Color.Black;
                btn1SD.BackColor = System.Drawing.Color.Black;
                btn1SB.PerformClick();
                btn1SC.PerformClick();
            }
            else if (onceSecond == 2)
            {
                btn1SC.BackColor = System.Drawing.Color.Black;
                btn1SA.PerformClick();
                btn1SB.PerformClick();
                btn1SG.PerformClick();
                btn1SE.PerformClick();
                btn1SD.PerformClick();
            }
            else if (onceSecond == 3)
            {
                btn1SE.BackColor = System.Drawing.Color.Black;
                btn1SA.PerformClick();
                btn1SB.PerformClick();
                btn1SG.PerformClick();
                btn1SD.PerformClick();
                btn1SC.PerformClick();
            }
            else if (onceSecond == 4)
            {
                btn1SA.BackColor = System.Drawing.Color.Black;
                btn1SD.BackColor = System.Drawing.Color.Black;
                btn1SB.PerformClick();
                btn1SG.PerformClick();
                btn1SC.PerformClick();
                btn1SF.PerformClick();
            }
            else if (onceSecond == 5)
            {
                btn1SB.BackColor = System.Drawing.Color.Black;
                btn1SA.PerformClick();
                btn1SG.PerformClick();
                btn1SC.PerformClick();
                btn1SF.PerformClick();
                btn1SD.PerformClick();
            }
            else if (onceSecond == 6)
            {
                btn1SA.PerformClick();
                btn1SG.PerformClick();
                btn1SC.PerformClick();
                btn1SF.PerformClick();
                btn1SD.PerformClick();
                btn1SE.PerformClick();
            }
            else if (onceSecond == 7)
            {
                btn1SD.BackColor = System.Drawing.Color.Black;
                btn1SE.BackColor = System.Drawing.Color.Black;
                btn1SG.BackColor = System.Drawing.Color.Black;
                btn1SF.BackColor = System.Drawing.Color.Black;
                btn1SA.PerformClick();
                btn1SB.PerformClick();
                btn1SC.PerformClick();
            }
            else if (onceSecond == 8)
            {
                btn1SA.PerformClick();
                btn1SB.PerformClick();
                btn1SC.PerformClick();
                btn1SD.PerformClick();
                btn1SE.PerformClick();
                btn1SF.PerformClick();
                btn1SG.PerformClick();
            }
            else if (onceSecond == 9)
            {
                btn1SE.BackColor = System.Drawing.Color.Black;
                btn1SA.PerformClick();
                btn1SB.PerformClick();
                btn1SC.PerformClick();
                btn1SD.PerformClick();
                btn1SF.PerformClick();
                btn1SG.PerformClick();
            }
            else
            {
                btn1SG.BackColor = System.Drawing.Color.Black;
                btn1SA.PerformClick();
                btn1SB.PerformClick();
                btn1SC.PerformClick();
                btn1SD.PerformClick();
                btn1SE.PerformClick();
                btn1SF.PerformClick();
            }

            // For tenths place (Seconds)
            int tenthSecond = Convert.ToInt32(timeSecond.Substring(0,1));

            if (tenthSecond == 1)
            {
                btn2SA.BackColor = System.Drawing.Color.Black;
                btn2SF.BackColor = System.Drawing.Color.Black;
                btn2SE.BackColor = System.Drawing.Color.Black;
                btn2SD.BackColor = System.Drawing.Color.Black;
                btn2SB.PerformClick();
                btn2SC.PerformClick();
            }
            else if (tenthSecond == 2)
            {
                btn2SC.BackColor = System.Drawing.Color.Black;
                btn2SA.PerformClick();
                btn2SB.PerformClick();
                btn2SG.PerformClick();
                btn2SE.PerformClick();
                btn2SD.PerformClick();
            }
            else if (tenthSecond == 3)
            {
                btn2SE.BackColor = System.Drawing.Color.Black;
                btn2SA.PerformClick();
                btn2SB.PerformClick();
                btn2SG.PerformClick();
                btn2SD.PerformClick();
                btn2SC.PerformClick();
            }
            else if (tenthSecond == 4)
            {
                btn2SA.BackColor = System.Drawing.Color.Black;
                btn2SD.BackColor = System.Drawing.Color.Black;
                btn2SB.PerformClick();
                btn2SG.PerformClick();
                btn2SC.PerformClick();
                btn2SF.PerformClick();
            }
            else if (tenthSecond == 5)
            {
                btn2SB.BackColor = System.Drawing.Color.Black;
                btn2SA.PerformClick();
                btn2SG.PerformClick();
                btn2SC.PerformClick();
                btn2SF.PerformClick();
                btn2SD.PerformClick();
            }
            else
            {
                btn2SG.BackColor = System.Drawing.Color.Black;
                btn2SA.PerformClick();
                btn2SB.PerformClick();
                btn2SC.PerformClick();
                btn2SD.PerformClick();
                btn2SE.PerformClick();
                btn2SF.PerformClick();
            }

            // For once place (Minute)
            var timeMinute = DateTime.Now.ToString("mm");
            int onceMinute = Convert.ToInt32(timeMinute.Substring(timeMinute.Length - 1));

            if (onceMinute == 1)
            {
                btn1MA.BackColor = System.Drawing.Color.Black;
                btn1MF.BackColor = System.Drawing.Color.Black;
                btn1ME.BackColor = System.Drawing.Color.Black;
                btn1MD.BackColor = System.Drawing.Color.Black;
                btn1MB.PerformClick();
                btn1MC.PerformClick();
            }
            else if (onceMinute == 2)
            {
                btn1MC.BackColor = System.Drawing.Color.Black;
                btn1MA.PerformClick();
                btn1MB.PerformClick();
                btn1MG.PerformClick();
                btn1ME.PerformClick();
                btn1MD.PerformClick();
            }
            else if (onceMinute == 3)
            {
                btn1ME.BackColor = System.Drawing.Color.Black;
                btn1MA.PerformClick();
                btn1MB.PerformClick();
                btn1MG.PerformClick();
                btn1MD.PerformClick();
                btn1MC.PerformClick();
            }
            else if (onceMinute == 4)
            {
                btn1MA.BackColor = System.Drawing.Color.Black;
                btn1MD.BackColor = System.Drawing.Color.Black;
                btn1MB.PerformClick();
                btn1MG.PerformClick();
                btn1MC.PerformClick();
                btn1MF.PerformClick();
            }
            else if (onceMinute == 5)
            {
                btn1MB.BackColor = System.Drawing.Color.Black;
                btn1MA.PerformClick();
                btn1MG.PerformClick();
                btn1MC.PerformClick();
                btn1MF.PerformClick();
                btn1MD.PerformClick();
            }
            else if (onceMinute == 6)
            {
                btn1MA.PerformClick();
                btn1MG.PerformClick();
                btn1MC.PerformClick();
                btn1MF.PerformClick();
                btn1MD.PerformClick();
                btn1ME.PerformClick();
            }
            else if (onceMinute == 7)
            {
                btn1MD.BackColor = System.Drawing.Color.Black;
                btn1ME.BackColor = System.Drawing.Color.Black;
                btn1MG.BackColor = System.Drawing.Color.Black;
                btn1MF.BackColor = System.Drawing.Color.Black;
                btn1MA.PerformClick();
                btn1MB.PerformClick();
                btn1MC.PerformClick();
            }
            else if (onceMinute == 8)
            {
                btn1MA.PerformClick();
                btn1MB.PerformClick();
                btn1MC.PerformClick();
                btn1MD.PerformClick();
                btn1ME.PerformClick();
                btn1MF.PerformClick();
                btn1MG.PerformClick();
            }
            else if (onceMinute == 9)
            {
                btn1ME.BackColor = System.Drawing.Color.Black;
                btn1MA.PerformClick();
                btn1MB.PerformClick();
                btn1MC.PerformClick();
                btn1MD.PerformClick();
                btn1MF.PerformClick();
                btn1MG.PerformClick();
            }
            else
            {
                btn1MG.BackColor = System.Drawing.Color.Black;
                btn1MA.PerformClick();
                btn1MB.PerformClick();
                btn1MC.PerformClick();
                btn1MD.PerformClick();
                btn1ME.PerformClick();
                btn1MF.PerformClick();
            }

        }

        private void all(object sender, EventArgs e)
        {
            Button btnAll = (Button)sender;
            btnAll.BackColor = System.Drawing.Color.Red;
        }
    }
}
