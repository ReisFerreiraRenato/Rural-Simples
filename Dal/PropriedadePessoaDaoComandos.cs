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
    class PropriedadePessoaDaoComandos
    {
        public bool tem = false;
        public String mensagem = "";
        NpgsqlCommand cmd = new NpgsqlCommand();
        Conexao con = new Conexao();
        NpgsqlDataReader dr;

        private const string erro_salvar_propriedade_pessoa = "Erro ao salvar/inserir propriedade(s) da pessoa! ";
        private const string propriedade_pessoa_salvas = "Propriedade(s) da pessoa atualizada(s)/inserida(s) com sucesso!";
        private const string propriedade_pessoa_encontradas = "Propriedade(s) da pessoa encontrada(s) no BD.";
        private const string propriedade_pessoa_nao_encontradas = "Propriedade(s) da pessoa não encontrada(s) no BD.";
        private const string erro_ao_acessar_bd = "Erro ao acessar o banco de dados! ";
        //comandos SQL padrão para buuscar pessoa
        public string sqlBuscarPropriedadePessoa =
            "select " +
                "id_propriedade_pessoa, " +
                "id_pessoa, " +
                "id_propriedade, " +
                "participacao_societaria, " +
                "inativa " +
            "from " +
            "   public.propriedades_pessoas ";
        public string sqlInserirPropriedadePessoa =
            "insert into propriedades_pessoas (" +
                "id_pessoa, " +
                "id_propriedade, " +
                "participacao_societaria, " +
                "inativa " +
            ") " +
            " values (" +
                "@id_pessoa, " +
                "@id_propriedade, " +
                "@participacao_societaria, " +
                "@inativa " +
        ")";
        public string sqlSalvarPropriedadePessoa =
            "UPDATE public.propriedades_pessoas SET " +
                "id_pessoa = @id_pessoa, " +
                "id_propriedade = @id_propriedade, " +
                "participacao_societaria = @participacao_societaria, " +
                "inativa = @inativa " +
            "WHERE  id_propriedade_pessoa = @id_propriedade_pessoa "
        ;
        
        public PropriedadePessoa BuscarPropriedadePessoa(int id_propriedade)
        {
            PropriedadePessoa propriedadePessoa = new PropriedadePessoa();
            String where = " where id_propriedade = @id_propriedade";

            cmd.CommandText = sqlBuscarPropriedadePessoa + where;

            cmd.Parameters.AddWithValue("@id_propriedade", id_propriedade);
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    propriedadePessoa.PreencherClasse(
                        dr.GetInt32(dr.GetOrdinal("id_propriedade_pessoa")),
                        dr.GetInt32(dr.GetOrdinal("id_pessoa")),
                        dr.GetInt32(dr.GetOrdinal("id_propriedade")),
                        dr.GetInt32(dr.GetOrdinal("participacao_societaria")),
                        dr["nome_propriedade"].ToString(),
                        dr.GetDateTime(dr.GetOrdinal("data_aquisicao")),
                        dr["inativo"].ToString()
                    );
                    this.mensagem = propriedade_pessoa_encontradas;
                }
                else
                {
                    propriedadePessoa = null;
                    this.mensagem = propriedade_pessoa_nao_encontradas;
                }
            }
            catch (NpgsqlException e)
            {
                propriedadePessoa = null;
                this.mensagem = erro_ao_acessar_bd + e.Message;
            }
            return propriedadePessoa;
        }
        public bool SalvarPropriedadePessoa(PropriedadePessoa propriedadePessoa)
        {
            try
            {
                cmd.CommandText = sqlSalvarPropriedadePessoa;

                ParametrosInserirAtualizar(propriedadePessoa, cmd);

                //conectar com banco
                cmd.Connection = con.Conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                con.Desconectar();

                this.mensagem = propriedade_pessoa_salvas;
                return true;
            }
            catch (NpgsqlException e)
            {
                this.mensagem = erro_salvar_propriedade_pessoa + erro_ao_acessar_bd + e.Message;
                return false;
            }
        }
        
        public bool InserirPropriedadePessoa(PropriedadePessoa propriedadePessoa)
        {
            try
            {
                cmd.CommandText = sqlInserirPropriedadePessoa;

                ParametrosInserirAtualizar(propriedadePessoa, cmd);

                //conectar com banco
                cmd.Connection = con.Conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                con.Desconectar();

                this.mensagem = propriedade_pessoa_salvas;
                return true;
            }
            catch (NpgsqlException e)
            {
                this.mensagem = erro_salvar_propriedade_pessoa + erro_ao_acessar_bd + e.Message;
                return false;
            }
        }
        public void ParametrosInserirAtualizar(PropriedadePessoa propriedadePessoa, NpgsqlCommand comando)
        {
            //Parametros
            if (propriedadePessoa.IDPropriedadePessoa != 0)
            {
                comando.Parameters.AddWithValue("@id_propriedade_pessoa", propriedadePessoa.IDPropriedadePessoa);
            }
            comando.Parameters.AddWithValue("@id_pessoa", propriedadePessoa.IDPessoa);
            comando.Parameters.AddWithValue("@id_propriedade", propriedadePessoa.IDPropriedade);
            comando.Parameters.AddWithValue("@participacao_societaria", propriedadePessoa.ParticipacaoSocietaria);
            comando.Parameters.AddWithValue("@inativa", propriedadePessoa.Inativo);
        }
        public List<PropriedadePessoa> BuscarPropriedadesPessoaAtivas(int id_pessoa)
        {
            return BuscarPropriedadesPessoa(id_pessoa, "N");
        }
        public List<PropriedadePessoa> BuscarPropriedadesPessoaInativas(int id_pessoa)
        {
            return BuscarPropriedadesPessoa(id_pessoa, "S");
        }
        public List<PropriedadePessoa> BuscarPropriedadesPessoaTodas(int id_pessoa)
        {
            return BuscarPropriedadesPessoa(id_pessoa, "");
        }
        public List<PropriedadePessoa> BuscarPropriedadesPessoa(int id_pessoa, String inativa)
        {
            List<PropriedadePessoa> propriedadesPessoa = new List<PropriedadePessoa>();
            String sqlBuscarPropriedades =
                "select " +
                "   ppe.id_propriedade_pessoa, " +
                "   ppe.id_pessoa, " +
                "   ppe.id_propriedade, " +
                "   ppe.participacao_societaria, " +
                "   pro.nome_propriedade, " +
                "   pro.data_aquisicao, " +
                "   ppe.inativa " +
                "from " +
                "   public.propriedades_pessoas as ppe " +
                "inner join propriedades as pro " +
                "on ppe.id_propriedade = pro.id_propriedade " +
                "where ppe.id_pessoa = @id_pessoa " +
                (inativa != "" ? "and ppe.inativa = @inativa " : "") +
                "order by ppe.id_propriedade";

            cmd.CommandText = sqlBuscarPropriedades;

            cmd.Parameters.AddWithValue("@id_pessoa", id_pessoa);
            if (inativa != "")
                cmd.Parameters.AddWithValue("@inativa", inativa);
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        PropriedadePessoa propriedadePessoa = new PropriedadePessoa(
                            dr.GetInt32(dr.GetOrdinal("id_propriedade_pessoa")),
                            dr.GetInt32(dr.GetOrdinal("id_pessoa")),
                            dr.GetInt32(dr.GetOrdinal("id_propriedade")),
                            dr.GetInt32(dr.GetOrdinal("participacao_societaria")),
                            dr["nome_propriedade"].ToString(),
                            dr.GetDateTime(dr.GetOrdinal("data_aquisicao")),
                            dr["inativa"].ToString()
                        );
                        propriedadesPessoa.Add(propriedadePessoa);
                    }
                    this.mensagem = propriedade_pessoa_encontradas;
                }
                else
                {
                    propriedadesPessoa = null;
                    this.mensagem = propriedade_pessoa_nao_encontradas;
                }
            }
            catch (NpgsqlException e)
            {
                propriedadesPessoa = null;
                this.mensagem = erro_ao_acessar_bd + e.Message;
            }
            return propriedadesPessoa;
        }
    }
}

