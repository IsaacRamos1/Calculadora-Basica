using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstCode
{
    public partial class Form1 : Form
    {
        string operador;
        double a = 0;
        bool validar = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

  
        private void button15_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a / Convert.ToDouble(valor.Text);
                label1.Text = Convert.ToString(a) + "/";
                valor.Text = "";
                operador = "/";
            }
            else
            {
                label1.Text = valor.Text + btn_div.Text;
                a = Convert.ToDouble(valor.Text);
                valor.Text = "";
                operador = "/";
                validar = false;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            /*if (operador == "+")
            {
                label1.Text = label1.Text + valor.Text + "+";
                valor.Text = Convert.ToString(a + Convert.ToInt32(valor.Text));
            }*/
            switch(operador){
                case "+":
                    label1.Text = label1.Text + valor.Text + "=";
                    valor.Text = Convert.ToString(a + Convert.ToDouble(valor.Text));
                    break;
                case "-":
                    label1.Text = label1.Text + valor.Text + "=";
                    valor.Text = Convert.ToString(a - Convert.ToInt32(valor.Text));
                    break;
                case "*":
                    label1.Text = label1.Text + valor.Text + "=";
                    valor.Text = Convert.ToString(a * Convert.ToInt32(valor.Text));
                    break;
                case "/":
                    label1.Text = label1.Text + valor.Text + "=";
                    valor.Text = Convert.ToString(a / Convert.ToInt32(valor.Text));
                    break;
                default:
                    label1.Text = "Operação Iválida";
                    break;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a * Convert.ToDouble(valor.Text);
                label1.Text = Convert.ToString(a) + "*";
                valor.Text = "";
                operador = "*";
            }
            else
            {
                label1.Text = valor.Text + btn_mult.Text;
                a = Convert.ToDouble(valor.Text);
                valor.Text = "";
                operador = "*";
                validar = false;
            }
        }

        private void valor_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnNumerador_Click(object sender, EventArgs e) // qualquer numero da calculadora
        {
            Button bt = (Button)sender;
            valor.Text = valor.Text + bt.Text;
        }

        private void btn_Limpar(object sender, EventArgs e)
        {
            valor.Text = "";
            label1.Text = "";
            a = 0;
        }

        private void btn_soma(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a + Convert.ToDouble(valor.Text);

                label1.Text = Convert.ToString(a) + "+";
                valor.Text = "";
                operador = "+";
            }
            else
            {
                label1.Text = valor.Text + btn_adicao.Text;
                a = Convert.ToDouble(valor.Text);
                valor.Text = "";
                operador = "+";
                validar = false;
            }

        }

        private void btn_subtracao_clik(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a =  a - Convert.ToDouble(valor.Text);
                label1.Text = Convert.ToString(a) + "-";
                valor.Text = "";
                operador = "-";
            }
            else
            {
                label1.Text = valor.Text + btn_subtracao.Text;
                a = Convert.ToDouble(valor.Text);
                valor.Text = "";
                operador = "-";
                validar = false;
            }
        }
    }
}
