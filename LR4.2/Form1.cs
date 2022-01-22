using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxA_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownA_ValueChanged(object sender, EventArgs e)
        {

        }

        private void trackBarA_Scroll(object sender, EventArgs e)
        {

        }

        private void textBoxB_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownB_ValueChanged(object sender, EventArgs e)
        {

        }

        private void trackBarB_Scroll(object sender, EventArgs e)
        {

        }

        private void textBoxC_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownC_ValueChanged(object sender, EventArgs e)
        {

        }

        private void trackBarC_Scroll(object sender, EventArgs e)
        {

        }
    }

    public class Model
    {
        private int value_A, value_B, value_C;
        public System.EventHandler observers;

        public void setValue_A(int A)
        {
            if (A < 0)
            {
                value_A = 0;
            }
            else if (A > 100)
            {
                value_A = 100;
                value_B = 100;
                value_C = 100;
            }
            else if (A == value_C)
            {
                value_A = A;
                value_B = A;
            }
            else if (A >= value_C)
            {
                value_A = A;
                value_B = A;
                value_C = A;
            }
            else if (A <= value_C)
            {
                value_A = A;
                if (A > value_B)
                {
                    value_B = A;
                }
            }
            observers.Invoke(this, null);
        }

        public void setValue_B(int B)
        {
            if (B >= value_A)
            {
                if (B <= value_C)
                {
                    value_B = B;
                }
            }
            observers.Invoke(this, null);
        }
        public void setValue_C(int C)
        {
            if (C < 0)
            {
                value_A = 0;
                value_B = 0;
                value_C = 0;
            }
            else if (C > 100)
            {
                value_C = 100;
            }
            else if (C >= value_A)
            {
                value_C = C;
                if (C <= value_B)
                {
                    value_B = C;
                }
            }
            else if (C <= value_A)
            {
                value_A = C;
                value_B = C;
                value_C = C;
            }
            observers.Invoke(this, null);
        }

        public int getValue_A()
        {
            return value_A;
        }
        public int getValue_B()
        {
            return value_B;
        }
        public int getValue_C()
        {
            return value_C;
        }
    }
}
