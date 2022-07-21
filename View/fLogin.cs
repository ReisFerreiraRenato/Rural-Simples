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
            Application.Exit();
            this.Close();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            tbSenha.Clear();
            tbUsuario.Clear();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (tbUsuario.Text == "")
            {
                MessageBox.Show("O campo Usuário não pode ficar vazio!");
                tbUsuario.Focus();
            }
            else if (tbSenha.Text == "")
            {
                MessageBox.Show("O campo Usuário não pode ficar vazio!");
                tbSenha.Focus();
            }
            else
            {
                if ((tbUsuario.Text == "ADM") && (tbSenha.Text == "123"))
                {
                    this.Close();
                    principal = new Thread(novoForm);
                    principal.SetApartmentState(ApartmentState.STA);
                    principal.Start();
                }
                else
                {
                    MessageBox.Show("Login inválido!");
                    tbUsuario.Focus();
                }
            }
        }

        private void novoForm()
        {
            Application.Run(new fPrincipal());
        }

        private void fLogin_Shown(object sender, EventArgs e)
        {
            tbUsuario.Text = "ADM";
            tbSenha.Text = "123";
            btOK.Focus();
        }
    }
}
