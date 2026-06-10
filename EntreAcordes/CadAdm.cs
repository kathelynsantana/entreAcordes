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
    //Tela Cadastrar (ADM)
    public partial class CadAdm : Form
    {
        //Variáveis
        DAOAdm adm;

        public CadAdm()
        {
            //Inicializando...
            InitializeComponent();
            adm = new DAOAdm();
        }

        //Botão de Cadastro
        private void button1_Click(object sender, EventArgs e)
        {
            //Verificando se todos os campos foram preenchidos...
            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == ""))
            {
                //Se algum campo estiver vazio...
                MessageBox.Show("Por favor, preencha todos os campos!");
            }
            else
            {
                //Variáveis locais
                string nome = textBox1.Text;
                string cargo = textBox2.Text;
                string email = textBox3.Text;
                string senha = textBox4.Text;

                //Inserindo esses dados no Banco de Dados...
                this.adm.cadastrarAdm(nome, cargo, email, senha);

                //Limpando os campos após o cadastro...
                LimparCampos();

            }//Fim do if_else
        }//Fim do Botão de Cadastro

        //Limpar os campos
        private void LimparCampos()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }//Fim do método de Limpar os Campos

        //Botão de Voltar
        private void button2_Click(object sender, EventArgs e)
        {
            //Fechando a aba...
            this.Close();

        }//Fim do Botão de Voltar

    }//Fim da Tela Cadastrar (ADM)
}//Fim do Projeto Entre Acordes