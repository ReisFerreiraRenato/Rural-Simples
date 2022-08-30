using Npgsql;
using RuralSimples.Model;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RuralSimples.Classes
{
    class Pessoa
    {

        private string FID;
        private string FAcessoSistema; //S - Sim; N - Não
        private string FCFPCNPJ;
        private char FClassificacao; //A - Propriedade - C - CLiente;  F - Fornecedor; P - Parceiro; O - Outro; S - Sócio; Z - Funcionario
        private DateTime FDataNascimentoFundacao;
        private DateTime FDataCadastro;
        private string FInscricaoEstadual;
        private string FInscricaoMunicipal;
        private string FLogin;
        private string FNomeRazaoSocial;
        private string FOrgaoEmissor;
        private string FFantasiaFazenda;
        private string FRG;
        private string FSenha;
        private char FTipo; //Pessoa Física ou Jurídica (F ou J)
        private Endereco FEndereco;
        private Contatos FContatos;

        public Pessoa()
        {
            Guid g = new Guid();
            ID = g.ToString();
            AcessoSistema = "N";
            CFPCNPJ = "";
            Classificacao = 'C';
            Contatos = new Contatos();
            DataNascimentoFundacao = new DateTime(1900, 1, 1, 1, 0, 0);
            DataCadastro = DateTime.Today;
            FantasiaFazenda = "";
            InscricaoEstadual = "";
            InscricaoMunicipal = "";
            Login = "";
            NomeRazaoSocial = "";
            OrgaoEmissor = "";
            RG = "";
            Senha = "";
            Tipo = 'F';
            Endereco = new Endereco();
            Contatos = new Contatos();
        }
        public Pessoa(String nomerazaosocial, char classificacao, DateTime datanascimentofundacao, char tipo, string CPFCNPJ,
                string rg, String inscricaoestadual, String inscricaomunicipal, string fantasiafazenda, string orgaoemissor, 
                string login, string senha, string acessosistema, Endereco endereco, Contatos contato)
        {
            Guid g = new Guid();
            this.ID = g.ToString();
            PeencherClasse(nomerazaosocial, classificacao, datanascimentofundacao, tipo, CPFCNPJ, rg, inscricaoestadual, inscricaomunicipal, 
                fantasiafazenda,  orgaoemissor, login, senha, acessosistema, endereco, contato);
        }
        public void PeencherClasse(String nomerazaosocial, char classificacao, DateTime datanascimentofundacao, char tipo, string CPFCNPJ,
                string rg, String inscricaoestadual, String inscricaomunicipal, string fantasiafazenda, string orgaoemissor, string login, string senha,
                string acessosistema, Endereco endereco, Contatos contato)
        {
            this.AcessoSistema = acessosistema;
            this.CFPCNPJ = CPFCNPJ;
            this.Classificacao = classificacao;
            this.Contatos = contato;
            this.DataNascimentoFundacao = datanascimentofundacao;
            this.DataCadastro = DateTime.Today;
            this.Endereco = endereco;
            this.FantasiaFazenda = fantasiafazenda;
            this.InscricaoEstadual = inscricaoestadual;
            this.InscricaoMunicipal = inscricaomunicipal;
            this.Login = login;
            this.NomeRazaoSocial = nomerazaosocial;
            this.OrgaoEmissor = orgaoemissor;
            this.RG = rg;
            this.Senha = senha;
            this.Tipo = tipo;
        }
        public Boolean Salvar()
        {
            try
            {
                Conexao conexao = new Conexao();
                NpgsqlCommand cmd = new NpgsqlCommand();
                //Comando Sql - Salvando Cadastro de Pessoas 
                cmd.CommandText = "insert into pessoas (" +
                    "id_pessoa, " +
                    "acesso_sistema, " +
                    "cpf_cnpj, " +
                    "classificacao," +
                    "data_nascimento_fundacao," +
                    "data_cadastro," +
                    "fantasia_fazenda," +
                    "inscricao_estadual," +
                    "inscricao_municipal," +
                    "login," +
                    "nome_razao_social," +
                    "orgao_emissor," +
                    "rg," +
                    "senha," +
                    "tipo )" +
                    " values (" +
                    "@id_pessoa, " +
                    "@acesso_sistema, " +
                    "@cpf_cnpj, " +
                    "@classificacao," +
                    "@data_nascimento_fundacao," +
                    "@data_cadastro," +
                    "@fantasia_fazenda," +
                    "@inscricao_estadual," +
                    "@inscricao_municipal," +
                    "@login," +
                    "@nome_razao_social," +
                    "@orgao_emissor," +
                    "@rg," +
                    "@senha," +
                    "@tipo )";
                //Parametros
                cmd.Parameters.AddWithValue("@id_pessoa", this.ID);
                cmd.Parameters.AddWithValue("@acesso_sistema", this.AcessoSistema);
                cmd.Parameters.AddWithValue("@cpf_cnpj", this.CFPCNPJ);
                cmd.Parameters.AddWithValue("@classificacao", this.Classificacao);
                cmd.Parameters.AddWithValue("@data_nascimento_fundacao", this.DataNascimentoFundacao);
                cmd.Parameters.AddWithValue("@data_cadastro", this.DataCadastro);
                cmd.Parameters.AddWithValue("@fantasia_fazenda", this.FantasiaFazenda);
                cmd.Parameters.AddWithValue("@inscricao_estadual", this.InscricaoEstadual);
                cmd.Parameters.AddWithValue("@inscricao_municipal", this.InscricaoMunicipal);
                cmd.Parameters.AddWithValue("@login", this.Login);
                cmd.Parameters.AddWithValue("@nome_razao_social", this.NomeRazaoSocial);
                cmd.Parameters.AddWithValue("@orgao_emissor", this.OrgaoEmissor);
                cmd.Parameters.AddWithValue("@rg", this.RG);
                cmd.Parameters.AddWithValue("@senha", this.Senha);
                cmd.Parameters.AddWithValue("@tipo", this.Tipo);
            
                //conectar com banco
                cmd.Connection = conexao.Conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.Desconectar();


                if (!this.Endereco.EstaVazio)
                {
                    //
                }

                if (!this.Contatos.EstaVazio)
                {
                    //
                }
                //retorno OK
                return true;
            }
            catch (NpgsqlException e)
            {
                return false;
            }
        }
        public Boolean Salvar(String nomerazaosocial, char classificacao, DateTime datanascimentofundacao, char tipo, string cpfcnpj,
                      string rg, String inscricaoestadual, String inscricaomunicipal, string fantasiafazenda, string orgaoemissor, string login, string senha,
                      string acessosistema, Endereco endereco, Contatos contato)
        {
            PeencherClasse(nomerazaosocial, classificacao, datanascimentofundacao, tipo, cpfcnpj, rg, inscricaoestadual, inscricaomunicipal, fantasiafazenda, orgaoemissor,
                login, senha, acessosistema, endereco, contato);
            return Salvar();
        }
        public string ID
        {
            get { return FID; }
            set { FID = value; }
        }
        public string AcessoSistema
        {
            get { return FAcessoSistema; }
            set { FAcessoSistema = value; }
        }
        public string CFPCNPJ
        {
            get { return FCFPCNPJ; }
            set { FCFPCNPJ = value; }
        }
        public char Classificacao
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
        public string FantasiaFazenda
        {
            get { return FFantasiaFazenda; }
            set { FFantasiaFazenda = value; }
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
        public string OrgaoEmissor
        {
            get { return FOrgaoEmissor; }
            set { FOrgaoEmissor = value; }
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
        public char Tipo
        {
            get { return FTipo; }
            set { FTipo = value; }
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
        public Endereco Endereco
        {
            get { return FEndereco; }
            set { FEndereco = value; }
        }
        public Contatos Contatos
        {
            get { return FContatos; }
            set { FContatos = value; }
        }
    }
}
