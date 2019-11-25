using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_de_Teste
{
    public partial class Calculadora : Form
    {
        string operador;
        int result = 0;
        bool validar = false; //variável booleana, verifica se é verdadeiro ou falso

        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnNumerador_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender; // envia Numerador
            txt_valor.Text = txt_valor.Text + bt.Text; // transporta o valor do botão para a tela
        }

        private void btn_c_Click(object sender, EventArgs e) //Limpar
        {
            txt_valor.Text = "";
            visor_label.Text = "";
            result = 0;
            validar = false; //mantém a vairável de validação
        }

        private void btn_mais_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                result = result + Convert.ToInt32(txt_valor.Text); //convertendo o texto dentro do visor para innteiro, para que seja possível fazer as operações
                visor_label.Text = Convert.ToString(result) + "+"; //pegando o primeiro número digitado junto com a operação escolhida e mostrando no visor esquerdo
                txt_valor.Text = ""; //limpamdo o visor que irá aparecer o resultado final (visor direito)
                operador = "+"; //guarda a informação de qual operador irá utilizar
            }
            else
            {
                visor_label.Text = txt_valor.Text + btn_mais.Text; //pegar o valor que está guardado na última operação e adicionar o operador
                result = Convert.ToInt32(txt_valor.Text); // convertendo o novo valor em um número inteiro
                txt_valor.Text = ""; //limpando o visor da direita para aparecer o resultado
                operador = "+"; //guarda a informação de qual operador irá utilizar
                validar = true; //retoma o primeiro if para continuar a operação
            }
        }

        private void btn_menos_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                result = result - Convert.ToInt32(txt_valor.Text);
                visor_label.Text = Convert.ToString(result) + "-";
                txt_valor.Text = "";
                operador = "-";
            }
            else
            {
                visor_label.Text = txt_valor.Text + btn_menos.Text;
                result = Convert.ToInt32(txt_valor.Text);
                txt_valor.Text = "";
                operador = "-";
                validar = true;
            }

        }

        private void btn_multi_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                result = result * Convert.ToInt32(txt_valor.Text);
                visor_label.Text = Convert.ToString(result) + "*";
                txt_valor.Text = "";
                operador = "*";
            }
            else
            {
                visor_label.Text = txt_valor.Text + btn_multi.Text;
                result = Convert.ToInt32(txt_valor.Text);
                txt_valor.Text = "";
                operador = "*";
                validar = true;
            }
        }

        private void btn_divisao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                result = result / Convert.ToInt32(txt_valor.Text);
                visor_label.Text = Convert.ToString(result) + "/";
                txt_valor.Text = "";
                operador = "-";
            }
            else
            {
                visor_label.Text = txt_valor.Text + btn_divisao.Text;
                result = Convert.ToInt32(txt_valor.Text);
                txt_valor.Text = "";
                operador = "/";
                validar = true;
            }
        }

        private void btn_resultado_Click(object sender, EventArgs e)
        {
            if (operador == "+") //verificar qual o perador está sendo utilizado
            {
                visor_label.Text = visor_label.Text + txt_valor.Text + "="; //mostra a operação realizada do valor do número antigo (visor esquerdo) com o número novo (visor direito)
                txt_valor.Text = Convert.ToString(result + Convert.ToInt32(txt_valor.Text)); //faz o cálculo escolhido e mostra o resultado
            }

            else if (operador == "-")
            {
                visor_label.Text = visor_label.Text + txt_valor.Text + "=";
                txt_valor.Text = Convert.ToString(result - Convert.ToInt32(txt_valor.Text));
            }

            else if (operador == "*")
            {
                visor_label.Text = visor_label.Text + txt_valor.Text + "=";
                txt_valor.Text = Convert.ToString(result * Convert.ToInt32(txt_valor.Text));
            }

            else if (operador == "/")
            {
                visor_label.Text = visor_label.Text + txt_valor.Text + "=";
                txt_valor.Text = Convert.ToString(result / Convert.ToInt32(txt_valor.Text));
            }

        }
    }
}
