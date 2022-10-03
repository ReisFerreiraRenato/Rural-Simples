﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RuralSimples.Classes;
using RuralSimples.Fontes_Comuns;
using RuralSimples.Model;

namespace RuralSimples.View
{
    public partial class fReproducao : Form
    {
        public fReproducao()
        {
            InitializeComponent();
        }

        private void ckPrenhez_CheckedChanged(object sender, EventArgs e)
        {
            if ((ckPrenhez.Checked) && (ValidacoesEConstantes.ValidarData(eDataInseminacao)))
            {
                eDataToque.Text = DateTime.Now.ToString();
                if (!ckNaoSeAplicaInseminacao.Checked)
                    eDataPrevisaoParto.Text = DateTime.Parse(eDataInseminacao.Text).AddDays(298).ToString();
            }
        }

        private void btAdicionarEstacaoMonta_Click(object sender, EventArgs e)
        {
            if ((ckPrenhez.Checked) && ValidacoesEConstantes.ValidarData(eDataInseminacao))
            {
                if (ValidacoesEConstantes.MensagemQuestionar("A prenhez foi informada, adicionar a previsão do parto?"))
                {
                    btAdicionarParto_Click(sender, e);
                }
            }
        }

        private void btAdicionarParto_Click(object sender, EventArgs e)
        {
            //
        }

        private void eDataInseminacao_TextChanged(object sender, EventArgs e)
        {
            ValidacoesEConstantes.ValidarDataMensagemErro(eDataInseminacao);
        }

        private void eDataToque_TextChanged(object sender, EventArgs e)
        {
            ValidacoesEConstantes.ValidarDataMensagemErro(eDataToque);
        }

        private void eDataParto_TextChanged(object sender, EventArgs e)
        {
            ValidacoesEConstantes.ValidarDataMensagemErro(eDataParto);
        }

        private void fReproducao_Shown(object sender, EventArgs e)
        {
            //
        }

        private void eIdentificacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((Keys)e.KeyChar == Keys.Enter || (Keys)e.KeyChar == Keys.Return) && (eCodigo.Text != ""))
            {
                int codigo = ValidacoesEConstantes.stringToInteger(eCodigo.Text);
                ControleBosTaurus controleBostaurus = new ControleBosTaurus();
                BosTaurus bostaurus = controleBostaurus.buscarBosTaurusIdBostaurus(codigo);
                if (bostaurus != null)
                {
                    lbNomeAnimal.Text = bostaurus.NomeAnimal;

                }
                else
                {
                    ValidacoesEConstantes.MensagemErro(controleBostaurus.mensagem);
                }
            }
        }
    }
}
