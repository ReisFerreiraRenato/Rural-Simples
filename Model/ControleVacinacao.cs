using RuralSimples.Classes;
using RuralSimples.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuralSimples.Model
{
    class ControleVacinacao
    {
        public bool tem = false;
        public String mensagem = "";
        public bool Salvar(Vacinacao vacinacao)
        {
            VacinacaoDaoComandos vacinacaoDao = new VacinacaoDaoComandos();
            this.tem = vacinacaoDao.SalvarVacinacao(vacinacao);
            this.mensagem = vacinacaoDao.mensagem;
            return tem;
        }
        public bool Inserir(Vacinacao vacinacao)
        {
            VacinacaoDaoComandos vacinacaoDao = new VacinacaoDaoComandos();
            tem = vacinacaoDao.InserirVacinacao(vacinacao);
            this.mensagem = vacinacaoDao.mensagem;
            return tem;
        }
        public Vacinacao BuscarVacinacao(int idVacina)
        {
            VacinacaoDaoComandos vacinacaoDao = new VacinacaoDaoComandos();
            Vacinacao vacinacao = vacinacaoDao.BuscarVacinacao(idVacina);
            this.mensagem = vacinacaoDao.mensagem;
            return vacinacao;
        }
        public List<Vacinacao> BuscarVacinacoes(int idAnimal)
        {
            VacinacaoDaoComandos vacinacaoDao = new VacinacaoDaoComandos();
            List<Vacinacao> vacinacoes = vacinacaoDao.BuscarVacinacoes(idAnimal);
            this.mensagem = vacinacaoDao.mensagem;
            return vacinacoes;
        }
    }
}
