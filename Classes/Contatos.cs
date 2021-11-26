using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuralSimples.Classes
{
    class Contatos
    {
        private string FIDContatos;
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

        public Contatos()
        {
            Guid g = new Guid();
            IDContatos = g.ToString();
            FTelFixo = null;
            FCelular = null;
            FFacebook = "";
            FTwiter = "";
            FLinkedin = "";
            FInstagram = "";
            FGitHub = "";
            FSite = "";
            FPinterest = "";
            FTikTok = "";
            FSnapchat = "";
            FSkype = "";
            FMessenger = "";
            FTeams = "";
            FYoutube = "";
        }
        public Contatos(string[] telefones, string[] celulares, string facebook, string twiter, string linkedin,
                        string instagram, string github, string site, string pinterest, string tiktok,
                        string snapchat, string skype, string messenger, string teams, string youtube)
        {
            Guid g = new Guid();
            IDContatos = g.ToString();
            setTelFixo(telefones);
            setCelular(celulares);
            FFacebook = facebook;
            FTwiter = twiter;
            FLinkedin = linkedin;
            FInstagram = instagram;
            FGitHub = github;
            FSite = site;
            FPinterest = pinterest;
            FTikTok = tiktok;
            FSnapchat = snapchat;
            FSkype = skype;
            FMessenger = messenger;
            FTeams = teams;
            FYoutube = youtube;
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
        public string IDContatos
        {
            get { return FIDContatos; }
            set { FIDContatos = value; }
        }
        public string facebook
        {
            get { return FFacebook; }
            set { FFacebook = value; }
        }
        public string linkedin
        {
            get { return FLinkedin; }
            set { FLinkedin = value; }
        }
        public string twiter
        {
            get { return FTwiter; }
            set { FTwiter = value; }
        }
        public string instagram
        {
            get { return FInstagram; }
            set { FInstagram = value; }
        }
        public string gitHub
        {
            get { return FGitHub; }
            set { FGitHub = value; }
        }
        public string site
        {
            get { return FSite; }
            set { FSite = value; }
        }
        public string pinterest
        {
            get { return FPinterest; }
            set { FPinterest = value; }
        }
        public string tikTok
        {
            get { return FTikTok; }
            set { FTikTok = value; }
        }
        public string snapchat
        {
            get { return FSnapchat; }
            set { FSnapchat = value; }
        }
        public string skype
        {
            get { return FSkype; }
            set { FSkype = value; }
        }
        public string messeger
        {
            get { return FMessenger; }
            set { FMessenger = value; }
        }
        public string teams
        {
            get { return FTeams; }
            set { FTeams = value; }
        }
        public string youtube
        {
            get { return FYoutube; }
            set { FYoutube = value; }
        }
    }
}
