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
    //Tela "Sobre Nós"
    public partial class Sobrenos : Form
    {
        //Variáveis
        CadastrarIns cadIns;
        Homepage home;
        Musicas musc;

        public Sobrenos()
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

        //Botão de Voltar
        private void button2_Click(object sender, EventArgs e)
        {
            //Fechando a aba...
            this.Close();

        }//Fim do Botão de Voltar

        //Link de acesso à Tela de Homepage
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Redirecionando para a tela Homepage...
            home = new Homepage();
            home.ShowDialog();

        }//Fim do Link de acesso à Tela de Homepage

        //Link de acesso à Tela de Músicas
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            musc = new Musicas();
            musc.ShowDialog();

        }//Fim do Link de acesso à Tela de Músicas

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }//Fim da Tela "Sobre Nós"
}//Fim do Projeto Entre Acordes
