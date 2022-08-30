using Npgsql;
using RuralSimples.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuralSimples.Classes
{
    class Contatos
    {
        private string FIDContato;
        private string FIDPessoa;
        private string[] FTelFixo;
        private string[] FCelular;
        private string FFacebook;
        private string FTwiter;
        private string FLinkedin;
        private string FInstagram;
        private string FGitHub;
        private string FSite;
        private string FPinterest;
        private string FTikTok;
        private string FSnapchat;
        private string FSkype;
        private string FMessenger;
        private string FTeams;
        private string FYoutube;
        private Boolean FEstaVazio;

        public Contatos()
        {
            Guid g = new Guid();
            IDContato = g.ToString();
            IDPessoa = "";
            FTelFixo = null;
            FCelular = null;
            EstaVazio = true;
            Facebook = "";
            Twiter = "";
            Linkedin = "";
            Instagram = "";
            GitHub = "";
            Site = "";
            Pinterest = "";
            TikTok = "";
            Snapchat = "";
            Skype = "";
            Messeger = "";
            Teams = "";
            Youtube = "";
        }
        public Contatos(string[] telefones, string[] celulares, string facebook, string twiter, string linkedin,
                        string instagram, string github, string site, string pinterest, string tiktok,
                        string snapchat, string skype, string messeger, string teams, string youtube)
        {
            Guid g = new Guid();
            IDContato = g.ToString();
            PreencherClasse(telefones, celulares, facebook, twiter, linkedin, instagram, github, site, pinterest, tiktok, 
                snapchat, skype, messeger, teams, youtube);
        }
        public void PreencherClasse(string[] telefones, string[] celulares, string facebook, string twiter, string linkedin,
                                    string instagram, string github, string site, string pinterest, string tiktok,
                                    string snapchat, string skype, string messeger, string teams, string youtube)
        {
            setTelFixo(telefones);
            setCelular(celulares);
            EstaVazio = false;
            Facebook = facebook;
            Twiter = twiter;
            Linkedin = linkedin;
            Instagram = instagram;
            GitHub = github;
            Site = site;
            Pinterest = pinterest;
            TikTok = tiktok;
            Snapchat = snapchat;
            Skype = skype;
            Messeger = messeger;
            Teams = teams;
            Youtube = youtube;
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
                cmd.Parameters.AddWithValue("@linkedin", this.Linkedin);
                cmd.Parameters.AddWithValue("@instagram", this.Instagram);
                cmd.Parameters.AddWithValue("@github", this.GitHub);
                cmd.Parameters.AddWithValue("@site", this.Site);
                cmd.Parameters.AddWithValue("@pinterest", this.Pinterest);
                cmd.Parameters.AddWithValue("@tiktok", this.TikTok);
                cmd.Parameters.AddWithValue("@snapchat", this.Snapchat);
                cmd.Parameters.AddWithValue("@skype", this.Skype);
                cmd.Parameters.AddWithValue("@messeger", this.Messeger);
                cmd.Parameters.AddWithValue("@teams", this.Teams);
                cmd.Parameters.AddWithValue("@youtube", this.Youtube);
                
                //conectar com banco
                cmd.Connection = conexao.Conectar();
                //executar comando
                cmd.ExecuteNonQuery();
                //desconectar
                conexao.Desconectar();
                return true;
            }
            catch (NpgsqlException e)
            {
                return false;
            }
        }
        public Boolean Salvar(string[] telefones, string[] celulares, string facebook, string twiter, string linkedin,
                              string instagram, string github, string site, string pinterest, string tiktok,
                              string snapchat, string skype, string messeger, string teams, string youtube)
        {
            PreencherClasse(telefones, celulares, facebook, twiter, linkedin, instagram, github, site, pinterest, tiktok,
                            snapchat, skype, messeger, teams, youtube);
            return Salvar();
        }
        public Boolean Salvar(Contatos contato)
        {
            string[] cont;

            return Salvar(contato.FTelFixo, contato.FCelular, contato.Facebook, contato.Twiter, contato.Linkedin,
                          contato.Instagram, contato.GitHub, contato.Site, contato.Pinterest, contato.TikTok,
                          contato.Snapchat, contato.Skype, contato.Messeger, contato.Teams, contato.Youtube);
        }
        public void setTelFixo(params string[] telefones) //Validar antes da insercao
        {
            for (int cont = 0; cont <telefones.Length; cont++)
            {
                FTelFixo[cont] = telefones[cont];
            }
        }
        public void setTelFixo(int indice, string telefone) //Validar antes da insercao
        {
            FTelFixo[indice] = telefone;
        }
        public void setCelular(params string[] celular) //Validar antes da insercao
        {
            for (int cont = 0; cont < celular.Length; cont++)
            {
                FTelFixo[cont] = celular[cont];
            }
        }
        public void setCelular(int indice, string celular) //Validar antes da insercao
        {
            FCelular[indice] = celular;
        }
        //Retornar os telefones fixos cadastrados
        public string[] getTelFixo()
        {
            if (FTelFixo.Length>0) //Verificando se está vazio
            {
                return FTelFixo;
            }
            else
            {
                return null;
            }
        }
        //Retornar o telefone fixo pelo indice
        public string getTelFixo(int indice)
        {
            if (string.IsNullOrEmpty(FTelFixo[indice])) //Verificando se está vazio
            {
                return "";
            }
            else
            {
                return FTelFixo[indice];
            }
        }
        //Retornar os celulares cadastrados
        public string[] getTelCelular()
        {
            if (FCelular.Length > 0) //Verificando se está vazio
            {
                return FCelular;
            }
            else
            {
                return null;
            }
        }
        //Retornar os celulares cadastrados pelo índice
        public string getCelular(int indice)
        {
            if (string.IsNullOrEmpty(FCelular[indice])) //Verificando se está vazio
            {
                return null;
            }
            else
            {
                return FCelular[indice];
            }
        }
        public string IDContato
        {
            get { return FIDContato; }
            set { FIDContato = value; }
        }
        public string IDPessoa
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
        public string Linkedin
        {
            get { return FLinkedin; }
            set { FLinkedin = value; }
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
        public string GitHub
        {
            get { return FGitHub; }
            set { FGitHub = value; }
        }
        public string Site
        {
            get { return FSite; }
            set { FSite = value; }
        }
        public string Pinterest
        {
            get { return FPinterest; }
            set { FPinterest = value; }
        }
        public string TikTok
        {
            get { return FTikTok; }
            set { FTikTok = value; }
        }
        public string Snapchat
        {
            get { return FSnapchat; }
            set { FSnapchat = value; }
        }
        public string Skype
        {
            get { return FSkype; }
            set { FSkype = value; }
        }
        public string Messeger
        {
            get { return FMessenger; }
            set { FMessenger = value; }
        }
        public string Teams
        {
            get { return FTeams; }
            set { FTeams = value; }
        }
        public string Youtube
        {
            get { return FYoutube; }
            set { FYoutube = value; }
        }
    }
}
