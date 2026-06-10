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
    //Tela Cantor
    public partial class GerenCantor : Form
    {
        //Variáveis
        HomepageAdm homepage;
        SobreNosAdm sobre;
        MusicaAdm musica;
        CadastarCan cadCan;

        public GerenCantor()
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

        }//Fim do Link de acesso à Tela Sobre Nós

        //Link de acesso à Tela Música
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Redirecionando para a tela de Música...
            musica = new MusicaAdm();
            musica.ShowDialog();

        }//Fim do Link de acesso à Tela Música

        //Botão para acessar a Tela de Cadastro do Cantor
        private void button2_Click(object sender, EventArgs e)
        {
            //Redirecionando para a Área de Cadastro do Inscrito...
            cadCan = new CadastarCan();
            cadCan.ShowDialog();

        }//Fim do Botão para acessar a Tela de Cadastro do Cantor
    }//Fim da Tela Cantor
}//Fim do Projeto Entre Acordes