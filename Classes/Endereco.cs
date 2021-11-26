using System;

namespace RuralSimples.Classes
{
    class Endereco
    {
        private string FIDEndereco;
        private string FCEP;
        private string FLogradouro;
        private string FNumero;
        private string FComplemento;
        private string FBairro;
        private string FCidade;
        private string FUF;
        private int FIBGE;
        private int FGia;
        private int FSiafi;
        private int FDDD;

        public Endereco()
        {
            Guid g = new Guid();
            IDEndereco = g.ToString();
            CEP = "";
            Logradouro = "";
            Numero = "";
            Complemento = "";
            Bairro = "";
            Cidade = "";
            UF = "";
            IBGE = 0;
            Gia = 0;
            Siafi = 0;
            DDD = 0;
        }

        public Endereco(string cep, string logradouro, string numero, string complemento, string bairro,
                        string cidade, string uf, int ibge, int gia, int siafi, int ddd)
        {
            Guid g = new Guid();
            IDEndereco = g.ToString();
            CEP = cep;
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            UF = uf;
            IBGE = ibge;
            Gia = gia;
            Siafi = siafi;
            DDD = ddd;
        }
        public string IDEndereco
        {
            get { return FIDEndereco; }
            set { FIDEndereco = value; }
        }
        public string CEP
        {
            get { return FCEP; }
            set { FCEP = value; }
        }
        public string Logradouro
        {
            get { return FLogradouro; }
            set { FLogradouro = value; }
        }
        public string Numero
        {
            get { return FNumero; }
            set { FNumero = value; }
        }
        public string Complemento
        {
            get { return FComplemento; }
            set { FComplemento = value; }
        }
        public string Bairro
        {
            get { return FBairro; }
            set { FBairro = value; }
        }
        public string Cidade
        {
            get { return FCidade; }
            set { FCidade = value; }
        }
        public string UF
        {
            get { return FUF; }
            set { FUF = value; }
        }
        public int IBGE
        {
            get { return FIBGE; }
            set { FIBGE = value; }
        }
        public int Gia
        {
            get { return FGia; }
            set { FGia = value; }
        }
        public int Siafi
        {
            get { return FSiafi; }
            set { FSiafi = value; }
        }
        public int DDD
        {
            get { return FDDD; }
            set { FDDD = value; }
        }
    }
}
