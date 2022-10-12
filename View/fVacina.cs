using RuralSimples.Classes;
using RuralSimples.Fontes_Comuns;
using RuralSimples.Model;
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
    public partial class fVacina : Form
    {
        //Colunas da Grid gdVacina
        private const int cDataCadastro = 0;
        private const int cDataVacina = 1;
        private const int cNomeVacina = 2;
        private const int cDosagem = 3;
        private const int cIDVacinacao = 4;
        private const int cIDAnimal = 5;

        private Vacinacao vacinaEditando;
        private int idAnimal;
        private string identificacaoAnimal;

        public fVacina()
        {
            InitializeComponent();
        }

        private void ckTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (ckTodos.Checked)
            {
                ckData.Checked = true;
                ckDosagem.Checked = true;
                ckNomeVacina.Checked = true;
                ckIdentificacao.Checked = true;
                ckCodigo.Checked = true;
            }
            else
            {
                ckData.Checked = false;
                ckDosagem.Checked = false;
                ckNomeVacina.Checked = false;
                ckIdentificacao.Checked = false;
                ckCodigo.Checked = false;
            }
        }

        private void eCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((Keys)e.KeyChar == Keys.Enter || (Keys)e.KeyChar == Keys.Return) && (eCodigo.Text != ""))
            {
                int codigo = Funcoes.stringToInteger(eCodigo.Text);
                ControleBosTaurus controleBostaurus = new ControleBosTaurus();
                BosTaurus bostaurus = controleBostaurus.buscarBosTaurusIdBostaurus(codigo);
                if (bostaurus != null)
                {
                    ControleVacinacao controleVacinacao = new ControleVacinacao();
                    
                    List<Vacinacao> listaVacinacao = controleVacinacao.BuscarVacinacoes(codigo);
                    lbNomeAnimal.Text = bostaurus.NomeAnimal;
                    eIdentificacao.Text = bostaurus.Identificacao;
                    idAnimal = bostaurus.IDBosTaurus;
                    identificacaoAnimal = bostaurus.Identificacao;
                    InserirDadosGridVacinacao(listaVacinacao);
                }
                else
                {
                    Funcoes.MensagemErro(controleBostaurus.mensagem);
                }
            }
        }

        private void eIdentificacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((Keys)e.KeyChar == Keys.Enter || (Keys)e.KeyChar == Keys.Return) && (eIdentificacao.Text != ""))
            {
                ControleBosTaurus controleBostaurus = new ControleBosTaurus();
                BosTaurus bostaurus = controleBostaurus.buscarBosTaurusIdentificacaoAtivo(eIdentificacao.Text);
                if (bostaurus != null)
                {
                    ControleVacinacao controleVacinacao = new ControleVacinacao();
                    List<Vacinacao> listaVacinacao = controleVacinacao.BuscarVacinacoes(bostaurus.IDBosTaurus);
                    lbNomeAnimal.Text = bostaurus.NomeAnimal;
                    eCodigo.Text = Funcoes.NumeroPadrao(bostaurus.IDBosTaurus);
                    idAnimal = bostaurus.IDBosTaurus;
                    identificacaoAnimal = bostaurus.Identificacao;
                    InserirDadosGridVacinacao(listaVacinacao);
                }
                else
                {
                    Funcoes.MensagemErro(controleBostaurus.mensagem);
                }
            }
        }

        private void fVacina_Shown(object sender, EventArgs e)
        {
            //Ocultando as colunas
            this.dgVacina.Columns[cIDVacinacao].Visible = false;
            this.dgVacina.Columns[cIDAnimal].Visible = false;
            lbNomeAnimal.Text = "";
            eIdentificacao.Focus();
        }

        private void btAdicionarVacina_Click(object sender, EventArgs e)
        {
            bool retorno;

            if (idAnimal == 0)
                return;

            if (Funcoes.stringToInteger(eCodigo.Text) != idAnimal)
            {
                if (Funcoes.MensagemQuestionar(String.Format("Você alterou o código do animal e não buscou o cadastro, " +
                        "a vacinação será feita no animal anterior (código {0}) que foi buscado no cadastro!" + "Deseja continuar?", idAnimal)) == false)
                    return;
            }

            if (!identificacaoAnimal.Equals(eIdentificacao.Text))
            {
                if (Funcoes.MensagemQuestionar(String.Format("Você alterou a identificação do animal e não buscou o cadastro, " +
                        "a vacinação será feita no animal anterior (identificação {0}) que foi buscado no cadastro!" + "Deseja continuar?", idAnimal)) == false)
                    return;
            }

            if (!VerificarCampos())
                return;

            ControleVacinacao controleVacinacao = new ControleVacinacao();
            if (vacinaEditando != null)
            {
                retorno = controleVacinacao.SalvarVacinacao(vacinaEditando);
                if (!retorno)
                {
                    Funcoes.MensagemErro(controleVacinacao.mensagem);
                    eDataVacina.Focus();
                    return;
                }
            }
            else
            {
                Vacinacao vacinacao = new Vacinacao(
                    idAnimal,
                    eNomeVacina.Text,
                    Funcoes.StringToDateTime(eDataVacina.Text),
                    DateTime.Now,
                    Funcoes.stringToDouble(Funcoes.StringApenasNumeros(eDosagem.Text))
                );
                retorno = controleVacinacao.InserirVacinacao(vacinacao);
                if (!retorno)
                {
                    Funcoes.MensagemErro(controleVacinacao.mensagem);
                    eDataVacina.Focus();
                    return;
                }
                InserirLinhaGrid(dgVacina.Rows.Count, vacinacao);
            }
            LimparTodosEdits();
            eIdentificacao.Focus();
        }
        private bool VerificarCampos()
        {
            if (Funcoes.ValidarData(eDataVacina, lbDataVacina))
                return false;

            if (Funcoes.VerificarTextBoxVazio(eNomeVacina, lbNomeVacina))
                return false;

            if (Funcoes.VerificarTextBoxVazio(eDosagem, lbDosagem))
                return false;

            if (Funcoes.ValidarStringInteiro(eDosagem, lbDosagem))
                return false;

            return true;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            vacinaEditando = null;
            LimparEditsVacina(true);
            btAdicionarVacina.Text = "Adicionar";
            btCancelar.Visible = false;
        }
        private void LimparTodosEdits(bool valor = false)
        {
            if (!ckCodigo.Checked || valor)
            {
                eCodigo.Clear();
                if (!ckIdentificacao.Checked)
                    lbNomeAnimal.Text = "";
            }
            if (!ckIdentificacao.Checked || valor)
            {
                eIdentificacao.Clear();
                if (!ckCodigo.Checked)
                    lbNomeAnimal.Text = "";
            }
            LimparEditsVacina();
        }
        private void LimparEditsVacina(bool valor = false)
        {
            if (!ckData.Checked || valor)
                eDataVacina.Clear();
            if (!ckNomeVacina.Checked || valor)
                eNomeVacina.Clear();
            if (!ckDosagem.Checked || valor)
                eDosagem.Clear();
        }
        private void InserirDadosGridVacinacao(List<Vacinacao> listaVacinacao)
        {
            LimparGrid();
            int cont = 0;
            if (listaVacinacao != null)
            {
                foreach (Vacinacao vacina in listaVacinacao)
                {
                    InserirLinhaGrid(cont, vacina);
                    cont++;
                }
            }
        }
        private void InserirLinhaGrid(int cont, Vacinacao vacinacao)
        {
            if (cont == 1)
            {
                dgVacina.Rows[cont].Cells[cDataCadastro].Value = Funcoes.DateTimeToStringDate(vacinacao.DataCadastro);
                dgVacina.Rows[cont].Cells[cDataVacina].Value = Funcoes.DateTimeToStringDate(vacinacao.DataVacinacao);
                dgVacina.Rows[cont].Cells[cNomeVacina].Value = vacinacao.NomeVacina;
                dgVacina.Rows[cont].Cells[cDosagem].Value = vacinacao.Dosagem.ToString() + " ml";
                dgVacina.Rows[cont].Cells[cIDVacinacao].Value = vacinacao.IDVacinacao;
                dgVacina.Rows[cont].Cells[cIDAnimal].Value = vacinacao.IDAnimal;
            }
            else
            {
                dgVacina.Rows.Add(
                    Funcoes.DateTimeToStringDate(vacinacao.DataCadastro),
                    Funcoes.DateTimeToStringDate(vacinacao.DataVacinacao),
                    vacinacao.NomeVacina,
                    vacinacao.Dosagem.ToString() + " ml",
                    //Colunas ocultas
                    vacinacao.IDVacinacao,
                    vacinacao.IDAnimal
                );
            }
        }
        private void LimparGrid()
        {
            dgVacina.Rows.Clear();
            dgVacina.Refresh();
        }

        private void dgVacina_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            vacinaEditando = new Vacinacao(
                Funcoes.stringToInteger(dgVacina.CurrentRow.Cells[cIDAnimal].Value.ToString()),
                dgVacina.CurrentRow.Cells[cNomeVacina].Value.ToString(),
                Funcoes.StringToDateTime(dgVacina.CurrentRow.Cells[cDataVacina].Value.ToString()),
                Funcoes.StringToDateTime(dgVacina.CurrentRow.Cells[cDataCadastro].Value.ToString()),
                Funcoes.stringToDouble(Funcoes.StringApenasNumeros(dgVacina.CurrentRow.Cells[cDosagem].Value.ToString()))
            );
            eDataVacina.Text = Funcoes.DateTimeToStringDate(vacinaEditando.DataVacinacao);
            eNomeVacina.Text = vacinaEditando.NomeVacina;
            eDosagem.Text = Funcoes.NumeroPadrao(vacinaEditando.Dosagem);
            btAdicionarVacina.Text = "Salvar";
            btCancelar.Visible = true;
        }
    }
}
