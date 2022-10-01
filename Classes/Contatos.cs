using Npgsql;
using RuralSimples.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuralSimples.Classes
{
    class Contato
    {
        private int FIDContato;
        private int FIDPessoa;
        private String FTelefoneFixo;
        private String FCelular;
        private String FFacebook;
        private String FInstagram;
        private String FTwiter;
        private String FTikTok;
        private String FYoutube;
        private String FSite;
        private String FCelularWhats;
        private String FEmail;
        private String FTelefoneRecado;
        private String FNomePessoaRecado;

        private Boolean FEstaVazio;

        public Contato()
        {
            IDContato = 0;
            IDPessoa = 0;
            TelefoneFixo = "";
            Celular = "";
            
            Facebook = "";
            Instagram = "";
            Twiter = "";
            TikTok = "";
            Youtube = "";
            Site = "";
            CelularWhats = "";
            Email = "";
            TelefoneRecado = "";
            NomePessoaRecado = "";

            EstaVazio = true;
        }
        public Contato(int idPessoa, String telefoneFixo, String celular, String facebook, String twiter, String nomePessoaRecado, String instagram, 
            String telefoneRecado, String site, String email, String tiktok, String celularWhats, String youtube)
        {
            preencherClasse(0, idPessoa, telefoneFixo, celular, facebook, twiter, nomePessoaRecado, instagram, telefoneRecado, site, email, tiktok,
                celularWhats, youtube, false);
        }
        public Contato(int idContato, int idPessoa, String telefoneFixo, String celular, String facebook, String twiter, String nomePessoaRecado,
                        String instagram, String telefoneRecado, String site, String email, String tiktok, String celularWhats, String youtube)
        {
            preencherClasse(idContato, idPessoa, telefoneFixo, celular, facebook, twiter, nomePessoaRecado, instagram, telefoneRecado, site, email, tiktok,
                celularWhats, youtube, false);
        }
        public void preencherClasse(int idContato, int idPessoa, String telefoneFixo, String celular, String facebook, String twiter, String nomePessoaRecado,
              String instagram, String telefoneRecado, String site, String email, String tiktok, String celularWhats, String youtube, bool estaVazio)
        {
            this.IDContato = idContato;
            this.IDPessoa = idPessoa;
            this.TelefoneFixo = telefoneFixo;
            this.Celular = celular;
            this.Facebook = facebook;
            this.Twiter = twiter;
            this.Instagram = instagram;
            this.Site = site;
            this.TikTok = tiktok;
            this.Youtube = youtube;
            this.TelefoneRecado = telefoneRecado;
            this.Email = email;
            this.NomePessoaRecado = nomePessoaRecado;
            this.CelularWhats = celularWhats;
            this.EstaVazio = estaVazio;
        }
        public Boolean Salvar()
        {
            Conexao conexao = new Conexao();
            NpgsqlCommand cmd = new NpgsqlCommand();
            try
            { 
                //Comando Sql - Salvando Contatos 
                cmd.CommandText = 
                "insert into contatos (" +
                    "id_contato, " +
                    "id_pessoa, " +
                    "facebook, " +
                    "twiter, " +
                    "linkedin," +
                    "instagram," +
                    "github," +
                    "site," +
                    "pinterest," +
                    "tiktok," +
                    "snapchat," +
                    "skype," +
                    "messeger," +
                    "teams," +
                    "youtube" +
                " ) " + 
                "values(" +
                    "@id_contato, " +
                    "@id_pessoa, " +
                    "@facebook, " +
                    "@twiter, " +
                    "@linkedin," +
                    "@instagram," +
                    "@github," +
                    "@site," +
                    "@pinterest," +
                    "@tiktok," +
                    "@snapchat," +
                    "@skype," +
                    "@messeger," +
                    "@teams," +
                    "@youtube" +
                " )";
                //Parametros
                cmd.Parameters.AddWithValue("@id_contato", this.IDContato);
                cmd.Parameters.AddWithValue("@id_pessoa", this.IDPessoa);
                cmd.Parameters.AddWithValue("@facebook", this.Facebook);
                cmd.Parameters.AddWithValue("@twiter", this.Twiter);
                cmd.Parameters.AddWithValue("@instagram", this.Instagram);
                cmd.Parameters.AddWithValue("@site", this.Site);
                cmd.Parameters.AddWithValue("@tiktok", this.TikTok);
                cmd.Parameters.AddWithValue("@youtube", this.Youtube);
                
                //conectar com banco
                cmd.Connection = conexao.Conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.Desconectar();
                return true;
            }
            catch (NpgsqlException)
            {
                return false;
            }
        }
        public Boolean Salvar(int idPessoa, String telefoneFixo, String celular, String facebook, String twiter, String nomePessoaRecado,
              String instagram, String telefoneRecado, String site, String email, String tiktok, String celularWhats, String youtube, bool estaVazio)
        {
            preencherClasse(0, idPessoa, telefoneFixo, celular, facebook, twiter, nomePessoaRecado, instagram, telefoneRecado, site, email, tiktok, 
                celularWhats, youtube, estaVazio);
            return Salvar();
        }
        public Boolean Salvar(Contato contato)
        {
            return false;/* Salvar(contato.TelefoneFixo, contato.Celular, contato.Facebook, contato.Twiter, contato.Linkedin,
                          contato.Instagram, contato.GitHub, contato.Site, contato.Pinterest, contato.TikTok,
                          contato.Snapchat, contato.Skype, contato.Messeger, contato.Teams, contato.Youtube);*/
        }
        public String TelefoneFixo
        {
            get { return FTelefoneFixo; }
            set { FTelefoneFixo = value; }
        }
        public String Celular
        {
            get { return FCelular; }
            set { FCelular = value; }
        }
        public String CelularWhats
        {
            get { return FCelularWhats; }
            set { FCelularWhats = value; }
        }
        public String Email
        {
            get { return FEmail; }
            set { FEmail = value; }
        }
        public String TelefoneRecado
        {
            get { return FTelefoneRecado; }
            set { FTelefoneRecado = value; }
        }
        public String NomePessoaRecado
        {
            get { return FNomePessoaRecado; }
            set { FNomePessoaRecado = value; }
        }
        public int IDContato
        {
            get { return FIDContato; }
            set { FIDContato = value; }
        }
        public int IDPessoa
        {
            get { return FIDPessoa; }
            set { FIDPessoa = value; }
        }
        public Boolean EstaVazio
        {
            get { return FEstaVazio; }
            set { FEstaVazio = value; }
        }
        public string Facebook
        {
            get { return FFacebook; }
            set { FFacebook = value; }
        }
        public string Twiter
        {
            get { return FTwiter; }
            set { FTwiter = value; }
        }
        public string Instagram
        {
            get { return FInstagram; }
            set { FInstagram = value; }
        }
        public string Site
        {
            get { return FSite; }
            set { FSite = value; }
        }
        public string TikTok
        {
            get { return FTikTok; }
            set { FTikTok = value; }
        }
        public string Youtube
        {
            get { return FYoutube; }
            set { FYoutube = value; }
        }
    }
}
