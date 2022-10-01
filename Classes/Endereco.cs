using Npgsql;
using RuralSimples.Model;
using System;

namespace RuralSimples.Classes
{
    class Endereco
    {
        private int FIDEndereco;
        private int FIDPessoa;
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
        private Boolean FEstaVazio;

        public Endereco()
        {
            prencherClasse(0, 0, "", "", "", "", "", "", "", 0, 0, 0, 0, false);
        }
        public Endereco(int idPessoa, string cep, string logradouro, string numero, string complemento, string bairro,
                        string cidade, string uf, int ibge, int gia, int siafi, int ddd)
        {
            prencherClasse(0, idPessoa, cep, logradouro, numero, complemento, bairro, cidade, uf, ibge, gia, siafi, ddd, false);
        }
        public Endereco(int idEndereco, int idPessoa, string cep, string logradouro, string numero, string complemento, string bairro,
                        string cidade, string uf, int ibge, int gia, int siafi, int ddd)
        {
            prencherClasse(idEndereco, idPessoa, cep, logradouro, numero, complemento, bairro, cidade, uf, ibge, gia, siafi, ddd, false);
        }
        public void prencherClasse(int idEndereco, int idPessoa, string cep, string logradouro, string numero, string complemento, string bairro,
                        string cidade, string uf, int ibge, int gia, int siafi, int ddd, bool estaVazio)
        {
            IDEndereco = idEndereco;
            IDPessoa = idPessoa;
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
            EstaVazio = estaVazio;
        }
        public Boolean Salvar()
        {
            ControleEnderecos controleEndereco = new ControleEnderecos();

            //retorno OK
            if (this.IDEndereco != 0)
            {
                return controleEndereco.salvar(this);
            }
            else
            {
                return controleEndereco.inserir(this);
            }  
        }
        public Boolean Salvar(int idPessoa, string cep, string logradouro, string numero, string complemento, string bairro,
                        string cidade, string uf, int ibge, int gia, int siafi, int ddd)
        {
            prencherClasse(0, idPessoa, cep, logradouro, numero, complemento, bairro, cidade, uf, ibge, gia, siafi, 
                ddd, false);

            return Salvar();
        }
        public int IDEndereco
        {
            get { return FIDEndereco; }
            set { FIDEndereco = value; }
        }
        public int IDPessoa
        {
            get { return FIDPessoa; }
            set { FIDPessoa = value; }
        }
        public string CEP
        {
            get { return FCEP; }
            set { FCEP = value; }
        }
        public Boolean EstaVazio
        {
            get { return FEstaVazio; }
            set { FEstaVazio = value; }
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
