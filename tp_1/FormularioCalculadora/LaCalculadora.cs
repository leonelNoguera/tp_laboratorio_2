using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Matematicas;

namespace FormularioCalculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnConvertirADecimal.Enabled = false;

            this.MaximizeBox = false;
            this.MinimizeBox = false;

            //this.FormBorderStyle = FixedSingle;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            Calculadora miCalculadora = new Calculadora();
            Double numeroUno;
            Double numeroDos;
            Double resultado;
            if (Double.TryParse(txtNumero1.Text, out numeroUno) == true)
            {
                if (Double.TryParse(txtNumero2.Text, out numeroDos) == true)
                {
                    Numero num1 = new Numero(numeroUno);
                    Numero num2 = new Numero(numeroDos);
                    resultado = miCalculadora.Operar(num1, num2, cmbOperador.Text);

                    lblResultado.Text = "" + resultado;
                }
                else
                {
                    txtNumero2.Clear();
                }
            }
            else
            {
                txtNumero1.Clear();
            }

            btnConvertirABinario.Enabled = true;
            btnConvertirADecimal.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();

            btnConvertirABinario.Enabled = true;
            btnConvertirADecimal.Enabled = true;
        }

        private void Limpiar()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            lblResultado.Text = "";
            if (cmbOperador.SelectedIndex >= 0)
            {
                cmbOperador.SetSelected(cmbOperador.SelectedIndex, false);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e) // tiene problemas con los negativos
        {
            Numero numeroAux = new Numero();

            //lblResultado.Text = numeroAux.DecimalBinario(lblResultado.Text);

            //Double.TryParse(lblResultado.Text, out )

            lblResultado.Text = numeroAux.DecimalBinario(lblResultado.Text);

            btnConvertirABinario.Enabled = false;
            btnConvertirADecimal.Enabled = true;
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero numeroAux = new Numero();

            lblResultado.Text = numeroAux.BinarioDecimal(lblResultado.Text);

            btnConvertirADecimal.Enabled = false;
            btnConvertirABinario.Enabled = true;
        }

        private void cmbOperador_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
