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
        }

        //Link de acesso à Tela de Login
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Redirecionando para a Área de Login do Inscrito...
            login = new Login();
            login.ShowDialog();

        }//Fim do Link de acesso à Tela de Login

        //Botão de Cadastro
        private void button1_Click(object sender, EventArgs e)
        {

        }//Fim do Botão de Cadastro

        //Botão de Voltar
        private void button2_Click(object sender, EventArgs e)
        {
            //Fechando a aba...
            this.Close();

        }//Fim do Botão de Voltar

    }//Fim da Tela de Cadastro do Inscrito
}//Fim do Projeto Entre Acordes