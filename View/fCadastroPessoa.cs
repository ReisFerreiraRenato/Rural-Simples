using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuralSimples.View
{
    public partial class fCadastroPessoa : Form
    {
        public fCadastroPessoa()
        {
            InitializeComponent();
        }

        private void cbTipoPessoa_DropDown(object sender, EventArgs e)
        {
            if (cbTipoPessoa.SelectedIndex == 0) {
                eCPF_CNPJ.Mask = "000.000.000-00";
                lbCPFCNPJ.Text = "CPF"; 
            }
            else if (cbTipoPessoa.SelectedIndex == 1)
            {
                eCPF_CNPJ.Mask = "00.000.000/0000-00";
                lbCPFCNPJ.Text = "CNPJ";
            }
        }
    }
}
