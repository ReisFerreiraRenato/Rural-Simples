using RuralSimples.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuralSimples.Classes
{
    class Vacinacao
    {
        private int FidVacinacao;
        private int FidAnimal;
        private Double FDosagem;
        private DateTime FdataVacinacao;
        private DateTime FdataCadastro;
        private String FNomeVacina;

        public Vacinacao()
        {
            PreencherClasse(0, 0, "", new DateTime(1900, 1, 1, 0, 0, 0), DateTime.Now, 0);
        }
        public Vacinacao(int idVacinacao, int idAnimal, String nomeVacina, DateTime dataVacinacao, DateTime dataCadastro, Double dosagem)
        {
            PreencherClasse(idVacinacao, idAnimal, nomeVacina, dataVacinacao, dataCadastro, dosagem);
        }
        public void PreencherClasse(int idVacinacao, int idAnimal, String nomeVacina, DateTime dataVacinacao, DateTime dataCadastro, Double dosagem)
        {
            IDVacinacao = idVacinacao;
            IDAnimal = idAnimal;
            NomeVacina = nomeVacina;
            DataCadastro = dataCadastro;
            DataVacinacao = dataVacinacao;
            Dosagem = dosagem;
        }
        public int IDVacinacao
        {
            get { return FidVacinacao; }
            set { FidVacinacao = value; }
        }
        public int IDAnimal
        {
            get { return FidAnimal; }
            set { FidAnimal = value; }
        }
        public String NomeVacina
        {
            get { return FNomeVacina; }
            set { FNomeVacina = value; }
        }
        public DateTime DataVacinacao
        {
            get { return FdataVacinacao; }
            set { FdataVacinacao = value; }
        }
        public DateTime DataCadastro
        {
            get { return FdataCadastro; }
            set { FdataCadastro = value; }
        }
        public Double Dosagem
        {
            get { return FDosagem; }
            set { FDosagem = value; }
        }
        public bool Salvar()
        {
            ControleVacinacao controleVacinacao = new ControleVacinacao();
            //retorno OK
            if (this.IDAnimal != 0)
                return controleVacinacao.Salvar(this);
            else
                return controleVacinacao.Inserir(this);
        }
    }
}
