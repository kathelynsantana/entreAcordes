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
        SobreNosAdm sobreNos;
        MusicaAdm musica;

        public HomepageAdm()
        {
            //Inicializando...
            InitializeComponent();
        }

        //Link de acesso à Tela Sobre Nós
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sobreNos = new SobreNosAdm();
            sobreNos.ShowDialog();

        }//Fim do Link de acesso à Tela Sobre Nós

        //Link de acesso à Tela de Músicas
        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            musica = new MusicaAdm();
            musica.ShowDialog();

        }//Fim do Link de acesso à Tela de Músicas
    }//Fim da Tela Homepage (ADM)
}//Fim do Projeto Entre Acordes