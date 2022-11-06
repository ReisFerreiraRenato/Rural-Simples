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
    class VacinacaoDaoComandos
    {
        public bool tem = false;
        public String mensagem = "";
        private NpgsqlCommand cmd = new NpgsqlCommand();
        private Conexao con = new Conexao();
        private NpgsqlDataReader dr;

        private const string erro_salvar_vacianacao = "Erro ao salvar/inserir vacianação(ões)! ";
        private const string vacianacao_salvas = "Vacianação(ões) salva(s)/inserida(s) com sucesso!";
        private const string vacianacao_encontradas = "Vacianação(ões) encontrada(s) no BD.";
        private const string vacianacao_nao_encontradas = "Vacianação(ões) não encontrada(s) no BD.";
        private const string erro_ao_acessar_bd = "Erro ao acessar o banco de dados! ";

        //comandos SQL padrão para buuscar pessoa
        public string sqlBuscarVacina =
            "select " +
                "id_vacina, " +
                "id_animal, " +
                "nome_vacina, " +
                "dosagem, " +
                "data_cadastro, " +
                "data_vacinacao " +
            "from " +
            "   public.vacinas ";
        public string sqlInserirVacina =
            "insert into vacinas (" +
                "id_animal, " +
                "nome_vacina, " +
                "dosagem, " +
                "data_cadastro, " +
                "data_vacinacao " +
            ") " +
                " values (" +
                "@id_animal, " +
                "@nome_vacina, " +
                "@dosagem, " +
                "@data_cadastro, " +
                "@data_vacinacao " +
        ")";
        public string sqlSalvarVacina =
            "UPDATE public.vacinas SET " +
                "id_animal = @id_animal, " +
                "nome_vacina = @nome_vacina, " +
                "dosagem = @dosagem, " +
                "data_cadastro = @data_cadastro, " +
                "data_vacinacao = @data_vacinacao " +
            "WHERE  id_vacina = @id_vacina "
        ;
        public bool SalvarVacinacao(Vacinacao vacinacao)
        {
            try
            {
                cmd.CommandText = sqlSalvarVacina;

                parametrosInserirAtualizar(vacinacao, cmd);

                //conectar com banco
                cmd.Connection = con.Conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                con.Desconectar();

                this.mensagem = vacianacao_salvas;
                return true;
            }
            catch (NpgsqlException e)
            {
                this.mensagem = erro_salvar_vacianacao + erro_ao_acessar_bd + e.Message;
                return false;
            }
        }
        public bool InserirVacinacao(Vacinacao vacinacao)
        {
            try
            {
                cmd.CommandText = sqlInserirVacina;

                parametrosInserirAtualizar(vacinacao, cmd);

                //conectar com banco
                cmd.Connection = con.Conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                con.Desconectar();

                this.mensagem = vacianacao_salvas;
                return true;
            }
            catch (NpgsqlException e)
            {
                this.mensagem = erro_salvar_vacianacao + erro_ao_acessar_bd + e.Message;
                return false;
            }
        }
        public List<Vacinacao> BuscarVacinacoes(int idAnimal)
        {
            List<Vacinacao> vacinacoes = new List<Vacinacao>();
            String where = " where id_animal = @id_animal";

            cmd.CommandText = sqlBuscarVacina + where;

            cmd.Parameters.AddWithValue("@id_animal", idAnimal);
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Vacinacao vacinacao = new Vacinacao(
                            dr.GetInt32(dr.GetOrdinal("id_vacina")),
                            dr.GetInt32(dr.GetOrdinal("id_animal")),
                            dr.GetString(dr.GetOrdinal("nome_vacina")),
                            dr.GetDateTime(dr.GetOrdinal("data_vacinacao")),
                            dr.GetDateTime(dr.GetOrdinal("data_cadastro")),
                            dr.GetDouble(dr.GetOrdinal("dosagem"))
                        );
                        vacinacoes.Add(vacinacao);
                    }
                    this.mensagem = vacianacao_encontradas;
                }
                else
                {
                    vacinacoes = null;
                    this.mensagem = vacianacao_nao_encontradas;
                }
            }
            catch (NpgsqlException e)
            {
                vacinacoes = null;
                this.mensagem = erro_ao_acessar_bd + e.Message;
            }
            return vacinacoes;
        }
        public Vacinacao BuscarVacinacao(int idVacinacao)
        {
            Vacinacao vacinacao = new Vacinacao();
            String where = " where id_vacinacao = @id_vacinacao";

            cmd.CommandText = sqlBuscarVacina + where;

            cmd.Parameters.AddWithValue("@id_vacinacao", idVacinacao);
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    vacinacao.PreencherClasse(
                        dr.GetInt32(dr.GetOrdinal("id_vacinacao")),
                        dr.GetInt32(dr.GetOrdinal("id_pessoa")),
                        dr.GetString(dr.GetOrdinal("nome_vacina")),
                        dr.GetDateTime(dr.GetOrdinal("data_vacinacao")),
                        dr.GetDateTime(dr.GetOrdinal("data_cadastro")),
                        dr.GetDouble(dr.GetOrdinal("dosagem"))
                    );
                    this.mensagem = vacianacao_encontradas;
                }
                else
                {
                    vacinacao = null;
                    this.mensagem = vacianacao_nao_encontradas;
                }
            }
            catch (NpgsqlException e)
            {
                vacinacao = null;
                this.mensagem = erro_ao_acessar_bd + e.Message;
            }
            return vacinacao;
        }
        public void parametrosInserirAtualizar(Vacinacao vacinacao, NpgsqlCommand comando)
        {
            //Parametros
            if (vacinacao.IDVacinacao != 0)
            {
                comando.Parameters.AddWithValue("@id_vacina", vacinacao.IDVacinacao);
            }
            comando.Parameters.AddWithValue("@id_animal", vacinacao.IDAnimal);
            comando.Parameters.AddWithValue("@nome_vacina", vacinacao.NomeVacina);
            comando.Parameters.AddWithValue("@dosagem", vacinacao.Dosagem);
            comando.Parameters.AddWithValue("@data_cadastro", vacinacao.DataCadastro);
            comando.Parameters.AddWithValue("@data_vacinacao", vacinacao.DataVacinacao);
        }
    }
}
