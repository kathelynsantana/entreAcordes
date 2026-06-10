using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

//Projeto Entre Acordes
namespace EntreAcordes
{
    //Tela Cadastrar 
    public partial class CadastarCan : Form
    {
        //Variáveis
        DAOCantor cantor;

        public CadastarCan()
        {
            //Inicializando...
            InitializeComponent();
            cantor = new DAOCantor();
        }

        //Botão de Cadastro
        private void button1_Click(object sender, EventArgs e)
        {
            //Verificando se todos os campos foram preenchidos...
            if ((textBox1.Text == "") || (textBox2.Text == "") || (maskedTextBox1.Text == ""))
            {
                //Se algum campo estiver vazio...
                MessageBox.Show("Por favor, preencha todos os campos!");
            }
            else
            {
                //Variáveis locais
                string nome = textBox1.Text;
                string genero = textBox2.Text;

                //Tratamento do Datetime...
                string dt = maskedTextBox1.Text;
                string dtDia = dt.Substring(0, 2);
                string dtMes = dt.Substring(3, 2);
                string dtAno = dt.Substring(6, 4);
                String dtNascimento = (dtAno + "/" + dtMes + "/" + dtDia);

                //Inserindo esses dados no Banco de Dados...
                this.cantor.cadastrarCantor(nome, genero, Convert.ToDateTime(dtNascimento));

                //Limpando os campos após o cadastro...
                LimparCampos();

            }//Fim do if_else
        }//Fim do Botão de Cadastro

        //Limpar os campos
        private void LimparCampos()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            maskedTextBox1.Text = "";

        }//Fim do método de Limpar os Campos

        //Botão de Voltar
        private void button2_Click(object sender, EventArgs e)
        {
            //Fechando a aba...
            this.Close();

        }//Fim do Botão de Voltar

    }//Fim da Tela Cadastrar
}//Fim do Projeto Entre Acordes