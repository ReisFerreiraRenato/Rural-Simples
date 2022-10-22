using Npgsql;
using RuralSimples.Model;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RuralSimples.Classes
{
    class Pessoa
    {

        private int FIDPessoa;
        private string FAcessoSistema; //S - Sim; N - Não
        private string FCei;
        private string FCpf;
        private string FCnpj;
        private string FClassificacao; //A - Propriedade - C - CLiente;  F - Fornecedor; P - Parceiro; O - Outro; S - Sócio; Z - Funcionario
        private DateTime FDataNascimentoFundacao;
        private DateTime FDataCadastro;
        private string FInscricaoEstadual;
        private string FInscricaoMunicipal;
        private string FLogin;
        private string FNomeRazaoSocial;
        private string FNomeFantasia;
        private string FOrgaoExpedidor;
        private string FNomeFazenda;
        private string FRG;
        private string FSenha;
        private string FTipoPessoa; //Pessoa Física ou Jurídica (F ou J)
        private string FInativo;
        private string FMensagemSalvarAtualizar;
        private string FUfOrgaoExpedidor;
        private string FObservacoes;
        private bool FEstaVazio;

        public Pessoa()
        {
            PeencherClasse(0, "", "", new DateTime(1900, 1, 1, 1, 0, 0), DateTime.Today, "",
                "", "", "", "", "", "", "", "",
                "", "", "", "", "", "", "", true);
        }
        public Pessoa(int idPessoa, String nomerazaosocial, string classificacao, DateTime dataNascimentoFundacao, DateTime dataCadastro, string tipo, 
                string cpf, string cnpj, string rg, String inscricaoestadual, String inscricaomunicipal, String nomeFantasia, String nomeFazenda, string orgaoExpedidor,
                string login, string senha, string acessosistema, string inativo, string observacoes, String ufOrgaoExpedidor, String cei)
        {
            PeencherClasse(idPessoa, nomerazaosocial, classificacao, dataNascimentoFundacao, dataCadastro, tipo, cpf, cnpj, rg, inscricaoestadual, inscricaomunicipal,
                nomeFantasia, nomeFazenda, orgaoExpedidor, login, senha, acessosistema, inativo, observacoes, ufOrgaoExpedidor, cei, false);
        }
        public Pessoa(String nomerazaosocial, string classificacao, DateTime dataNascimentoFundacao, DateTime dataCadastro, string tipo,
                string cpf, string cnpj, string rg, String inscricaoestadual, String inscricaomunicipal, String nomeFantasia, String nomeFazenda, string orgaoExpedidor,
                string login, string senha, string acessosistema, string inativo, string observacoes, String ufOrgaoExpedidor, String cei)
        {
            PeencherClasse(0, nomerazaosocial, classificacao, dataNascimentoFundacao, dataCadastro, tipo, cpf, cnpj, rg, inscricaoestadual, inscricaomunicipal,
                nomeFantasia, nomeFazenda, orgaoExpedidor, login, senha, acessosistema, inativo, observacoes, ufOrgaoExpedidor, cei, false);
        }

        public void PeencherClasse(int idPessoa, String nomerazaosocial, String classificacao, DateTime datanascimentofundacao, DateTime datacadastro, String tipoPessoa, 
                String cpf, String cnpj, String rg, String inscricaoestadual, String inscricaomunicipal, String nomeFantasia, String nomeFazenda, String orgaoExpedidor, 
                String login, String senha, String acessosistema, String inativo, String observacoes, String ufOrgaoExpedidor, String cei, bool estaVazio)
        {
            this.IDPessoa = idPessoa;
            this.AcessoSistema = acessosistema;
            this.Inativo = inativo;
            this.CEI = cei;
            this.CPF = cpf;
            this.CNPJ = cnpj;
            this.Classificacao = classificacao;
            this.DataNascimentoFundacao = datanascimentofundacao;
            this.DataCadastro = datacadastro;
            this.DataCadastro = datacadastro;
            this.NomeFantasia = nomeFantasia;
            this.NomeFazenda = nomeFazenda;
            this.InscricaoEstadual = inscricaoestadual;
            this.InscricaoMunicipal = inscricaomunicipal;
            this.Login = login;
            this.NomeRazaoSocial = nomerazaosocial;
            this.Observacoes = observacoes;
            this.OrgaoExpedidor = orgaoExpedidor;
            this.RG = rg;
            this.UfOrgaoExpedidor = ufOrgaoExpedidor;
            this.Senha = senha;
            this.TipoPessoa = tipoPessoa;
            this.EstaVazio = estaVazio;
        }
        public Boolean Salvar()
        {
            ControlePessoas controlePessoa = new ControlePessoas();
            bool retorno;
            //retorno OK
            if (this.IDPessoa != 0)
                retorno = controlePessoa.salvar(this);                
            else
                retorno = controlePessoa.inserir(this);
            MensagemSalvarAtualizar = controlePessoa.mensagem;
            return retorno;
        }
        public Boolean Salvar(int idPessoa, String nomerazaosocial, string classificacao, DateTime dataNascimentoFundacao, DateTime dataCadastro, string tipo, string cpf,
                string cnpj, string rg, String inscricaoestadual, String inscricaomunicipal, string fantasia, String fazenda, string orgaoemissor,
                string login, string senha, string acessosistema, string inativo, string observacoes, String cei, String ufOrgaoExpedidor)
        {
            PeencherClasse(idPessoa, nomerazaosocial, classificacao, dataNascimentoFundacao, dataCadastro, tipo, cpf, cnpj, rg, inscricaoestadual, inscricaomunicipal,
                fantasia, fazenda, orgaoemissor, login, senha, acessosistema, inativo, observacoes, ufOrgaoExpedidor, cei, false);
            return Salvar();
        }
        public int IDPessoa
        {
            get { return FIDPessoa; }
            set { FIDPessoa = value; }
        }
        public string AcessoSistema
        {
            get { return FAcessoSistema; }
            set { FAcessoSistema = value; }
        }
        public string Inativo
        {
            get { return FInativo; }
            set { FInativo = value; }
        }
        public string CEI
        {
            get { return FCei; }
            set { FCei = value; }
        }
        public string CPF
        {
            get { return FCpf; }
            set { FCpf = value; }
        }
        public string CNPJ
        {
            get { return FCnpj; }
            set { FCnpj = value; }
        }
        public string Classificacao
        {
            get { return FClassificacao; }
            set { FClassificacao = value; }
        }
        public DateTime DataCadastro
        {
            get { return FDataCadastro; }
            set { FDataCadastro = value; }
        }
        public DateTime DataNascimentoFundacao
        {
            get { return FDataNascimentoFundacao; }
            set { FDataNascimentoFundacao = value; }
        }
        public string NomeFantasia
        {
            get { return FNomeFantasia; }
            set { FNomeFantasia = value; }
        }
        public string NomeFazenda
        {
            get { return FNomeFazenda; }
            set { FNomeFazenda = value; }
        }
        public string Login
        {
            get { return FLogin; }
            set { FLogin = value; }
        }
        public string NomeRazaoSocial
        {
            get { return FNomeRazaoSocial; }
            set { FNomeRazaoSocial = value; }
        }        
        public string OrgaoExpedidor
        {
            get { return FOrgaoExpedidor; }
            set { FOrgaoExpedidor = value; }
        }
        public string RG
        {
            get { return FRG; }
            set { FRG = value; }
        }
        public string Senha
        {
            get { return FSenha; }
            set { FSenha = value; }
        }
        public string TipoPessoa
        {
            get { return FTipoPessoa; }
            set { FTipoPessoa = value; }
        }
        public string InscricaoEstadual
        {
            get { return FInscricaoEstadual; }
            set { FInscricaoEstadual = value; }
        }
        public string InscricaoMunicipal
        {
            get { return FInscricaoMunicipal; }
            set { FInscricaoMunicipal = value; }
        }
        public String MensagemSalvarAtualizar
        {
            get { return FMensagemSalvarAtualizar; }
            set { FMensagemSalvarAtualizar = value; }
        }
        public String UfOrgaoExpedidor
        {
            get { return FUfOrgaoExpedidor; }
            set { FUfOrgaoExpedidor = value; }
        }
        public String Observacoes
        {
            get { return FObservacoes; }
            set { FObservacoes = value; }
        }
        public bool EstaVazio
        {
            get { return FEstaVazio; }
            set { FEstaVazio = value; }
        }
    }
}
