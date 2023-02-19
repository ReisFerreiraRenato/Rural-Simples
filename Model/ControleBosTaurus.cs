using RuralSimples.Classes;
using RuralSimples.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuralSimples.Model
{
    class ControleBosTaurus
    {
        public bool tem = false;
        public String mensagem = "";

        public BosTaurus buscarBosTaurusIdBostaurusAtivo(int idBostaurus)
        {
            return buscarBosTaurusIdBostaurus(idBostaurus, "N");
        }
        public BosTaurus buscarBosTaurusIdBostaurusInativo(int idBostaurus)
        {
            return buscarBosTaurusIdBostaurus(idBostaurus, "S");
        }
        public BosTaurus buscarBosTaurusIdBostaurus(int idBostaurus, String inativo)
        {
            BosTaurusDaoComandos bostaurusDaoComandos = new BosTaurusDaoComandos();
            BosTaurus bostaurus = bostaurusDaoComandos.buscarBosTaurusIdBostaurus(idBostaurus, inativo);
            this.mensagem = bostaurusDaoComandos.mensagem;
            return bostaurus;
        }
        public BosTaurus buscarBosTaurusIdBostaurus(int idBostaurus)
        {
            BosTaurusDaoComandos bostaurusDaoComandos = new BosTaurusDaoComandos();
            BosTaurus bostaurus = bostaurusDaoComandos.buscarBosTaurusIdBostaurus(idBostaurus, "N");
            this.mensagem = bostaurusDaoComandos.mensagem;
            return bostaurus;
        }
        public BosTaurus buscarBosTaurusIdentificacaoAtivo(String identificacao)
        {
            BosTaurusDaoComandos bostaurusDaoComandos = new BosTaurusDaoComandos();
            BosTaurus bostaurus = bostaurusDaoComandos.buscarBosTaurusIdentificacaoAtivo(identificacao);
            this.mensagem = bostaurusDaoComandos.mensagem;
            return bostaurus;
        }
        public bool SalvarBosTaurus(BosTaurus bostaurus)
        {
            BosTaurusDaoComandos bostaurusDaoComandos = new BosTaurusDaoComandos();
            tem = bostaurusDaoComandos.SalvarBostaurus(bostaurus);
            this.mensagem = bostaurusDaoComandos.mensagem;
            return tem;
        }
        public bool SalvarBosTaurus(int idBosTaurus, int idPessoa, string raca, string nomeAnimal, String identificacao, DateTime datanascimento, String sexo,
            string aptidao, int idBostaurusPai, int idBosTaurusMae, string registro, string classificacao, string classificacaoPatas, DateTime dataCadastro,
            string grupo, string tipoReproducao, String nomeCientifico, String nomePai, String nomeMae, String familia, String inativo, DateTime dataDescarte,
            String motivoDescarte, String observacoes, String ciclo, String cicloReprodutivo)
        {
            BosTaurus bostaurus = new BosTaurus(idBosTaurus, idPessoa, raca, nomeAnimal, identificacao, datanascimento, sexo,
                aptidao, idBostaurusPai, idBosTaurusMae, registro, classificacao, classificacaoPatas, dataCadastro,
                grupo, tipoReproducao, nomeCientifico, nomePai, nomeMae, familia, inativo, dataDescarte, motivoDescarte, observacoes,
                ciclo, cicloReprodutivo);
            return SalvarBosTaurus(bostaurus);
        }
        public bool InserirBosTaurus(
            int idPessoa,
            string raca,
            string nomeAnimal,
            String identificacao,
            DateTime datanascimento,
            String sexo,
            string aptidao,
            int idBostaurusPai,
            int idBosTaurusMae,
            string registro,
            string classificacao,
            string classificacaoPatas,
            DateTime dataCadastro,
            string grupo,
            string tipoReproducao,
            String nomeCientifico,
            String nomePai,
            String nomeMae,
            String familia,
            String inativo,
            DateTime dataDescarte,
            String motivoDescarte,
            String observacoes,
            String ciclo,
            String cicloReprodutico//25
        )
        {
            BosTaurus bostaurus = new BosTaurus(idPessoa, raca, nomeAnimal, identificacao, datanascimento, sexo,
                aptidao, idBostaurusPai, idBosTaurusMae, registro, classificacao, classificacaoPatas, dataCadastro,
                grupo, tipoReproducao, nomeCientifico, nomePai, nomeMae, familia, inativo, dataDescarte, 
                motivoDescarte, observacoes, ciclo, cicloReprodutico);

            return InserirBostaurus(bostaurus);
        }
        public bool InserirBostaurus(BosTaurus bostaurus)
        {
            BosTaurusDaoComandos bostaurusDaoComandos = new BosTaurusDaoComandos();
            tem = bostaurusDaoComandos.InserirBostaurus(bostaurus);
            this.mensagem = bostaurusDaoComandos.mensagem;
            return tem;
        }
        
    }
}
