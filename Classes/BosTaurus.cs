using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuralSimples.Classes
{
    class BosTaurus:Animal //Classificacao das vacas e bois
    {
        private string FID;
        private string FIDPai;
        private string FIDMae;
        private string FAptidao; //Leite, Carne, etc..
        private int FNumero;
        private string FRegistro;
        private char FSexo; //M - MAcho, F - Fêmea
        
        public BosTaurus()
        {
            Guid g = new Guid();
            ID = g.ToString();
            Classificacao = "Vertebrado";
            ClassificacaoPatas = "Quadrupede";
            DataNascimento = new DateTime(1900, 1, 1, 0, 0, 0);
            DataCadastro = DateTime.Today;
            Grupo = "Mamífero";
            NomeCientifico = "Bos Taurus";
            TipoReproducao = "Sexuada";
            Aptidao = "";
            Nome = "";
            Numero = 0;
            Raca = "";
            Registro = "";
            Sexo = 'M';
        }
        public BosTaurus(string raca, string nome, int numero, DateTime datanascimento, char sexo, 
                         string aptidao, string idpai, string idmae, string registro)
        {
            Guid g = new Guid();
            ID = g.ToString();
            Classificacao = "Vertebrado";
            ClassificacaoPatas = "Quadrupede";
            DataNascimento = datanascimento;
            DataCadastro = DateTime.Today;
            Grupo = "Mamífero";
            TipoReproducao = "Sexuada";
            Aptidao = aptidao;
            IDMae = idpai;
            IDPai = idmae;
            Nome = nome;
            Numero = numero;
            Raca = raca;
            Registro = registro;
            Sexo = sexo;
        }
        public string ID
        {
            get { return FID; }
            set { FID = value; }
        }
        public string IDPai
        {
            get { return FIDPai; }
            set { FIDPai = value; }
        }
        public string IDMae
        {
            get { return FIDMae; }
            set { FIDMae = value; }
        }
        public string Aptidao
        {
            get { return FAptidao; }
            set { FAptidao = value; }
        }
        public int Numero
        {
            get { return FNumero; }
            set { FNumero = value; }
        }
        public string Registro
        {
            get { return FRegistro; }
            set { FRegistro = value; }
        }
        public char Sexo
        {
            get { return FSexo; }
            set { FSexo = value; }
        }
    }
}
