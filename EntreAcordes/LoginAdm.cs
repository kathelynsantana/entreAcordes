using Microsoft.VisualBasic.Logging;
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
    //Tela Login (ADM)
    public partial class LoginAdm : Form
    {
        //Variáveis
        DAOAdm adm;
        CadAdm cadastrar;

        public LoginAdm()
        {
            //Inicializando...
            InitializeComponent();
            adm = new DAOAdm();
        }
            
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
            this.adm.loginAdm(maskedTextBox1.Text, maskedTextBox2.Text);

        }//Fim do Botão de Login

        //Botão de Voltar
        private void button2_Click(object sender, EventArgs e)
        {
            //Fechando a aba...
            this.Close();

        }//Fim do Botão de Voltar

        //Link de Acesso à Área de Cadastro do ADM
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Redirecionando para a Área de Cadastro do ADM...
            cadastrar = new CadAdm();
            cadastrar.ShowDialog();

        }//Fim do Link de Acesso à Área de Cadastro do ADM
    }//Fim da Tela Login (ADM)
}//Fim do Projeto Entre Acordes