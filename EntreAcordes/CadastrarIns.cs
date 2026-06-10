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
    //Tela de Cadastro do Inscrito
    public partial class CadastrarIns : Form
    {
        //Variáveis
        DAOInscrito inscrito;
        Login login;

        public CadastrarIns()
        {
            //Inicializando...
            InitializeComponent();
            inscrito = new DAOInscrito();
        }

        //Link de acesso à Tela de Login
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Redirecionando para a Área de Login do Inscrito...
            login = new Login();
            login.ShowDialog();

            //Fechando a aba depois de ser redirecionado...
            this.Close();

        }//Fim do Link de acesso à Tela de Login

        //Botão de Cadastro
        private void button1_Click(object sender, EventArgs e)
        {
            //Verificando se todos os campos foram preenchidos...
            if ((textBox1.Text == "") || (maskedTextBox1.Text == "") || (maskedTextBox2.Text == "") || (textBox2.Text == "") || (textBox3.Text == ""))
            {
                //Se algum campo estiver vazio...
                MessageBox.Show("Por favor, preencha todos os campos!");
            }
            else
            {
                //Variáveis locais
                string nome = textBox1.Text;
                string email = textBox2.Text;
                string senha = textBox3.Text;
                string telefone = maskedTextBox2.Text;

                //Tratamento do Datetime...
                string dt = maskedTextBox1.Text;
                string dtDia = dt.Substring(0, 2);
                string dtMes = dt.Substring(3, 2);
                string dtAno = dt.Substring(6, 4);
                String dtNascimento = (dtAno + "/" + dtMes + "/" + dtDia);

                //Inserindo esses dados no Banco de Dados...
                this.inscrito.cadastrarInscrito(nome, Convert.ToDateTime(dtNascimento), telefone, email, senha);

                //Limpando os campos após o cadastro...
                LimparCampos();

            }//Fim do if_else
        }//Fim do Botão de Cadastro

        //Limpar os campos
        private void LimparCampos()
        {
            textBox1.Text = "";
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

        }//Fim do método de Limpar os Campos

        //Botão de Voltar
        private void button2_Click(object sender, EventArgs e)
        {
            //Fechando a aba...
            this.Close();

        }//Fim do Botão de Voltar

    }//Fim da Tela de Cadastro do Inscrito
}//Fim do Projeto Entre Acordes