using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuralSimples.Classes
{
    class BosTaurus:Animal //Classificacao das vacas e bois
    {
        private int FIDBosTaurus;
        private int FIDPessoa;
        private int FIDBosTaurusPai;
        private int FIDBosTaurusMae;
        private String FAptidao; //Leite, Carne, etc..
        private String FCiclo; //B - bezerro, C - cria, R - recria, E - engorda, A - acabamento
        private String FCicloReprodutivo; //N - Nulípara, P - Primípara, S - Segundípara, M - Multípara, N - Nehum
        private String FIdentificacao;
        private String FNumeroRegistro;
        private String FSexo; //M - MAcho, F - Fêmea
        private String FNomePai;
        private String FNomeMae;
        private DateTime FDataDescarte;
        private String FMotivoDescarte;
        private String FObservacoes;
        
        public BosTaurus()
        {
            preencherClasse(0, 0, "", "", "", new DateTime(1900, 1, 1, 0, 0, 0), "M",
                "", 0, 0, "", "Vertebrado", "Quadrupede", DateTime.Today,
                "Mamífero", "Sexuada", "Bos Taurus", "", "", "Bovídeos", "N", 
                new DateTime(1900, 1, 1, 0, 0, 0), "", "", "B", "N");
        }
        public BosTaurus(string raca, string nomeAnimal, String identificacao, DateTime datanascimento, String sexo, 
                         string aptidao, int idBostaurusPai, int idBosTaurusMae, string numeroRegistro, String nomePai, 
                         String nomeMae, String inativo, String motivoDescarte, String observacoes, DateTime dataDescarte, 
                         String ciclo, String cicloReprodutivo )
        {
            //Padrão ao definir a classe
            var idBosTaurus = 0;
            var idPessoa = 0;
            var classificacaoOssea = "Vertebrado";
            var classificacaoPatas = "Quadrupede";
            var dataCadastro = DateTime.Today;
            var grupo = "Mamífero";
            var tipoReproducao = "Sexuada";
            var nomeCientifico = "Bos Taurus";
            var familia = "Bovídeos";
            preencherClasse(idBosTaurus, idPessoa, raca, nomeAnimal, identificacao, datanascimento, sexo,
                aptidao, idBostaurusPai, idBosTaurusMae, numeroRegistro, classificacaoOssea, classificacaoPatas, dataCadastro,
                grupo, tipoReproducao, nomeCientifico, nomePai, nomeMae, familia, inativo, dataDescarte, motivoDescarte, 
                observacoes, ciclo, cicloReprodutivo);
        }
        public BosTaurus(int idBosTaurus, int idPessoa, string raca, string nomeAnimal, String identificacao, DateTime datanascimento, String sexo,
            string aptidao, int idBostaurusPai, int idBosTaurusMae, string numeroRegistro, string classificacaoOssea, string classificacaoPatas, DateTime dataCadastro,
            string grupo, string tipoReproducao, String nomeCientifico, String nomePai, String nomeMae, String familia, String inativo, DateTime dataDescarte,
            String motivoDescarte, String observacoes, String ciclo, String cicloReprodutivo)
        {
            preencherClasse(idBosTaurus, idPessoa, raca, nomeAnimal, identificacao, datanascimento, sexo, 
                aptidao, idBostaurusPai, idBosTaurusMae, numeroRegistro, classificacaoOssea, classificacaoPatas, dataCadastro,
                grupo, tipoReproducao, nomeCientifico, nomePai, nomeMae, familia, inativo, dataDescarte, motivoDescarte, 
                observacoes, ciclo, cicloReprodutivo);
        }
        public BosTaurus(int idPessoa, string raca, string nomeAnimal, String identificacao, DateTime datanascimento, String sexo,
            string aptidao, int idBostaurusPai, int idBosTaurusMae, string numeroRegistro, string classificacaoOssea, string classificacaoPatas, DateTime dataCadastro,
            string grupo, string tipoReproducao, String nomeCientifico, String nomePai, String nomeMae, String familia, String inativo, DateTime dataDescarte,
            String motivoDescarte, String observacoes, String ciclo, String cicloReprodutivo)
        {
            preencherClasse(0, idPessoa, raca, nomeAnimal, identificacao, datanascimento, sexo,
                aptidao, idBostaurusPai, idBosTaurusMae, numeroRegistro, classificacaoOssea, classificacaoPatas, dataCadastro,
                grupo, tipoReproducao, nomeCientifico, nomePai, nomeMae, familia, inativo, dataDescarte, motivoDescarte, observacoes,
                ciclo, cicloReprodutivo);
        }
        public void preencherClasse(int idBosTaurus, int idPessoa, string raca, string nomeAnimal, String identificacao, DateTime datanascimento, String sexo,
            string aptidao, int idBostaurusPai, int idBosTaurusMae, string numeroRegistro, string classificacaoOssea, string classificacaoPatas, DateTime dataCadastro, 
            string grupo, string tipoReproducao, String nomeCientifico, String nomePai, String nomeMae, String familia, String inativo, DateTime dataDescarte,
            String motivoDescarte, String observacoes, String ciclo, String cicloReprodutivo)
        {
            IDBosTaurus = idBosTaurus;
            IDPessoa = idPessoa;
            IDBosTaurusMae = idBostaurusPai;
            IDBosTaurusPai = idBosTaurusMae;

            Aptidao = aptidao;
            Ciclo = ciclo;
            CicloReprodutivo = cicloReprodutivo;
            ClassificacaoOssea = classificacaoOssea;
            ClassificacaoPatas = classificacaoPatas;
            DataCadastro = dataCadastro;
            DataDescarte = dataDescarte;
            DataNascimento = datanascimento;
            Familia = familia;
            Grupo = grupo;
            Identificacao = identificacao;
            Inativo = inativo;
            MotivoDescarte = motivoDescarte;
            NomeAnimal = nomeAnimal;
            NomeCientifico = nomeCientifico;
            NomePai = nomePai;
            NomeMae = nomeMae;
            NumeroRegistro = numeroRegistro;
            Observacoes = observacoes;
            Raca = raca;
            Sexo = sexo;
            TipoReproducao = tipoReproducao;
        }
        public int IDBosTaurus
        {
            get { return FIDBosTaurus; }
            set { FIDBosTaurus = value; }
        }
        public int IDPessoa
        {
            get { return FIDPessoa; }
            set { FIDPessoa = value; }
        }
        public int IDBosTaurusPai
        {
            get { return FIDBosTaurusPai; }
            set { FIDBosTaurusPai = value; }
        }
        public int IDBosTaurusMae
        {
            get { return FIDBosTaurusMae; }
            set { FIDBosTaurusMae = value; }
        }
        public String Aptidao
        {
            get { return FAptidao; }
            set { FAptidao = value; }
        }
        public String Ciclo
        {
            get { return FCiclo; }
            set { FCiclo = value; }
        }
        public String CicloReprodutivo
        {
            get { return FCicloReprodutivo; }
            set { FCicloReprodutivo = value; }
        }
        public DateTime DataDescarte
        {
            get { return FDataDescarte; }
            set { FDataDescarte = value; }
        }
        public String Identificacao
        {
            get { return FIdentificacao; }
            set { FIdentificacao = value; }
        }
        public string MotivoDescarte
        {
            get { return FMotivoDescarte; }
            set { FMotivoDescarte = value; }
        }
        public string Observacoes
        {
            get { return FObservacoes; }
            set { FObservacoes = value; }
        }
        public string NumeroRegistro
        {
            get { return FNumeroRegistro; }
            set { FNumeroRegistro = value; }
        }
        public String Sexo
        {
            get { return FSexo; }
            set { FSexo = value; }
        }
        public String NomePai
        {
            get { return FNomePai; }
            set { FNomePai = value; }
        }
        public String NomeMae
        {
            get { return FNomeMae; }
            set { FNomeMae = value; }
        }
    }
}
