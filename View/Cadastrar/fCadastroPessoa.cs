﻿using RuralSimples.Classes;
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
using RuralSimples.Fontes_Comuns;

namespace RuralSimples.View
{
    public partial class fCadastroPessoa : Form
    {
        private bool inserindoEditando = false;
        private PropriedadePessoa editandoPropriedadePessoa = null;
        private bool adicionandoPropriedade = false;
        private bool excluindoPropriedade = false;
        public fCadastroPessoa()
        {
            InitializeComponent();
        }
        //Colunas da grid gdPropriedades
        const int cIDPropriedade = 0;
        const int cNomePropriedade = 1;
        const int cParticipacaoSocietaria = 2;
        const int cDataCadastroPropriedade = 3;
        const int cInativa = 4;
        const int cIDPropriedadePessoa = 5;
        private void ControlaEditsFormulario(Boolean pEnabled)
        {
            eIdentificacao.Enabled = !pEnabled;
            eCPF_CNPJ.Enabled = pEnabled;
            eDataCadastro.Enabled = pEnabled;
            eNomeFazendaNomeFantasia.Enabled = pEnabled;
            eInscricaoMunicipal.Enabled = pEnabled;
            eNascimento.Enabled = pEnabled;
            eNome.Enabled = pEnabled;
            eOrgaoEmissor.Enabled = pEnabled;
            eRG_Inscricao.Enabled = pEnabled;
            cbTipoPessoa.Enabled = pEnabled;
            cbClassificacao.Enabled = pEnabled;
            tabControl.Enabled = pEnabled;
            eUfOrgaoEmissor.Enabled = pEnabled;
            eCEI.Enabled = pEnabled;
            controlaButtonsFormulario(pEnabled);
        }
        private void controlaButtonsFormulario(bool pEnabled)
        {
            btNovo.Enabled = !pEnabled;
            inserindoEditando = pEnabled;
            btCancelar.Enabled = pEnabled;
            btLimpar.Enabled = pEnabled;
            btSalvar.Enabled = pEnabled;
            if (!pEnabled)
            {
                ckAcessoSistema.Checked = pEnabled;
                ckInativo.Checked = pEnabled;
            }
            ckAcessoSistema.Enabled = pEnabled;
            ckInativo.Enabled = pEnabled;
            if (ckAcessoSistema.Checked)
            {
                ckAcessoSistema_CheckedChanged(null, null);
            }
            if (btNovo.Enabled)
            {
                eIdentificacao.Focus();
            }
            else
            {
                cbTipoPessoa.Focus();
            }
        }
        private bool verificarCampos()
        {
            if (Funcoes.VerificarTextBoxVazio(eCPF_CNPJ, lbCPFCNPJ))
            {
                return false;
            }
            if (Funcoes.VerificarTextBoxVazio(eNascimento, lbDataNascimento))
            {
                return false;
            }
            if (Funcoes.VerificarTextBoxVazio(eNome, lbNomeRazao))
            {
                return false;
            }
            if (Funcoes.VerificarTextBoxVazio(eDataCadastro, lbDataCadastro))
            {
                return false;
            }
            if (ckAcessoSistema.Checked)
            {
                if (Funcoes.VerificarTextBoxVazio(eLogin, lbLogin))
                {
                    return false;
                }
                if (Funcoes.VerificarTextBoxVazio(eSenha, lbSenha))
                {
                    return false;
                }
            }
            if (Funcoes.VerificarComboBoxSelecionado(cbClassificacao, lbClassificacao))
            {
                return false;
            }
            if (Funcoes.VerificarComboBoxSelecionado(cbTipoPessoa, lbTipoPessoa))
            {
                return false;
            }

            return true;
        }
        private void cbTipoPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            telaCPFCNPJ();
        }
        private void btSair_Click(object sender, EventArgs e)
        {
            if (inserindoEditando)
            {
                if (!Funcoes.MensagemQuestionar("As informações não foram inseridas/salvas e serão perdidas, deseja sair?"))
                {
                    return;
                }
            }
            Close();
        }
        private void btNovo_Click(object sender, EventArgs e)
        {
            eIdentificacao.Clear();
            ControlaEditsFormulario(true);
            eDataCadastro.Text = DateTime.Now.ToString();
            cbTipoPessoa.SelectedIndex = 0;
            cbClassificacao.SelectedIndex = 0;
            cbTipoPessoa.Focus();
        }
        private void btLimpar_Click(object sender, EventArgs e)
        {
            if (Funcoes.MensagemQuestionar("Deseja cancelar/limpar?"))
            {
                limparTela();
            }
        }
        private void limparTela()
        {
            eCPF_CNPJ.Clear();
            eDataCadastro.Clear();
            eNomeFazendaNomeFantasia.Clear();
            eIdentificacao.Clear();
            eInscricaoMunicipal.Clear();
            eNascimento.Clear();
            eNome.Clear();
            eOrgaoEmissor.Clear();
            eRG_Inscricao.Clear();
            eLogin.Clear();
            eSenha.Clear();
            cbTipoPessoa.SelectedIndex = -1;
            cbClassificacao.SelectedIndex = -1;
            eObservacoes.Clear();
            eUfOrgaoEmissor.Clear();
            eCEI.Clear();
            //Endereco
            eIdEndereco.Clear();
            eLogradouro.Clear();
            eNumero.Clear();
            eComplemento.Clear();
            eBairro.Clear();
            eCidade.Clear();
            eUfCidade.Clear();
            eCep.Clear();
            eIbge.Clear();
            eGia.Clear();
            eSiafi.Clear();
            eDdd.Clear();
            tabControl.SelectedIndex = 0;
            //Contato
            ControlaEditsFormulario(false);
        }
        private void btSalvar_Click(object sender, EventArgs e)
        {
            bool retorno;
            if (!Funcoes.MensagemQuestionar("Deseja salvar o cadastro de Pessoa?"))
            {
                return;
            }

            if (!verificarCampos())
                return;

            String cpf = "", cnpj = "", rg = "", inscricao_estadual = "", nome_fazenda = "", nome_fantasia = "";

            if (ehPessoaFisica(getTipoPessoa()))
            {
                cpf = eCPF_CNPJ.Text;
                rg = eRG_Inscricao.Text;
                nome_fazenda = eNomeFazendaNomeFantasia.Text;
            }
            else
            {
                cnpj = eCPF_CNPJ.Text;
                inscricao_estadual = eRG_Inscricao.Text;
                nome_fantasia = eNomeFazendaNomeFantasia.Text;
            }

            ControlePessoas controlePessoa = new ControlePessoas();

            if (eIdentificacao.Text == "")
            {
                retorno = controlePessoa.inserirPessoaEnderecoContato(
                    eNome.Text,
                    getcbClassificacaoString(),
                    getDateTime(eNascimento.Text),
                    getDateTime(eDataCadastro.Text),
                    getTipoPessoa(),
                    cpf,
                    cnpj,
                    rg,
                    inscricao_estadual,
                    eInscricaoMunicipal.Text,
                    nome_fantasia,
                    nome_fazenda,
                    eOrgaoEmissor.Text,
                    eLogin.Text,
                    eSenha.Text,
                    getckAcessoSistemaString(),
                    getckInativoString(),
                    eObservacoes.Text,
                    eUfOrgaoEmissor.Text,
                    eCEI.Text,
                    //Endereco
                    eCep.Text,
                    eLogradouro.Text,
                    eNumero.Text,
                    eComplemento.Text,
                    eBairro.Text,
                    eCidade.Text,
                    eUfCidade.Text,
                    Funcoes.StringToInteger(eIbge.Text),
                    Funcoes.StringToInteger(eGia.Text),
                    Funcoes.StringToInteger(eSiafi.Text),
                    Funcoes.StringToInteger(eDdd.Text),
                    //Contatos
                    eTelefoneFixo.Text,
                    eCelular.Text,
                    eFacebook.Text,
                    eTwiter.Text,
                    eNomeRecado.Text,
                    eInstagram.Text,
                    eTelefoneRecado.Text,
                    eSite.Text,
                    eEmail.Text,
                    eTiktok.Text,
                    getckWhatsAppString(),
                    eYoutube.Text
                );
            }
            else
            {
                retorno = controlePessoa.salvarPessoaEnderecoContato(
                    Funcoes.StringToInteger(eIdentificacao.Text),
                    eNome.Text,
                    getcbClassificacaoString(),
                    getDateTime(eNascimento.Text),
                    getDateTime(eDataCadastro.Text),
                    getTipoPessoa(),
                    cpf,
                    cnpj,
                    rg,
                    inscricao_estadual,
                    eInscricaoMunicipal.Text,
                    nome_fantasia,
                    nome_fazenda,
                    eOrgaoEmissor.Text,
                    eLogin.Text,
                    eSenha.Text,
                    getckAcessoSistemaString(),
                    getckInativoString(),
                    eObservacoes.Text,
                    eUfOrgaoEmissor.Text,
                    eCEI.Text,
                    //Endereco
                    Funcoes.StringToInteger(eIdEndereco.Text),
                    eCep.Text,
                    eLogradouro.Text,
                    eNumero.Text,
                    eComplemento.Text,
                    eBairro.Text,
                    eCidade.Text,
                    eUfCidade.Text,
                    Funcoes.StringToInteger(eIbge.Text),
                    Funcoes.StringToInteger(eGia.Text),
                    Funcoes.StringToInteger(eSiafi.Text),
                    Funcoes.StringToInteger(eDdd.Text),
                    //Contatos
                    Funcoes.StringToInteger(eIdContato.Text),
                    eTelefoneFixo.Text,
                    eCelular.Text,
                    eFacebook.Text,
                    eTwiter.Text,
                    eNomeRecado.Text,
                    eInstagram.Text,
                    eTelefoneRecado.Text,
                    eSite.Text,
                    eEmail.Text,
                    eTiktok.Text,
                    getckWhatsAppString(),
                    eYoutube.Text
                );
            }
            Funcoes.Mensagem(controlePessoa.mensagem);
            if (retorno)
            {
                limparTela();
            }
        }
        private void fCadastroPessoa_Shown(object sender, EventArgs e)
        {
            ControlaEditsFormulario(false);
            this.dgPropriedades.Columns[cIDPropriedadePessoa].Visible = false;
        }
        private void ckAcessoSistema_CheckedChanged(object sender, EventArgs e)
        {
            if (ckAcessoSistema.Checked)
            {
                eLogin.Enabled = true;
            }
            else
            {
                eLogin.Enabled = false;
            }
            eSenha.Enabled = eLogin.Enabled;
        }
        private String getcbClassificacaoString()
        {
            String valor = "";
            switch (cbClassificacao.SelectedIndex)
            {
                case 0: valor = "C"; break; //Cliente
                case 1: valor = "F"; break;//Fornecedor
                case 2: valor = "Z"; break;//Funcionário
                case 3: valor = "O"; break;//Outros
                case 4: valor = "P"; break;//Parceiro
                case 5: valor = "A"; break;//Propriedade
                case 6: valor = "S"; break;//Sócio
            }
            return valor;
        }
        private void setcbClassificacao(String valor)
        {
            switch (valor)
            {
                case "C": cbClassificacao.SelectedIndex = 0; break; //Cliente
                case "F": cbClassificacao.SelectedIndex = 1; break;//Fornecedor
                case "Z": cbClassificacao.SelectedIndex = 2; break;//Funcionário
                case "O": cbClassificacao.SelectedIndex = 3; break;//Outros
                case "P": cbClassificacao.SelectedIndex = 4; break;//Parceiro
                case "A": cbClassificacao.SelectedIndex = 5; break;//Propriedade
                case "S": cbClassificacao.SelectedIndex = 6; break;//Sócio
            }
        }
        private string getckInativoString()
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
        private void setckInativo(String valor)
        {
            if (valor == "S")
            {
                ckInativo.Checked = true;
            }
            else
            {
                ckInativo.Checked = false;
            }
        }
        private string getckWhatsAppString()
        {
            if (ckWhatsApp.Checked)
            {
                return "S";
            }
            else
            {
                return "N";
            }
        }
        private void setckWhatsAppString(String valor)
        {
            if (valor == "S")
            {
                ckWhatsApp.Checked = true;
            }
            else
            {
                ckWhatsApp.Checked = false;
            }
        }

