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
        Model model;

        public Form1()
        {
            InitializeComponent();
            model = new Model();
            
        }

        
        private void numericUpDownA_ValueChanged(object sender, EventArgs e)
        {
            model.setValue_A(Decimal.ToInt32(numericUpDownA.Value));
        }

        private void trackBarA_Scroll(object sender, EventArgs e)
        {
            model.setValue_A(trackBarA.Value);
        }

        private void numericUpDownB_ValueChanged(object sender, EventArgs e)
        {
            model.setValue_B(Decimal.ToInt32(numericUpDownB.Value));
        }

        private void trackBarB_Scroll(object sender, EventArgs e)
        {
            model.setValue_B(trackBarB.Value);
        }
         

        private void numericUpDownC_ValueChanged(object sender, EventArgs e)
        {
            model.setValue_C(Decimal.ToInt32(numericUpDownC.Value));
        }

        private void trackBarC_Scroll(object sender, EventArgs e)
        {
            model.setValue_C(trackBarC.Value);
        }

        private void textBoxA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                model.setValue_A(Int32.Parse(textBoxA.Text));
            }
        }

        private void textBoxB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                model.setValue_B(Int32.Parse(textBoxB.Text));
            }
        }

        private void textBoxC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                model.setValue_C(Int32.Parse(textBoxC.Text));
            }
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
