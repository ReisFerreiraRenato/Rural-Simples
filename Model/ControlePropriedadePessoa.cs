using RuralSimples.Classes;
using RuralSimples.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuralSimples.Model
{
    class ControlePropriedadePessoa
    {
        public bool tem = false;
        public String mensagem = "";
        public PropriedadePessoa BuscarPropriedadePessoaID(int id_propriedade_pessoa)
        {
            PropriedadePessoaDaoComandos propriedadePessoaDaoComandos = new PropriedadePessoaDaoComandos();
            PropriedadePessoa propriedadePessoa = propriedadePessoaDaoComandos.BuscarPropriedadePessoa(id_propriedade_pessoa);
            this.mensagem = propriedadePessoaDaoComandos.mensagem;
            return propriedadePessoa;
        }
        public List<PropriedadePessoa> BuscarPropriedadesPessoaTodas(int id_pessoa)
        {
            PropriedadePessoaDaoComandos propriedadePessoaDaoComandos = new PropriedadePessoaDaoComandos();
            List<PropriedadePessoa> propriedadesPessoa = propriedadePessoaDaoComandos.BuscarPropriedadesPessoaTodas(id_pessoa);
            this.mensagem = propriedadePessoaDaoComandos.mensagem;
            return propriedadesPessoa;
        }
        public List<PropriedadePessoa> BuscarPropriedadesPessoaAtivas(int id_pessoa)
        {
            PropriedadePessoaDaoComandos propriedadePessoaDaoComandos = new PropriedadePessoaDaoComandos();
            List<PropriedadePessoa> propriedadesPessoa = propriedadePessoaDaoComandos.BuscarPropriedadesPessoaAtivas(id_pessoa);
            this.mensagem = propriedadePessoaDaoComandos.mensagem;
            return propriedadesPessoa;
        }
        public List<PropriedadePessoa> BuscarPropriedadesPessoaInativas(int id_pessoa)
        {
            PropriedadePessoaDaoComandos propriedadePessoaDaoComandos = new PropriedadePessoaDaoComandos();
            List<PropriedadePessoa> propriedadesPessoa = propriedadePessoaDaoComandos.BuscarPropriedadesPessoaInativas(id_pessoa);
            this.mensagem = propriedadePessoaDaoComandos.mensagem;
            return propriedadesPessoa;
        }
        public bool InserirPropriedadePessoa(PropriedadePessoa propriedadePessoa)
        {
            PropriedadePessoaDaoComandos propriedadePessoaDaoComandos = new PropriedadePessoaDaoComandos();
            tem = propriedadePessoaDaoComandos.InserirPropriedadePessoa(propriedadePessoa);
            this.mensagem = propriedadePessoaDaoComandos.mensagem;
            return tem;
        }
        public bool InserirPropriedadePessoa(int id_pessoa, int id_propriedade, int participacao_societaria)
        {
            PropriedadePessoa propriedadePessoa = new PropriedadePessoa(id_pessoa, id_propriedade, participacao_societaria);
            return this.InserirPropriedadePessoa(propriedadePessoa);
        }
        public Boolean SalvarPropriedadePessoa(PropriedadePessoa propriedadePessoa)
        {
            PropriedadePessoaDaoComandos propriedadePessoaDaoComandos = new PropriedadePessoaDaoComandos();
            tem = propriedadePessoaDaoComandos.SalvarPropriedadePessoa(propriedadePessoa);
            this.mensagem = propriedadePessoaDaoComandos.mensagem;
            return tem;
        }
        public bool SalvarPropriedadePessoa(int id_propriedade_pessoa, int id_pessoa, int id_propriedade, int participacao_societaria)
        {
            PropriedadePessoa propriedadePessoa = new PropriedadePessoa(id_propriedade_pessoa, id_pessoa, id_propriedade, participacao_societaria);
            return this.SalvarPropriedadePessoa(propriedadePessoa);
        }
    }
}
