using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Projeto Entre Acordes
namespace EntreAcordes
{
    //Tela Excluir Cantor (ADM)
    public partial class ExcCantor : Form
    {
        //Variáveis
        DAOCantor cantor;

        public ExcCantor()
        {
            //Inicializando...
            InitializeComponent();
            cantor = new DAOCantor();
        }

        //Botão de Excluir
        private void button1_Click(object sender, EventArgs e)
        {
            //Verificando se o campo do código está vazio...
            if (maskedTextBox1.Text == "")
            {
                MessageBox.Show("Por favor, preencha o campo do código!");
            }
            else
            {
                //Executando a exclusão...
                int codigo = Convert.ToInt32(maskedTextBox1.Text);
                string excluido = this.cantor.excluirCantor(codigo);
                MessageBox.Show(excluido);//Exibindo a mensagem de exclusão do método
                maskedTextBox1.Text = "";//Limpando o campo do código

            }//Fim do if else
        }//Fim do Botão de Excluir

        //Botão de Voltar
        private void button2_Click(object sender, EventArgs e)
        {
            //Fechando a aba...
            this.Close();

        }//Fim do Botão de Voltar
    }//Fim da Tela Excluir Cantor (ADM)s
}//Fim do Projeto Entre Acordes