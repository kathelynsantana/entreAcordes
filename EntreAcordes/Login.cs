using Microsoft.VisualBasic.Logging;
using MySqlX.XDevAPI;
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
    //Tela de Login
    public partial class Login : Form
    {
        //Variáveis
        DAOInscrito inscrito;
        CadastrarIns cadIns;
        LoginAdm loginAdm;

        public Login()
        {
            //Inicializando...
            InitializeComponent();
            inscrito = new DAOInscrito();
        }

        //Link de acesso à Tela de Cadastro de Inscrito
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Redirecionando para a Área de Cadastro do Inscrito...
            cadIns = new CadastrarIns();
            cadIns.ShowDialog();

        }//Fim do Link de acesso à Tela de Cadastro de Inscrito

        //Link de acesso à Tela de Login(ADM)
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Redirecionando para a Área de Login (ADM)...
            loginAdm = new LoginAdm();
            loginAdm.ShowDialog();

        }//Fim do Link de acesso à Tela de Login(ADM)

        //Botão de Login
        private void button1_Click(object sender, EventArgs e)
        {
            //Verificando se os campos estão vazios...
            if ((maskedTextBox1.Text == "") || (maskedTextBox2.Text == ""))
            {
                //Se algum campo estiver vazio...
                MessageBox.Show("Por favor, preencha todos os campos para realizar o login!");

            }//Fim do if

            //Variáveis para receber os dados
            string email = maskedTextBox1.Text;
            string senha = maskedTextBox2.Text;

            //Chamando o método de validação de login...
            this.inscrito.loginInscrito(maskedTextBox1.Text, maskedTextBox2.Text);

        }//Fim do Botão de Login

        //Botão de Voltar
        private void button2_Click(object sender, EventArgs e)
        {
            //Fechando a aba...
            this.Close();

        }//Fim do Botão de Voltar

    }//Fim da Tela de Login
}//Fim do Projeto Entre Acordes