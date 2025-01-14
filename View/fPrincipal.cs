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
using Npgsql;
using RuralSimples.Model;
using RuralSimples.FontesComuns;

namespace RuralSimples
{
    public partial class fPrincipal : Form
    {
        public fPrincipal()
        {
            InitializeComponent();
        }
        private void pbCadastroPessoas_Click(object sender, EventArgs e)
        {
            fCadastroPessoa cadastropessoa = new fCadastroPessoa();
            cadastropessoa.Text = Constantes.cTituloCadastroPessoas;
            cadastropessoa.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbCadastroAnimais_Click(object sender, EventArgs e)
        {
            fCadastroAnimais cadastroanimais = new fCadastroAnimais();
            cadastroanimais.Text = Constantes.cTituloCadastroAnimais;
            cadastroanimais.ShowDialog();
        }

        private void pbReproducao_Click(object sender, EventArgs e)
        {
            fReproducao reproducao = new fReproducao();
            reproducao.Text = Constantes.cTituloReproducao;
            reproducao.ShowDialog();
        }

        private void vacinacaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fVacina vacina = new fVacina();
            vacina.Text = Constantes.cTituloReproducao;
            vacina.ShowDialog();
        }

        private void vermifugacaoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fVermifugacao vermifugacao = new fVermifugacao();
            vermifugacao.Text = Constantes.cTituloReproducao;
            vermifugacao.ShowDialog();
        }
    }
}
