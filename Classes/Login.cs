using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuralSimples.Classes
{
    class Login
    {
        private string FIDPessoa;
        private string FNome;
        private string FUsuario;
        private string FSenha;

        public string IDPessoa
        {
            get { return FIDPessoa; }
            set { FIDPessoa = value; }
        }
        public string Nome
        {
            get { return FNome; }
            set { FNome = value; }
        }
        public string Usuario
        {
            get { return FUsuario; }
            set { FUsuario = value; }
        }
        public string Senha
        {
            get { return FSenha; }
            set { FSenha = value; }
        }
        public Login ()
        {
            IDPessoa = "";
            Nome = "";
            Usuario = "";
            Senha = "";
        }
        public Login(string idpessoa, string nome, string usuario, string senha)
        {
            this.IDPessoa = idpessoa;
            this.Nome = nome;
            this.Senha = senha;
            this.Usuario = usuario;
        }
    }
}
