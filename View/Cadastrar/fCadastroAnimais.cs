using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RuralSimples.Classes;
using RuralSimples.Fontes_Comuns;
using RuralSimples.Model;

namespace RuralSimples.View
{
    public partial class fCadastroAnimais : Form
    {
        public object ValidacoesEContatos { get; private set; }

        public fCadastroAnimais()
        {
            InitializeComponent();
        }
        private void tpDataNascimento_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan Diferenca = DateTime.Now - DateTime.Parse(eDataNascimento.Text);
            int TotalDias = Diferenca.Days;
            int ano = (TotalDias / 365);
            int mes = (((TotalDias - (ano * 365)) / 30));
            if (ano >= 1)
                eIdade.Text = String.Format("{0}, {1} ano(s)", ano, mes);
            else
                eIdade.Text = String.Format("{0} meses", mes);
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

        }

        private void eDataDescarte_TextChanged(object sender, EventArgs e)
        {
            if ((eDataDescarte.Text != "") && (eDataDescarte.Text.Replace("/", "").Trim().Length == 8))
                Funcoes.ValidarDataMensagemErro(eDataDescarte, lbDataDescarte);
        }

        private void eCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((Keys)e.KeyChar == Keys.Enter || (Keys)e.KeyChar == Keys.Return) && (eCodigo.Text != ""))
            {
                int codigo = Funcoes.StringToInteger(eCodigo.Text);
                ControleBosTaurus controleBostaurus = new ControleBosTaurus();
                BosTaurus bostaurus = controleBostaurus.buscarBosTaurusIdBostaurus(codigo);
                if (bostaurus != null)
                {
                    PreencherBostaurus(bostaurus);
                }
                else
                {
                    Funcoes.MensagemErro(controleBostaurus.mensagem);
                }
            }
        }
        private void eIdentificacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((Keys)e.KeyChar == Keys.Enter || (Keys)e.KeyChar == Keys.Return) && (eCodigo.Text != ""))
            {
                ControleBosTaurus controleBostaurus = new ControleBosTaurus();
                BosTaurus bostaurus = controleBostaurus.buscarBosTaurusIdentificacaoAtivo(eCodigo.Text);
                if (bostaurus != null)
                {
                    PreencherBostaurus(bostaurus);
                }
                else
                {
                    Funcoes.MensagemErro(controleBostaurus.mensagem);
                }
            }
        }
        private void PreencherBostaurus(BosTaurus bostaurus)
        {
            ControlaEditsFormularios(true);
            ControlaBotoes(true);
            eAptidao.Text = bostaurus.Aptidao;
            eCodigoPropriedade.Text = Funcoes.NumeroPadrao(bostaurus.IDPessoa);
            eCodigo.Text = Funcoes.NumeroPadrao(bostaurus.IDBosTaurus);
            eIdentificacao.Text = bostaurus.Identificacao;
            eNumeroRegistro.Text = bostaurus.NumeroRegistro;
            SetSexo(bostaurus.Sexo);
            eDataCadastro.Text = bostaurus.DataCadastro.ToString();
            eNomeAnimal.Text = bostaurus.NomeAnimal;
            eRaca.Text = bostaurus.Raca;
            eDataNascimento.Text = bostaurus.DataNascimento.ToString();
            eIdade.Text = Funcoes.CalcularIdade(bostaurus.DataNascimento);
            eCodigoBosTaurusPai.Text = Funcoes.NumeroPadrao(bostaurus.IDBosTaurusPai);
            eNomePai.Text = bostaurus.NomePai;
            eCodigoBosTaurusMae.Text = Funcoes.NumeroPadrao(bostaurus.IDBosTaurusMae);
            eNomeMae.Text = bostaurus.NomeMae;
            
            SetInativo(bostaurus.Inativo);
            SetCiclo(bostaurus.Ciclo);
            SetCicloRepeodutivo(bostaurus.CicloReprodutivo);

            if (bostaurus.DataDescarte != new DateTime(1900, 1, 1, 0, 0, 0))
                eDataDescarte.Text = bostaurus.DataDescarte.ToString();
            eMotivoDescarte.Text = bostaurus.MotivoDescarte;
            eObservacoes.Text = bostaurus.Observacoes;

            //Clampos padrão, ocultados
            eClassificacaoOssea.Text = bostaurus.ClassificacaoOssea;
            eClassificacaoPatas.Text = bostaurus.ClassificacaoPatas;
            eGrupo.Text = bostaurus.Grupo;
            eTipoReproducao.Text = bostaurus.TipoReproducao;
            eNomeCientifico.Text = bostaurus.NomeCientifico;
            eFamilia.Text = bostaurus.Familia;
        }
        private void SetCiclo(String ciclo)
        {
            switch (ciclo)
            {
                case "A": cbCiclo.SelectedIndex = 0; break;
                case "B": cbCiclo.SelectedIndex = 1; break;
                case "C": cbCiclo.SelectedIndex = 2; break;
                case "E": cbCiclo.SelectedIndex = 3; break;
                case "R": cbCiclo.SelectedIndex = 4; break;

                default: cbCiclo.SelectedIndex = 2; break;
            }
        }
        private String GetCiclo()
        {
            switch (cbCiclo.SelectedItem)
            {
                case 0: return "A";
                case 1: return "B";
                case 2: return "C";
                case 3: return "E";
                case 4: return "R";

                default: return "C";
            } 
        }
        private void SetCicloRepeodutivo(String cicloReprodutivo)
        {
            switch (cicloReprodutivo)
            {
                case "M": cbCiclo.SelectedIndex = 0; break;
                case "N": cbCiclo.SelectedIndex = 1; break;
                case "P": cbCiclo.SelectedIndex = 2; break;
                case "S": cbCiclo.SelectedIndex = 3; break;

                default: cbCiclo.SelectedIndex = -1; break;
            }
        }
        private String GetCicloReprodutivo()
        {
            switch (cbCiclo.SelectedItem)
            {
                case 0: return "M";
                case 1: return "N";
                case 2: return "P";
                case 3: return "S";

                default: return "N";
            }
        }
        private void SetSexo(String sexo)
        {
            if (sexo == "F")
            {
                cbSexo.SelectedIndex = 0;//Fêmea
            }
            else
            {
                cbSexo.SelectedIndex = 1;//Macho
            }
        }
        private String GetSexo()
        {
            if (cbSexo.SelectedIndex == 0)
            {
                return "F";
            }
            else
            { 
               return "M";
            }
        }
        private void SetInativo(String inativo)
        {
            ckInativo.Checked = inativo == "S";
        }
        private String GetInativo()
        {
            if (ckInativo.Checked)
            {
                return "S";
            }
            else
            {
                return "N";
            }
        }

        private void ckInativo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckInativo.Checked)
            {
                eDataDescarte.Enabled = true;
                eMotivoDescarte.Enabled = true;
            }
            else
            {
                eDataDescarte.Enabled = false;
                eMotivoDescarte.Enabled = false;
            }
        }
        private void ControlaEditsFormularios(bool enabled)
        {
            eCodigo.Enabled = !enabled;
            eCodigoPropriedade.Enabled = enabled;

            eAptidao.Enabled = enabled;
            eCodigoBosTaurusMae.Enabled = enabled;
            eCodigoBosTaurusPai.Enabled = enabled;
            eDataCadastro.Enabled = enabled;
            eDataNascimento.Enabled = enabled;
            eIdade.Enabled = enabled;
            eNomeAnimal.Enabled = enabled;
            eNomeMae.Enabled = enabled;
            eNomePai.Enabled = enabled;
            eNumeroRegistro.Enabled = enabled;
            eObservacoes.Enabled = enabled;
            eRaca.Enabled = enabled;
            ckInativo.Enabled = enabled;
            
            btBuscarPropriedade.Enabled = enabled;
            btBuscarIdBostaurusPai.Enabled = enabled;
            btBuscarIdBostaurusMae.Enabled = enabled;

            cbCiclo.Enabled = enabled;
            cbCicloReprodutivo.Enabled = enabled;
            cbSexo.Enabled = enabled;
        }
        private void LimparTela()
        {
            eAptidao.Clear();
            eCodigo.Clear();
            eCodigoBosTaurusMae.Clear();
            eCodigoBosTaurusPai.Clear();
            eCodigoPropriedade.Clear();
            eDataCadastro.Clear();
            eDataDescarte.Clear();
            eDataNascimento.Clear();
            eIdade.Clear();
            eIdentificacao.Clear();
            eMotivoDescarte.Clear();
            eNomeAnimal.Clear();
            eNomeMae.Clear();
            eNomePai.Clear();
            eNomePropriedade.Clear();
            eNumeroRegistro.Clear();
            eObservacoes.Clear();
            eRaca.Clear();
            ckInativo.Checked = false;
            
            cbCiclo.SelectedIndex = -1;
            cbCicloReprodutivo.SelectedIndex = -1;
            cbSexo.SelectedIndex = -1;

            ControlaBotoes(false);
            ControlaEditsFormularios(false);
        }
        private void ControlaBotoes(bool enabled)
        {
            btNovo.Enabled = !enabled;
            btCancelar.Enabled = enabled;
            btSair.Enabled = !enabled;
            btSalvar.Enabled = enabled;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            if (Funcoes.MensagemQuestionar("Deseja cancelar a inserção/edição?"))
            {
                LimparTela();
            }
        }

        private void fCadastroAnimais_Shown(object sender, EventArgs e)
        {
            LimparTela();
        }
        private void btSair_Click(object sender, EventArgs e)
        {
            if (btSalvar.Enabled)
            {
                if (!Funcoes.MensagemQuestionar("Atenção, informações serão pedidas! Deseja sair?"))
                {
                    return;
                }
            }
            Close();
        }
        private void btNovo_Click(object sender, EventArgs e)
        {
            ControlaBotoes(true);
            ControlaEditsFormularios(true);
        }

        private bool VerificarCampos()
        {
            if (Funcoes.VerificarComboBoxSelecionado(cbSexo, lbSexo))
            {
                return false;
            }

            if (Funcoes.VerificarTextBoxVazio(eCodigoPropriedade, lbCodigoPropriedade))
            {
                return false;
            }

            return true;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            bool retorno;
            if (!Funcoes.MensagemQuestionar("Deseja salvar o cadastro de Pessoa?"))
            {
                return;
            }

            if (!VerificarCampos())
                return;

            ControleBosTaurus controleBostaurus = new ControleBosTaurus();
            DateTime dataDescarte;
            if (Funcoes.VerificarDataVazia(eDataDescarte))
                dataDescarte = Funcoes.StringToDateTime(eDataDescarte.Text);
            else
                dataDescarte = new DateTime(1900, 1, 1, 0, 0, 0);

            if (eCodigo.Text == "")
            {
                retorno = controleBostaurus.InserirBosTaurus(
                    Funcoes.StringToInteger(eCodigoPropriedade.Text.Trim()),
                    eRaca.Text.Trim(), 
                    eNomeAnimal.Text.Trim(),
                    eIdentificacao.Text.Trim(),
                    Funcoes.StringToDateTime(eDataNascimento.Text.Trim()), 
                    GetSexo(),
                    eAptidao.Text.Trim(),
                    Funcoes.StringToInteger(eCodigoBosTaurusPai.Text.Trim()),
                    Funcoes.StringToInteger(eCodigoBosTaurusMae.Text.Trim()), 
                    eNumeroRegistro.Text.Trim(),
                    eClassificacaoOssea.Text.Trim(), 
                    eClassificacaoPatas.Text.Trim(),
                    Funcoes.StringToDateTime(eDataCadastro.Text.Trim()),
                    eGrupo.Text.Trim(), 
                    eTipoReproducao.Text.Trim(), 
                    eNomeCientifico.Text.Trim(), 
                    eNomePai.Text.Trim(), 
                    eNomeMae.Text.Trim(),
                    eFamilia.Text.Trim(), 
                    GetInativo(), 
                    dataDescarte,
                    eMotivoDescarte.Text.Trim(), 
                    eObservacoes.Text.Trim(),
                    GetCiclo(),
                    GetCicloReprodutivo()
                );
            }
            else
            {
                retorno = controleBostaurus.SalvarBosTaurus(
                    Funcoes.StringToInteger(eCodigo.Text.Trim()),
                    Funcoes.StringToInteger(eCodigoPropriedade.Text.Trim()),
                    eRaca.Text.Trim(),
                    eNomeAnimal.Text.Trim(),
                    eIdentificacao.Text.Trim(),
                    Funcoes.StringToDateTime(eDataNascimento.Text.Trim()),
                    GetSexo(),
                    eAptidao.Text.Trim(),
                    Funcoes.StringToInteger(eCodigoBosTaurusPai.Text.Trim()),
                    Funcoes.StringToInteger(eCodigoBosTaurusMae.Text.Trim()),
                    eNumeroRegistro.Text.Trim(),
                    eClassificacaoOssea.Text.Trim(),
                    eClassificacaoPatas.Text.Trim(),
                    Funcoes.StringToDateTime(eDataCadastro.Text.Trim()),
                    eGrupo.Text.Trim(),
                    eTipoReproducao.Text.Trim(),
                    eNomeCientifico.Text.Trim(),
                    eNomePai.Text.Trim(),
                    eNomeMae.Text.Trim(),
                    eFamilia.Text.Trim(),
                    GetInativo(),
                    dataDescarte,
                    eMotivoDescarte.Text.Trim(),
                    eObservacoes.Text.Trim(),
                    GetCiclo(),
                    GetCicloReprodutivo()
                );
            }
            Funcoes.Mensagem(controleBostaurus.mensagem);
            if (retorno)
            {
                LimparTela();
            }
        }

        private void eIdentificacao_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (((Keys)e.KeyChar == Keys.Enter || (Keys)e.KeyChar == Keys.Return) && (eIdentificacao.Text != "") && (eCodigo.Text.Trim() == ""))
            {
                ControleBosTaurus controleBostaurus = new ControleBosTaurus();
                BosTaurus bostaurus = controleBostaurus.buscarBosTaurusIdentificacaoAtivo(eIdentificacao.Text);
                if (bostaurus != null)
                {
                    PreencherBostaurus(bostaurus);
                }
                else
                {
                    Funcoes.MensagemErro(controleBostaurus.mensagem);
                }
            }
        }

        private void cbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSexo.SelectedIndex == 0)
            {
                lbCicloReprodutivo.Visible = true;
                cbCicloReprodutivo.Visible = true;
            }
            else
            {
                lbCicloReprodutivo.Visible = false;
                cbCicloReprodutivo.Visible = false;
            }
        }

    }
}
