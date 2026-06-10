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
    //Tela Homepage
    public partial class Homepage : Form
    {
        //Variáveis
        CadastrarIns cadIns;
        Sobrenos sobre;
        Musicas musc;
        musicaTetoVidro tetoVidro;

        public Homepage()
        {
            //Inicializando...
            InitializeComponent();
        }

        //Botão para acessar a Tela de Cadastro do Inscrito
        private void button1_Click(object sender, EventArgs e)
        {
            //Redirecionando para a Área de Cadastro do Inscrito...
            cadIns = new CadastrarIns();
            cadIns.ShowDialog();

        }//Fim do Botão para acessar a Tela de Cadastro do Inscrito

        //Link de acesso à Tela Sobre Nós
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Redirecionando para a tela Sobre Nós...
            sobre = new Sobrenos();
            sobre.ShowDialog();

        }//Fim do Link de acesso à Tela Sobre Nós

        //Link de acesso à Tela de Músicas
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Redirecionando para a tela de Música...
            musc = new Musicas();
            musc.ShowDialog();

        }//Fim do Link de acesso à Tela de Músicas

        //Botão Ver Música (Teto de Vidro)
        private void button2_Click(object sender, EventArgs e)
        {
            //Redirecionando para a tela da Letra da Música...
            tetoVidro = new musicaTetoVidro();
            tetoVidro.ShowDialog();

        }//Fim do Botão Ver Música (Teto de Vidro)
        
    }//Fim da Tela Homepage
}//Fim do Projeto Entre Acordes