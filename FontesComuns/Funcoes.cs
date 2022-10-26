using RuralSimples.FontesComuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuralSimples.Fontes_Comuns
{
    class Funcoes
    {
        public static bool ValidarStringInteiro(TextBox objeto, Label campo)
        {
            if (!VerificarTextBoxVazio(objeto, campo))
                return false;

            if (!StringEhInteiro(StringApenasNumeros(objeto.Text)))
            {
                MensagemErro(String.Format("Valor inválido para o campo {0}", campo.Text));
                return false;
            }

            return true;
        }
        public static bool ValidarStringDouble(TextBox objeto, Label campo)
        {
            if (!VerificarTextBoxVazio(objeto, campo))
                return false;

            if (!StringEhDouble(StringApenasNumeros(objeto.Text)))
            {
                MensagemErro(String.Format("Valor inválido para o campo {0}", campo.Text));
                return false;
            }

            return true;
        }
        public static string StringApenasNumeros(string str)
        {
            var apenasDigitos = new Regex(@"[^\d]");
            return apenasDigitos.Replace(str, "");
        }
        public static bool StringEhInteiro(string str)
        {
            try
            {
                Convert.ToInt32(str);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool StringEhDouble(String str)
        {
            try
            {
                Convert.ToDouble(str);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static void ValidarDataMensagemErro(MaskedTextBox objeto, Label campo)
        {
            if (!ValidarData(objeto, campo))
            {
                MensagemErro(String.Format("Data Inválida! Favor preencher {0} corretamente!", campo.Text));
                objeto.Focus();
            }
        }
        public static Boolean ValidarData(MaskedTextBox objeto, Label campo)
        {
            Boolean retorno = false;

            if (!VerificarTextBoxVazio(objeto, campo))
                return retorno;

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

        public static Boolean VerificarTextBoxVazio(TextBox objeto, Label campo)
        {
            if (objeto.Text.Trim() == "")
            {
                MensagemErro(String.Format("O campo {0} não pode ficar vazio!", campo.Text));
                objeto.Focus();
                return true;
            }
            else
                return false;
        }
        public static Boolean VerificarTextBoxVazio(MaskedTextBox objeto, Label campo)
        {
            objeto.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            String value = objeto.Text;
            objeto.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            if (value.Trim() == "")
            {
                MensagemErro(String.Format("O campo {0} não pode ficar vazio!", campo.Text));
                objeto.Focus();
                return true;
            }

            return false;
        }
        public static bool VerificarComboBoxSelecionado(ComboBox objeto, Label campo)
        {
            if (objeto.SelectedIndex == -1)
            {
                MensagemErro(String.Format("Favor selecionar o {0}", campo.Text));
                objeto.Focus();
                return true;
            }
            return false;
        }
        public static Boolean ValidarDouble(TextBox objeto, Label campo)
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
                MensagemErro(String.Format("Favor inserir um número válido no campo {0}!", campo.Text));
                objeto.Focus();
                return false;
            }
        }
        public static void MensagemErro(string mensagem)
        {
            MessageBox.Show(mensagem, Constantes.cMensagemErro, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static Boolean MensagemQuestionar(string mensagem)
        {
            var retorno = (MessageBox.Show(mensagem, Constantes.cMensagemQuestionamento, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
            return retorno;
        }
        public static void Mensagem(string mensagem)
        {
            MessageBox.Show(mensagem, Constantes.cTituloPrincipal, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public static Double stringToDouble(String valor)
        {
            if (valor == "")
            {
                return 0;
            }
            try
            {
                return Convert.ToDouble(valor);
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public static String NumeroPadrao(String valor)
        {
            return NumeroPadrao(valor, 0);
        }
        public static String NumeroPadrao(String valor, int casasDecimais)
        {
            try
            {
                Double val = Convert.ToDouble(valor);
                String casas = "N" + casasDecimais.ToString();
                return val.ToString(casas);
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static String NumeroPadrao(Double valor)
        {
            return NumeroPadrao(valor, 0);
        }
        public static String NumeroPadrao(Double valor, int casasDecimais)
        {
            String casas = "N" + casasDecimais.ToString();
            return valor.ToString(casas); //String.Format("{0}", Math.Round(valor, casasDecimais));
        }
        public static DateTime StringToDateTime(String data)
        {
            if ((data == null) || (data == ""))
                return new DateTime(1900, 1, 1, 0, 0, 0);
            try
            {
                return Convert.ToDateTime(data);
            }
            catch (Exception e)
            {
                Funcoes.MensagemErro("Erro ao converter data! " + e.Message);
                return new DateTime(1900, 1, 1, 0, 0, 0);
            }
        }
        public static String DateTimeToStringDate(DateTime data)
        {
            return data.ToString("dd/MM/yyyy");
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
            DateTime data1 = Funcoes.StringToDateTime(data);
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
