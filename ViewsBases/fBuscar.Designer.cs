
namespace RuralSimples.ViewsBases
{
    partial class fBuscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBuscar));
            this.gdDados = new System.Windows.Forms.DataGridView();
            this.clCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clIdentificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbNome = new System.Windows.Forms.Label();
            this.eNome = new System.Windows.Forms.TextBox();
            this.btSelecionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdDados)).BeginInit();
            this.SuspendLayout();
            // 
            // gdDados
            // 
            this.gdDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCodigo,
            this.clIdentificador,
            this.clNome,
            this.clDataCadastro});
            this.gdDados.Location = new System.Drawing.Point(1, 135);
            this.gdDados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gdDados.Name = "gdDados";
            this.gdDados.RowHeadersVisible = false;
            this.gdDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdDados.Size = new System.Drawing.Size(807, 429);
            this.gdDados.TabIndex = 3;
            this.gdDados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gdDados_CellDoubleClick);
            // 
            // clCodigo
            // 
            this.clCodigo.HeaderText = "Código";
            this.clCodigo.Name = "clCodigo";
            // 
            // clIdentificador
            // 
            this.clIdentificador.HeaderText = "Identificador";
            this.clIdentificador.Name = "clIdentificador";
            this.clIdentificador.Width = 120;
            // 
            // clNome
            // 
            this.clNome.HeaderText = "Nome";
            this.clNome.Name = "clNome";
            this.clNome.Width = 415;
            // 
            // clDataCadastro
            // 
            this.clDataCadastro.HeaderText = "Data Cadastro";
            this.clDataCadastro.Name = "clDataCadastro";
            this.clDataCadastro.Width = 150;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(13, 9);
            this.lbNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(58, 20);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome:";
            // 
            // eNome
            // 
            this.eNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.eNome.Location = new System.Drawing.Point(17, 41);
            this.eNome.Name = "eNome";
            this.eNome.Size = new System.Drawing.Size(653, 26);
            this.eNome.TabIndex = 0;
            // 
            // btSelecionar
            // 
            this.btSelecionar.Location = new System.Drawing.Point(676, 38);
            this.btSelecionar.Name = "btSelecionar";
            this.btSelecionar.Size = new System.Drawing.Size(122, 29);
            this.btSelecionar.TabIndex = 3;
            this.btSelecionar.Text = "Selecionar";
            this.btSelecionar.UseVisualStyleBackColor = true;
            this.btSelecionar.Click += new System.EventHandler(this.btSelecionar_Click);
            // 
            // fBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 565);
            this.Controls.Add(this.btSelecionar);
            this.Controls.Add(this.eNome);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.gdDados);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fBuscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar";
            this.Shown += new System.EventHandler(this.fBuscar_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gdDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView gdDados;
        public System.Windows.Forms.Label lbNome;
        public System.Windows.Forms.TextBox eNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clIdentificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDataCadastro;
        public System.Windows.Forms.Button btSelecionar;
    }
}