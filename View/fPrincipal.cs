using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RuralSimples.View;
using RuralSimples.Fontes_Comuns;

namespace RuralSimples
{
    public partial class fPrincipal : Form
    {
        public fPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fReproducao reproducao = new fReproducao();
            reproducao.Show();
        }

        private void pbCadastroPessoas_Click(object sender, EventArgs e)
        {
            fCadastroPessoa cadastropessoa = new fCadastroPessoa();
            cadastropessoa.Text = ValidacoesEConstantes.cTituloCadastroPessoas;
            cadastropessoa.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbCadastroAnimais_Click(object sender, EventArgs e)
        {
            fCadastroAnimais cadastroanimais = new fCadastroAnimais();
            cadastroanimais.Text = ValidacoesEConstantes.cTituloCadastroAnimais;
            cadastroanimais.Show();
        }

        private void pbReproducao_Click(object sender, EventArgs e)
        {
            fReproducao reproducao = new fReproducao();
            reproducao.Text = ValidacoesEConstantes.cTituloReproducao;
            reproducao.Show();
        }
    }
}