        private string getckAcessoSistemaString()
        {
            if (ckAcessoSistema.Checked)
            {
                return "S";
            }
            else
            {
                return "N";
            }
        }
        private void setckAcessoSistema(String valor)
        {
            if (valor == "S")
            {
                ckAcessoSistema.Checked = true;
            }
            else
            {
                ckAcessoSistema.Checked = false;
            }
        }
        private DateTime getDateTime(String data)
        {
            try
            {
                return Convert.ToDateTime(data);
            }
            catch (Exception)
            {
                return Convert.ToDateTime("01/01/1900");
            }
        }
        private void setDateTime(MaskedTextBox objeto, String valor)
        {
            objeto.Text = valor;
        }
        private void setDateTime(MaskedTextBox objeto, DateTime valor)
        {
            objeto.Text = valor.ToString();
        }
        private String getTipoPessoa()
        {
            if (cbTipoPessoa.SelectedIndex == 0)
            {
                return "F";
            }
            else
            {
                return "J";
            }
        }
        private void setTipoPessoa(String valor)
        {
            if (valor == "F")
            {
                cbTipoPessoa.SelectedIndex = 0;
            }
            else
            {
                cbTipoPessoa.SelectedIndex = 1;
            }
        }
        private void telaCPFCNPJ()
        {
            if (cbTipoPessoa.SelectedIndex == 0)
            {
                eCPF_CNPJ.Mask = "000,000,000-00";
                lbCPFCNPJ.Text = "CPF";
                lbNomeRazao.Text = "Nome";
                lbFazendaFantasia.Text = "Fazenda";
                lbRG_Inscricao.Text = "RG";
                lbOrgaoEmissor.Visible = true;
                eOrgaoEmissor.Visible = true;
                lbUfEmissor.Visible = true;
                eUfOrgaoEmissor.Visible = true;
                lbCEI.Visible = true;
                eCEI.Visible = true;
            }
            else if (cbTipoPessoa.SelectedIndex == 1)
            {
                eCPF_CNPJ.Mask = "00,000,000/0000-00";
                lbCPFCNPJ.Text = "CNPJ";
                lbNomeRazao.Text = "Razão Social";
                lbFazendaFantasia.Text = "Fantasia";
                lbRG_Inscricao.Text = "Inscrição Estadual";
                lbOrgaoEmissor.Visible = false;
                eOrgaoEmissor.Visible = false;
                lbUfEmissor.Visible = false;
                eUfOrgaoEmissor.Visible = false;
                lbCEI.Visible = false;
                eCEI.Visible = false;
            }
        }
        private void preencherPessoa(Pessoa pessoa)
        {
            if (ehPessoaFisica(pessoa.TipoPessoa))
            {
                eCPF_CNPJ.Text = pessoa.CPF;
                eRG_Inscricao.Text = pessoa.RG;
            }
            else
            {
                eCPF_CNPJ.Text = pessoa.CNPJ;
                eRG_Inscricao.Text = pessoa.InscricaoEstadual;
            }

            eDataCadastro.Text = pessoa.DataCadastro.ToString();
            eNomeFazendaNomeFantasia.Text = pessoa.NomeFantasia;
            eIdentificacao.Text = pessoa.IDPessoa.ToString();
            eInscricaoMunicipal.Text = pessoa.InscricaoMunicipal;
            eNascimento.Text = pessoa.DataNascimentoFundacao.ToString();
            eNome.Text = pessoa.NomeRazaoSocial;
            eOrgaoEmissor.Text = pessoa.OrgaoExpedidor;
            eObservacoes.Text = pessoa.Observacoes;
            eCEI.Text = pessoa.CEI;
            eUfOrgaoEmissor.Text = pessoa.UfOrgaoExpedidor;
            setTipoPessoa(pessoa.TipoPessoa);
            setcbClassificacao(pessoa.Classificacao);
            setckInativo(pessoa.Inativo);
            setckAcessoSistema(pessoa.AcessoSistema);
            if (ckAcessoSistema.Checked)
            {
                eLogin.Text = pessoa.Login;
                eSenha.Text = pessoa.Senha;
            }
        }
        private void preencherEndereco(Endereco endereco)
        {
            eLogradouro.Text = endereco.Logradouro;
            eNumero.Text = endereco.Numero;
            eComplemento.Text = endereco.Complemento;
            eBairro.Text = endereco.Bairro;
            eCidade.Text = endereco.Cidade;
            eUfCidade.Text = endereco.UF;
            eCep.Text = endereco.CEP;
            eIdEndereco.Text = endereco.IDEndereco.ToString();
            eIbge.Text = endereco.IBGE.ToString();
            eGia.Text = endereco.Gia.ToString();
            eSiafi.Text = endereco.Siafi.ToString();
            eDdd.Text = endereco.DDD.ToString();
        }
        private void preencherContato(Contato contato)
        {
            eIdContato.Text = contato.IDContato.ToString();
            eTelefoneFixo.Text = contato.TelefoneFixo;
            eCelular.Text = contato.Celular;
            eEmail.Text = contato.Email;
            eTelefoneRecado.Text = contato.TelefoneRecado;
            eNomeRecado.Text = contato.NomePessoaRecado;
            eFacebook.Text = contato.Facebook;
            eTwiter.Text = contato.Twiter;
            eInstagram.Text = contato.Instagram;
            eSite.Text = contato.Site;
            eTiktok.Text = contato.TikTok;
            eYoutube.Text = contato.Youtube;
        }
        private bool ehPessoaFisica(String valor)
        {
            return (valor == "F");
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            btLimpar_Click(sender, e);
        }

