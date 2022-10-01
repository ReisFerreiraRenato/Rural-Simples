using RuralSimples.Classes;
using RuralSimples.Dal;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace RuralSimples.Model
{
    class ControlePessoas
    {
        public bool tem;
        public String mensagem = "";

        public bool salvar(Pessoa pessoa)
        {
            PessoasDaoComandos pessoaDao = new PessoasDaoComandos();
            tem = pessoaDao.atualizarPessoa(pessoa);
            this.mensagem = pessoaDao.mensagem;
            return tem;
        }
        public bool salvar(int codigoPessoa, String nomeRazaosocial, String classificacao, DateTime dataNascimentoFundacao, DateTime dataCadastro, String tipo, 
            String cpf, String cnpj, string rg, String inscricaoEstadual, String inscricaoMunicipal, String nomeFantasia, String nomeFazenda, String orgaoEmissor, 
            String login, String senha, String acessoSistema, String inativo, String observacoes, String ufOrgaoExpedidor)
        {
            Pessoa pessoa = new Pessoa(codigoPessoa, nomeRazaosocial, classificacao, dataNascimentoFundacao, dataCadastro, tipo, cpf, cnpj, rg, inscricaoEstadual, 
                inscricaoMunicipal, nomeFantasia, nomeFazenda, orgaoEmissor, login, senha, acessoSistema, inativo, observacoes, ufOrgaoExpedidor);
            return salvar(pessoa);
        }
        public bool inserir(Pessoa pessoa)
        {
            PessoasDaoComandos pessoaDao = new PessoasDaoComandos();
            tem = pessoaDao.inserirPessoa(pessoa);
            this.mensagem = pessoaDao.mensagem;
            return tem;
        }
        public bool inserir(String nomeRazaosocial, String classificacao, DateTime dataNascimentoFundacao, DateTime dataCadastro, String tipo,
            String cpf, String cnpj, string rg, String inscricaoEstadual, String inscricaoMunicipal, String nomeFantasia, String nomeFazenda, String orgaoEmissor, 
            String login, String senha, String acessoSistema, String inativo, String observacoes, String ufOrgaoExpedidor)
        {
            Pessoa pessoa = new Pessoa(0, nomeRazaosocial, classificacao, dataNascimentoFundacao, dataCadastro, tipo, cpf, cnpj, rg, 
                inscricaoEstadual, inscricaoMunicipal, nomeFantasia, nomeFazenda, orgaoEmissor, login, senha, acessoSistema, inativo, observacoes, ufOrgaoExpedidor);
            return this.inserir(pessoa);
        }
        public Pessoa buscarPessoaIdentificacao(int idPessoa)
        {
            PessoasDaoComandos pessoaDao = new PessoasDaoComandos();
            Pessoa pessoa = pessoaDao.buscarPessoaAtivo(idPessoa);
            this.mensagem = pessoaDao.mensagem;
            return pessoa;
        }
        public List<Pessoa> buscarPessoaPorNome(String nome)
        {
            PessoasDaoComandos pessoaDao = new PessoasDaoComandos();
            List <Pessoa> pessoas = pessoaDao.buscarPessoaPorNome(nome);
            this.mensagem = pessoaDao.mensagem;
            return pessoas;
        }
        public bool inserirPessoaEnderecoContato(Pessoa pessoa, Endereco endereco, Contato contato)
        {
            PessoasDaoComandos pessoaDao = new PessoasDaoComandos();
            tem = pessoaDao.inserirPessoaEnderecoContato(pessoa, endereco, contato);
            this.mensagem = pessoaDao.mensagem;
            return tem;
        }
        public bool inserirPessoaEnderecoContato(String nomeRazaosocial, String classificacao, DateTime dataNascimentoFundacao, DateTime dataCadastro, String tipo,
            String cpf, String cnpj, string rg, String inscricaoEstadual, String inscricaoMunicipal, String nomeFantasia, String nomeFazenda, String orgaoEmissor,
            String login, String senha, String acessoSistema, String inativo, String observacoes, String ufOrgaoExpedidor,
            //Endereco
            string cep, string logradouro, string numero, string complemento, string bairro,
            string cidade, string uf, int ibge, int gia, int siafi, int ddd,
            //Contatos
            String telefoneFixo, String celular, String facebook, String twiter, String nomePessoaRecado, String instagram,
            String telefoneRecado, String site, String email, String tiktok, String celularWhats, String youtube)
        {
            int idPessoa = 0;

            Pessoa pessoa = new Pessoa(nomeRazaosocial, classificacao, dataNascimentoFundacao, dataCadastro, tipo, cpf, cnpj, rg,
                inscricaoEstadual, inscricaoMunicipal, nomeFantasia, nomeFazenda, orgaoEmissor, login, senha, acessoSistema, inativo, observacoes, ufOrgaoExpedidor);
            Contato contato = new Contato(idPessoa, telefoneFixo, celular, facebook, twiter, nomePessoaRecado, instagram, telefoneRecado, site, email, tiktok,
                celularWhats, youtube);
            Endereco endereco = new Endereco(idPessoa, cep, logradouro, numero, complemento, bairro, cidade, uf, ibge, gia, siafi, ddd);

            return inserirPessoaEnderecoContato(pessoa, endereco, contato);
        }
        public bool salvarPessoaEnderecoContato(Pessoa pessoa, Endereco endereco, Contato contato)
        {
            PessoasDaoComandos pessoaDao = new PessoasDaoComandos();
            tem = pessoaDao.salvarPessoaEnderecoContato(pessoa, endereco, contato);
            this.mensagem = pessoaDao.mensagem;
            return tem;
        }
        public bool salvarPessoaEnderecoContato(int codigoPessoa, String nomeRazaosocial, String classificacao, DateTime dataNascimentoFundacao, DateTime dataCadastro, String tipo,
            String cpf, String cnpj, string rg, String inscricaoEstadual, String inscricaoMunicipal, String nomeFantasia, String nomeFazenda, String orgaoEmissor,
            String login, String senha, String acessoSistema, String inativo, String observacoes, String ufOrgaoExpedidor,
            //Endereco
            int idEndereco, string cep, string logradouro, string numero, string complemento, string bairro,
            string cidade, string uf, int ibge, int gia, int siafi, int ddd,
            //Contatos
            int idContato, String telefoneFixo, String celular, String facebook, String twiter, String nomePessoaRecado, String instagram,
            String telefoneRecado, String site, String email, String tiktok, String celularWhats, String youtube)
        {
            Pessoa pessoa = new Pessoa(codigoPessoa, nomeRazaosocial, classificacao, dataNascimentoFundacao, dataCadastro, tipo, cpf, cnpj, rg, inscricaoEstadual,
                inscricaoMunicipal, nomeFantasia, nomeFazenda, orgaoEmissor, login, senha, acessoSistema, inativo, observacoes, ufOrgaoExpedidor);
            Contato contato = new Contato(idContato, codigoPessoa, telefoneFixo, celular, facebook, twiter, nomePessoaRecado, instagram, telefoneRecado, site, email, tiktok,
                celularWhats, youtube);
            Endereco endereco = new Endereco(idEndereco, codigoPessoa, cep, logradouro, numero, complemento, bairro, cidade, uf, ibge, gia, siafi, ddd);

            return salvarPessoaEnderecoContato(pessoa, endereco, contato);
        }
    }
}
