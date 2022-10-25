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
        //comandos SQL padrão para buuscar pessoa
        public string sqlBuscarPropriedadePessoa =
            "select " +
                "id_propriedade_pessoa, " +
                "id_pessoa, " +
                "id_propriedade, " +
                "participacao_societaria " +
            "from " +
            "   public.propriedades_pessoas ";
        public string sqlInserirPropriedadePessoa =
            "insert into propriedades_pessoas (" +
                "id_propriedade_pessoa, " +
                "id_pessoa, " +
                "id_propriedade, " +
                "participacao_societaria " +
            ") " +
            " values (" +
                "@id_propriedade_pessoa, " +
                "@id_pessoa, " +
                "@id_propriedade, " +
                "@participacao_societaria " +
        ")";
        public string sqlSalvarPropriedadePessoa =
            "UPDATE public.propriedades_pessoas SET " +
                "id_pessoa = @id_pessoa, " +
                "id_propriedade = @id_propriedade, " +
                "participacao_societaria = @participacao_societaria " +
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
                        "",
                        new DateTime(1900, 1, 1, 1, 0, 0)
                    );
                    this.mensagem = "Propriedade Pessoa encontrada no BD.";
                }
                else
                {
                    propriedadePessoa = null;
                    this.mensagem = "Propriedade Pessoa não encontrada no BD.";
                }
            }
            catch (NpgsqlException e)
            {
                propriedadePessoa = null;
                this.mensagem = "Erro ao acessar o banco de dados! " + e.Message;
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

                this.mensagem = "Propriedade pessoa salvo com sucesso!";
                return true;
            }
            catch (NpgsqlException e)
            {
                this.mensagem = "Erro ao salvar propriedade pessoa! " + e.Message;
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

                this.mensagem = "Propriedade pessoa atualizado com sucesso!";
                return true;
            }
            catch (NpgsqlException e)
            {
                this.mensagem = "Erro ao atualizar cadastro! " + e.Message;
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
        }
        public List<PropriedadePessoa> BuscarPropriedadesPessoa(int id_pessoa)
        {
            List<PropriedadePessoa> propriedadesPessoa = new List<PropriedadePessoa>();
            String sqlBuscarPropriedades =
                "select " +
                "   ppe.id_propriedade_pessoa, " +
                "   ppe.id_pessoa, " +
                "   ppe.id_propriedade, " +
                "   ppe.participacao_societaria, " +
                "   pro.nome_propriedade, " +
                "   pro.data_aquisicao " +
                "from " +
                "   public.propriedades_pessoas as ppe " +
                "inner join propriedades as pro " +
                "on ppe.id_propriedade = pro.id_propriedade " +
                "where id_pessoa = @id_pessoa ";

            cmd.CommandText = sqlBuscarPropriedades;

            cmd.Parameters.AddWithValue("@id_pessoa", id_pessoa);
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
                            dr.GetDateTime(dr.GetOrdinal("data_aquisicao"))
                        );
                        propriedadesPessoa.Add(propriedadePessoa);
                    }
                    this.mensagem = "Propriedade Pessoa encontrada no BD.";
                }
                else
                {
                    propriedadesPessoa = null;
                    this.mensagem = "Propriedade Pessoa não encontrada no BD.";
                }
            }
            catch (NpgsqlException e)
            {
                propriedadesPessoa = null;
                this.mensagem = "Erro ao acessar o banco de dados! " + e.Message;
            }
            return propriedadesPessoa;
        }
    }
}

