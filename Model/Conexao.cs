using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuralSimples.Model
{
    public class Conexao
    {
        NpgsqlConnection con = new NpgsqlConnection();
        //Constructor
        public Conexao()
        {
            con.ConnectionString = "Server = 34.151.203.114; Port = 5432; DataBase = RS_FAZENDA_UNIAO; User Id = postgres; Password = ^GRnI5ts3B * 9m#jR;";
        }
        //Conect
        public NpgsqlConnection Conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        //Desconect
        public void Desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
