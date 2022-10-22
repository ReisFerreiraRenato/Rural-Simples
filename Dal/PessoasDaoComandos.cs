using Npgsql;
using RuralSimples.Classes;
using RuralSimples.Dal;
using RuralSimples.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuralSimples.Dal
{
    class PessoasDaoComandos
    {
        public bool tem = false;
        public String mensagem = "";
        NpgsqlCommand cmd = new NpgsqlCommand();
        Conexao con = new Conexao();
        NpgsqlDataReader dr;

        private const string sqlRetornarIdentity = "; select max(id_pessoa) from pessoas"; 
        //comandos SQL padrão para buuscar pessoa
        public const string sqlBuscarPessoa = 
            "select " +
            "id_pessoa, " +
            "cpf, " +
            "cnpj, " +
            "acesso_sistema, " +
            "classificacao, " +
            "CAST (data_nascimento_fundacao AS DATE) AS data_nascimento_fundacao, " +
            "CAST (data_cadastro AS DATE) AS data_cadastro, " +
            "nome_fantasia, " +
            "nome_fazenda, " +
            "inscricao_estadual, " +
            "inscricao_municipal, " +
            "login, " +
            "nome_razao_social, " +
            "orgao_expedidor, " +
            "rg,  " +
            "senha, " +
            "inativo, " +
            "tipo_pessoa, " +
            "uf_orgao_expedidor, " +
            "observacoes, " +
            "cei " +
        "from " +
        "   public.pessoas ";
        public const string sqlInserirPessoa =
            "insert into pessoas (" +
                "acesso_sistema, " +
                "cpf, " +
                "cnpj, " +
                "classificacao, " +
                "data_nascimento_fundacao, " +
                "data_cadastro, " +
                "nome_fantasia, " +
                "nome_fazenda, " +
                "inscricao_estadual, " +
                "inscricao_municipal, " +
                "login, " +
                "nome_razao_social, " +
                "orgao_expedidor, " +
                "rg, " +
                "senha, " +
                "inativo, " +
                "tipo_pessoa, " +
                "uf_orgao_expedidor, " +
                "observacoes, " +
                "cei " +
            " ) " +
                " values (" +
                "@acesso_sistema, " +
                "@cpf, " +
                "@cnpj, " +
                "@classificacao, " +
                "@data_nascimento_fundacao, " +
                "@data_cadastro, " +
                "@nome_fantasia, " +
                "@nome_fazenda, " +
                "@inscricao_estadual, " +
                "@inscricao_municipal, " +
                "@login, " +
                "@nome_razao_social, " +
                "@orgao_expedidor, " +
                "@rg, " +
                "@senha, " +
                "@inativo, " +
                "@tipo_pessoa, " +
                "@uf_orgao_expedidor, " +
                "@observacoes, " +
                "@cei " +
        ")";
        public const string sqlAtualizarPessoa =
            "UPDATE public.pessoas SET " +
                "acesso_sistema = @acesso_sistema, " +
                "cpf = @cpf, " +
                "cnpj = @cnpj, " +
                "classificacao = @classificacao, " +
                "data_nascimento_fundacao = @data_nascimento_fundacao, " +
                "data_cadastro = @data_cadastro, " +
                "nome_fantasia = @nome_fantasia, " +
                "nome_fazenda = @nome_fazenda, " +
                "inscricao_estadual = @inscricao_estadual, " +
                "inscricao_municipal = @inscricao_municipal, " +
                "login = @login, " +
                "nome_razao_social = @nome_razao_social, " +
                "orgao_expedidor = @orgao_expedidor, " +
                "rg = @rg, " +
                "senha = @senha, " +
                "inativo = @inativo, " +
                "tipo_pessoa = @tipo_pessoa, " +
                "uf_orgao_expedidor = @uf_orgao_expedidor, " +
                "observacoes = @observacoes, " +
                "cei = @cei " +
            "WHERE  id_pessoa = @id_pessoa ";

        public Pessoa buscarPessoa(int idPessoa, String inativo)
        {
            Pessoa pessoa = new Pessoa();
            String where = " where id_pessoa = @idPessoa and inativo = @inativo";

            cmd.CommandText = sqlBuscarPessoa + where;

            cmd.Parameters.AddWithValue("@idPessoa", Convert.ToInt32(idPessoa));
            cmd.Parameters.AddWithValue("@inativo", inativo);
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    pessoa.PeencherClasse(
                        Convert.ToInt32(dr["id_pessoa"].ToString()),
                        dr["nome_razao_social"].ToString(),
                        dr["classificacao"].ToString(),
                        dr.GetDateTime(dr.GetOrdinal("data_nascimento_fundacao")),
                        dr.GetDateTime(dr.GetOrdinal("data_cadastro")),
                        dr["tipo_pessoa"].ToString(),
                        dr["cpf"].ToString(),
                        dr["cnpj"].ToString(),
                        dr["rg"].ToString(),
                        dr["inscricao_estadual"].ToString(),
                        dr["inscricao_municipal"].ToString(),
                        dr["nome_fantasia"].ToString(),
                        dr["nome_fazenda"].ToString(),
                        dr["orgao_expedidor"].ToString(),
                        dr["login"].ToString(),
                        dr["senha"].ToString(),
                        dr["acesso_sistema"].ToString(),
                        dr["inativo"].ToString(),
                        dr["observacoes"].ToString(),
                        dr["uf_orgao_expedidor"].ToString(),
                        dr["cei"].ToString(),
                        false
                    );

                    this.mensagem = "Pessoa encontrada no BD.";
                }
                else
                {
                    this.mensagem = "Pessoa não encontrada no BD.";
                }
            }
            catch (NpgsqlException e)
            {
                pessoa = null;
                this.mensagem = "Erro ao acessar o banco de dados! " + e.Message;
            }
            return pessoa;
        }
        public Pessoa buscarPessoaAtivo(int idPessoa)
        {
            return buscarPessoa(idPessoa, "N");
        }
        public Pessoa buscarPessoaInativo(int idPessoa)
        {
            return buscarPessoa(idPessoa, "S");
        }
        public List<Pessoa> buscarPessoaPorNome(string nome)
        {
            List<Pessoa> pessoas = new List<Pessoa>();

            String where = " where (nome_razao_social like @nome)";
            String orderBy = " order by nome_razao_social";

            cmd.CommandText = sqlBuscarPessoa + where + orderBy;

            cmd.Parameters.AddWithValue("@nome", nome+"%");
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Pessoa pessoa = new Pessoa(
                            dr.GetInt32(dr.GetOrdinal("id_pessoa")), //dr.GetDateTime(dr.GetOrdinal("data_nascimento"))
                            dr["nome_razao_social"].ToString(),
                            dr["classificacao"].ToString(),
                            dr.GetDateTime(dr.GetOrdinal("data_nascimento_fundacao")),
                            dr.GetDateTime(dr.GetOrdinal("data_cadastro")),
                            dr["tipo_pessoa"].ToString(),
                            dr["cpf"].ToString(),
                            dr["cnpj"].ToString(),
                            dr["rg"].ToString(),
                            dr["inscricao_estadual"].ToString(),
                            dr["inscricao_municipal"].ToString(),
                            dr["nome_fantasia"].ToString(),
                            dr["nome_fazenda"].ToString(),
                            dr["orgao_expedidor"].ToString(),
                            dr["login"].ToString(),
                            dr["senha"].ToString(),
                            dr["acesso_sistema"].ToString(),
                            dr["inativo"].ToString(),
                            dr["observacoes"].ToString(),
                            dr["uf_orgao_expedidor"].ToString(),
                            dr["cei"].ToString()
                        );
                        pessoas.Add(pessoa);
                    }
                    this.mensagem = "Cadastro de pessoa encontrada no BD.";
                }
                else
                {
                    this.mensagem = "Cadastro de pessoas não encontrado!";
                    pessoas = null;
                }
            }
            catch (NpgsqlException e)
            {
                this.mensagem = "Erro ao acessar o banco de dados! " + e.Message;
                pessoas = null;
            }
            return pessoas;
        }
        public bool atualizarPessoa(Pessoa pessoa)
        {
            try
            {
                cmd.CommandText = sqlAtualizarPessoa;

                parametrosInserirAtualizar(pessoa);

                //conectar com banco
                cmd.Connection = con.Conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                con.Desconectar();

                this.mensagem = "Cadastro de pessoa atualizado com sucesso!";
                return true;
            }
            catch (NpgsqlException e)
            {
                this.mensagem = "Erro ao atualizar cadastro! " + e.Message;
                return false;
            }
        }
        public bool inserirPessoa(Pessoa pessoa)
        {
            try
            {
                cmd.CommandText = sqlInserirPessoa;

                parametrosInserirAtualizar(pessoa);

                //conectar com banco
                cmd.Connection = con.Conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                con.Desconectar();

                this.mensagem = "Cadastro de pessoa inserido com sucesso!";
                return true;
            }
            catch(NpgsqlException e)
            {
                this.mensagem = "Erro ao inserir cadastro! " + e.Message;
                return false;
            }
        }
        private void parametrosInserirAtualizar(Pessoa pessoa)
        {
            //Parametros
            if (pessoa.IDPessoa != 0)
            {
                cmd.Parameters.AddWithValue("@id_pessoa", pessoa.IDPessoa);
            }
            cmd.Parameters.AddWithValue("@acesso_sistema", pessoa.AcessoSistema);
            cmd.Parameters.AddWithValue("@cpf", pessoa.CPF);
            cmd.Parameters.AddWithValue("@cnpj", pessoa.CNPJ); 
            cmd.Parameters.AddWithValue("@classificacao", pessoa.Classificacao);
            cmd.Parameters.AddWithValue("@data_nascimento_fundacao", pessoa.DataNascimentoFundacao);
            cmd.Parameters.AddWithValue("@data_cadastro", pessoa.DataCadastro);
            cmd.Parameters.AddWithValue("@nome_fantasia", pessoa.NomeFantasia);
            cmd.Parameters.AddWithValue("@nome_fazenda", pessoa.NomeFazenda);
            cmd.Parameters.AddWithValue("@inscricao_estadual", pessoa.InscricaoEstadual);
            cmd.Parameters.AddWithValue("@inscricao_municipal", pessoa.InscricaoMunicipal);
            cmd.Parameters.AddWithValue("@login", pessoa.Login);
            cmd.Parameters.AddWithValue("@nome_razao_social", pessoa.NomeRazaoSocial);
            cmd.Parameters.AddWithValue("@orgao_expedidor", pessoa.OrgaoExpedidor);
            cmd.Parameters.AddWithValue("@rg", pessoa.RG);
            cmd.Parameters.AddWithValue("@senha", pessoa.Senha);
            cmd.Parameters.AddWithValue("@inativo", pessoa.Inativo);
            cmd.Parameters.AddWithValue("@tipo_pessoa", pessoa.TipoPessoa);
            cmd.Parameters.AddWithValue("@uf_orgao_expedidor", pessoa.UfOrgaoExpedidor);            
            cmd.Parameters.AddWithValue("@observacoes", pessoa.Observacoes);
            cmd.Parameters.AddWithValue("@cei", pessoa.CEI);
        }
        public bool inserirPessoaEnderecoContato(Pessoa pessoa, Endereco endereco, Contato contato)
        {
            var comando = sqlInserirPessoa + sqlRetornarIdentity;
            EnderecosDaoComandos enderecosDaoComandos = new EnderecosDaoComandos();
            ContatosDaoComandos contatosDaoComandos = new ContatosDaoComandos();

            try
            {
                //Conectar
                cmd.Connection = con.Conectar();

                //Inserir pessoa
                cmd.CommandText = comando;
                parametrosInserirAtualizar(pessoa);
                endereco.IDPessoa = Convert.ToInt32(cmd.ExecuteScalar());
                contato.IDPessoa = endereco.IDPessoa;

                //Inserir endereco
                comando = enderecosDaoComandos.sqlInserirEndereco;
                cmd.CommandText = comando;
                enderecosDaoComandos.parametrosInserirAtualizar(endereco, cmd);
                cmd.ExecuteNonQuery();

                //Inserir contato
                comando = contatosDaoComandos.sqlInserirContato;
                cmd.CommandText = comando;
                contatosDaoComandos.parametrosInserirAtualizar(contato, cmd);
                cmd.ExecuteNonQuery();

                //desconectar
                con.Desconectar();

                this.mensagem = "Cadastro de pessoa inserido com sucesso!";
                return true;
            }
            catch (Exception e)
            {
                con.CancelarTransacao();
                this.mensagem = "Erro ao salvar contato! " + e.Message;
                return false;
            }
        }
        public bool salvarPessoaEnderecoContato(Pessoa pessoa, Endereco endereco, Contato contato)
        {
            var comando = sqlAtualizarPessoa;
            EnderecosDaoComandos enderecosDaoComandos = new EnderecosDaoComandos();
            ContatosDaoComandos contatosDaoComandos = new ContatosDaoComandos();

            try
            {
                //Conectar
                cmd.Connection = con.Conectar();

                //Inserir pessoa
                cmd.CommandText = comando;
                parametrosInserirAtualizar(pessoa);
                cmd.ExecuteNonQuery();

                //Inserir endereco
                comando = enderecosDaoComandos.sqlAtualizarEndereco;
                cmd.CommandText = comando;
                enderecosDaoComandos.parametrosInserirAtualizar(endereco, cmd);
                cmd.ExecuteNonQuery();

                //Inserir contato
                comando = contatosDaoComandos.sqlSalvarContato;
                cmd.CommandText = comando;
                contatosDaoComandos.parametrosInserirAtualizar(contato, cmd);
                cmd.ExecuteNonQuery();

                //desconectar
                con.Desconectar();

                this.mensagem = "Pessoa atualizada com sucesso!";
                return true;
            }
            catch (Exception e)
            {
                this.mensagem = "Erro ao atualizar Pessoa completo! " + e.Message;
                con.CancelarTransacao();
                return false;
            }
        }
    }
}
