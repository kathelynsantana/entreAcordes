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
    //Tela Músicas
    public partial class Musicas : Form
    {
        //Variáveis
        Homepage home;
        Sobrenos sobre;
        musicaTetoVidro tetoVidro;

        public Musicas()
        {
            //Inicializando...
            InitializeComponent();
        }

        //Link de acesso à Tela de Homepage
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Redirecionando para a tela Homepage...
            home = new Homepage();
            home.ShowDialog();

        }//Fim do Link de acesso à Tela de Homepage

        //Link de acesso à Tela Sobre Nós
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Redirecionando para a tela Sobre Nós...
            sobre = new Sobrenos();
            sobre.ShowDialog();

        }//Fim do Link de acesso à Tela Sobre Nós

        //Botão Voltar
        private void button4_Click(object sender, EventArgs e)
        {
            //Fechando a aba...
            this.Close();

        }//Fim do Botão Voltar

        //Botão Ver Música (Teto de Vidro)
        private void button2_Click(object sender, EventArgs e)
        {
            //Redirecionando para a tela da Letra da Música...
            tetoVidro = new musicaTetoVidro();
            tetoVidro.ShowDialog();

        }//Fim do Botão Ver Música (Teto de Vidro)

    }//Fim da Tela Músicas
}//Fim do Projeto Entre Acordes