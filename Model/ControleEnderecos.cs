using RuralSimples.Classes;
using RuralSimples.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuralSimples.Model
{
    class ControleEnderecos
    {
        public bool tem = false;
        public String mensagem = "";
        public Endereco buscarEnderecoPessoaPorID(int idPessoa)
        {
            EnderecosDaoComandos enderecoDao = new EnderecosDaoComandos();
            Endereco endereco = enderecoDao.buscarEnderecoPessoaPorID(idPessoa);
            this.mensagem = enderecoDao.mensagem;
            return endereco;
        }
        public bool salvar(Endereco endereco)
        {
            EnderecosDaoComandos enderecoDao = new EnderecosDaoComandos();
            tem = enderecoDao.atualizarEndereco(endereco);
            this.mensagem = enderecoDao.mensagem;
            return tem;
        }
        public bool inserir(Endereco endereco)
        {
            EnderecosDaoComandos enderecoDao = new EnderecosDaoComandos();
            tem = enderecoDao.inserirEndereco(endereco);
            this.mensagem = enderecoDao.mensagem;
            return tem;
        }
        public bool inserir(int idPessoa, string cep, string logradouro, string numero, string complemento, string bairro,
                        string cidade, string uf, int ibge, int gia, int siafi, int ddd)
        {
            Endereco endereco = new Endereco(idPessoa, cep, logradouro, numero, complemento, bairro, cidade, uf, ibge, gia, siafi, ddd);
            return this.inserir(endereco);
        }
        public bool salvar(int idEndereco, int idPessoa, string cep, string logradouro, string numero, string complemento, string bairro,
                        string cidade, string uf, int ibge, int gia, int siafi, int ddd)
        {
            Endereco endereco = new Endereco(idEndereco, idPessoa, cep, logradouro, numero, complemento, bairro, cidade, uf, ibge, gia, siafi, ddd);
            return this.salvar(endereco);
        }
    }
}
