
namespace RuralSimples.View
{
    partial class fReproducao
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fReproducao));
            this.lbIdentificacao = new System.Windows.Forms.Label();
            this.eIdentificacao = new System.Windows.Forms.TextBox();
            this.pnEstacoesMonta = new System.Windows.Forms.Panel();
            this.eDataToque = new System.Windows.Forms.MaskedTextBox();
            this.eDataInseminacao = new System.Windows.Forms.MaskedTextBox();
            this.ckPrenhez = new System.Windows.Forms.CheckBox();
            this.lbDataConfirmacao = new System.Windows.Forms.Label();
            this.pnTituloEstacoesMonta = new System.Windows.Forms.Panel();
            this.ckNaoSeAplicaInseminacao = new System.Windows.Forms.CheckBox();
            this.lbEstacoesMonta = new System.Windows.Forms.Label();
            this.lbIdentificacaoPai = new System.Windows.Forms.Label();
            this.lbDataInseminacao = new System.Windows.Forms.Label();
            this.btAdicionarEstacaoMonta = new System.Windows.Forms.Button();
            this.eNomePai = new System.Windows.Forms.TextBox();
            this.dgEstacoesMonta = new System.Windows.Forms.DataGridView();
            this.clDataInseminacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPaiInseminacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrenha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDataToque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnPartos = new System.Windows.Forms.Panel();
            this.eDataParto = new System.Windows.Forms.MaskedTextBox();
            this.eDataPrevisaoParto = new System.Windows.Forms.MaskedTextBox();
            this.lbDataPrevisaoParto = new System.Windows.Forms.Label();
            this.pnTituloPartos = new System.Windows.Forms.Panel();
            this.lbPartos = new System.Windows.Forms.Label();
            this.lbObservacaoParto = new System.Windows.Forms.Label();
            this.lbDataParto = new System.Windows.Forms.Label();
            this.btAdicionarParto = new System.Windows.Forms.Button();
            this.eObservacaoParto = new System.Windows.Forms.TextBox();
            this.dgPartos = new System.Windows.Forms.DataGridView();
            this.clPrevisaoParto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDataParto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clObservacoesParto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pnEstacoesMonta.SuspendLayout();
            this.pnTituloEstacoesMonta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEstacoesMonta)).BeginInit();
            this.pnPartos.SuspendLayout();
            this.pnTituloPartos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPartos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbIdentificacao
            // 
            this.lbIdentificacao.AutoSize = true;
            this.lbIdentificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdentificacao.Location = new System.Drawing.Point(8, 44);
            this.lbIdentificacao.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbIdentificacao.Name = "lbIdentificacao";
            this.lbIdentificacao.Size = new System.Drawing.Size(121, 25);
            this.lbIdentificacao.TabIndex = 33;
            this.lbIdentificacao.Text = "Identificação";
            // 
            // eIdentificacao
            // 
            this.eIdentificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eIdentificacao.Location = new System.Drawing.Point(141, 41);
            this.eIdentificacao.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.eIdentificacao.Name = "eIdentificacao";
            this.eIdentificacao.Size = new System.Drawing.Size(220, 30);
            this.eIdentificacao.TabIndex = 0;
            // 
            // pnEstacoesMonta
            // 
            this.pnEstacoesMonta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnEstacoesMonta.Controls.Add(this.eDataToque);
            this.pnEstacoesMonta.Controls.Add(this.eDataInseminacao);
            this.pnEstacoesMonta.Controls.Add(this.ckPrenhez);
            this.pnEstacoesMonta.Controls.Add(this.lbDataConfirmacao);
            this.pnEstacoesMonta.Controls.Add(this.pnTituloEstacoesMonta);
            this.pnEstacoesMonta.Controls.Add(this.lbIdentificacaoPai);
            this.pnEstacoesMonta.Controls.Add(this.lbDataInseminacao);
            this.pnEstacoesMonta.Controls.Add(this.btAdicionarEstacaoMonta);
            this.pnEstacoesMonta.Controls.Add(this.eNomePai);
            this.pnEstacoesMonta.Controls.Add(this.dgEstacoesMonta);
            this.pnEstacoesMonta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnEstacoesMonta.Location = new System.Drawing.Point(6, 87);
            this.pnEstacoesMonta.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pnEstacoesMonta.Name = "pnEstacoesMonta";
            this.pnEstacoesMonta.Size = new System.Drawing.Size(740, 329);
            this.pnEstacoesMonta.TabIndex = 1;
            // 
            // eDataToque
            // 
            this.eDataToque.Location = new System.Drawing.Point(448, 81);
            this.eDataToque.Mask = "00/00/0000";
            this.eDataToque.Name = "eDataToque";
            this.eDataToque.Size = new System.Drawing.Size(154, 30);
            this.eDataToque.TabIndex = 4;
            this.eDataToque.ValidatingType = typeof(System.DateTime);
            this.eDataToque.TextChanged += new System.EventHandler(this.eDataToque_TextChanged);
            // 
            // eDataInseminacao
            // 
            this.eDataInseminacao.Location = new System.Drawing.Point(5, 81);
            this.eDataInseminacao.Mask = "00/00/0000";
            this.eDataInseminacao.Name = "eDataInseminacao";
            this.eDataInseminacao.Size = new System.Drawing.Size(160, 30);
            this.eDataInseminacao.TabIndex = 2;
            this.eDataInseminacao.ValidatingType = typeof(System.DateTime);
            this.eDataInseminacao.TextChanged += new System.EventHandler(this.eDataInseminacao_TextChanged);
            // 
            // ckPrenhez
            // 
            this.ckPrenhez.AutoSize = true;
            this.ckPrenhez.Location = new System.Drawing.Point(614, 49);
            this.ckPrenhez.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ckPrenhez.Name = "ckPrenhez";
            this.ckPrenhez.Size = new System.Drawing.Size(97, 29);
            this.ckPrenhez.TabIndex = 5;
            this.ckPrenhez.Text = "Prenha";
            this.ckPrenhez.UseVisualStyleBackColor = true;
            this.ckPrenhez.CheckedChanged += new System.EventHandler(this.ckPrenhez_CheckedChanged);
            // 
            // lbDataConfirmacao
            // 
            this.lbDataConfirmacao.AutoSize = true;
            this.lbDataConfirmacao.Location = new System.Drawing.Point(443, 50);
            this.lbDataConfirmacao.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbDataConfirmacao.Name = "lbDataConfirmacao";
            this.lbDataConfirmacao.Size = new System.Drawing.Size(115, 25);
            this.lbDataConfirmacao.TabIndex = 34;
            this.lbDataConfirmacao.Text = "Data Toque";
            // 
            // pnTituloEstacoesMonta
            // 
            this.pnTituloEstacoesMonta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnTituloEstacoesMonta.Controls.Add(this.ckNaoSeAplicaInseminacao);
            this.pnTituloEstacoesMonta.Controls.Add(this.lbEstacoesMonta);
            this.pnTituloEstacoesMonta.Location = new System.Drawing.Point(-2, -2);
            this.pnTituloEstacoesMonta.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pnTituloEstacoesMonta.Name = "pnTituloEstacoesMonta";
            this.pnTituloEstacoesMonta.Size = new System.Drawing.Size(1338, 33);
            this.pnTituloEstacoesMonta.TabIndex = 0;
            // 
            // ckNaoSeAplicaInseminacao
            // 
            this.ckNaoSeAplicaInseminacao.AutoSize = true;
            this.ckNaoSeAplicaInseminacao.Location = new System.Drawing.Point(14, 4);
            this.ckNaoSeAplicaInseminacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ckNaoSeAplicaInseminacao.Name = "ckNaoSeAplicaInseminacao";
            this.ckNaoSeAplicaInseminacao.Size = new System.Drawing.Size(152, 29);
            this.ckNaoSeAplicaInseminacao.TabIndex = 1;
            this.ckNaoSeAplicaInseminacao.Text = "Não se aplica";
            this.ckNaoSeAplicaInseminacao.UseVisualStyleBackColor = true;
            // 
            // lbEstacoesMonta
            // 
            this.lbEstacoesMonta.AutoSize = true;
            this.lbEstacoesMonta.Location = new System.Drawing.Point(275, 4);
            this.lbEstacoesMonta.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbEstacoesMonta.Name = "lbEstacoesMonta";
            this.lbEstacoesMonta.Size = new System.Drawing.Size(180, 25);
            this.lbEstacoesMonta.TabIndex = 23;
            this.lbEstacoesMonta.Text = "Estações de Monta";
            // 
            // lbIdentificacaoPai
            // 
            this.lbIdentificacaoPai.AutoSize = true;
            this.lbIdentificacaoPai.Location = new System.Drawing.Point(172, 50);
            this.lbIdentificacaoPai.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbIdentificacaoPai.Name = "lbIdentificacaoPai";
            this.lbIdentificacaoPai.Size = new System.Drawing.Size(154, 25);
            this.lbIdentificacaoPai.TabIndex = 30;
            this.lbIdentificacaoPai.Text = "Identificação Pai";
            // 
            // lbDataInseminacao
            // 
            this.lbDataInseminacao.AutoSize = true;
            this.lbDataInseminacao.Location = new System.Drawing.Point(1, 50);
            this.lbDataInseminacao.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbDataInseminacao.Name = "lbDataInseminacao";
            this.lbDataInseminacao.Size = new System.Drawing.Size(111, 25);
            this.lbDataInseminacao.TabIndex = 29;
            this.lbDataInseminacao.Text = "Data Insem";
            // 
            // btAdicionarEstacaoMonta
            // 
            this.btAdicionarEstacaoMonta.Location = new System.Drawing.Point(614, 79);
            this.btAdicionarEstacaoMonta.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btAdicionarEstacaoMonta.Name = "btAdicionarEstacaoMonta";
            this.btAdicionarEstacaoMonta.Size = new System.Drawing.Size(118, 32);
            this.btAdicionarEstacaoMonta.TabIndex = 6;
            this.btAdicionarEstacaoMonta.Text = "Adicionar";
            this.btAdicionarEstacaoMonta.UseVisualStyleBackColor = true;
            this.btAdicionarEstacaoMonta.Click += new System.EventHandler(this.btAdicionarEstacaoMonta_Click);
            // 
            // eNomePai
            // 
            this.eNomePai.Location = new System.Drawing.Point(177, 81);
            this.eNomePai.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.eNomePai.Name = "eNomePai";
            this.eNomePai.Size = new System.Drawing.Size(259, 30);
            this.eNomePai.TabIndex = 3;
            // 
            // dgEstacoesMonta
            // 
            this.dgEstacoesMonta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEstacoesMonta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clDataInseminacao,
            this.clPaiInseminacao,
            this.clPrenha,
            this.clDataToque});
            this.dgEstacoesMonta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgEstacoesMonta.Location = new System.Drawing.Point(6, 127);
            this.dgEstacoesMonta.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.dgEstacoesMonta.MultiSelect = false;
            this.dgEstacoesMonta.Name = "dgEstacoesMonta";
            this.dgEstacoesMonta.RowHeadersVisible = false;
            this.dgEstacoesMonta.RowHeadersWidth = 51;
            this.dgEstacoesMonta.RowTemplate.Height = 24;
            this.dgEstacoesMonta.Size = new System.Drawing.Size(727, 197);
            this.dgEstacoesMonta.TabIndex = 7;
            // 
            // clDataInseminacao
            // 
            this.clDataInseminacao.HeaderText = "Dt Inseminação";
            this.clDataInseminacao.MinimumWidth = 6;
            this.clDataInseminacao.Name = "clDataInseminacao";
            this.clDataInseminacao.Width = 175;
            // 
            // clPaiInseminacao
            // 
            this.clPaiInseminacao.HeaderText = "Indentificação pai";
            this.clPaiInseminacao.MinimumWidth = 6;
            this.clPaiInseminacao.Name = "clPaiInseminacao";
            this.clPaiInseminacao.Width = 295;
            // 
            // clPrenha
            // 
            this.clPrenha.HeaderText = "Prenha";
            this.clPrenha.MinimumWidth = 6;
            this.clPrenha.Name = "clPrenha";
            this.clPrenha.Width = 85;
            // 
            // clDataToque
            // 
            this.clDataToque.HeaderText = "Data Toque";
            this.clDataToque.MinimumWidth = 6;
            this.clDataToque.Name = "clDataToque";
            this.clDataToque.Width = 147;
            // 
            // pnPartos
            // 
            this.pnPartos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnPartos.Controls.Add(this.eDataParto);
            this.pnPartos.Controls.Add(this.eDataPrevisaoParto);
            this.pnPartos.Controls.Add(this.lbDataPrevisaoParto);
            this.pnPartos.Controls.Add(this.pnTituloPartos);
            this.pnPartos.Controls.Add(this.lbObservacaoParto);
            this.pnPartos.Controls.Add(this.lbDataParto);
            this.pnPartos.Controls.Add(this.btAdicionarParto);
            this.pnPartos.Controls.Add(this.eObservacaoParto);
            this.pnPartos.Controls.Add(this.dgPartos);
            this.pnPartos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnPartos.Location = new System.Drawing.Point(6, 416);
            this.pnPartos.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pnPartos.Name = "pnPartos";
            this.pnPartos.Size = new System.Drawing.Size(740, 351);
            this.pnPartos.TabIndex = 2;
            // 
            // eDataParto
            // 
            this.eDataParto.Location = new System.Drawing.Point(148, 71);
            this.eDataParto.Mask = "00/00/0000";
            this.eDataParto.Name = "eDataParto";
            this.eDataParto.Size = new System.Drawing.Size(116, 30);
            this.eDataParto.TabIndex = 9;
            this.eDataParto.ValidatingType = typeof(System.DateTime);
            this.eDataParto.TextChanged += new System.EventHandler(this.eDataParto_TextChanged);
            // 
            // eDataPrevisaoParto
            // 
            this.eDataPrevisaoParto.Location = new System.Drawing.Point(6, 71);
            this.eDataPrevisaoParto.Mask = "00/00/0000";
            this.eDataPrevisaoParto.Name = "eDataPrevisaoParto";
            this.eDataPrevisaoParto.Size = new System.Drawing.Size(126, 30);
            this.eDataPrevisaoParto.TabIndex = 8;
            this.eDataPrevisaoParto.ValidatingType = typeof(System.DateTime);
            // 
            // lbDataPrevisaoParto
            // 
            this.lbDataPrevisaoParto.AutoSize = true;
            this.lbDataPrevisaoParto.Location = new System.Drawing.Point(1, 40);
            this.lbDataPrevisaoParto.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbDataPrevisaoParto.Name = "lbDataPrevisaoParto";
            this.lbDataPrevisaoParto.Size = new System.Drawing.Size(108, 25);
            this.lbDataPrevisaoParto.TabIndex = 39;
            this.lbDataPrevisaoParto.Text = "Prev. Parto";
            // 
            // pnTituloPartos
            // 
            this.pnTituloPartos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnTituloPartos.Controls.Add(this.lbPartos);
            this.pnTituloPartos.Location = new System.Drawing.Point(-2, -5);
            this.pnTituloPartos.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pnTituloPartos.Name = "pnTituloPartos";
            this.pnTituloPartos.Size = new System.Drawing.Size(780, 37);
            this.pnTituloPartos.TabIndex = 31;
            // 
            // lbPartos
            // 
            this.lbPartos.AutoSize = true;
            this.lbPartos.Location = new System.Drawing.Point(340, 10);
            this.lbPartos.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbPartos.Name = "lbPartos";
            this.lbPartos.Size = new System.Drawing.Size(68, 25);
            this.lbPartos.TabIndex = 23;
            this.lbPartos.Text = "Partos";
            // 
            // lbObservacaoParto
            // 
            this.lbObservacaoParto.AutoSize = true;
            this.lbObservacaoParto.Location = new System.Drawing.Point(274, 40);
            this.lbObservacaoParto.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbObservacaoParto.Name = "lbObservacaoParto";
            this.lbObservacaoParto.Size = new System.Drawing.Size(119, 25);
            this.lbObservacaoParto.TabIndex = 30;
            this.lbObservacaoParto.Text = "Observação";
            // 
            // lbDataParto
            // 
            this.lbDataParto.AutoSize = true;
            this.lbDataParto.Location = new System.Drawing.Point(143, 40);
            this.lbDataParto.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbDataParto.Name = "lbDataParto";
            this.lbDataParto.Size = new System.Drawing.Size(104, 25);
            this.lbDataParto.TabIndex = 29;
            this.lbDataParto.Text = "Data Parto";
            // 
            // btAdicionarParto
            // 
            this.btAdicionarParto.Location = new System.Drawing.Point(625, 65);
            this.btAdicionarParto.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btAdicionarParto.Name = "btAdicionarParto";
            this.btAdicionarParto.Size = new System.Drawing.Size(108, 36);
            this.btAdicionarParto.TabIndex = 11;
            this.btAdicionarParto.Text = "Adicionar";
            this.btAdicionarParto.UseVisualStyleBackColor = true;
            this.btAdicionarParto.Click += new System.EventHandler(this.btAdicionarParto_Click);
            // 
            // eObservacaoParto
            // 
            this.eObservacaoParto.Location = new System.Drawing.Point(279, 71);
            this.eObservacaoParto.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.eObservacaoParto.Name = "eObservacaoParto";
            this.eObservacaoParto.Size = new System.Drawing.Size(333, 30);
            this.eObservacaoParto.TabIndex = 10;
            // 
            // dgPartos
            // 
            this.dgPartos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPartos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clPrevisaoParto,
            this.clDataParto,
            this.clObservacoesParto});
            this.dgPartos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgPartos.Location = new System.Drawing.Point(6, 117);
            this.dgPartos.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.dgPartos.MultiSelect = false;
            this.dgPartos.Name = "dgPartos";
            this.dgPartos.RowHeadersVisible = false;
            this.dgPartos.RowHeadersWidth = 51;
            this.dgPartos.RowTemplate.Height = 24;
            this.dgPartos.Size = new System.Drawing.Size(727, 229);
            this.dgPartos.TabIndex = 12;
            // 
            // clPrevisaoParto
            // 
            this.clPrevisaoParto.HeaderText = "Prev. Parto";
            this.clPrevisaoParto.MinimumWidth = 6;
            this.clPrevisaoParto.Name = "clPrevisaoParto";
            this.clPrevisaoParto.Width = 150;
            // 
            // clDataParto
            // 
            this.clDataParto.HeaderText = "Data Parto";
            this.clDataParto.MinimumWidth = 6;
            this.clDataParto.Name = "clDataParto";
            this.clDataParto.Width = 150;
            // 
            // clObservacoesParto
            // 
            this.clObservacoesParto.HeaderText = "Observações";
            this.clObservacoesParto.MinimumWidth = 6;
            this.clObservacoesParto.Name = "clObservacoesParto";
            this.clObservacoesParto.Width = 405;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbTitulo);
            this.panel1.Location = new System.Drawing.Point(-36, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 36);
            this.panel1.TabIndex = 37;
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitulo.Location = new System.Drawing.Point(365, 4);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(141, 28);
            this.lbTitulo.TabIndex = 0;
            this.lbTitulo.Text = "Reprodução";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // fReproducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 767);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnEstacoesMonta);
            this.Controls.Add(this.pnPartos);
            this.Controls.Add(this.lbIdentificacao);
            this.Controls.Add(this.eIdentificacao);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fReproducao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reprodução - Rural Simples";
            this.pnEstacoesMonta.ResumeLayout(false);
            this.pnEstacoesMonta.PerformLayout();
            this.pnTituloEstacoesMonta.ResumeLayout(false);
            this.pnTituloEstacoesMonta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEstacoesMonta)).EndInit();
            this.pnPartos.ResumeLayout(false);
            this.pnPartos.PerformLayout();
            this.pnTituloPartos.ResumeLayout(false);
            this.pnTituloPartos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPartos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIdentificacao;
        private System.Windows.Forms.TextBox eIdentificacao;
        private System.Windows.Forms.Panel pnEstacoesMonta;
        private System.Windows.Forms.CheckBox ckPrenhez;
        private System.Windows.Forms.Label lbDataConfirmacao;
        private System.Windows.Forms.Panel pnTituloEstacoesMonta;
        private System.Windows.Forms.CheckBox ckNaoSeAplicaInseminacao;
        private System.Windows.Forms.Label lbEstacoesMonta;
        private System.Windows.Forms.Label lbIdentificacaoPai;
        private System.Windows.Forms.Label lbDataInseminacao;
        private System.Windows.Forms.Button btAdicionarEstacaoMonta;
        private System.Windows.Forms.TextBox eNomePai;
        private System.Windows.Forms.DataGridView dgEstacoesMonta;
        private System.Windows.Forms.Panel pnPartos;
        private System.Windows.Forms.Panel pnTituloPartos;
        private System.Windows.Forms.Label lbPartos;
        private System.Windows.Forms.Label lbObservacaoParto;
        private System.Windows.Forms.Label lbDataParto;
        private System.Windows.Forms.Button btAdicionarParto;
        private System.Windows.Forms.TextBox eObservacaoParto;
        private System.Windows.Forms.DataGridView dgPartos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDataInseminacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPaiInseminacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrenha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDataToque;
        private System.Windows.Forms.Label lbDataPrevisaoParto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrevisaoParto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDataParto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clObservacoesParto;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MaskedTextBox eDataInseminacao;
        private System.Windows.Forms.MaskedTextBox eDataToque;
        private System.Windows.Forms.MaskedTextBox eDataPrevisaoParto;
        private System.Windows.Forms.MaskedTextBox eDataParto;
    }
}