using System;
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
        private int FParticipacao_Societaria;

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
        public int ParticipacaoSocietaria
        {
            get { return FParticipacao_Societaria; }
            set { FParticipacao_Societaria = value; }
        }
        public PropriedadePessoa()
        {
            PreencherClasse(0, 0, 0, 0);
        }
        public PropriedadePessoa(int id_pessoa, int id_propriedade, int participacao_societaria)
        {
            PreencherClasse(0, id_pessoa, id_propriedade, participacao_societaria);
        }
        public void PreencherClasse(int id_propriedade_pessoa, int id_pessoa, int id_propriedade, int participacao_societaria)
        {
            IDPropriedadePessoa = id_propriedade_pessoa;
            IDPropriedade = id_propriedade;
            IDPessoa = id_pessoa;
            ParticipacaoSocietaria = participacao_societaria;
        }
    }
}
