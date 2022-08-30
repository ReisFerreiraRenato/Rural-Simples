using System;

namespace RuralSimples.Classes
{
    class Propriedade : Pessoa
    {
        private string FAptidao;
        private double FArea;
        private double FAreaProdutiva;
        private string FCAR;
        private string[] FIDProprietarios;
        private string FITR;
        private double FLatitude;
        private double FLongitude;

        public Propriedade()
        {
            //Atributos Propriedades
            Guid g = new Guid();
            ID = g.ToString();
            Aptidao = "";
            Area = 0;
            Areaprodutiva = 0;
            CAR = "";
            ITR = "";
            Latitude = 0;
            Longitude = 0;
            //Atributos Pessoas
            CFPCNPJ = "";
            Classificacao = 'A'; //Propriedade
            Contatos = new Contatos();
            DataNascimentoFundacao = new DateTime(1900, 1, 1, 1, 0, 0);
            DataCadastro = DateTime.Today;
            Endereco = new Endereco();
            InscricaoEstadual = "";
            InscricaoMunicipal = "";
            NomeRazaoSocial = "";
            RG = "";
            Tipo = 'F'; //Pessoa Física ou Jurídica (F ou J)
        }
        public Propriedade(string Aptidao, double Area, double AreaProdutiva, string CAR, string ITR,
                           double Latitude, double Longitude, string Nome, DateTime DataNascimentoFundacao,
                           char tipo, string CPFCNPJ, string RG, string InscricaoEstadual, string InscricaoMunicipal,
                           Endereco Endereco, Contatos Contatos)
        {
            //Atributos Propriedades
            Guid g = new Guid();
            ID = g.ToString();
            this.Aptidao = Aptidao;
            this.Area = Area;
            this.Areaprodutiva = AreaProdutiva;
            this.CAR = CAR;
            this.ITR = ITR;
            this.Latitude = Latitude;
            this.Longitude = Longitude;
            //Atributos Pessoas
            this.Classificacao = 'A'; //Propriedade
            this.NomeRazaoSocial = Nome;
            this.DataNascimentoFundacao = DataNascimentoFundacao;
            this.DataCadastro = DateTime.Today;
            this.Tipo = 'F'; //Pessoa Física ou Jurídica (F ou J)
            this.CFPCNPJ = CPFCNPJ;
            this.RG = RG;
            this.InscricaoEstadual = InscricaoEstadual;
            this.InscricaoMunicipal = InscricaoMunicipal;
            this.Endereco = Endereco;
            this.Contatos = Contatos;
        }

        public double Area
        {
            get { return FArea; }
            set { FArea = value; }
        }
        public double Areaprodutiva
        {
            get { return FAreaProdutiva; }
            set { FAreaProdutiva = value; }
        }
        public string[] IDProprietarios
        {
            get { return FIDProprietarios; }
            set { FIDProprietarios = value; }
        }
        public double Latitude
        {
            get { return FLatitude; }
            set { FLatitude = value; }
        }
        public double Longitude
        {
            get { return FLongitude; }
            set { FLongitude = value; }
        }
        public string Aptidao
        {
            get { return FAptidao; }
            set { FAptidao = value; }
        }
        public string CAR
        {
            get { return FCAR; }
            set { FCAR = value; }
        }
        public string ITR
        {
            get { return FITR; }
            set { FITR = value; }
        }
    }
}
