using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuralSimples.Classes
{
    class Pessoa
    {
        private string FID;
        private string FNome;
        private DateTime FDataNascimentoFundacao;
        private DateTime FDataCadastro;
        private char FTipo; //Pessoa Física ou Jurídica (F ou J)
        private string FCFPCNPJ;
        private string FRG;
        private string FInscricaoEstadual;
        private string FInscricaoMunicipal;
        private Endereco FEndereco;
        private Contatos FContatos;

        public Pessoa()
        {
            Guid g = new Guid();
            FID = g.ToString();
            FNome = "";
            FDataNascimentoFundacao = new DateTime(1900, 1, 1, 1, 0, 0);
            FDataCadastro = DateTime.Today ;
            FTipo = 'F'; //Pessoa Física ou Jurídica (F ou J)
            FCFPCNPJ = "";
            FRG = "";
            FInscricaoEstadual = "";
            FInscricaoMunicipal = "";
            FEndereco = new Endereco();
            FContatos = new Contatos();
        }
        public Pessoa(Guid ID, String Nome, DateTime DataNascimentoFundacao, char Tipo, string CPFCNPJ,
                      string RG, String InscricaoEstadual, String InscricaoMunicipal, Endereco endereco,
                      Contatos contato)
        {
            FID = ID.ToString();
            FNome = Nome;
            FDataNascimentoFundacao = DataNascimentoFundacao;
            FDataCadastro = DateTime.Today;
            FTipo = Tipo; //Pessoa Física ou Jurídica (F ou J)
            FCFPCNPJ = CPFCNPJ;
            FRG = RG;
            FInscricaoEstadual = InscricaoEstadual;
            FInscricaoMunicipal = InscricaoMunicipal;
            FEndereco = endereco;
            FContatos = contato;
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
        public string RG
        {
            get { return FRG; }
            set { FRG = value; }
        }
        public string InscEstadual
        {
            get { return FInscricaoEstadual; }
            set { FInscricaoEstadual = value; }
        }
        public string InscMunicipal
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
