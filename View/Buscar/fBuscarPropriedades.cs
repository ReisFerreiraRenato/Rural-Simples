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
    public partial class fBuscarPropriedades : RuralSimples.ViewsBases.fBuscar
    {
        public fBuscarPropriedades()
        {
            InitializeComponent();
        }

        private void eNome_TextChanged(object sender, EventArgs e)
        {
            if (eNome.Text.Trim() != "")
            {
                ControlePropriedade controlePropriedade = new ControlePropriedade();
                List<Propriedade> propriedades = controlePropriedade.BuscarPropriedades(eNome.Text.Trim());

                if (propriedades != null)
                {
                    gdDados.Rows.Clear();
                    gdDados.Refresh();
                    
                    foreach (Propriedade item in propriedades)
                    {
                        gdDados.Rows.Add(
                            Funcoes.NumeroPadrao(item.IDPropriedade),
                            item.Escritura,
                            item.NomePropriedade,
                            Funcoes.DateTimeToStringDate(item.DataAquisicao)
                        );
                    }
                }
            }
        }

        private void fBuscarPropriedades_Shown(object sender, EventArgs e)
        {
            gdDados.Columns[cIdentificador].Visible = false;
        }
    }
}