        private void btBuscarIdPessoa_Click(object sender, EventArgs e)
        {
            String codigo;
            fBuscarPessoa buscarPessoa = new fBuscarPessoa();
            buscarPessoa.ShowDialog();
            codigo = buscarPessoa.codigo;
            if (codigo != "0")
            {
                KeyPressEventArgs press = new KeyPressEventArgs((char)Keys.Enter);
                eIdentificacao.Text = codigo;
                eIdentificacao_KeyPress(eIdentificacao, press);
            }
        }

        private void eIdentificacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((Keys)e.KeyChar == Keys.Enter || (Keys)e.KeyChar == Keys.Return) && (eIdentificacao.Text != ""))
            {
                int codigo = Funcoes.StringToInteger(eIdentificacao.Text);
                ControlePessoas controlePessoa = new ControlePessoas();
                Pessoa pessoa = controlePessoa.buscarPessoaIdentificacao(codigo);
                if (pessoa != null)
                {
                    ControleEnderecos controleEndereco = new ControleEnderecos();
                    ControleContatos controleContatos = new ControleContatos();
                    Endereco endereco = controleEndereco.buscarEnderecoPessoaPorID(codigo);
                    Contato contato = controleContatos.buscarContatoPessoaID(codigo);

                    ControlaEditsFormulario(true);
                    preencherPessoa(pessoa);
                    preencherContato(contato);
                    preencherEndereco(endereco);
                    AtualizarGridPropriedades();
                }
                else
                {
                    Funcoes.MensagemErro(controlePessoa.mensagem);
                }
            }
        }

        private void btBuscarPropriedade_Click(object sender, EventArgs e)
        {
            String codigo;
            fBuscarPropriedades buscarPropriedade = new fBuscarPropriedades();
            buscarPropriedade.ShowDialog();
            codigo = buscarPropriedade.codigo;
            if (codigo != "")
            {
                KeyPressEventArgs press = new KeyPressEventArgs((char)Keys.Enter);
                eCodigoPropriedade.Text = codigo;
                eCodigoPropriedade_KeyPress(eCodigoPropriedade, press);
                adicionandoPropriedade = true;
                eParticipacaoSocietaria.Focus();
            }
        }
        private void eCodigoPropriedade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
            if (((Keys)e.KeyChar == Keys.Enter || (Keys)e.KeyChar == Keys.Return) && (eCodigoPropriedade.Text != ""))
            {
                int codigo = Funcoes.StringToInteger(eCodigoPropriedade.Text);
                ControlePropriedade controlePropriedade = new ControlePropriedade();
                Propriedade propriedade = controlePropriedade.BuscarPropriedade(codigo);
                if (propriedade == null)
                {
                    Funcoes.MensagemErro(controlePropriedade.mensagem);
                    return;
                }
                lbPropriedade.Text = propriedade.NomePropriedade;
                eParticipacaoSocietaria.Focus();
                btCancelarEdicaoPropriedade.Visible = true;
            }
        }
        private void btAdicionarPropriedade_Click(object sender, EventArgs e)
        {
            if (!excluindoPropriedade)
            {
                if (Funcoes.VerificarTextBoxVazio(eCodigoPropriedade, lbCodigoPropriedade))
                    return;

                if (Funcoes.VerificarTextBoxVazio(eParticipacaoSocietaria, lbParticipacao))
                    return;

                if (Funcoes.VerificarTextBoxVazio(eIdentificacao, lbIDPessoa))
                    return;

                if (VerificarPropriedadeNaGrid(eCodigoPropriedade.Text.Trim(), eParticipacaoSocietaria.Text.Trim()))
                {
                    Funcoes.MensagemErro("A propriedade já foi adicionada, se for edição, favor alterar a porcentagem ou cancele a edição!");
                    return;
                }
            }

            ControlePropriedadePessoa controlePropriedadePessoa = new ControlePropriedadePessoa();
            PropriedadePessoa propriedadePessoa = null;
            bool retorno;
            if (editandoPropriedadePessoa == null)
            {
                propriedadePessoa = new PropriedadePessoa();
                propriedadePessoa.PreencherClasse(
                    Funcoes.StringToInteger(eIdentificacao.Text),
                    Funcoes.StringToInteger(eCodigoPropriedade.Text),
                    Funcoes.StringToDouble(eParticipacaoSocietaria.Text),
                    lbPropriedade.Text,
                    "N"
                );
                retorno = controlePropriedadePessoa.InserirPropriedadePessoa(propriedadePessoa);
            }
            else
            {
                editandoPropriedadePessoa.ParticipacaoSocietaria = Funcoes.StringToDouble(eParticipacaoSocietaria.Text);
                propriedadePessoa = editandoPropriedadePessoa;
                retorno = controlePropriedadePessoa.SalvarPropriedadePessoa(propriedadePessoa);
            }  
            
            if (retorno)
            {
                LimparEdicaoPropriedade();
                AtualizarGridPropriedades();
            }

            Funcoes.MensagemErro(controlePropriedadePessoa.mensagem);
        }
        private void AdicionarPropriedadesGrid(List<PropriedadePessoa> propriedadesPessoas)
        {
            LimpaGridPropriedades();
            int cont = 0;
            if (propriedadesPessoas != null)
            {
                foreach (PropriedadePessoa propriedadePessoa in propriedadesPessoas)
                {
                    InserirLinhaGridPropriedade(cont, propriedadePessoa);
                    cont++;
                }
            }
        }
        private void LimpaGridPropriedades()
        {
            dgPropriedades.Rows.Clear();
            dgPropriedades.Refresh();
        }
        private void InserirLinhaGridPropriedade(int cont, PropriedadePessoa propriedadePessoa)
        {
            /*if (cont == 0)
            {
                dgPropriedades.Rows[cont].Cells[cIDPropriedade].Value = Funcoes.NumeroPadrao(propriedadePessoa.IDPropriedade);
                dgPropriedades.Rows[cont].Cells[cNomePropriedade].Value = propriedadePessoa.NomePropriedade;
                dgPropriedades.Rows[cont].Cells[cParticipacaoSocietaria].Value = Funcoes.NumeroPadrao(propriedadePessoa.ParticipacaoSocietaria, 2) + "%";
                dgPropriedades.Rows[cont].Cells[cDataCadastroPropriedade].Value = Funcoes.DateTimeToStringDate(propriedadePessoa.DataAquisicao),
                dgPropriedades.Rows[cont].Cells[cIDPropriedadePessoa].Value = Funcoes.NumeroPadrao(propriedadePessoa.IDPropriedadePessoa)
            }
            else
            {*/
            dgPropriedades.Rows.Add(
                    Funcoes.NumeroPadrao(propriedadePessoa.IDPropriedade),
                    propriedadePessoa.NomePropriedade,
                    Funcoes.NumeroPadrao(propriedadePessoa.ParticipacaoSocietaria, 2),
                    Funcoes.DateTimeToStringDate(propriedadePessoa.DataAquisicao),
                    propriedadePessoa.Inativo == "S" ? "Sim":"Não",
                    propriedadePessoa.IDPropriedadePessoa.ToString()
                );
            //}
        }

        private void eParticipacaoSocietaria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                MessageBox.Show("este campo aceita somente numero e virgula");
                return;
            }
            if (char.IsControl(e.KeyChar) && eParticipacaoSocietaria.Text.Trim() != "")
            {
                if (Funcoes.StringToDouble(eParticipacaoSocietaria.Text) == 0)
                {
                    Funcoes.MensagemErro("A participação societária tem que ser maior que 0 (zero)!");
                    eParticipacaoSocietaria.Clear();
                    eParticipacaoSocietaria.Focus();
                    return;
                }
                btAdicionarPropriedade.Focus();
            }
        }
        private bool VerificarPropriedadeNaGrid(string codigo, string porcentagem)
        {
            bool retorno = false;

            for (int i = 0; i < dgPropriedades.RowCount - 1; i++)
            {
                if ((dgPropriedades.Rows[i].Cells[cIDPropriedade].Value.ToString() == codigo) && 
                    (dgPropriedades.Rows[i].Cells[cParticipacaoSocietaria].Value.ToString() == Funcoes.NumeroPadrao(porcentagem, 2)))
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        private void dgPropriedades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (adicionandoPropriedade)
            {
                if (Funcoes.MensagemQuestionar("Há uma propriedade a ser adicionada, deseja cancelar?") == false)
                {
                    return;
                }
            }
            eCodigoPropriedade.Text = dgPropriedades.CurrentRow.Cells[cIDPropriedade].Value.ToString();
            lbPropriedade.Text = dgPropriedades.CurrentRow.Cells[cNomePropriedade].Value.ToString();
            eParticipacaoSocietaria.Text = dgPropriedades.CurrentRow.Cells[cParticipacaoSocietaria].Value.ToString();
            
            btCancelarEdicaoPropriedade.Visible = true;
            btInativarPropriedade.Visible = true;

            btAdicionarPropriedade.Text = "Salvar";
            editandoPropriedadePessoa = new PropriedadePessoa(
                Funcoes.StringToInteger(dgPropriedades.CurrentRow.Cells[cIDPropriedadePessoa].Value.ToString()),
                Funcoes.StringToInteger(eIdentificacao.Text),
                Funcoes.StringToInteger(dgPropriedades.CurrentRow.Cells[cIDPropriedade].Value.ToString()),
                Funcoes.StringToDouble(dgPropriedades.CurrentRow.Cells[cParticipacaoSocietaria].Value.ToString()),
                dgPropriedades.CurrentRow.Cells[cNomePropriedade].Value.ToString(),
                Funcoes.StringToDateTime(dgPropriedades.CurrentRow.Cells[cDataCadastroPropriedade].Value.ToString()),
                "N"
            );
        }
        private void LimparEdicaoPropriedade()
        {
            editandoPropriedadePessoa = null;
            eCodigoPropriedade.Clear();
            lbPropriedade.Text = "Propriedade";
            eParticipacaoSocietaria.Clear();
            btInativarPropriedade.Visible = false;
            btCancelarEdicaoPropriedade.Visible = false;
        }

        private void btCancelarEdicaoPropriedade_Click(object sender, EventArgs e)
        {
            LimparEdicaoPropriedade();
        }

        private void btInativarPropriedade_Click(object sender, EventArgs e)
        {
            if (Funcoes.MensagemQuestionar(
                "Deseja excluir a propriedade " + dgPropriedades.CurrentRow.Cells[cNomePropriedade].Value.ToString() +
                " do cadastro " + eNome.Text) == true)
            {
                editandoPropriedadePessoa.Inativo = "S";
                excluindoPropriedade = true;
                btAdicionarPropriedade_Click(sender, e);
                AtualizarGridPropriedades();
            }
            LimparEdicaoPropriedade();
        }
        private void AtualizarGridPropriedades()
        {
            ControlePropriedadePessoa controlePropriedade = new ControlePropriedadePessoa();
            List<PropriedadePessoa> propriedadesPessoas =
                controlePropriedade.BuscarPropriedadesPessoaAtivas(Funcoes.StringToInteger(eIdentificacao.Text));
            AdicionarPropriedadesGrid(propriedadesPessoas);
        }
    }
}
