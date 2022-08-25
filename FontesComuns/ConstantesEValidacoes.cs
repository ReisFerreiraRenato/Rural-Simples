using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuralSimples.Fontes_Comuns
{
    class ValidacoesEConstantes
    {
        public const string cTituloPrincipal = "Rural Simples";
        public const string cTituloCadastroPessoas = "Cadastro Pessoas - " + cTituloPrincipal;
        public const string cTituloReproducao = "Reprodução - " + cTituloPrincipal;
        public const string cTituloCadastroAnimais = "Cadastro Animais - " + cTituloPrincipal;
        private const string cMensagemErro = cTituloPrincipal + " - Erro!";
        private const string cMensagemQuestionamento = cTituloPrincipal + " - Questionamento!";
        public static void ValidarDataMensagemErro(MaskedTextBox objeto)
        {
            if (!ValidarData(objeto))
            {
                MensagemErro("Data Inválida! Favor preencher corretamente!");
                objeto.Focus();
            }
        }
        public static Boolean ValidarData(MaskedTextBox objeto)
        {
            Boolean retorno = false;
            if ((objeto.Text != "") && (objeto.Text.Replace("/", "").Trim().Length == 8))
            {
                try
                {
                    DateTime.Parse(objeto.Text);
                    retorno = true;
                }
                catch
                {
                    //
                }
            }
            return retorno;
        }
        public static Boolean VerificarTextBoxVazio(TextBox objeto, string campo)
        {
            if (objeto.Text.Trim() == "")
            {
                MensagemErro(String.Format("O campo {0} não pode ficar vazio!", campo));
                objeto.Focus();
                return false;
            }
            else
                return true;
        }
        public static Boolean ValidarDouble(TextBox objeto, string campo)
        {
            if (!VerificarTextBoxVazio(objeto, campo))
                return false;
            double num;
            try
            {
                double.TryParse(objeto.Text, out num);
                return true;
            }
            catch
            {
                MensagemErro(String.Format("Favor inserir um número válido no campo {0}!", campo));
                objeto.Focus();
                return false;
            }
        }
        public static void MensagemErro(string mensagem)
        {
            MessageBox.Show(String.Format(mensagem, cMensagemErro, MessageBoxButtons.OK, MessageBoxIcon.Error));
        }
        public static Boolean MensagemQuestionar(string mensagem)
        {
            return MessageBox.Show(mensagem, cMensagemQuestionamento, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
    }
}
