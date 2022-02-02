using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Calculadora : Form
    {

        double valor1, valor2, result;

        int op;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            //num 0
            tb.Text = tb.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //num 1
            tb.Text = tb.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //num 2
            tb.Text = tb.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //num 3
            tb.Text = tb.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            //num 4
            tb.Text = tb.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            //num 5
            tb.Text = tb.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            //num 6
            tb.Text = tb.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            //num 7
            tb.Text = tb.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            //num 8
            tb.Text = tb.Text + "8";
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            op = 1;

            valor1 = Convert.ToDouble(tb.Text);
            tb.Text = "";
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            valor2 = Convert.ToDouble(tb.Text);

            switch (op)
            {
                case 1:
                    result = valor1 + valor2;
                    break;
                case 2:
                    result = valor1 - valor2;
                    break;
                case 3:
                    result = valor1 * valor2;
                    break;
                case 4:
                    result = valor1 / valor2;
                    break;
            }

            tb.Text = result.ToString();
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            op = 2;

            valor1 = Convert.ToDouble(tb.Text);
            tb.Text = "";
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            op = 3;

            valor1 = Convert.ToDouble(tb.Text);
            tb.Text = "";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            op = 4;

            valor1 = Convert.ToDouble(tb.Text);
            tb.Text = "";
        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            //punto
            tb.Text = tb.Text + ".";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            //num 9
            tb.Text = tb.Text + "9";
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            //Borrar
            tb.Clear();
        }
    }
}
