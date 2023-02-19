
namespace RuralSimples.View
{
    partial class fVermifugacao
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
            this.pnVermifugacao = new System.Windows.Forms.Panel();
            this.eDataVermifugacao = new System.Windows.Forms.MaskedTextBox();
            this.pnTituloVermifugacao = new System.Windows.Forms.Panel();
            this.lbVermifugacao = new System.Windows.Forms.Label();
            this.lbNomeVermifugo = new System.Windows.Forms.Label();
            this.lbDataVermifugo = new System.Windows.Forms.Label();
            this.btAdicionarVermifugo = new System.Windows.Forms.Button();
            this.eNomeVermifugo = new System.Windows.Forms.TextBox();
            this.gdVermifugacao = new System.Windows.Forms.DataGridView();
            this.clDataVermifugo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNomeVermifugo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnVermifugacao.SuspendLayout();
            this.pnTituloVermifugacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdVermifugacao)).BeginInit();
            this.SuspendLayout();
            // 
            // pnVermifugacao
            // 
            this.pnVermifugacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnVermifugacao.Controls.Add(this.eDataVermifugacao);
            this.pnVermifugacao.Controls.Add(this.pnTituloVermifugacao);
            this.pnVermifugacao.Controls.Add(this.lbNomeVermifugo);
            this.pnVermifugacao.Controls.Add(this.lbDataVermifugo);
            this.pnVermifugacao.Controls.Add(this.btAdicionarVermifugo);
            this.pnVermifugacao.Controls.Add(this.eNomeVermifugo);
            this.pnVermifugacao.Controls.Add(this.gdVermifugacao);
            this.pnVermifugacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnVermifugacao.Location = new System.Drawing.Point(103, 151);
            this.pnVermifugacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnVermifugacao.Name = "pnVermifugacao";
            this.pnVermifugacao.Size = new System.Drawing.Size(498, 285);
            this.pnVermifugacao.TabIndex = 12;
            // 
            // eDataVermifugacao
            // 
            this.eDataVermifugacao.Location = new System.Drawing.Point(4, 61);
            this.eDataVermifugacao.Mask = "00/00/0000";
            this.eDataVermifugacao.Name = "eDataVermifugacao";
            this.eDataVermifugacao.Size = new System.Drawing.Size(117, 26);
            this.eDataVermifugacao.TabIndex = 32;
            this.eDataVermifugacao.ValidatingType = typeof(System.DateTime);
            // 
            // pnTituloVermifugacao
            // 
            this.pnTituloVermifugacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnTituloVermifugacao.Controls.Add(this.lbVermifugacao);
            this.pnTituloVermifugacao.Location = new System.Drawing.Point(-1, -1);
            this.pnTituloVermifugacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnTituloVermifugacao.Name = "pnTituloVermifugacao";
            this.pnTituloVermifugacao.Size = new System.Drawing.Size(498, 31);
            this.pnTituloVermifugacao.TabIndex = 31;
            // 
            // lbVermifugacao
            // 
            this.lbVermifugacao.AutoSize = true;
            this.lbVermifugacao.Location = new System.Drawing.Point(218, 3);
            this.lbVermifugacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbVermifugacao.Name = "lbVermifugacao";
            this.lbVermifugacao.Size = new System.Drawing.Size(108, 20);
            this.lbVermifugacao.TabIndex = 23;
            this.lbVermifugacao.Text = "Vermifugação";
            // 
            // lbNomeVermifugo
            // 
            this.lbNomeVermifugo.AutoSize = true;
            this.lbNomeVermifugo.Location = new System.Drawing.Point(132, 30);
            this.lbNomeVermifugo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNomeVermifugo.Name = "lbNomeVermifugo";
            this.lbNomeVermifugo.Size = new System.Drawing.Size(51, 20);
            this.lbNomeVermifugo.TabIndex = 30;
            this.lbNomeVermifugo.Text = "Nome";
            // 
            // lbDataVermifugo
            // 
            this.lbDataVermifugo.AutoSize = true;
            this.lbDataVermifugo.Location = new System.Drawing.Point(-1, 30);
            this.lbDataVermifugo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDataVermifugo.Name = "lbDataVermifugo";
            this.lbDataVermifugo.Size = new System.Drawing.Size(44, 20);
            this.lbDataVermifugo.TabIndex = 29;
            this.lbDataVermifugo.Text = "Data";
            // 
            // btAdicionarVermifugo
            // 
            this.btAdicionarVermifugo.Location = new System.Drawing.Point(374, 60);
            this.btAdicionarVermifugo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAdicionarVermifugo.Name = "btAdicionarVermifugo";
            this.btAdicionarVermifugo.Size = new System.Drawing.Size(120, 31);
            this.btAdicionarVermifugo.TabIndex = 8;
            this.btAdicionarVermifugo.Text = "Adicionar";
            this.btAdicionarVermifugo.UseVisualStyleBackColor = true;
            // 
            // eNomeVermifugo
            // 
            this.eNomeVermifugo.Location = new System.Drawing.Point(128, 62);
            this.eNomeVermifugo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.eNomeVermifugo.Name = "eNomeVermifugo";
            this.eNomeVermifugo.Size = new System.Drawing.Size(236, 26);
            this.eNomeVermifugo.TabIndex = 7;
            // 
            // gdVermifugacao
            // 
            this.gdVermifugacao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdVermifugacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdVermifugacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clDataVermifugo,
            this.clNomeVermifugo});
            this.gdVermifugacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gdVermifugacao.Location = new System.Drawing.Point(2, 101);
            this.gdVermifugacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gdVermifugacao.MultiSelect = false;
            this.gdVermifugacao.Name = "gdVermifugacao";
            this.gdVermifugacao.RowHeadersVisible = false;
            this.gdVermifugacao.RowHeadersWidth = 51;
            this.gdVermifugacao.RowTemplate.Height = 24;
            this.gdVermifugacao.Size = new System.Drawing.Size(491, 180);
            this.gdVermifugacao.TabIndex = 23;
            // 
            // clDataVermifugo
            // 
            this.clDataVermifugo.HeaderText = "Data Vermif.";
            this.clDataVermifugo.MinimumWidth = 6;
            this.clDataVermifugo.Name = "clDataVermifugo";
            this.clDataVermifugo.Width = 150;
            // 
            // clNomeVermifugo
            // 
            this.clNomeVermifugo.HeaderText = "Nome Vermifugo";
            this.clNomeVermifugo.MinimumWidth = 6;
            this.clNomeVermifugo.Name = "clNomeVermifugo";
            this.clNomeVermifugo.Width = 320;
            // 
            // fVermifugacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 450);
            this.Controls.Add(this.pnVermifugacao);
            this.Name = "fVermifugacao";
            this.Text = "Vermifugação";
            this.pnVermifugacao.ResumeLayout(false);
            this.pnVermifugacao.PerformLayout();
            this.pnTituloVermifugacao.ResumeLayout(false);
            this.pnTituloVermifugacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdVermifugacao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnVermifugacao;
        private System.Windows.Forms.MaskedTextBox eDataVermifugacao;
        private System.Windows.Forms.Panel pnTituloVermifugacao;
        private System.Windows.Forms.Label lbVermifugacao;
        private System.Windows.Forms.Label lbNomeVermifugo;
        private System.Windows.Forms.Label lbDataVermifugo;
        private System.Windows.Forms.Button btAdicionarVermifugo;
        private System.Windows.Forms.TextBox eNomeVermifugo;
        private System.Windows.Forms.DataGridView gdVermifugacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDataVermifugo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNomeVermifugo;
    }
}