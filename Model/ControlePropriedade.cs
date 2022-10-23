using RuralSimples.Classes;
using RuralSimples.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuralSimples.Model
{
    class ControlePropriedade
    {
        public bool tem = false;
        public String mensagem = "";
        public bool SalvarPropriedade(Propriedade propriedade)
        {
            PropriedadeDaoComandos propriedadeDao = new PropriedadeDaoComandos();
            this.tem = propriedadeDao.SalvarPropriedade(propriedade);
            this.mensagem = propriedadeDao.mensagem;
            return tem;
        }
        public bool SalvarPropriedade(int id_propriedade, String aptidao, double area_produtiva, double area_reserva, double area_total, String car,
            DateTime data_aquisicao, DateTime data_venda, String escritura, String itr, String inativa, String latitude, String longitude,
            String motivo_venda)
        {
            Propriedade propriedade = new Propriedade(id_propriedade, aptidao, area_produtiva, area_reserva, area_total, car,
                 data_aquisicao, data_venda, escritura, itr, inativa, latitude, longitude,
                 motivo_venda);
            return SalvarPropriedade(propriedade);
        }
        public bool InserirPropriedade(Propriedade propriedade)
        {
            PropriedadeDaoComandos propriedadeDao = new PropriedadeDaoComandos();
            this.tem = propriedadeDao.InserirPropriedade(propriedade);
            this.mensagem = propriedadeDao.mensagem;
            return tem;
        }
        public bool InserirPropriedade(String aptidao, double area_produtiva, double area_reserva, double area_total, String car,
            DateTime data_aquisicao, DateTime data_venda, String escritura, String itr, String inativa, String latitude, String longitude,
            String motivo_venda)
        {
            Propriedade propriedade = new Propriedade(aptidao, area_produtiva, area_reserva, area_total, car,
                 data_aquisicao, data_venda, escritura, itr, inativa, latitude, longitude,
                 motivo_venda);
            return InserirPropriedade(propriedade);
        }
        public Propriedade BuscarPropriedade(int id_propriedade)
        {
            PropriedadeDaoComandos propriedadeDao = new PropriedadeDaoComandos();
            Propriedade vacinacao = propriedadeDao.BuscarPropriedadeIdPropriedade(id_propriedade, "N");
            this.mensagem = propriedadeDao.mensagem;
            return vacinacao;
        }
        public List<Propriedade> BuscarPropriedades(int id_pessoa)
        {
            PropriedadeDaoComandos propriedadeDao = new PropriedadeDaoComandos();
            List<Propriedade> propriedades = propriedadeDao.BuscarPropriedades(id_pessoa);
            this.mensagem = propriedadeDao.mensagem;
            return propriedades;
        }
    }
}
