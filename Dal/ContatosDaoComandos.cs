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
    class ContatosDaoComandos
    {
        public bool tem = false;
        public String mensagem = "";
        NpgsqlCommand cmd = new NpgsqlCommand();
        Conexao con = new Conexao();
        NpgsqlDataReader dr;

        private const string erro_salvar_contato = "Erro ao salvar/inserir contato! ";
        private const string contato_salvo = "Contato salvo/inserido com sucesso!";
        private const string contato_encontrado = "Contato encontrado no BD.";
        private const string contato_nao_encontrado = "Contato não encontrado no BD.";
        private const string erro_ao_acessar_bd = "Erro ao acessar o banco de dados! ";

        //comandos SQL padrão para buuscar pessoa
        public string sqlBuscarContato =
            "select " +
                "id_contato, " +
                "id_pessoa, " +
                "facebook, " + 
                "instagram, " +
                "twiter, " +
                "tiktok, " +
                "youtube, " +
                "site, " +
                "telefone_fixo, " +
                "celular, " +
                "celular_whatsapp, " +
                "email, " +
                "telefone_recado,  " +
                "nome_pessoa_recado  " +
            "from " +
            "   public.contatos ";
        public string sqlInserirContato =
            "insert into contatos (" +
                "id_pessoa, " +
                "facebook, " +
                "instagram, " +
                "twiter, " +
                "tiktok, " +
                "youtube, " +
                "site, " +
                "telefone_fixo, " +
                "celular, " +
                "celular_whatsapp, " +
                "email, " +
                "telefone_recado, " +
                "nome_pessoa_recado " +
            ") " +
            " values (" +
                "@id_pessoa, " +
                "@facebook, " +
                "@instagram, " +
                "@twiter, " +
                "@tiktok, " +
                "@youtube, " +
                "@site, " +
                "@telefone_fixo, " +
                "@celular, " +
                "@celular_whatsapp, " +
                "@email, " +
                "@telefone_recado, " +
                "@nome_pessoa_recado " +
        ")";
        public string sqlSalvarContato =
            "UPDATE public.contatos SET " +
                "id_pessoa = @id_pessoa, " +
                "facebook = @facebook, " +
                "instagram = @instagram, " +
                "twiter = @twiter, " +
                "tiktok = @tiktok, " +
                "youtube = @youtube, " +
                "site = @site, " +
                "telefone_fixo = @telefone_fixo, " +
                "celular = @celular, " +
                "celular_whatsapp = @celular_whatsapp, " +
                "email = @email, " +
                "telefone_recado = @telefone_recado, " +
                "nome_pessoa_recado = @nome_pessoa_recado " +
            "WHERE  id_contato = @id_contato "
        ;
        public Contato buscarContatoPessoaID(int idPessoa)
        {
            Contato contato = new Contato();
            String where = " where id_pessoa = @idPessoa";

            cmd.CommandText = sqlBuscarContato + where;

            cmd.Parameters.AddWithValue("@idPessoa", idPessoa);
            try
            {
                cmd.Connection = con.Conectar();
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    contato.preencherClasse(
                        Funcoes.StringToInteger(dr["id_contato"].ToString()),
                        Funcoes.StringToInteger(dr["id_pessoa"].ToString()),
                        dr["telefone_fixo"].ToString(),
                        dr["celular"].ToString(),
                        dr["facebook"].ToString(),
                        dr["twiter"].ToString(),
                        dr["nome_pessoa_recado"].ToString(),
                        dr["instagram"].ToString(),
                        dr["telefone_recado"].ToString(),
                        dr["site"].ToString(),
                        dr["email"].ToString(),
                        dr["tiktok"].ToString(),
                        dr["celular_whatsapp"].ToString(),
                        dr["youtube"].ToString(),
                        false
                    );
                    this.mensagem = contato_encontrado;
                }
                else
                {
                    contato = null;
                    this.mensagem = contato_nao_encontrado;
                }
            }
            catch (NpgsqlException e)
            {
                contato = null;
                this.mensagem = erro_ao_acessar_bd + e.Message;
            }
            return contato;
        }
        public bool salvarContato(Contato contato)
        {
            try
            {
                cmd.CommandText = sqlSalvarContato;

                parametrosInserirAtualizar(contato, cmd);

                //conectar com banco
                cmd.Connection = con.Conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                con.Desconectar();

                this.mensagem = contato_salvo;
                return true;
            }
            catch (NpgsqlException e)
            {
                this.mensagem = erro_salvar_contato + erro_ao_acessar_bd + e.Message;
                return false;
            }
        }
        public bool inserirContato(Contato contato)
        {
            try
            {
                cmd.CommandText = sqlInserirContato;

                parametrosInserirAtualizar(contato, cmd);

                //conectar com banco
                cmd.Connection = con.Conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                con.Desconectar();

                this.mensagem = contato_salvo;
                return true;
            }
            catch (NpgsqlException e)
            {
                this.mensagem = erro_salvar_contato + erro_ao_acessar_bd + e.Message;
                return false;
            }
        }
        public void parametrosInserirAtualizar(Contato contato, NpgsqlCommand comando)
        {
            //Parametros
            if (contato.IDContato != 0)
            {
                comando.Parameters.AddWithValue("@id_contato", contato.IDContato);
            }
            comando.Parameters.AddWithValue("@id_pessoa", contato.IDPessoa);
            comando.Parameters.AddWithValue("@facebook", contato.Facebook);
            comando.Parameters.AddWithValue("@instagram", contato.Instagram);
            comando.Parameters.AddWithValue("@twiter", contato.Twiter);
            comando.Parameters.AddWithValue("@tiktok", contato.TikTok);
            comando.Parameters.AddWithValue("@youtube", contato.Youtube);
            comando.Parameters.AddWithValue("@site", contato.Site);
            comando.Parameters.AddWithValue("@telefone_fixo", contato.TelefoneFixo);
            comando.Parameters.AddWithValue("@celular", contato.Celular);
            comando.Parameters.AddWithValue("@celular_whatsapp", contato.CelularWhats);
            comando.Parameters.AddWithValue("@email", contato.Email);
            comando.Parameters.AddWithValue("@telefone_recado", contato.TelefoneRecado);
            comando.Parameters.AddWithValue("@nome_pessoa_recado", contato.NomePessoaRecado);
        }
    }
}
