using Npgsql;
using RuralSimples.Classes;
using RuralSimples.Fontes_Comuns;
using RuralSimples.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuralSimples.Dal
{
    class EnderecosDaoComandos
    {
        public bool tem = false;
        public String mensagem = "";
        private NpgsqlCommand cmd = new NpgsqlCommand();
        private Conexao con = new Conexao();
        private NpgsqlDataReader dr;

        private const string erro_salvar_endereco = "Erro ao salvar/inserir endereço! ";
        private const string endereco_salvo = "Endereço salvo/inserido com sucesso!";
        private const string endereco_encontrado = "Endereço encontrado no BD.";
        private const string endereco_nao_encontrado = "Endereço não encontrado no BD.";
        private const string erro_ao_acessar_bd = "Erro ao acessar o banco de dados! ";

        //comandos SQL padrão para buuscar pessoa
        public string sqlBuscarEndereco =
            "select " + 
                "id_endereco, " +
                "id_pessoa, " +
                "cep, " +
                "logradouro, " +
                "numero, " +
                "complemento, " +
                "bairro, " +
                "cidade, " +
                "uf, " +
                "ibge, " +
                "gia, " +
                "siafi, " +
                "ddd " +
            "from " +
            "   public.enderecos ";
        public string sqlInserirEndereco =
            "insert into enderecos (" +
                "id_pessoa, " +
                "cep, " +
                "logradouro, " +
                "numero, " +
                "complemento, " +
                "bairro, " +
                "cidade, " +
                "uf, " +
                "ibge, " +
                "gia, " +
                "siafi, " +
                "ddd " +
            ") " +
                " values (" +
                "@id_pessoa, " +
                "@cep, " +
                "@logradouro, " +
                "@numero, " +
                "@complemento, " +
                "@bairro, " +
                "@cidade, " +
                "@uf, " +
                "@ibge, " +
                "@gia, " +
                "@siafi, " +
                "@ddd " +
        ")";
        public string sqlAtualizarEndereco =
            "UPDATE public.enderecos SET " +
                "id_pessoa = @id_pessoa, " +
                "cep = @cep, " +
                "logradouro = @logradouro, " +
                "numero = @numero, " +
                "complemento = @complemento, " +
                "bairro = @bairro, " +
                "cidade = @cidade, " +
                "uf = @uf, " +
                "ibge = @ibge, " +
                "gia = @gia, " +
                "siafi = @siafi, " +
                "ddd = @ddd " +
            "WHERE  id_endereco = @id_endereco "
        ;
        public Endereco buscarEnderecoPessoaPorID(int idPessoa)
        {
            Endereco endereco = new Endereco();
            String where = " where id_pessoa = @idPessoa";

            cmd.CommandText = sqlBuscarEndereco + where;

            cmd.Parameters.AddWithValue("@idPessoa", idPessoa);
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    endereco.prencherClasse(
                        Funcoes.StringToInteger(dr["id_endereco"].ToString()),
                        Funcoes.StringToInteger(dr["id_pessoa"].ToString()),
                        dr["cep"].ToString(),
                        dr["logradouro"].ToString(),
                        dr["numero"].ToString(),
                        dr["complemento"].ToString(),
                        dr["bairro"].ToString(),
                        dr["cidade"].ToString(),
                        dr["uf"].ToString(),
                        Funcoes.StringToInteger(dr["ibge"].ToString()),
                        Funcoes.StringToInteger(dr["gia"].ToString()),
                        Funcoes.StringToInteger(dr["siafi"].ToString()),
                        Funcoes.StringToInteger(dr["ddd"].ToString()),
                        false
                    );
                    this.mensagem = endereco_encontrado;
                }
                else
                {
                    endereco = null;
                    this.mensagem = endereco_nao_encontrado;
                }
            }
            catch (NpgsqlException e)
            {
                endereco = null;
                this.mensagem = endereco_encontrado + erro_ao_acessar_bd + e.Message;
            }
            return endereco;
        }
        public bool atualizarEndereco(Endereco endereco)
        {
            try
            {
                cmd.CommandText = sqlAtualizarEndereco;

                parametrosInserirAtualizar(endereco, cmd);

                //conectar com banco
                cmd.Connection = con.Conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                con.Desconectar();

                this.mensagem = endereco_salvo;
                return true;
            }
            catch (NpgsqlException e)
            {
                this.mensagem = erro_salvar_endereco + erro_ao_acessar_bd + e.Message;
                return false;
            }
        }
        public bool inserirEndereco(Endereco endereco)
        {
            try
            {
                cmd.CommandText = sqlInserirEndereco;

                parametrosInserirAtualizar(endereco, cmd);

                //conectar com banco
                cmd.Connection = con.Conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                con.Desconectar();

                this.mensagem = endereco_salvo;
                return true;
            }
            catch (NpgsqlException e)
            {
                this.mensagem = erro_salvar_endereco + erro_ao_acessar_bd + e.Message;
                return false;
            }
        }
        public void parametrosInserirAtualizar(Endereco endereco, NpgsqlCommand comando)
        {
            //Parametros
            comando.Parameters.AddWithValue("@id_endereco", endereco.IDEndereco);
            comando.Parameters.AddWithValue("@id_pessoa", endereco.IDPessoa);
            comando.Parameters.AddWithValue("@cep", endereco.CEP);
            comando.Parameters.AddWithValue("@logradouro", endereco.Logradouro);
            comando.Parameters.AddWithValue("@numero", endereco.Numero);
            comando.Parameters.AddWithValue("@complemento", endereco.Complemento);
            comando.Parameters.AddWithValue("@bairro", endereco.Bairro);
            comando.Parameters.AddWithValue("@cidade", endereco.Cidade);
            comando.Parameters.AddWithValue("@uf", endereco.UF);
            comando.Parameters.AddWithValue("@ibge", endereco.IBGE);
            comando.Parameters.AddWithValue("@gia", endereco.Gia);
            comando.Parameters.AddWithValue("@siafi", endereco.Siafi);
            comando.Parameters.AddWithValue("@ddd", endereco.DDD);
        }
    }
}
