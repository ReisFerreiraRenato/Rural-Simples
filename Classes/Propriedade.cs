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
            this.IDPessoa = 0;
            this.Aptidao = "";
            this.Area = 0;
            this.Areaprodutiva = 0;
            this.CAR = "";
            this.ITR = "";
            this.Latitude = 0;
            this.Longitude = 0;
            //Atributos Pessoas
            this.CPF = "";
            this.CNPJ = "";
            this.Classificacao = "A"; //Propriedade
            this.DataNascimentoFundacao = new DateTime(1900, 1, 1, 1, 0, 0);
            this.DataCadastro = DateTime.Today;
            this.InscricaoEstadual = "";
            this.InscricaoMunicipal = "";
            this.NomeRazaoSocial = "";
            this.RG = "";
            this.TipoPessoa = "F"; //Pessoa Física ou Jurídica (F ou J)
        }
        public Propriedade(string Aptidao, double Area, double AreaProdutiva, string CAR, string ITR,
                           double Latitude, double Longitude, string Nome, DateTime DataNascimentoFundacao,
                           string tipo, string cpf, String cnpj, string RG, string InscricaoEstadual, string InscricaoMunicipal,
                           string ativo)
        {
            //Atributos Propriedades
            IDPessoa = 0;
            this.Aptidao = Aptidao;
            this.Area = Area;
            this.Areaprodutiva = AreaProdutiva;
            this.CAR = CAR;
            this.ITR = ITR;
            this.Latitude = Latitude;
            this.Longitude = Longitude;
            //Atributos Pessoas
            this.Classificacao = "A"; //Propriedade
            this.NomeRazaoSocial = Nome;
            this.DataNascimentoFundacao = DataNascimentoFundacao;
            this.DataCadastro = DateTime.Today;
            this.TipoPessoa = "F"; //Pessoa Física ou Jurídica (F ou J)
            this.CPF = cpf;
            this.CNPJ = cnpj;
            this.RG = RG;
            this.InscricaoEstadual = InscricaoEstadual;
            this.InscricaoMunicipal = InscricaoMunicipal;
            this.Inativo = ativo;
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
