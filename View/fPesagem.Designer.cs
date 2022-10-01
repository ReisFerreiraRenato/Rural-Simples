
namespace RuralSimples.View
{
    partial class fPesagem
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
            this.pnPesagens = new System.Windows.Forms.Panel();
            this.eDataPesagem = new System.Windows.Forms.MaskedTextBox();
            this.pnTituloPesagens = new System.Windows.Forms.Panel();
            this.lbPesagens = new System.Windows.Forms.Label();
            this.lbPeso = new System.Windows.Forms.Label();
            this.lbDataPesagem = new System.Windows.Forms.Label();
            this.btAdicionarPesagem = new System.Windows.Forms.Button();
            this.ePeso = new System.Windows.Forms.TextBox();
            this.dgPesagens = new System.Windows.Forms.DataGridView();
            this.clDataPesagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPeso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPesoMedio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnPesagens.SuspendLayout();
            this.pnTituloPesagens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPesagens)).BeginInit();
            this.SuspendLayout();
            // 
            // pnPesagens
            // 
            this.pnPesagens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnPesagens.Controls.Add(this.eDataPesagem);
            this.pnPesagens.Controls.Add(this.pnTituloPesagens);
            this.pnPesagens.Controls.Add(this.lbPeso);
            this.pnPesagens.Controls.Add(this.lbDataPesagem);
            this.pnPesagens.Controls.Add(this.btAdicionarPesagem);
            this.pnPesagens.Controls.Add(this.ePeso);
            this.pnPesagens.Controls.Add(this.dgPesagens);
            this.pnPesagens.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnPesagens.Location = new System.Drawing.Point(142, 151);
            this.pnPesagens.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnPesagens.Name = "pnPesagens";
            this.pnPesagens.Size = new System.Drawing.Size(457, 285);
            this.pnPesagens.TabIndex = 13;
            // 
            // eDataPesagem
            // 
            this.eDataPesagem.Location = new System.Drawing.Point(4, 61);
            this.eDataPesagem.Mask = "00/00/0000";
            this.eDataPesagem.Name = "eDataPesagem";
            this.eDataPesagem.Size = new System.Drawing.Size(118, 26);
            this.eDataPesagem.TabIndex = 32;
            this.eDataPesagem.ValidatingType = typeof(System.DateTime);
            // 
            // pnTituloPesagens
            // 
            this.pnTituloPesagens.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnTituloPesagens.Controls.Add(this.lbPesagens);
            this.pnTituloPesagens.Location = new System.Drawing.Point(-1, -1);
            this.pnTituloPesagens.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnTituloPesagens.Name = "pnTituloPesagens";
            this.pnTituloPesagens.Size = new System.Drawing.Size(457, 31);
            this.pnTituloPesagens.TabIndex = 31;
            // 
            // lbPesagens
            // 
            this.lbPesagens.AutoSize = true;
            this.lbPesagens.Location = new System.Drawing.Point(177, 3);
            this.lbPesagens.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPesagens.Name = "lbPesagens";
            this.lbPesagens.Size = new System.Drawing.Size(80, 20);
            this.lbPesagens.TabIndex = 23;
            this.lbPesagens.Text = "Pesagens";
            // 
            // lbPeso
            // 
            this.lbPeso.AutoSize = true;
            this.lbPeso.Location = new System.Drawing.Point(124, 30);
            this.lbPeso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPeso.Name = "lbPeso";
            this.lbPeso.Size = new System.Drawing.Size(45, 20);
            this.lbPeso.TabIndex = 30;
            this.lbPeso.Text = "Peso";
            // 
            // lbDataPesagem
            // 
            this.lbDataPesagem.AutoSize = true;
            this.lbDataPesagem.Location = new System.Drawing.Point(-1, 30);
            this.lbDataPesagem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDataPesagem.Name = "lbDataPesagem";
            this.lbDataPesagem.Size = new System.Drawing.Size(44, 20);
            this.lbDataPesagem.TabIndex = 29;
            this.lbDataPesagem.Text = "Data";
            // 
            // btAdicionarPesagem
            // 
            this.btAdicionarPesagem.Location = new System.Drawing.Point(334, 60);
            this.btAdicionarPesagem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAdicionarPesagem.Name = "btAdicionarPesagem";
            this.btAdicionarPesagem.Size = new System.Drawing.Size(120, 31);
            this.btAdicionarPesagem.TabIndex = 8;
            this.btAdicionarPesagem.Text = "Adicionar";
            this.btAdicionarPesagem.UseVisualStyleBackColor = true;
            // 
            // ePeso
            // 
            this.ePeso.Location = new System.Drawing.Point(129, 61);
            this.ePeso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ePeso.Name = "ePeso";
            this.ePeso.Size = new System.Drawing.Size(197, 26);
            this.ePeso.TabIndex = 7;
            // 
            // dgPesagens
            // 
            this.dgPesagens.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgPesagens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPesagens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clDataPesagem,
            this.clPeso,
            this.clPesoMedio});
            this.dgPesagens.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgPesagens.Location = new System.Drawing.Point(2, 101);
            this.dgPesagens.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgPesagens.MultiSelect = false;
            this.dgPesagens.Name = "dgPesagens";
            this.dgPesagens.RowHeadersVisible = false;
            this.dgPesagens.RowHeadersWidth = 51;
            this.dgPesagens.RowTemplate.Height = 24;
            this.dgPesagens.Size = new System.Drawing.Size(452, 180);
            this.dgPesagens.TabIndex = 23;
            // 
            // clDataPesagem
            // 
            this.clDataPesagem.HeaderText = "Data Pesagem";
            this.clDataPesagem.MinimumWidth = 6;
            this.clDataPesagem.Name = "clDataPesagem";
            this.clDataPesagem.Width = 170;
            // 
            // clPeso
            // 
            this.clPeso.HeaderText = "Peso";
            this.clPeso.MinimumWidth = 6;
            this.clPeso.Name = "clPeso";
            this.clPeso.Width = 110;
            // 
            // clPesoMedio
            // 
            this.clPesoMedio.HeaderText = "Peso Médio";
            this.clPesoMedio.MinimumWidth = 6;
            this.clPesoMedio.Name = "clPesoMedio";
            this.clPesoMedio.Width = 150;
            // 
            // fPesagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnPesagens);
            this.Name = "fPesagem";
            this.Text = "Pesagem";
            this.pnPesagens.ResumeLayout(false);
            this.pnPesagens.PerformLayout();
            this.pnTituloPesagens.ResumeLayout(false);
            this.pnTituloPesagens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPesagens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnPesagens;
        private System.Windows.Forms.MaskedTextBox eDataPesagem;
        private System.Windows.Forms.Panel pnTituloPesagens;
        private System.Windows.Forms.Label lbPesagens;
        private System.Windows.Forms.Label lbPeso;
        private System.Windows.Forms.Label lbDataPesagem;
        private System.Windows.Forms.Button btAdicionarPesagem;
        private System.Windows.Forms.TextBox ePeso;
        private System.Windows.Forms.DataGridView dgPesagens;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDataPesagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPeso;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPesoMedio;
    }
}