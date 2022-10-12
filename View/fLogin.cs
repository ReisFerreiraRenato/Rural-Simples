using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Npgsql;
using RuralSimples.Model;
using RuralSimples.Fontes_Comuns;
using RuralSimples.FontesComuns;

namespace RuralSimples.View
{
    public partial class fLogin : Form
    {
        Thread principal;

        public fLogin()
        {
            InitializeComponent();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
           
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            tbSenha.Clear();
            tbUsuario.Clear();
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            if (Funcoes.VerificarTextBoxVazio(tbUsuario, lbLogin))
                return;

            if (Funcoes.VerificarTextBoxVazio(tbSenha, lbSenha))
                return;
            
            ControleLogin controle = new ControleLogin();
            controle.Acessar(tbUsuario.Text, tbSenha.Text);
            
            if (!controle.tem)
            {
                Funcoes.MensagemErro("Usuário não encontrado, verifique login e senha!");
                tbUsuario.Focus();
            }
            
            this.Close();
            principal = new Thread(novoForm);
            principal.SetApartmentState(ApartmentState.STA);
            principal.Start();
        }

        private void novoForm()
        {
            Application.Run(new fPrincipal());
        }

        private void fLogin_Shown(object sender, EventArgs e)
        {
            lbNomeSoftware.Text = Constantes.cNomeSoftware;
            lbNomeEmpresa.Text = Constantes.cNomeEmpresa;
            tbUsuario.Focus();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }

        private void btCadastre_Click(object sender, EventArgs e)
        {
            fCadastreSe cadastrese = new fCadastreSe();
            cadastrese.Show();
        }

        private void fLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
    }
}
