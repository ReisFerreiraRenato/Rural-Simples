using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RuralSimples.Fontes_Comuns;

namespace RuralSimples.View
{
    public partial class fCadastroAnimais : Form
    {
        public fCadastroAnimais()
        {
            InitializeComponent();
        }
        private void tpDataNascimento_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan Diferenca =  DateTime.Now - DateTime.Parse(eDataNascimento.Text);
            int TotalDias = Diferenca.Days;
            int ano = (TotalDias / 365);
            int mes = (((TotalDias - (ano * 365)) / 30));
            if (ano >= 1)
                eIdade.Text = String.Format("{0}, {1} ano(s)", ano, mes);
            else
                eIdade.Text = String.Format("{0} meses", mes);
        }

        private void btAdicionarPesagem_Click(object sender, EventArgs e)
        {
            if (!ValidacoesEConstantes.ValidarDouble(ePeso, "Peso"))
            {
                return;
            }
        }

        private void eDataNascimento_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan diferenca = DateTime.Now - DateTime.Parse(eDataNascimento.Text);
            int totaldias = diferenca.Days;
            int ano = (totaldias / 365);
            int mes = (((totaldias - (ano * 365)) / 30));
            if (ano >= 1)
                eIdade.Text = String.Format("{0} ano(s), {1} mês(es)", ano, mes);
            else
                eIdade.Text = String.Format("{0} mês(es)", mes);
        }

        private void eDataNascimento_TextChanged(object sender, EventArgs e)
        {
            ValidacoesEConstantes.ValidarDataMensagemErro(eDataNascimento);
        }

        private void eDataDescarte_TextChanged(object sender, EventArgs e)
        {
            ValidacoesEConstantes.ValidarDataMensagemErro(eDataDescarte);
        }

        private void eDataVacina_TextChanged(object sender, EventArgs e)
        {
            ValidacoesEConstantes.ValidarDataMensagemErro(eDataVacina);
        }

        private void eDataVermifugacao_TextChanged(object sender, EventArgs e)
        {
            ValidacoesEConstantes.ValidarDataMensagemErro(eDataVermifugacao);
        }
    }
}
