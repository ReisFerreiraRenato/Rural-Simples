﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuralSimples.Classes
{
    class PropriedadePessoa
    {
        private int FIDPropriedadePessoa;
        private int FIDPessoa;
        private int FIDPropriedade;
        private DateTime FDataAquisicao;
        private String FInativo;
        private Double FParticipacao_Societaria;
        private String FNomePropriedade;

        public int IDPropriedadePessoa
        {
            get { return FIDPropriedadePessoa; }
            set { FIDPropriedadePessoa = value; }
        }
        public int IDPessoa
        {
            get { return FIDPessoa; }
            set { FIDPessoa = value; }
        }
        public int IDPropriedade
        {
            get { return FIDPropriedade; }
            set { FIDPropriedade = value; }
        }
        public DateTime DataAquisicao
        {
            get { return FDataAquisicao; }
            set { FDataAquisicao = value; }
        }
        public String Inativo
        {
            get { return FInativo; }
            set { FInativo = value; }
        }
        public Double ParticipacaoSocietaria
        {
            get { return FParticipacao_Societaria; }
            set { FParticipacao_Societaria = value; }
        }
        public String NomePropriedade
        {
            get { return FNomePropriedade; }
            set { FNomePropriedade = value; }
        }
        public PropriedadePessoa()
        {
            PreencherClasse(0, 0, 0, 0, "", new DateTime(1900, 1, 1, 1, 0, 0), "N");
        }
        public PropriedadePessoa(int id_pessoa, int id_propriedade, double participacao_societaria)
        {
            PreencherClasse(0, id_pessoa, id_propriedade, participacao_societaria, "", new DateTime(1900, 1, 1, 1, 0, 0), "N");
        }
        public PropriedadePessoa(int id_propriedade_pessoa, int id_pessoa, int id_propriedade, double participacao_societaria)
        {
            PreencherClasse(id_propriedade_pessoa, id_pessoa, id_propriedade, participacao_societaria, "", new DateTime(1900, 1, 1, 1, 0, 0), 
                "N");
        }
        public PropriedadePessoa(int id_propriedade_pessoa, int id_pessoa, int id_propriedade, double participacao_societaria,
            String nome_propriedade, DateTime data_aquisicao, String inativo)
        {
            PreencherClasse(id_propriedade_pessoa, id_pessoa, id_propriedade, participacao_societaria, nome_propriedade, data_aquisicao,
                inativo);
        }
        public void PreencherClasse(int id_pessoa, int id_propriedade, double participacao_societaria, String nome_propriedade, 
            String inativo)
        {
            PreencherClasse(0, id_pessoa, id_propriedade, participacao_societaria, nome_propriedade, new DateTime(1900, 1, 1, 1, 0, 0), 
                inativo);
        }
        public void PreencherClasse(int id_propriedade_pessoa, int id_pessoa, int id_propriedade, double participacao_societaria, 
            String nome_propriedade, DateTime data_aquisicao, String inativo)
        {
            IDPropriedadePessoa = id_propriedade_pessoa;
            IDPropriedade = id_propriedade;
            IDPessoa = id_pessoa;
            DataAquisicao = data_aquisicao;
            ParticipacaoSocietaria = participacao_societaria;
            NomePropriedade = nome_propriedade;
            Inativo = inativo;
        }
    }
}
