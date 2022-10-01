using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuralSimples.Classes
{
    class Animal
    {
        private string FClassificacaoOssea;      //Vertebrado ou invertebrado
        private string FClassificacaoPatas; //Bipede, quadrupede, etc
        private DateTime FDataCadastro;
        private DateTime FDataNascimento;
        private string FFamilia;
        private string FGrupo;              //Mamíferos, répteis, Aves, Peixes, Amfíbio, Insetos, Aracnídeos, etc..
        private String FInativo;
        private string FNomeCientifico;
        private string FNomeAnimal;
        private string FRaca;
        private string FTipoReproducao;     //Sexuada ou Assexuada

        public String Inativo
        {
            get { return FInativo; }
            set { FInativo = value; }
        }
        public string ClassificacaoOssea
        {
            get { return FClassificacaoOssea; }
            set { FClassificacaoOssea = value; }
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
        public string NomeAnimal
        {
            get { return FNomeAnimal; }
            set { FNomeAnimal = value; }
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
