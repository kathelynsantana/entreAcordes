using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

//Projeto Entre Acordes
namespace EntreAcordes
{
    //Tela Músicas
    public partial class MusicaAdm : Form
    {
        //Variáveis
        HomepageAdm homepage;
        SobreNosAdm sobre;
        GerenCantor cantor;

        public MusicaAdm()
        {
            //Inicializando...
            InitializeComponent();
        }

        //Link de acesso à Tela Homepage
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Redirecionando para a tela Sobre Nós...
            homepage = new HomepageAdm();
            homepage.ShowDialog();

        }//Fim do Link de acesso à Tela Homepage

        //Link de acesso à Tela Sobre Nós
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Redirecionando para a tela Sobre Nós...
            sobre = new SobreNosAdm();
            sobre.ShowDialog();

        }//Link de acesso à Tela Sobre Nós

        //Link de acesso à Tela Cantor
        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Redirecionando para a tela de Cantor...
            cantor = new GerenCantor();
            cantor.ShowDialog();

        }//Fim do Link de acesso à Tela Cantor

    }//Fim da Tela Músicas
}//Fim do Projeto Entre Acordes