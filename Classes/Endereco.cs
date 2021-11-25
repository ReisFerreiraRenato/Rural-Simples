using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuralSimples.Classes
{
    class Endereco
    {
        private string FCEP;
        private string FLogradouro;
        private int FNumero;
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
            FCEP = "";
            FLogradouro = "";
            FNumero = 0;
            FComplemento = "";
            FBairro = "";
            FCidade = "";
            FUF = "";
            FIBGE = 0;
            FGia = 0;
            FSiafi = 0;
            FDDD = 0;
        }

        public Endereco(string cep, string logradouro, int numero, string complemento, string bairro,
                        string cidade,  string uf, int ibge, int gia, int siafi, int ddd)
        {
            FCEP = cep;
            FLogradouro = logradouro;
            FNumero = numero;
            FComplemento = complemento;
            FBairro = bairro;
            FCidade = cidade;
            FUF = uf;
            FIBGE = ibge;
            FGia = gia;
            FSiafi = siafi;
            FDDD = ddd;
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
        public int Numero
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
