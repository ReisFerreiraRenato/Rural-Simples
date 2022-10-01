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
        public const string cMensagemErro = cTituloPrincipal + " - Erro!";
        public const string cMensagemQuestionamento = cTituloPrincipal + " - Questionamento!";
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
        public static Boolean VerificarDataVazia(MaskedTextBox objeto)
        {
            if ((objeto.Text != "") && (objeto.Text.Replace("/", "").Trim().Length == 8))
                return true;
            else
                return false;
        }

        public static Boolean VerificarTextBoxVazio(TextBox objeto, string campo)
        {
            if (objeto.Text.Trim() == "")
            {
                MensagemErro(String.Format("O campo {0} não pode ficar vazio!", campo));
                objeto.Focus();
                return true;
            }
            else
                return false;
        }
        public static Boolean VerificarTextBoxVazio(MaskedTextBox objeto, string campo)
        {
            objeto.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            String value = objeto.Text;
            objeto.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            if (value.Trim() == "")
            {
                MensagemErro(String.Format("O campo {0} não pode ficar vazio!", campo));
                objeto.Focus();
                return true;
            }

            return false;
        }
        public static bool VerificarComboBoxSelecionado(ComboBox objeto, string campo)
        {
            if (objeto.SelectedIndex == -1)
            {
                MensagemErro(String.Format("Favor selecionar o {0}", campo));
                objeto.Focus();
                return true;
            }
            return false;
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
            MessageBox.Show(mensagem, cMensagemErro, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static Boolean MensagemQuestionar(string mensagem)
        {
            return MessageBox.Show(mensagem, cMensagemQuestionamento, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }
        public static void Mensagem(string mensagem)
        {
            MessageBox.Show(mensagem, cTituloPrincipal, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static int stringToInteger(String valor)
        {
            if (valor == "")
            { 
                return 0;
            }
            try
            {
                return Convert.ToInt32(valor);
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public static String NumeroPadrao(String valor, int casasDecimais = 0)
        {
            try
            {
                Double val = Convert.ToDouble(valor);
                return String.Format("{0}", Math.Round(val, casasDecimais));
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static String NumeroPadrao(Double valor, int casasDecimais = 0)
        {
            return String.Format("{0}", Math.Round(valor, casasDecimais));
        }
        public static DateTime StringToDateTime(String data)
        {
            try
            {
                return Convert.ToDateTime(data);
            }
            catch (Exception e)
            {
                ValidacoesEConstantes.MensagemErro("Erro ao converter data! " + e.Message);
                return new DateTime(1900, 1, 1, 0, 0, 0);
            }
        }
        public static String CalcularIdade(DateTime data)
        {
            DateTime dataAtual = DateTime.Now;
            int anos = new DateTime(DateTime.Now.Subtract(data).Ticks).Year - 1;
            DateTime anosTranscorridos = data.AddYears(anos);
            int meses = 0;
            for (int i = 1; i <= 12; i++)
            {
                if (anosTranscorridos.AddMonths(i) == dataAtual)
                {
                    meses = i;
                    break;
                }
                else if (anosTranscorridos.AddMonths(i) >= dataAtual)
                {
                    meses = i - 1;
                    break;
                }
            }
            return String.Format("{0} anos, {1} meses", anos, meses);
        }
        public static String CalcularIdade(String data)
        {
            DateTime data1 = ValidacoesEConstantes.StringToDateTime(data);
            if (data1 != new DateTime(1900, 1, 1, 0, 0, 0))
            {
                return CalcularIdade(data1);
            }
            else
            {
                return "";
            }
        }
    }
}
