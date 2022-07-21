
namespace RuralSimples.View
{
    partial class fCadastroPessoa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbTipoPessoa = new System.Windows.Forms.ComboBox();
            this.lbTipoPessoa = new System.Windows.Forms.Label();
            this.eCodigo = new System.Windows.Forms.TextBox();
            this.eInscricaoMunicipal = new System.Windows.Forms.TextBox();
            this.eFazendaFantasia = new System.Windows.Forms.TextBox();
            this.eNome = new System.Windows.Forms.TextBox();
            this.eRG_Inscricao = new System.Windows.Forms.TextBox();
            this.eOrgaoEmissor = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.lbCPFCNPJ = new System.Windows.Forms.Label();
            this.lbNomeRazao = new System.Windows.Forms.Label();
            this.lbFazendaFantasia = new System.Windows.Forms.Label();
            this.lbDataNascimento = new System.Windows.Forms.Label();
            this.lbDataCadastro = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.lbRG_Inscricao = new System.Windows.Forms.Label();
            this.lbInscricaoMunicipal = new System.Windows.Forms.Label();
            this.lbOrgaoEmissor = new System.Windows.Forms.Label();
            this.eCPF_CNPJ = new System.Windows.Forms.MaskedTextBox();
            this.eNascimento = new System.Windows.Forms.MaskedTextBox();
            this.eDataCadastro = new System.Windows.Forms.MaskedTextBox();
            this.cbClassificacao = new System.Windows.Forms.ComboBox();
            this.btNovo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbTipoPessoa
            // 
            this.cbTipoPessoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPessoa.Enabled = false;
            this.cbTipoPessoa.FormattingEnabled = true;
            this.cbTipoPessoa.Items.AddRange(new object[] {
            "Física",
            "Jurídica"});
            this.cbTipoPessoa.Location = new System.Drawing.Point(133, 24);
            this.cbTipoPessoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTipoPessoa.Name = "cbTipoPessoa";
            this.cbTipoPessoa.Size = new System.Drawing.Size(96, 21);
            this.cbTipoPessoa.TabIndex = 1;
            this.cbTipoPessoa.SelectedIndexChanged += new System.EventHandler(this.cbTipoPessoa_SelectedIndexChanged);
            // 
            // lbTipoPessoa
            // 
            this.lbTipoPessoa.AutoSize = true;
            this.lbTipoPessoa.Location = new System.Drawing.Point(130, 10);
            this.lbTipoPessoa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTipoPessoa.Name = "lbTipoPessoa";
            this.lbTipoPessoa.Size = new System.Drawing.Size(81, 13);
            this.lbTipoPessoa.TabIndex = 1;
            this.lbTipoPessoa.Text = "Tipo de Pessoa";
            // 
            // eCodigo
            // 
            this.eCodigo.Location = new System.Drawing.Point(9, 24);
            this.eCodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eCodigo.Name = "eCodigo";
            this.eCodigo.Size = new System.Drawing.Size(120, 20);
            this.eCodigo.TabIndex = 0;
            // 
            // eInscricaoMunicipal
            // 
            this.eInscricaoMunicipal.Enabled = false;
            this.eInscricaoMunicipal.Location = new System.Drawing.Point(442, 140);
            this.eInscricaoMunicipal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eInscricaoMunicipal.Name = "eInscricaoMunicipal";
            this.eInscricaoMunicipal.Size = new System.Drawing.Size(147, 20);
            this.eInscricaoMunicipal.TabIndex = 8;
            // 
            // eFazendaFantasia
            // 
            this.eFazendaFantasia.Enabled = false;
            this.eFazendaFantasia.Location = new System.Drawing.Point(9, 98);
            this.eFazendaFantasia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eFazendaFantasia.Name = "eFazendaFantasia";
            this.eFazendaFantasia.Size = new System.Drawing.Size(580, 20);
            this.eFazendaFantasia.TabIndex = 4;
            // 
            // eNome
            // 
            this.eNome.Enabled = false;
            this.eNome.Location = new System.Drawing.Point(9, 61);
            this.eNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eNome.Name = "eNome";
            this.eNome.Size = new System.Drawing.Size(580, 20);
            this.eNome.TabIndex = 3;
            // 
            // eRG_Inscricao
            // 
            this.eRG_Inscricao.Enabled = false;
            this.eRG_Inscricao.Location = new System.Drawing.Point(123, 140);
            this.eRG_Inscricao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eRG_Inscricao.Name = "eRG_Inscricao";
            this.eRG_Inscricao.Size = new System.Drawing.Size(152, 20);
            this.eRG_Inscricao.TabIndex = 6;
            // 
            // eOrgaoEmissor
            // 
            this.eOrgaoEmissor.Enabled = false;
            this.eOrgaoEmissor.Location = new System.Drawing.Point(288, 140);
            this.eOrgaoEmissor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eOrgaoEmissor.Name = "eOrgaoEmissor";
            this.eOrgaoEmissor.Size = new System.Drawing.Size(140, 20);
            this.eOrgaoEmissor.TabIndex = 7;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(7, 9);
            this.lbID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(40, 13);
            this.lbID.TabIndex = 12;
            this.lbID.Text = "Código";
            // 
            // lbCPFCNPJ
            // 
            this.lbCPFCNPJ.AutoSize = true;
            this.lbCPFCNPJ.Location = new System.Drawing.Point(232, 9);
            this.lbCPFCNPJ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCPFCNPJ.Name = "lbCPFCNPJ";
            this.lbCPFCNPJ.Size = new System.Drawing.Size(27, 13);
            this.lbCPFCNPJ.TabIndex = 13;
            this.lbCPFCNPJ.Text = "CPF";
            // 
            // lbNomeRazao
            // 
            this.lbNomeRazao.AutoSize = true;
            this.lbNomeRazao.Location = new System.Drawing.Point(8, 46);
            this.lbNomeRazao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNomeRazao.Name = "lbNomeRazao";
            this.lbNomeRazao.Size = new System.Drawing.Size(35, 13);
            this.lbNomeRazao.TabIndex = 14;
            this.lbNomeRazao.Text = "Nome";
            // 
            // lbFazendaFantasia
            // 
            this.lbFazendaFantasia.AutoSize = true;
            this.lbFazendaFantasia.Location = new System.Drawing.Point(7, 83);
            this.lbFazendaFantasia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFazendaFantasia.Name = "lbFazendaFantasia";
            this.lbFazendaFantasia.Size = new System.Drawing.Size(48, 13);
            this.lbFazendaFantasia.TabIndex = 15;
            this.lbFazendaFantasia.Text = "Fazenda";
            // 
            // lbDataNascimento
            // 
            this.lbDataNascimento.AutoSize = true;
            this.lbDataNascimento.Location = new System.Drawing.Point(7, 124);
            this.lbDataNascimento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDataNascimento.Name = "lbDataNascimento";
            this.lbDataNascimento.Size = new System.Drawing.Size(63, 13);
            this.lbDataNascimento.TabIndex = 16;
            this.lbDataNascimento.Text = "Nascimento";
            // 
            // lbDataCadastro
            // 
            this.lbDataCadastro.AutoSize = true;
            this.lbDataCadastro.Location = new System.Drawing.Point(475, 9);
            this.lbDataCadastro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDataCadastro.Name = "lbDataCadastro";
            this.lbDataCadastro.Size = new System.Drawing.Size(75, 13);
            this.lbDataCadastro.TabIndex = 17;
            this.lbDataCadastro.Text = "Data Cadastro";
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(348, 9);
            this.lbTipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(69, 13);
            this.lbTipo.TabIndex = 18;
            this.lbTipo.Text = "Classificação";
            // 
            // lbRG_Inscricao
            // 
            this.lbRG_Inscricao.AutoSize = true;
            this.lbRG_Inscricao.Location = new System.Drawing.Point(120, 125);
            this.lbRG_Inscricao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRG_Inscricao.Name = "lbRG_Inscricao";
            this.lbRG_Inscricao.Size = new System.Drawing.Size(23, 13);
            this.lbRG_Inscricao.TabIndex = 19;
            this.lbRG_Inscricao.Text = "RG";
            // 
            // lbInscricaoMunicipal
            // 
            this.lbInscricaoMunicipal.AutoSize = true;
            this.lbInscricaoMunicipal.Location = new System.Drawing.Point(439, 124);
            this.lbInscricaoMunicipal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbInscricaoMunicipal.Name = "lbInscricaoMunicipal";
            this.lbInscricaoMunicipal.Size = new System.Drawing.Size(98, 13);
            this.lbInscricaoMunicipal.TabIndex = 20;
            this.lbInscricaoMunicipal.Text = "Inscrição Municipal";
            // 
            // lbOrgaoEmissor
            // 
            this.lbOrgaoEmissor.AutoSize = true;
            this.lbOrgaoEmissor.Location = new System.Drawing.Point(285, 124);
            this.lbOrgaoEmissor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOrgaoEmissor.Name = "lbOrgaoEmissor";
            this.lbOrgaoEmissor.Size = new System.Drawing.Size(43, 13);
            this.lbOrgaoEmissor.TabIndex = 21;
            this.lbOrgaoEmissor.Text = "Emissor";
            // 
            // eCPF_CNPJ
            // 
            this.eCPF_CNPJ.Enabled = false;
            this.eCPF_CNPJ.Location = new System.Drawing.Point(235, 24);
            this.eCPF_CNPJ.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eCPF_CNPJ.Mask = "000.000.000-00";
            this.eCPF_CNPJ.Name = "eCPF_CNPJ";
            this.eCPF_CNPJ.Size = new System.Drawing.Size(111, 20);
            this.eCPF_CNPJ.TabIndex = 2;
            // 
            // eNascimento
            // 
            this.eNascimento.Enabled = false;
            this.eNascimento.Location = new System.Drawing.Point(9, 140);
            this.eNascimento.Mask = "00/00/0000";
            this.eNascimento.Name = "eNascimento";
            this.eNascimento.Size = new System.Drawing.Size(103, 20);
            this.eNascimento.TabIndex = 5;
            this.eNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // eDataCadastro
            // 
            this.eDataCadastro.Enabled = false;
            this.eDataCadastro.Location = new System.Drawing.Point(478, 23);
            this.eDataCadastro.Mask = "00/00/0000";
            this.eDataCadastro.Name = "eDataCadastro";
            this.eDataCadastro.Size = new System.Drawing.Size(111, 20);
            this.eDataCadastro.TabIndex = 39;
            this.eDataCadastro.TabStop = false;
            this.eDataCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // cbClassificacao
            // 
            this.cbClassificacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClassificacao.Enabled = false;
            this.cbClassificacao.FormattingEnabled = true;
            this.cbClassificacao.Items.AddRange(new object[] {
            "Cliente",
            "Fornecedor",
            "Funcionario",
            "Outro",
            "Parceiro",
            "Propriedade",
            "Sócio"});
            this.cbClassificacao.Location = new System.Drawing.Point(351, 23);
            this.cbClassificacao.Name = "cbClassificacao";
            this.cbClassificacao.Size = new System.Drawing.Size(121, 21);
            this.cbClassificacao.TabIndex = 3;
            // 
            // btNovo
            // 
            this.btNovo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovo.Location = new System.Drawing.Point(3, 8);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(110, 33);
            this.btNovo.TabIndex = 1;
            this.btNovo.Text = "&Novo";
            this.btNovo.UseVisualStyleBackColor = true;
            this.btNovo.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btLimpar);
            this.panel1.Controls.Add(this.btSair);
            this.panel1.Controls.Add(this.btCancelar);
            this.panel1.Controls.Add(this.btSalvar);
            this.panel1.Controls.Add(this.btNovo);
            this.panel1.Location = new System.Drawing.Point(9, 409);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 47);
            this.panel1.TabIndex = 40;
            // 
            // btSalvar
            // 
            this.btSalvar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.Location = new System.Drawing.Point(119, 8);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(110, 33);
            this.btSalvar.TabIndex = 2;
            this.btSalvar.Text = "&Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(235, 8);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(110, 33);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "&Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Location = new System.Drawing.Point(467, 8);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(110, 33);
            this.btSair.TabIndex = 4;
            this.btSair.Text = "Sai&r";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.Location = new System.Drawing.Point(351, 8);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(110, 33);
            this.btLimpar.TabIndex = 5;
            this.btLimpar.Text = "&Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            // 
            // fCadastroPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 465);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbClassificacao);
            this.Controls.Add(this.eDataCadastro);
            this.Controls.Add(this.eNascimento);
            this.Controls.Add(this.eCPF_CNPJ);
            this.Controls.Add(this.lbOrgaoEmissor);
            this.Controls.Add(this.lbInscricaoMunicipal);
            this.Controls.Add(this.lbRG_Inscricao);
            this.Controls.Add(this.lbTipo);
            this.Controls.Add(this.lbDataCadastro);
            this.Controls.Add(this.lbDataNascimento);
            this.Controls.Add(this.lbFazendaFantasia);
            this.Controls.Add(this.lbNomeRazao);
            this.Controls.Add(this.lbCPFCNPJ);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.eOrgaoEmissor);
            this.Controls.Add(this.eRG_Inscricao);
            this.Controls.Add(this.eNome);
            this.Controls.Add(this.eFazendaFantasia);
            this.Controls.Add(this.eInscricaoMunicipal);
            this.Controls.Add(this.eCodigo);
            this.Controls.Add(this.lbTipoPessoa);
            this.Controls.Add(this.cbTipoPessoa);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fCadastroPessoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Pessoas";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTipoPessoa;
        private System.Windows.Forms.Label lbTipoPessoa;
        private System.Windows.Forms.TextBox eCodigo;
        private System.Windows.Forms.TextBox eInscricaoMunicipal;
        private System.Windows.Forms.TextBox eFazendaFantasia;
        private System.Windows.Forms.TextBox eNome;
        private System.Windows.Forms.TextBox eRG_Inscricao;
        private System.Windows.Forms.TextBox eOrgaoEmissor;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbCPFCNPJ;
        private System.Windows.Forms.Label lbNomeRazao;
        private System.Windows.Forms.Label lbFazendaFantasia;
        private System.Windows.Forms.Label lbDataNascimento;
        private System.Windows.Forms.Label lbDataCadastro;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Label lbRG_Inscricao;
        private System.Windows.Forms.Label lbInscricaoMunicipal;
        private System.Windows.Forms.Label lbOrgaoEmissor;
        private System.Windows.Forms.MaskedTextBox eCPF_CNPJ;
        private System.Windows.Forms.MaskedTextBox eNascimento;
        private System.Windows.Forms.MaskedTextBox eDataCadastro;
        private System.Windows.Forms.ComboBox cbClassificacao;
        private System.Windows.Forms.Button btNovo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btLimpar;
    }
}