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
    //Tela "Sobre Nós" (ADM)
    public partial class SobreNosAdm : Form
    {
        //Variáveis
        CadastrarIns cadIns;
        HomepageAdm homepage;
        MusicaAdm musica;
        GerenCantor cantor;

        public SobreNosAdm()
        {
            InitializeComponent();
        }

        //Link de acesso à Tela Homepage
        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Redirecionando para a tela Sobre Nós...
            homepage = new HomepageAdm();
            homepage.ShowDialog();

        }//Fim do Link de acesso à Tela Homepage

        //Link de acesso à Tela Música
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Redirecionando para a tela de Música...
            musica = new MusicaAdm();
            musica.ShowDialog();

        }//Fim do Link de acesso à Tela Música

        //Link de acesso à Tela Cantor
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Redirecionando para a tela de Cantor...
            cantor = new GerenCantor();
            cantor.ShowDialog();

        }//Fim do Link de acesso à Tela Cantor

        //Botão para acessar a Tela de Cadastro do Inscrito
        private void button1_Click(object sender, EventArgs e)
        {
            //Redirecionando para a Área de Cadastro do Inscrito...
            cadIns = new CadastrarIns();
            cadIns.ShowDialog();

        }//Fim do Botão para acessar a Tela de Cadastro do Inscrito

    }//Fim da Tela "Sobre Nós" (ADM)
}//Fim do Projeto Entre Acordes