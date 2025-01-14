using RuralSimples.Fontes_Comuns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuralSimples.View
{
    public partial class fCadastreSe : Form
    {
        public fCadastreSe()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            if (Funcoes.VerificarTextBoxVazio(eLogin, lbLogin))
               return;

            if (Funcoes.VerificarTextBoxVazio(eSenha, lbSenha))
                return;

            if (Funcoes.VerificarTextBoxVazio(eConfirmarSenha, lbConfirmarSenha))
                return;

            if (Funcoes.VerificarTextBoxVazio(eEmail, lbEmail))
                return;

            if (!VerificarConfirmacaoSenha())
            {
                Funcoes.MensagemErro("Confirmação de senha diferente da senha!");
                eConfirmarSenha.Focus();
                return;
            }

            Funcoes.Mensagem("Você receberá uma mensagem no e-mail para concluir o cadastro!");
            this.Close();
        }

        private bool VerificarConfirmacaoSenha()
        {
            if (eSenha.Text.Equals(eConfirmarSenha.Text))
                return true;
            else
                return false;
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
