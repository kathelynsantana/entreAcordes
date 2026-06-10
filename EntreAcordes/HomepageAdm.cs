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
    //Tela Homepage (ADM)
    public partial class HomepageAdm : Form
    {
        //Variáveis
        SobreNosAdm sobre;
        MusicaAdm musica;
        GerenCantor cantor;
        musicaTetoVidro tetoVidro;
        CadastrarIns cadIns;

        public HomepageAdm()
        {
            //Inicializando...
            InitializeComponent();
        }

        //Link de acesso à Tela Sobre Nós
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Redirecionando para a tela Sobre Nós...
            sobre = new SobreNosAdm();
            sobre.ShowDialog();

        }//Fim do Link de acesso à Tela Sobre Nós

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

        //Botão Ver Música (Teto de Vidro)
        private void button2_Click(object sender, EventArgs e)
        {
            //Redirecionando para a tela da Letra da Música...
            tetoVidro = new musicaTetoVidro();
            tetoVidro.ShowDialog();

        }//Fim do Botão Ver Música (Teto de Vidro)

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }//Fim da Tela Homepage (ADM)
}//Fim do Projeto Entre Acordes