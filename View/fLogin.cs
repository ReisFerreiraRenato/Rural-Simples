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
            if (!ValidacoesEConstantes.VerificarTextBoxVazio(tbUsuario, "Login"))
            {
                if (!ValidacoesEConstantes.VerificarTextBoxVazio(tbSenha, "Senha"))
                 {
                    ControleLogin controle = new ControleLogin();
                    controle.acessar(tbUsuario.Text, tbSenha.Text);
                    if (controle.tem)
                    {
                        this.Close();
                        principal = new Thread(novoForm);
                        principal.SetApartmentState(ApartmentState.STA);
                        principal.Start();
                    }
                    else
                    {
                        MessageBox.Show("Usuário não encontrado, verifique login e senha!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tbUsuario.Focus();
                    }
                }
            }
        }

        private void novoForm()
        {
            Application.Run(new fPrincipal());
        }

        private void fLogin_Shown(object sender, EventArgs e)
        {
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
    }
}
