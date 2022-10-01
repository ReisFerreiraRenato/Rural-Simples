using RuralSimples.Classes;
using RuralSimples.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuralSimples.Model
{
    class ControleContatos
    {
        public bool tem = false;
        public String mensagem = "";
        public Contato buscarContatoPessoaID(int idPessoa)
        {
            ContatosDaoComandos contatosDao = new ContatosDaoComandos();
            Contato contato = contatosDao.buscarContatoPessoaID(idPessoa);
            this.mensagem = contatosDao.mensagem;
            return contato;
        }
        public Boolean inserirContato(Contato contato)
        {
            ContatosDaoComandos contatoDao = new ContatosDaoComandos();
            tem = contatoDao.inserirContato(contato);
            this.mensagem = contatoDao.mensagem;
            return tem;
        }
        public bool inserir(int idPessoa, String telefoneFixo, String celular, String facebook, String twiter, String nomePessoaRecado, String instagram,
            String telefoneRecado, String site, String email, String tiktok, String celularWhats, String youtube)
        {
            Contato contato = new Contato(idPessoa, telefoneFixo, celular, facebook, twiter, nomePessoaRecado, instagram, telefoneRecado, site, email, tiktok,
                celularWhats, youtube);
            return this.inserirContato(contato);
        }
        public Boolean salvarContato(Contato contato)
        {
            ContatosDaoComandos contatoDao = new ContatosDaoComandos();
            tem = contatoDao.salvarContato(contato);
            this.mensagem = contatoDao.mensagem;
            return tem;
        }
        public bool salvarContato(int idContato, int idPessoa, String telefoneFixo, String celular, String facebook, String twiter, String nomePessoaRecado, String instagram,
            String telefoneRecado, String site, String email, String tiktok, String celularWhats, String youtube)
        {
            Contato contato = new Contato(idContato, idPessoa, telefoneFixo, celular, facebook, twiter, nomePessoaRecado, instagram, telefoneRecado, site, email, tiktok,
                celularWhats, youtube);
            return this.salvarContato(contato);
        }
    }
}
