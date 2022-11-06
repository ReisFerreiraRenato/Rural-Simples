using Npgsql;
using RuralSimples.Classes;
using RuralSimples.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuralSimples.Dal
{
    class BosTaurusDaoComandos
    {
        public bool tem = false;
        public String mensagem = "";
        NpgsqlCommand cmd = new NpgsqlCommand();
        Conexao con = new Conexao();
        NpgsqlDataReader dr;

        private const string erro_salvar_animal = "Erro ao salvar/inserir animal! ";
        private const string animal_salvo = "Animal salvo/inserido com sucesso!";
        private const string animal_encontrado = "Animal encontrado no BD.";
        private const string animal_nao_encontrado = "Animal não encontrado no BD.";
        private const string erro_ao_acessar_bd = "Erro ao acessar o banco de dados! ";

        private const string sqlRetornarIdentity = "; select max(id_pessoa) from bostaurus";
        //comandos SQL padrão para buuscar pessoa
        public string sqlBuscarBosTaurus =
            "select " +
                "id_bostaurus, " +
                "id_pessoa, " +
                "id_bostaurus_pai, " +
                "id_bostaurus_mae, " +
                "nome_pai, " +
                "nome_mae, " +
                "aptidao, " +
                "numero_registro, " +
                "sexo, " +
                "classificacao_ossea, " +
                "classificacao_patas, " +
                "data_cadastro, " +
                "data_nascimento, " +
                "familia,  " +
                "grupo,  " +
                "nome_cientifico,  " +
                "nome_animal,  " +
                "raca,  " +
                "tipo_reproducao,  " +
                "inativo,  " +
                "data_descarte,  " +
                "motivo_descarte,  " +
                "observacoes_bostaurus,  " +
                "identificacao  " +
            "from " +
            "   public.bostaurus ";
        public string sqlInserirBosTaurus =
            "insert into bostaurus (" +
                "id_pessoa, " +
                "id_bostaurus_pai, " +
                "id_bostaurus_mae, " +
                "nome_pai, " +
                "nome_mae, " +
                "aptidao, " +
                "identificacao, " +
                "numero_registro, " +
                "sexo, " +
                "classificacao_ossea, " +
                "classificacao_patas, " +
                "data_cadastro, " +
                "data_nascimento, " +
                "familia,  " +
                "grupo,  " +
                "nome_cientifico,  " +
                "nome_animal,  " +
                "raca,  " +
                "tipo_reproducao,  " +
                "inativo,  " +
                "data_descarte,  " +
                "motivo_descarte,  " +
                "observacoes_bostaurus  " +
            ") " +
            " values (" +
                "@id_pessoa, " +
                "@id_bostaurus_pai, " +
                "@id_bostaurus_mae, " +
                "@nome_pai, " +
                "@nome_mae, " +
                "@aptidao, " +
                "@identificacao, " +
                "@numero_registro, " +
                "@sexo, " +
                "@classificacao_ossea, " +
                "@classificacao_patas, " +
                "@data_cadastro, " +
                "@data_nascimento, " +
                "@familia, " +
                "@grupo, " +
                "@nome_cientifico, " +
                "@nome_animal, " +
                "@raca, " +
                "@tipo_reproducao, " +
                "@inativo,  " +
                "@data_descarte,  " +
                "@motivo_descarte,  " +
                "@observacoes_bostaurus  " +
        ")";
        public string sqlSalvarBosTaurus =
            "UPDATE public.bostaurus SET " +
                "id_pessoa = @id_pessoa, " +
                "id_bostaurus_pai = @id_bostaurus_pai, " +
                "id_bostaurus_mae = @id_bostaurus_mae, " +
                "nome_pai = @nome_pai, " +
                "nome_mae = @nome_mae, " +
                "aptidao = @aptidao, " +
                "identificacao = @identificacao, " +
                "numero_registro = @numero_registro, " +
                "sexo = @sexo, " +
                "classificacao_ossea = @classificacao_ossea, " +
                "classificacao_patas = @classificacao_patas, " +
                "data_cadastro = @data_cadastro, " +
                "data_nascimento = @data_nascimento, " +
                "familia = @familia, " +
                "grupo = @grupo, " +
                "nome_cientifico = @nome_cientifico, " +
                "nome_animal = @nome_animal, " +
                "raca = @raca, " +
                "tipo_reproducao = @tipo_reproducao, " +
                "inativo = @inativo,  " +
                "data_descarte = @data_descarte,  " +
                "motivo_descarte = @motivo_descarte,  " +
                "observacoes_bostaurus = @observacoes_bostaurus " +
            "WHERE  id_bostaurus = @id_bostaurus "
        ;
        public bool SalvarBostaurus(BosTaurus bostaurus)
        {
            try
            {
                cmd.CommandText = sqlSalvarBosTaurus;

                parametrosInserirAtualizar(bostaurus, cmd);

                //conectar com banco
                cmd.Connection = con.Conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                con.Desconectar();

                this.mensagem = animal_salvo;
                return true;
            }
            catch (NpgsqlException e)
            {
                this.mensagem = erro_salvar_animal + erro_ao_acessar_bd + e.Message;
                return false;
            }
        }
        public bool InserirBostaurus(BosTaurus bostaurus)
        {
            try
            {
                cmd.CommandText = sqlInserirBosTaurus;

                parametrosInserirAtualizar(bostaurus, cmd);

                //conectar com banco
                cmd.Connection = con.Conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                con.Desconectar();

                this.mensagem = animal_salvo;
                return true;
            }
            catch (NpgsqlException e)
            {
                this.mensagem = erro_salvar_animal + erro_ao_acessar_bd + e.Message;
                return false;
            }
        }
        public BosTaurus buscarBosTaurusIdBostaurus(int idBostaurus, String inativo)
        {
            BosTaurus bostaurus = new BosTaurus();
            String where = " where id_bostaurus = @idBosTauros and inativo = @inativo";

            cmd.CommandText = sqlBuscarBosTaurus + where;

            cmd.Parameters.AddWithValue("@idBosTauros", Convert.ToInt32(idBostaurus));
            cmd.Parameters.AddWithValue("@inativo", inativo);
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    preencherClasse(dr, ref bostaurus);
 
                    this.mensagem = animal_encontrado;
                }
                else
                {
                    bostaurus = null;
                    this.mensagem = animal_nao_encontrado;
                }
            }
            catch (NpgsqlException e)
            {
                bostaurus = null;
                this.mensagem = animal_nao_encontrado + erro_ao_acessar_bd + e.Message;
            }
            return bostaurus;
        }
        public BosTaurus buscarBosTaurusIdentificacao(String identificacao, String inativo)
        {
            BosTaurus bostaurus = new BosTaurus();
            String where = " where identificacao = @identificacao and inativo = @inativo";

            cmd.CommandText = sqlBuscarBosTaurus + where;

            cmd.Parameters.AddWithValue("@identificacao", identificacao);
            cmd.Parameters.AddWithValue("@inativo", inativo);
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    preencherClasse(dr, ref bostaurus);

                    this.mensagem = animal_encontrado;
                }
                else
                {
                    bostaurus = null;
                    this.mensagem = animal_nao_encontrado;
                }
            }
            catch (NpgsqlException e)
            {
                bostaurus = null;
                this.mensagem = animal_nao_encontrado + erro_ao_acessar_bd + e.Message;
            }
            return bostaurus;
        }
        public BosTaurus buscarBosTaurusIdentificacaoInativo(String identificacao)
        {
            return buscarBosTaurusIdentificacao(identificacao, "S");
        }
        public BosTaurus buscarBosTaurusIdentificacaoAtivo(String identificacao)
        {
            return buscarBosTaurusIdentificacao(identificacao, "N");
        }
        public BosTaurus buscarBosTaurusIdBostaurusAtivo(int idBostaurus)
        {
            return buscarBosTaurusIdBostaurus(idBostaurus, "N");
        }
        public BosTaurus buscarBosTaurusIdBostaurusInativo(int idBostaurus)
        {
            return buscarBosTaurusIdBostaurus(idBostaurus, "S");
        }
        private void preencherClasse(NpgsqlDataReader dr, ref BosTaurus bostaurus)
        {
            DateTime datadescarte;

            if (bostaurus.DataDescarte == null)
            {
                datadescarte = new DateTime(1900, 1, 1, 0, 0, 0);
            }
            else
            {
                datadescarte = bostaurus.DataDescarte;
            }

            bostaurus.preencherClasse(
                dr.GetInt32(dr.GetOrdinal("id_bostaurus")),
                dr.GetInt32(dr.GetOrdinal("id_pessoa")),
                dr["raca"].ToString(),
                dr["nome_animal"].ToString(),
                dr["identificacao"].ToString(),
                dr.GetDateTime(dr.GetOrdinal("data_nascimento")),
                dr["sexo"].ToString(),
                dr["aptidao"].ToString(),
                dr.GetInt32(dr.GetOrdinal("id_bostaurus_pai")),
                dr.GetInt32(dr.GetOrdinal("id_bostaurus_mae")),
                dr["numero_registro"].ToString(),
                dr["classificacao_ossea"].ToString(),
                dr["classificacao_patas"].ToString(),
                dr.GetDateTime(dr.GetOrdinal("data_cadastro")),
                dr["grupo"].ToString(),
                dr["tipo_reproducao"].ToString(),
                dr["nome_cientifico"].ToString(),
                dr["nome_pai"].ToString(),
                dr["nome_mae"].ToString(),
                dr["familia"].ToString(),

                dr["inativo"].ToString(),
                datadescarte,
                dr["motivo_descarte"].ToString(),
                dr["observacoes_bostaurus"].ToString()
            );
        }
        public void parametrosInserirAtualizar(BosTaurus bostaurus, NpgsqlCommand comando)
        {
            //Parametros
            if (bostaurus.IDBosTaurus != 0)
            {
                comando.Parameters.AddWithValue("@id_bostaurus", bostaurus.IDBosTaurus);
            }
            comando.Parameters.AddWithValue("@id_pessoa", bostaurus.IDPessoa);
            comando.Parameters.AddWithValue("@id_bostaurus_pai", bostaurus.IDBosTaurusPai);
            comando.Parameters.AddWithValue("@id_bostaurus_mae", bostaurus.IDBosTaurusMae);
            comando.Parameters.AddWithValue("@nome_pai", bostaurus.NomePai);
            comando.Parameters.AddWithValue("@nome_mae", bostaurus.NomeMae);
            comando.Parameters.AddWithValue("@aptidao", bostaurus.Aptidao);
            comando.Parameters.AddWithValue("@identificacao", bostaurus.Identificacao);
            comando.Parameters.AddWithValue("@numero_registro", bostaurus.NumeroRegistro);
            comando.Parameters.AddWithValue("@sexo", bostaurus.Sexo);
            comando.Parameters.AddWithValue("@classificacao_ossea", bostaurus.ClassificacaoOssea);
            comando.Parameters.AddWithValue("@classificacao_patas", bostaurus.ClassificacaoPatas);
            comando.Parameters.AddWithValue("@data_cadastro", bostaurus.DataCadastro);
            comando.Parameters.AddWithValue("@data_nascimento", bostaurus.DataNascimento);
            comando.Parameters.AddWithValue("@familia", bostaurus.Familia);
            comando.Parameters.AddWithValue("@grupo", bostaurus.Grupo);
            comando.Parameters.AddWithValue("@nome_cientifico", bostaurus.NomeCientifico);
            comando.Parameters.AddWithValue("@nome_animal", bostaurus.NomeAnimal);
            comando.Parameters.AddWithValue("@raca", bostaurus.Raca);
            comando.Parameters.AddWithValue("@tipo_reproducao", bostaurus.TipoReproducao);
            comando.Parameters.AddWithValue("@inativo", bostaurus.Inativo);
            comando.Parameters.AddWithValue("@data_descarte", bostaurus.DataDescarte);
            comando.Parameters.AddWithValue("@motivo_descarte", bostaurus.MotivoDescarte);
            comando.Parameters.AddWithValue("@observacoes_bostaurus", bostaurus.Observacoes);
        }
    }
}