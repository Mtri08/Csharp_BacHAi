﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_BacHAi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            txta.Text = trackBar1.Value.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            txtb.Text = trackBar2.Value.ToString();
        }

        private void txtc_TextChanged(object sender, EventArgs e)
        {
            txtc.Text = trackBar3.Value.ToString();
        }

        private void btngpt_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(txta.Text);
            b = Convert.ToInt32(txtb.Text);
            c = Convert.ToInt32(txtc.Text);
            double delta, x1, x2;
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        lblkq.Text = "Phương trình vô nghiệm";
                    }
                }
                else
                {
                    lblkq.Text = "Phương trình có vô số nghiệm";
                }
            }
            else {

                x1 = x2 = -c / b;
                lblkq.Text = "Phương trình có nghiệm x = " + x1;
            }

                
            


        else

            { delta = b* b - 4 * a* c;
                if (delta < 0)
                {
                    lblkq.Text = "Phương trình vô nghiệm";
                }
                else if (delta == 0)
                {
                    x1 = x2 = -b / (2 * a);
                    lblkq.Text = "Phương trình có nghiệm kép x1 = x2 = " + x1;
                }
                else
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    lblkq.Text = "Phương trình có 2 nghiệm phân biệt " + " \nx1 = " + x1 + " \nx2 = " + x2;
                }
                    }
                }





 }

        }
    

