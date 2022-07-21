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
    public partial class fCadastroPessoa : Form
    {
        public fCadastroPessoa()
        {
            InitializeComponent();
        }

        private void cbTipoPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoPessoa.SelectedIndex == 0)
            {
                eCPF_CNPJ.Mask = "000.000.000-00";
                lbCPFCNPJ.Text = "CPF";
                lbNomeRazao.Text = "Nome";
                lbFazendaFantasia.Text = "Fazenda";
                lbRG_Inscricao.Text = "RG";
                lbOrgaoEmissor.Visible = true;
                eOrgaoEmissor.Visible = true;
            }
            else if (cbTipoPessoa.SelectedIndex == 1)
            {
                eCPF_CNPJ.Mask = "00.000.000/0000-00";
                lbCPFCNPJ.Text = "CNPJ";
                lbNomeRazao.Text = "Razão Social";
                lbFazendaFantasia.Text = "Fantasia";
                lbRG_Inscricao.Text = "Inscrição Estadual";
                lbOrgaoEmissor.Visible = false;
                eOrgaoEmissor.Visible = false;
            }
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Limpar()
        {
            eCPF_CNPJ.Clear();
            eDataCadastro.Clear();
            eFazendaFantasia.Clear();
            eInscricaoMunicipal.Clear();
            eNascimento.Clear();
            eNome.Clear();
            eOrgaoEmissor.Clear();
            eRG_Inscricao.Clear();
            cbTipoPessoa.Text = "";
            cbClassificacao.Text = "";
        }
        private void ControlaEditsFormulario(Boolean pEnabled)
        {
            eCodigo.Enabled = !pEnabled;
            eCPF_CNPJ.Enabled = pEnabled;
            eDataCadastro.Enabled = pEnabled;
            eFazendaFantasia.Enabled = pEnabled;
            eInscricaoMunicipal.Enabled = pEnabled;
            eNascimento.Enabled = pEnabled;
            eNome.Enabled = pEnabled;
            eOrgaoEmissor.Enabled = pEnabled;
            eRG_Inscricao.Enabled = pEnabled;
            cbTipoPessoa.Enabled = pEnabled;
            cbClassificacao.Enabled = pEnabled;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ControlaEditsFormulario(true);
            cbTipoPessoa.Focus();
        }
    }
}
