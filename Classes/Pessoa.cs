using System;

namespace RuralSimples.Classes
{
    class Pessoa
    {
        private string FID;
        private string FCFPCNPJ;
        private char FClassificacao; //A - Propriedade - C - CLiente;  F - Fornecedor; P - Parceiro; O - Outro; S - Sócio; Z - Funcionario
        private DateTime FDataNascimentoFundacao;
        private DateTime FDataCadastro;
        private string FInscricaoEstadual;
        private string FInscricaoMunicipal;
        private string FNome;
        private string FOrgaoEmissor;
        private string FFantasiaFazenda;
        private string FRG;
        private char FTipo; //Pessoa Física ou Jurídica (F ou J)
        private Endereco FEndereco;
        private Contatos FContatos;

        public Pessoa()
        {
            Guid g = new Guid();
            ID = g.ToString();
            CFPCNPJ = "";
            Classificacao = 'C';
            Contatos = new Contatos();
            DataNascimentoFundacao = new DateTime(1900, 1, 1, 1, 0, 0);
            DataCadastro = DateTime.Today;
            Endereco = new Endereco();
            FFantasiaFazenda = "";
            Tipo = 'F'; //Pessoa Física ou Jurídica (F ou J)
            Nome = "";
            RG = "";
            InscricaoEstadual = "";
            InscricaoMunicipal = "";
        }
        public Pessoa(String pNome, char pClassificacao, DateTime pDataNascimentoFundacao, char pTipo, string pCPFCNPJ,
                      string pRG, String pInscricaoEstadual, String pInscricaoMunicipal, Endereco pEndereco,
                      Contatos pContato, string pFantasiaFazenda, string pOrgaoEmissor)
        {
            Guid g = new Guid();
            this.ID = g.ToString();
            this.CFPCNPJ = pCPFCNPJ;
            this.Classificacao = Classificacao;
            this.Contatos = pContato;
            this.DataNascimentoFundacao = pDataNascimentoFundacao;
            this.DataCadastro = DateTime.Today;
            this.Endereco = pEndereco;
            this.FantasiaFazenda = pFantasiaFazenda;
            this.InscricaoEstadual = pInscricaoEstadual;
            this.InscricaoMunicipal = pInscricaoMunicipal;
            this.Nome = pNome;
            this.OrgaoEmissor = pOrgaoEmissor;
            this.Tipo = pTipo;
            this.RG = pRG;
        }
        public string ID
        {
            get { return FID; }
            set { FID = value; }
        }
        public string Nome
        {
            get { return FNome; }
            set { FNome = value; }
        }
        public string FantasiaFazenda
        {
            get { return FFantasiaFazenda; }
            set { FFantasiaFazenda = value; }
        }
        public string OrgaoEmissor
        {
            get { return FOrgaoEmissor; }
            set { FOrgaoEmissor = value; }
        }
        public DateTime DataNascimentoFundacao
        {
            get { return FDataNascimentoFundacao; }
            set { FDataNascimentoFundacao = value; }
        }
        public DateTime DataCadastro
        {
            get { return FDataCadastro; }
            set { FDataCadastro = value; }
        }
        public char Tipo
        {
            get { return FTipo; }
            set { FTipo = value; }
        }
        public string CFPCNPJ
        {
            get { return FCFPCNPJ; }
            set { FCFPCNPJ = value; }
        }
        public char Classificacao
        {
            get { return FClassificacao ; }
            set { FClassificacao  = value; }
        }
        public string RG
        {
            get { return FRG; }
            set { FRG = value; }
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
