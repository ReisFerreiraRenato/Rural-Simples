using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuralSimples.Classes
{
    class Animal
    {
        private string FClassificacao;      //Vertebrado ou invertebrado
        private string FClassificacaoPatas; //Bipede, quadrupede, etc
        private DateTime FDataCadastro;
        private DateTime FDataNascimento;
        private string FFamilia;
        private string FGrupo;              //Mamíferos, répteis, Aves, Peixes, Amfíbio, Insetos, Aracnídeos, etc..
        private string FNomeCientifico;
        private string FNome;
        private string FRaca;
        private string FTipoReproducao;     //Sexuada ou Assexuada

        public string Classificacao
        {
            get { return FClassificacao; }
            set { FClassificacao = value; }
        }
        public string ClassificacaoPatas
        {
            get { return FClassificacaoPatas; }
            set { FClassificacaoPatas = value; }
        }
        public DateTime DataCadastro
        {
            get { return FDataCadastro; }
            set { FDataCadastro = value; }
        }
        public DateTime DataNascimento
        {
            get { return FDataNascimento; }
            set { FDataNascimento = value; }
        }
        public string Familia
        {
            get { return FFamilia; }
            set { FFamilia = value; }
        }
        public string Grupo
        {
            get { return FGrupo; }
            set { FGrupo = value; }
        }
        public string NomeCientifico
        {
            get { return FNomeCientifico; }
            set { FNomeCientifico = value; }
        }
        public string Nome
        {
            get { return FNome; }
            set { FNome = value; }
        }
        public string Raca
        {
            get { return FRaca; }
            set { FRaca = value; }
        }
        public string TipoReproducao
        {
            get { return FTipoReproducao; }
            set { FTipoReproducao = value; }
        }
    }
}
