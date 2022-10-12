using RuralSimples.Dal;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuralSimples.Model
{
    public class ControleLogin
    {
        public bool tem;
        public String mensagem = "";

        public bool Acessar(String login, String senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.VerificarLogin(login, senha);
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }    
            return tem;
        }
        public String cadastrar(String login, String senha, String confirmarSenha)
        {
            return mensagem;
        }
    }
}
