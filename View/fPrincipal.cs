using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RuralSimples.View;
using RuralSimples.Fontes_Comuns;
using Npgsql;

namespace RuralSimples
{
    public partial class fPrincipal : Form
    {
        public fPrincipal()
        {
            InitializeComponent();
            NpgsqlConnection con = new NpgsqlConnection("Server=34.151.203.114;Port=5432;DataBase=RS_FAZENDA_UNIAO;User Id=postgres;Password= ^GRnI5ts3B*9m#jR;");
            con.Open();
            NpgsqlCommand com = new NpgsqlCommand();
            com.Connection = con;
            com.CommandType = CommandType.Text;
            com.CommandText = "select * from pessoas";
            NpgsqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                DataSet ds = new DataSet();
                dataGridView1.DataSource = dt;
            }
            com.Dispose();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fReproducao reproducao = new fReproducao();
            reproducao.Show();
        }

        private void pbCadastroPessoas_Click(object sender, EventArgs e)
        {
            fCadastroPessoa cadastropessoa = new fCadastroPessoa();
            cadastropessoa.Text = ValidacoesEConstantes.cTituloCadastroPessoas;
            cadastropessoa.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbCadastroAnimais_Click(object sender, EventArgs e)
        {
            fCadastroAnimais cadastroanimais = new fCadastroAnimais();
            cadastroanimais.Text = ValidacoesEConstantes.cTituloCadastroAnimais;
            cadastroanimais.Show();
        }

        private void pbReproducao_Click(object sender, EventArgs e)
        {
            fReproducao reproducao = new fReproducao();
            reproducao.Text = ValidacoesEConstantes.cTituloReproducao;
            reproducao.Show();
        }
    }
}
