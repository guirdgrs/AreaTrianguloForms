using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaTrianguloForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Var para armazenar a base e a altura
                double num1, num2;

                //Preenchendo var com o TextBox
                num1 = double.Parse(txbNum1.Text); //Base
                num2 = double.Parse(txbNum2.Text); //Altura

                if (num1 == 0 || num2 == 0) //Condição - Valores não podem ser zero
                {
                    MessageBox.Show("Valores não podem ser zero");
                    txbResultado.Text = "Erro";
                }
                else //Área do triângulo = b * h / 2
                {
                    lblResultado.Text = "A área do triângulo é: ";
                    txbResultado.Text = (num1 * num2 / 2).ToString(); //Resultado
                }
            }
            catch
            {
                MessageBox.Show("Erro! Dados inválidos");
                lblResultado.Text = "PREENCHA OS CAMPOS";
                txbResultado.Clear();
                txbNum1.Clear();
                txbNum2.Clear();
            }
        }
    }
}
