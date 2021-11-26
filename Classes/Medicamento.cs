using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuralSimples.Classes
{
    class Medicamento
    {
        private string FID;
        private string FIDFornecedor;
        private string FIDLaboratorio;
        private DateTime FDataAtualizacao;
        private DateTime FDataCadastro;
        private DateTime FDataFabricacao;
        private DateTime FDataVencimento;
        private string FDoencas;
        private string FLote;
        private string FNome;
        private string FPeriodicidade; //Em dias

        public Medicamento()
        {
            Guid g = new Guid();
            ID = g.ToString();
            IDFornecedor = "";
            IDLaboratorio = "";
            Doencas = "";
            DataAtualizacao = DateTime.Today;
            DataCadastro = DateTime.Today;
            DataFabricacao = new DateTime(1900, 1, 1, 1, 0, 0);
            DataVencimento = new DateTime(1900, 1, 1, 1, 0, 0);
            Lote = "";
            Nome = "";
        }
        public Medicamento(string idfornecedor, string idLaboratorio, string doencas, DateTime datafabricacao,
                      DateTime datavencimento, string laboratorio, string lote, string nome)
        {
            Guid g = new Guid();
            ID = g.ToString();
            IDFornecedor = idfornecedor;
            IDLaboratorio = idLaboratorio;
            Doencas = doencas;
            DataAtualizacao = DateTime.Today;
            DataCadastro = DateTime.Today;
            DataFabricacao = datafabricacao;
            DataVencimento = datavencimento;
            Lote = lote;
            Nome = nome;
        }
        public string ID
        {
            get { return FID; }
            set { FID = value; }
        }
        public string IDFornecedor
        {
            get { return FIDFornecedor; }
            set { FIDFornecedor = value; }
        }
        public string IDLaboratorio
        {
            get { return FIDLaboratorio; }
            set { FIDLaboratorio = value; }
        }
        public DateTime DataAtualizacao
        {
            get { return FDataAtualizacao; }
            set { FDataAtualizacao = value; }
        }
        public DateTime DataCadastro
        {
            get { return FDataCadastro; }
            set { FDataCadastro = value; }
        }
        public DateTime DataFabricacao
        {
            get { return FDataFabricacao; }
            set { FDataFabricacao = value; }
        }
        public DateTime DataVencimento
        {
            get { return FDataVencimento; }
            set { FDataVencimento = value; }
        }
        public string Doencas
        {
            get { return FDoencas; }
            set { FDoencas = value; }
        }
        public string Lote
        {
            get { return FLote; }
            set { FLote = value; }
        }
        public string Nome
        {
            get { return FNome; }
            set { FNome = value; }
        }
        public string Periodicidade
        {
            get { return FPeriodicidade; }
            set { FPeriodicidade = value; }
        }
    }
}
