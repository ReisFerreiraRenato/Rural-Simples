﻿using Npgsql;
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
    class PropriedadeDaoComandos
    {
        public bool tem = false;
        public String mensagem = "";
        NpgsqlCommand cmd = new NpgsqlCommand();
        Conexao con = new Conexao();
        NpgsqlDataReader dr;
        private const string sqlRetornarIdentity = "; select max(id_propriedade) from propriedades";
        
        private const string erro_salvar_propriedades = "Erro ao salvar propriedade(s)! ";
        private const string propriedades_salvas = "Propriedade(s) salva(s) com sucesso!";
        private const string propriedades_encontradas = "Propriedade(s) encontrada(s) no BD.";
        private const string propriedades_não_encontradas = "Propriedade(s) não encontrada(s) no BD.";
        private const string erro_ao_acessar_bd = "Erro ao acessar o banco de dados! ";
        //comandos SQL padrão para buuscar pessoa
        public string sqlBuscarPropriedade =
            "select " +
                "id_propriedade, " +
                "aptidao, " +
                "area_produtiva, " +
                "area_reserva, " +
                "area_total, " +
                "car, " +
                "data_aquisicao, " +
                "data_venda, " +
                "escritura, " +
                "inativa, " +
                "itr, " +
                "latitude, " +
                "longitude, " +
                "motivo_venda,  " +
                "nome_propriedade  " +
            "from " +
            "   public.propriedades ";
        public string sqlInserirPropriedade =
            "insert into propriedades (" +
                "id_propriedade, " +
                "aptidao, " +
                "area_produtiva, " +
                "area_reserva, " +
                "area_total, " +
                "car, " +
                "data_aquisicao, " +
                "data_venda, " +
                "escritura, " +
                "inativa, " +
                "itr, " +
                "latitude, " +
                "longitude, " +
                "motivo_venda,  " +
                "nome_propriedade  " +
            ") " +
            " values (" +
                "@id_propriedade, " +
                "@aptidao, " +
                "@area_produtiva, " +
                "@area_reserva, " +
                "@area_total, " +
                "@car, " +
                "@data_aquisicao, " +
                "@data_venda, " +
                "@escritura, " +
                "@inativa, " +
                "@itr, " +
                "@latitude, " +
                "@longitude, " +
                "@motivo_venda, " +
                "@nome_propriedade  " +
        ")";
        public string sqlSalvarPropriedade =
            "UPDATE public.propriedades SET " +
                "aptidao = @aptidao, " +
                "area_produtiva = @area_produtiva, " +
                "area_reserva = @area_reserva, " +
                "area_total = @area_total, " +
                "car = @car, " +
                "data_aquisicao = @data_aquisicao, " +
                "data_venda = @data_venda, " +
                "escritura = @escritura, " +
                "inativa = @inativa, " +
                "itr = @itr, " +
                "latitude = @latitude, " +
                "longitude = @longitude, " +
                "motivo_venda = @motivo_venda, " +
                "nome_propriedade = @nome_propriedade  " +
            "WHERE  id_propriedade = @id_propriedade "
        ;
        public void parametrosInserirAtualizar(Propriedade propriedade, NpgsqlCommand comando)
        {
            //Parametros
            if (propriedade.IDPropriedade != 0)
            {
                comando.Parameters.AddWithValue("@id_propriedade", propriedade.IDPropriedade);
            }
            comando.Parameters.AddWithValue("@aptidao", propriedade.Aptidao);
            comando.Parameters.AddWithValue("@area_produtiva", propriedade.AreaProdutiva);
            comando.Parameters.AddWithValue("@area_reserva", propriedade.AreaReserva);
            comando.Parameters.AddWithValue("@area_total", propriedade.AreaTotal);
            comando.Parameters.AddWithValue("@car", propriedade.CAR);
            comando.Parameters.AddWithValue("@data_aquisicao", propriedade.DataAquisicao);
            comando.Parameters.AddWithValue("@data_venda", propriedade.DataVenda);
            comando.Parameters.AddWithValue("@escritura", propriedade.Escritura);
            comando.Parameters.AddWithValue("@inativa", propriedade.Inativa);
            comando.Parameters.AddWithValue("@itr", propriedade.ITR);
            comando.Parameters.AddWithValue("@latitude", propriedade.Latitude);
            comando.Parameters.AddWithValue("@longitude", propriedade.Longitude);
            comando.Parameters.AddWithValue("@motivo_venda", propriedade.MotivoVenda);
        }
        public bool SalvarPropriedade(Propriedade propriedade)
        {
            try
            {
                cmd.CommandText = sqlSalvarPropriedade;

                parametrosInserirAtualizar(propriedade, cmd);

                //conectar com banco
                cmd.Connection = con.Conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                con.Desconectar();

                this.mensagem = propriedades_salvas;
                return true;
            }
            catch (NpgsqlException e)
            {
                this.mensagem = erro_salvar_propriedades + " " + erro_ao_acessar_bd + e.Message;
                return false;
            }
        }
        public bool InserirPropriedade(Propriedade propriedade)
        {
            try
            {
                cmd.CommandText = sqlInserirPropriedade + sqlRetornarIdentity;

                parametrosInserirAtualizar(propriedade, cmd);

                //conectar com banco
                cmd.Connection = con.Conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                con.Desconectar();

                this.mensagem = propriedades_salvas;
                return true;
            }
            catch (NpgsqlException e)
            {
                this.mensagem = erro_salvar_propriedades + " " + erro_ao_acessar_bd + e.Message;
                return false;
            }
        }
        public Propriedade BuscarPropriedadeIdPropriedade(int idPropriedade, String inativa)
        {
            Propriedade propriedade = new Propriedade();
            String where = " where id_propriedade = @idPropriedade and inativa = @inativa";

            cmd.CommandText = sqlBuscarPropriedade + where;

            cmd.Parameters.AddWithValue("@idPropriedade", Convert.ToInt32(idPropriedade));
            cmd.Parameters.AddWithValue("@inativa", inativa);
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                dr.Read();

                if (dr.HasRows)
                {
                    propriedade.PreencherClasse(
                        dr.GetInt32(dr.GetOrdinal("id_propriedade")),
                        dr["aptidao"].ToString(),
                        dr.GetDouble(dr.GetOrdinal("area_produtiva")),
                        dr.GetDouble(dr.GetOrdinal("area_reserva")),
                        dr.GetDouble(dr.GetOrdinal("area_total")),
                        dr["car"].ToString(),
                        dr.GetDateTime(dr.GetOrdinal("data_aquisicao")),
                        Funcoes.StringToDateTime(dr["data_venda"].ToString()),
                        dr["escritura"].ToString(),
                        dr["itr"].ToString(),
                        dr["inativa"].ToString(),
                        dr["latitude"].ToString(),
                        dr["longitude"].ToString(),
                        dr["motivo_venda"].ToString(),
                        dr["nome_propriedade"].ToString()
                    );

                    this.mensagem = propriedades_encontradas;
                }
                else
                {
                    propriedade = null;
                    this.mensagem = propriedades_não_encontradas;
                }
            }
            catch (NpgsqlException e)
            {
                propriedade = null;
                this.mensagem = erro_ao_acessar_bd + e.Message;
            }
            return propriedade;
        }
        public List<Propriedade> BuscarPropriedades(int id_pessoa)
        {
            List<Propriedade> propriedades = new List<Propriedade>();
            
            String where = " where id_pessoa = @id_pessoa";

            cmd.CommandText = sqlBuscarPropriedade + where;

            cmd.Parameters.AddWithValue("@id_pessoa", id_pessoa);
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Propriedade propriedade = new Propriedade(
                            dr.GetInt32(dr.GetOrdinal("id_propriedade")),
                            dr["aptidao"].ToString(),
                            dr.GetDouble(dr.GetOrdinal("area_produtiva")),
                            dr.GetDouble(dr.GetOrdinal("area_reserva")),
                            dr.GetDouble(dr.GetOrdinal("area_total")),
                            dr["car"].ToString(),
                            dr.GetDateTime(dr.GetOrdinal("data_aquisicao")),
                            Funcoes.StringToDateTime(dr["data_venda"].ToString()),
                            dr["escritura"].ToString(),
                            dr["itr"].ToString(),
                            dr["inativa"].ToString(),
                            dr["latitude"].ToString(),
                            dr["longitude"].ToString(),
                            dr["motivo_venda"].ToString(),
                            dr["nome_propriedade"].ToString()
                        );
                        propriedades.Add(propriedade);
                    }
                    this.mensagem = propriedades_encontradas;
                }
                else
                {
                    propriedades = null;
                    this.mensagem = propriedades_não_encontradas;
                }
            }
            catch (NpgsqlException e)
            {
                propriedades = null;
                this.mensagem = erro_ao_acessar_bd + e.Message;
            }
            return propriedades;
        }
        public List<Propriedade> BuscarPropriedades(String nome_propriedade)
        {
            List<Propriedade> propriedades = new List<Propriedade>();

            String where = " where nome_propriedade like @nome_propriedade";

            cmd.CommandText = sqlBuscarPropriedade + where;

            nome_propriedade += "%";

            cmd.Parameters.AddWithValue("@nome_propriedade", nome_propriedade);
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Propriedade propriedade = new Propriedade(
                            dr.GetInt32(dr.GetOrdinal("id_propriedade")),
                            dr["aptidao"].ToString(),
                            dr.GetDouble(dr.GetOrdinal("area_produtiva")),
                            dr.GetDouble(dr.GetOrdinal("area_reserva")),
                            dr.GetDouble(dr.GetOrdinal("area_total")),
                            dr["car"].ToString(),
                            dr.GetDateTime(dr.GetOrdinal("data_aquisicao")),
                            Funcoes.StringToDateTime(dr["data_venda"].ToString()),//  dr.GetDateTime(dr.GetOrdinal("data_venda")),
                            dr["escritura"].ToString(),
                            dr["itr"].ToString(),
                            dr["inativa"].ToString(),
                            dr["latitude"].ToString(),
                            dr["longitude"].ToString(),
                            dr["motivo_venda"].ToString(),
                            dr["nome_propriedade"].ToString()
                        );
                        propriedades.Add(propriedade);
                    }
                    this.mensagem = propriedades_encontradas;
                }
                else
                {
                    propriedades = null;
                    this.mensagem = propriedades_não_encontradas;
                }
            }
            catch (NpgsqlException e)
            {
                propriedades = null;
                this.mensagem = erro_ao_acessar_bd + e.Message;
            }
            return propriedades;
        }
    }
}
