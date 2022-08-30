using Npgsql;
using RuralSimples.Model;
using System;

namespace RuralSimples.Classes
{
    class Endereco
    {
        private string FIDEndereco;
        private string FIDPessoa;
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
            Guid g = new Guid();
            IDEndereco = g.ToString();
            IDPessoa = "";
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
            EstaVazio = true;
        }
        public Endereco(string cep, string logradouro, string numero, string complemento, string bairro,
                        string cidade, string uf, int ibge, int gia, int siafi, int ddd, string idPessoa)
        {
            Guid g = new Guid();
            IDEndereco = g.ToString();
            PeencherClasse(cep, logradouro, numero, complemento, bairro, cidade, uf, ibge, gia, siafi, ddd, idPessoa);
        }
        public void PeencherClasse(string cep, string logradouro, string numero, string complemento, string bairro,
                        string cidade, string uf, int ibge, int gia, int siafi, int ddd, string idPessoa)
        {
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
            EstaVazio = false;
        }
        public Boolean Salvar()
        {
            Conexao conexao = new Conexao();
            NpgsqlCommand cmd = new NpgsqlCommand();

            try
            {
                //Comando Sql - Salvando Endereco de Pessoas 
                cmd.CommandText = "insert into enderecos (" +
                        "id_endereco, " +
                        "id_pessoa, " +
                        "cep, " +
                        "logradouro, " +
                        "numero, " +
                        "complemento, " +
                        "bairro, " +
                        "cidade, " +
                        "uf, " +
                        "ibge, " +
                        "gia, " +
                        "siafi, " +
                        "ddd" +
                    ") " +
                    " values (" +
                        "@id_endereco, " +
                        "@id_pessoa, " +
                        "@cep, " +
                        "@logradouro, " +
                        "@numero, " +
                        "@complemento, " +
                        "@bairro, " +
                        "@cidade, " +
                        "@uf, " +
                        "@ibge, " +
                        "@gia, " +
                        "@siafi, " +
                        "@ddd " +
                    ")";
                //Parametros
                cmd.Parameters.AddWithValue("@id_endereco", this.IDEndereco);
                cmd.Parameters.AddWithValue("@id_pessoa", this.IDPessoa);
                cmd.Parameters.AddWithValue("@cep", this.CEP);
                cmd.Parameters.AddWithValue("@logradouro", this.Logradouro);
                cmd.Parameters.AddWithValue("@numero", this.Numero);
                cmd.Parameters.AddWithValue("@complemento", this.Complemento);
                cmd.Parameters.AddWithValue("@bairro", this.Bairro);
                cmd.Parameters.AddWithValue("@cidade", this.Cidade);
                cmd.Parameters.AddWithValue("@uf", this.UF);
                cmd.Parameters.AddWithValue("@ibge", this.IBGE);
                cmd.Parameters.AddWithValue("@gia", this.Gia);
                cmd.Parameters.AddWithValue("@siafi", this.Siafi);
                cmd.Parameters.AddWithValue("@ddd", this.DDD);

                //conectar com banco
                cmd.Connection = conexao.Conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.Desconectar();
                return true;
            }
            catch (NpgsqlException e)
            {
                return false;
            }
        }
        public Boolean Salvar(string cep, string logradouro, string numero, string complemento, string bairro,
                        string cidade, string uf, int ibge, int gia, int siafi, int ddd, string idPessoa)
        {
            PeencherClasse(cep, logradouro, numero, complemento, bairro, cidade, uf, ibge, gia, siafi, 
                ddd, idPessoa);

            return Salvar();
        }
        public Boolean Salvar(Endereco endereco)
        {
            return Salvar(endereco.CEP, endereco.Logradouro, endereco.Numero, endereco.Complemento, endereco.Bairro, endereco.Cidade, endereco.UF, endereco.IBGE, endereco.Gia,
                endereco.Siafi, endereco.DDD, endereco.IDPessoa);
        }
        public string IDEndereco
        {
            get { return FIDEndereco; }
            set { FIDEndereco = value; }
        }
        public string IDPessoa
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
