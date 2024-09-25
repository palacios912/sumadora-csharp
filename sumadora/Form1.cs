using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;


namespace gestorComercial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                CultureInfo cultura = new CultureInfo("en-US");
                double numero1 = Convert.ToDouble(txt1.Text, cultura);
                double numero2 = Convert.ToDouble(txt2.Text, cultura);

                double resultado = numero1 + numero2;

                lblResultado.Text = resultado.ToString(cultura);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese números válidos.", "pipucheck", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
