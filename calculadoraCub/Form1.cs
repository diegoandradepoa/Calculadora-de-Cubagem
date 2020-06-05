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

namespace calculadoraCub
{
    public partial class calculCubagem : Form
    {

        public double Comprimento;
        public double Largura;
        public double Altura;
        public double Fator;

        public double ResultadoSoma()
        {
            return Comprimento * Largura * Altura;
        }

        public double ResultadoFator()
        {
            return Fator * ResultadoSoma();
        }

        public double CubagemPlataforma()
        {
            return (ResultadoSoma() * 1000000) / ResultadoFator();
        }

        public calculCubagem()
        {
            InitializeComponent();
        }


        public void btResultMedidas_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtComprimento.Text == "")
                {
                    MessageBox.Show("Insira o comprimento");
                }
                else if (txtLargura.Text == "")
                {
                    MessageBox.Show("Insira a largura");
                }
                else if (txtAltura.Text == "")
                {

                    MessageBox.Show("Insira a altura");
                }
                else
                {

                    Comprimento = double.Parse(txtComprimento.Text);
                    Largura = double.Parse(txtLargura.Text);
                    Altura = double.Parse(txtAltura.Text);

                    lblResultadoMedidas.Text = ResultadoSoma().ToString();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Digite somente números");
            }
        }

        private void btCubagem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCoefCubagem.Text == "")
                {
                    MessageBox.Show("Insira o comprimento");
                }
                else
                {

                    Fator = double.Parse(txtCoefCubagem.Text);
                }

                lblResultadoFinal.Text = CubagemPlataforma().ToString("F0");
            }
            catch (Exception)
            {
                MessageBox.Show("Digite somente números");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtComprimento.Text = string.Empty;
            txtLargura.Text = string.Empty;
            txtAltura.Text = string.Empty;
            lblResultadoMedidas.Text = string.Empty;
            txtCoefCubagem.Text = string.Empty;
            lblResultadoFinal.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculCubagem_Load(object sender, EventArgs e)
        {

        }
    }
}