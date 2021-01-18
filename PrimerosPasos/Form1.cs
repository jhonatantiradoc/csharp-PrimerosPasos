using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerosPasos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtNum1.Text != "" && txtNum2.Text != "")
            {
                double num1, num2;
                double suma, resta, multiplicacion, division;
                num1 = double.Parse(txtNum1.Text);
                num2 = Convert.ToDouble(txtNum2.Text);
                suma = num1 + num2;
                resta = num1 - num2;
                multiplicacion = num1 * num2;
                division = num1 / num2;
                txtSuma.Text = "" + suma;
                txtResta.Text = "" + resta;
                txtMulti.Text = Convert.ToString(multiplicacion);
                txtDiv.Text = division.ToString();
            }
            else
            {
                MessageBox.Show("Llene los campos", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNum1.Focus();
            }      
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtSuma.Text = "";
            txtResta.Text = "";
            txtMulti.Text = "";
            txtDiv.Text = "";
            txtNum1.Focus();
        }

        private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
