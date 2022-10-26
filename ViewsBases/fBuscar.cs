using RuralSimples.Fontes_Comuns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuralSimples.ViewsBases
{
    public partial class fBuscar : Form
    {
        public fBuscar()
        {
            InitializeComponent();
        }
        //Colunas da grid
        protected const int cId = 0;
        protected const int cIdentificador = 1;
        protected const int cNome = 2;
        protected const int cDataCadastro = 3;

        public String codigo = "";

        private void gdDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btSelecionar_Click(gdDados, null);
        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            if (gdDados.CurrentRow.Cells[cId].Value == null)
            {
                Funcoes.MensagemErro("Favor selecionar um registro válido!");
                gdDados.Focus();
                return;
            }
            codigo = gdDados.CurrentRow.Cells[cId].Value.ToString();
            Close();
        }

        private void fBuscar_Shown(object sender, EventArgs e)
        {
            gdDados.Columns[cIdentificador].Visible = false;
        }
    }
}
