using RuralSimples.Classes;
using RuralSimples.Fontes_Comuns;
using RuralSimples.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RuralSimples.View
{
    public partial class fBuscarPessoa : RuralSimples.ViewsBases.fBuscar
    {
        public fBuscarPessoa()
        {
            InitializeComponent();
        }

        private void eNome_TextChanged(object sender, EventArgs e)
        {
            if (eNome.Text.Trim() != "")
            {
                ControlePessoas controlePessoas = new ControlePessoas();
                List<Pessoa> pessoas = new List<Pessoa>();
                int cont = 0;

                pessoas = controlePessoas.buscarPessoasPorNome(eNome.Text.Trim());

                if (pessoas != null)
                {
                    gdDados.Rows.Clear();
                    gdDados.Refresh();
                    foreach (Pessoa item in pessoas)
                    {
                        gdDados.Rows[cont].Cells[cId].Value = Funcoes.NumeroPadrao(item.IDPessoa);
                        //gdDados.Rows[cont].Cells[cIdentificador].Value = Funcoes.DateTimeToStringDate(vacinacao.DataVacinacao);
                        gdDados.Rows[cont].Cells[cNome].Value = item.NomeRazaoSocial;
                        gdDados.Rows[cont].Cells[cDataCadastro].Value = Funcoes.DateTimeToStringDate(item.DataCadastro);
                        cont++;
                    }
                }
            }
        }

        private void fBuscarPessoa_Scroll(object sender, ScrollEventArgs e)
        {
            gdDados.Columns[cIdentificador].Visible = false;
        }

        private void btSelecionar_Click(object sender, EventArgs e)
        {
            if (!this.erro.Equals(""))
            { 
                Funcoes.MensagemErro(this.erro);
            }
        }
    }
}
