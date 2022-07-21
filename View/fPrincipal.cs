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
            fCadastroPessoa cadastropessoa = new fCadastroPessoa();
            cadastropessoa.Show();
        }

        private void pessoasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fCadastroPessoa cadastropessoa = new fCadastroPessoa();
            cadastropessoa.Show();
        }

        private void pbCadastroPessoas_Click(object sender, EventArgs e)
        {
            fCadastroPessoa cadastropessoa = new fCadastroPessoa();
            cadastropessoa.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
