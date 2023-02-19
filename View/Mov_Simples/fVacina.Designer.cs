
namespace RuralSimples.View
{
    partial class fVacina
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
            this.lbNomeAnimal = new System.Windows.Forms.Label();
            this.lbAnimal = new System.Windows.Forms.Label();
            this.eCodigo = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbIdentificacao = new System.Windows.Forms.Label();
            this.eIdentificacao = new System.Windows.Forms.TextBox();
            this.pnTituloVacinas = new System.Windows.Forms.Panel();
            this.lbVacinas = new System.Windows.Forms.Label();
            this.lbDosagem = new System.Windows.Forms.Label();
            this.eDosagem = new System.Windows.Forms.TextBox();
            this.eDataVacina = new System.Windows.Forms.MaskedTextBox();
            this.lbNomeVacina = new System.Windows.Forms.Label();
            this.lbDataVacina = new System.Windows.Forms.Label();
            this.btAdicionarVacina = new System.Windows.Forms.Button();
            this.eNomeVacina = new System.Windows.Forms.TextBox();
            this.dgVacina = new System.Windows.Forms.DataGridView();
            this.DataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clVacinaData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNomeVacina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDosagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDVacina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDAnimal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bgManter = new System.Windows.Forms.GroupBox();
            this.ckTodos = new System.Windows.Forms.CheckBox();
            this.ckDosagem = new System.Windows.Forms.CheckBox();
            this.ckNomeVacina = new System.Windows.Forms.CheckBox();
            this.ckData = new System.Windows.Forms.CheckBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.ckIdentificacao = new System.Windows.Forms.CheckBox();
            this.ckCodigo = new System.Windows.Forms.CheckBox();
            this.pnTituloVacinas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVacina)).BeginInit();
            this.bgManter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNomeAnimal
            // 
            this.lbNomeAnimal.AutoSize = true;
            this.lbNomeAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeAnimal.Location = new System.Drawing.Point(96, 145);
            this.lbNomeAnimal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNomeAnimal.Name = "lbNomeAnimal";
            this.lbNomeAnimal.Size = new System.Drawing.Size(129, 25);
            this.lbNomeAnimal.TabIndex = 47;
            this.lbNomeAnimal.Text = "Nome Animal";
            // 
            // lbAnimal
            // 
            this.lbAnimal.AutoSize = true;
            this.lbAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnimal.Location = new System.Drawing.Point(10, 145);
            this.lbAnimal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAnimal.Name = "lbAnimal";
            this.lbAnimal.Size = new System.Drawing.Size(78, 25);
            this.lbAnimal.TabIndex = 46;
            this.lbAnimal.Text = "Animal:";
            // 
            // eCodigo
            // 
            this.eCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.eCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eCodigo.Location = new System.Drawing.Point(129, 104);
            this.eCodigo.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.eCodigo.Name = "eCodigo";
            this.eCodigo.Size = new System.Drawing.Size(223, 26);
            this.eCodigo.TabIndex = 1;
            this.eCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.eCodigo_KeyPress);
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.Location = new System.Drawing.Point(11, 107);
            this.lbCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(59, 20);
            this.lbCodigo.TabIndex = 44;
            this.lbCodigo.Text = "Código";
            // 
            // lbIdentificacao
            // 
            this.lbIdentificacao.AutoSize = true;
            this.lbIdentificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdentificacao.Location = new System.Drawing.Point(11, 72);
            this.lbIdentificacao.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.lbIdentificacao.Name = "lbIdentificacao";
            this.lbIdentificacao.Size = new System.Drawing.Size(100, 20);
            this.lbIdentificacao.TabIndex = 43;
            this.lbIdentificacao.Text = "Identificação";
            // 
            // eIdentificacao
            // 
            this.eIdentificacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.eIdentificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eIdentificacao.Location = new System.Drawing.Point(129, 69);
            this.eIdentificacao.Margin = new System.Windows.Forms.Padding(9, 12, 9, 12);
            this.eIdentificacao.Name = "eIdentificacao";
            this.eIdentificacao.Size = new System.Drawing.Size(223, 26);
            this.eIdentificacao.TabIndex = 0;
            this.eIdentificacao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.eIdentificacao_KeyPress);
            // 
            // pnTituloVacinas
            // 
            this.pnTituloVacinas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnTituloVacinas.Controls.Add(this.lbVacinas);
            this.pnTituloVacinas.Location = new System.Drawing.Point(0, 0);
            this.pnTituloVacinas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.pnTituloVacinas.Name = "pnTituloVacinas";
            this.pnTituloVacinas.Size = new System.Drawing.Size(824, 51);
            this.pnTituloVacinas.TabIndex = 48;
            // 
            // lbVacinas
            // 
            this.lbVacinas.AutoSize = true;
            this.lbVacinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVacinas.Location = new System.Drawing.Point(265, 8);
            this.lbVacinas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbVacinas.Name = "lbVacinas";
            this.lbVacinas.Size = new System.Drawing.Size(134, 38);
            this.lbVacinas.TabIndex = 23;
            this.lbVacinas.Text = "Vacinas";
            // 
            // lbDosagem
            // 
            this.lbDosagem.AutoSize = true;
            this.lbDosagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDosagem.Location = new System.Drawing.Point(426, 213);
            this.lbDosagem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDosagem.Name = "lbDosagem";
            this.lbDosagem.Size = new System.Drawing.Size(81, 20);
            this.lbDosagem.TabIndex = 56;
            this.lbDosagem.Text = "Dosagem";
            // 
            // eDosagem
            // 
            this.eDosagem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.eDosagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eDosagem.Location = new System.Drawing.Point(430, 235);
            this.eDosagem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.eDosagem.Name = "eDosagem";
            this.eDosagem.Size = new System.Drawing.Size(100, 26);
            this.eDosagem.TabIndex = 5;
            // 
            // eDataVacina
            // 
            this.eDataVacina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eDataVacina.Location = new System.Drawing.Point(15, 235);
            this.eDataVacina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eDataVacina.Mask = "00/00/0000";
            this.eDataVacina.Name = "eDataVacina";
            this.eDataVacina.Size = new System.Drawing.Size(100, 26);
            this.eDataVacina.TabIndex = 3;
            this.eDataVacina.ValidatingType = typeof(System.DateTime);
            // 
            // lbNomeVacina
            // 
            this.lbNomeVacina.AutoSize = true;
            this.lbNomeVacina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeVacina.Location = new System.Drawing.Point(118, 213);
            this.lbNomeVacina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNomeVacina.Name = "lbNomeVacina";
            this.lbNomeVacina.Size = new System.Drawing.Size(109, 20);
            this.lbNomeVacina.TabIndex = 54;
            this.lbNomeVacina.Text = "Nome Vacina";
            // 
            // lbDataVacina
            // 
            this.lbDataVacina.AutoSize = true;
            this.lbDataVacina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataVacina.Location = new System.Drawing.Point(13, 213);
            this.lbDataVacina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDataVacina.Name = "lbDataVacina";
            this.lbDataVacina.Size = new System.Drawing.Size(45, 20);
            this.lbDataVacina.TabIndex = 53;
            this.lbDataVacina.Text = "Data";
            // 
            // btAdicionarVacina
            // 
            this.btAdicionarVacina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdicionarVacina.Location = new System.Drawing.Point(538, 220);
            this.btAdicionarVacina.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btAdicionarVacina.Name = "btAdicionarVacina";
            this.btAdicionarVacina.Size = new System.Drawing.Size(108, 41);
            this.btAdicionarVacina.TabIndex = 6;
            this.btAdicionarVacina.Text = "Adicionar";
            this.btAdicionarVacina.UseVisualStyleBackColor = true;
            this.btAdicionarVacina.Click += new System.EventHandler(this.btAdicionarVacina_Click);
            // 
            // eNomeVacina
            // 
            this.eNomeVacina.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.eNomeVacina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eNomeVacina.Location = new System.Drawing.Point(122, 235);
            this.eNomeVacina.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.eNomeVacina.Name = "eNomeVacina";
            this.eNomeVacina.Size = new System.Drawing.Size(300, 26);
            this.eNomeVacina.TabIndex = 4;
            // 
            // dgVacina
            // 
            this.dgVacina.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgVacina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVacina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataCadastro,
            this.clVacinaData,
            this.clNomeVacina,
            this.clDosagem,
            this.IDVacina,
            this.IDAnimal});
            this.dgVacina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgVacina.Location = new System.Drawing.Point(5, 273);
            this.dgVacina.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dgVacina.MultiSelect = false;
            this.dgVacina.Name = "dgVacina";
            this.dgVacina.RowHeadersVisible = false;
            this.dgVacina.RowHeadersWidth = 51;
            this.dgVacina.RowTemplate.Height = 24;
            this.dgVacina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVacina.Size = new System.Drawing.Size(783, 353);
            this.dgVacina.TabIndex = 7;
            this.dgVacina.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVacina_CellDoubleClick);
            // 
            // DataCadastro
            // 
            this.DataCadastro.HeaderText = "Data Cadastro";
            this.DataCadastro.Name = "DataCadastro";
            this.DataCadastro.Width = 140;
            // 
            // clVacinaData
            // 
            this.clVacinaData.HeaderText = "Data Vacina";
            this.clVacinaData.MinimumWidth = 6;
            this.clVacinaData.Name = "clVacinaData";
            this.clVacinaData.Width = 140;
            // 
            // clNomeVacina
            // 
            this.clNomeVacina.HeaderText = "Nome Vacina";
            this.clNomeVacina.MinimumWidth = 6;
            this.clNomeVacina.Name = "clNomeVacina";
            this.clNomeVacina.Width = 360;
            // 
            // clDosagem
            // 
            this.clDosagem.HeaderText = "Dosagem";
            this.clDosagem.Name = "clDosagem";
            this.clDosagem.Width = 120;
            // 
            // IDVacina
            // 
            this.IDVacina.HeaderText = "IDVacina";
            this.IDVacina.Name = "IDVacina";
            // 
            // IDAnimal
            // 
            this.IDAnimal.HeaderText = "IDAnimal";
            this.IDAnimal.Name = "IDAnimal";
            // 
            // bgManter
            // 
            this.bgManter.Controls.Add(this.ckCodigo);
            this.bgManter.Controls.Add(this.ckIdentificacao);
            this.bgManter.Controls.Add(this.ckTodos);
            this.bgManter.Controls.Add(this.ckDosagem);
            this.bgManter.Controls.Add(this.ckNomeVacina);
            this.bgManter.Controls.Add(this.ckData);
            this.bgManter.Location = new System.Drawing.Point(612, 60);
            this.bgManter.Name = "bgManter";
            this.bgManter.Size = new System.Drawing.Size(153, 151);
            this.bgManter.TabIndex = 2;
            this.bgManter.TabStop = false;
            this.bgManter.Text = "Manter";
            // 
            // ckTodos
            // 
            this.ckTodos.AutoSize = true;
            this.ckTodos.Location = new System.Drawing.Point(6, 125);
            this.ckTodos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckTodos.Name = "ckTodos";
            this.ckTodos.Size = new System.Drawing.Size(72, 24);
            this.ckTodos.TabIndex = 3;
            this.ckTodos.Text = "Todos";
            this.ckTodos.UseVisualStyleBackColor = true;
            this.ckTodos.CheckedChanged += new System.EventHandler(this.ckTodos_CheckedChanged);
            // 
            // ckDosagem
            // 
            this.ckDosagem.AutoSize = true;
            this.ckDosagem.Location = new System.Drawing.Point(6, 62);
            this.ckDosagem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckDosagem.Name = "ckDosagem";
            this.ckDosagem.Size = new System.Drawing.Size(97, 24);
            this.ckDosagem.TabIndex = 2;
            this.ckDosagem.Text = "Dosagem";
            this.ckDosagem.UseVisualStyleBackColor = true;
            // 
            // ckNomeVacina
            // 
            this.ckNomeVacina.AutoSize = true;
            this.ckNomeVacina.Location = new System.Drawing.Point(6, 104);
            this.ckNomeVacina.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckNomeVacina.Name = "ckNomeVacina";
            this.ckNomeVacina.Size = new System.Drawing.Size(123, 24);
            this.ckNomeVacina.TabIndex = 1;
            this.ckNomeVacina.Text = "Nome Vacina";
            this.ckNomeVacina.UseVisualStyleBackColor = true;
            // 
            // ckData
            // 
            this.ckData.AutoSize = true;
            this.ckData.Location = new System.Drawing.Point(6, 41);
            this.ckData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckData.Name = "ckData";
            this.ckData.Size = new System.Drawing.Size(63, 24);
            this.ckData.TabIndex = 0;
            this.ckData.Text = "Data";
            this.ckData.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(654, 220);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(90, 41);
            this.btCancelar.TabIndex = 57;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Visible = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // ckIdentificacao
            // 
            this.ckIdentificacao.AutoSize = true;
            this.ckIdentificacao.Location = new System.Drawing.Point(6, 83);
            this.ckIdentificacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckIdentificacao.Name = "ckIdentificacao";
            this.ckIdentificacao.Size = new System.Drawing.Size(119, 24);
            this.ckIdentificacao.TabIndex = 4;
            this.ckIdentificacao.Text = "Identificação";
            this.ckIdentificacao.UseVisualStyleBackColor = true;
            // 
            // ckCodigo
            // 
            this.ckCodigo.AutoSize = true;
            this.ckCodigo.Location = new System.Drawing.Point(6, 20);
            this.ckCodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckCodigo.Name = "ckCodigo";
            this.ckCodigo.Size = new System.Drawing.Size(78, 24);
            this.ckCodigo.TabIndex = 5;
            this.ckCodigo.Text = "Código";
            this.ckCodigo.UseVisualStyleBackColor = true;
            // 
            // fVacina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 629);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.bgManter);
            this.Controls.Add(this.lbDosagem);
            this.Controls.Add(this.eDosagem);
            this.Controls.Add(this.eDataVacina);
            this.Controls.Add(this.lbNomeVacina);
            this.Controls.Add(this.lbDataVacina);
            this.Controls.Add(this.btAdicionarVacina);
            this.Controls.Add(this.eNomeVacina);
            this.Controls.Add(this.dgVacina);
            this.Controls.Add(this.pnTituloVacinas);
            this.Controls.Add(this.lbNomeAnimal);
            this.Controls.Add(this.lbAnimal);
            this.Controls.Add(this.eCodigo);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.lbIdentificacao);
            this.Controls.Add(this.eIdentificacao);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fVacina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vacinas";
            this.Shown += new System.EventHandler(this.fVacina_Shown);
            this.pnTituloVacinas.ResumeLayout(false);
            this.pnTituloVacinas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgVacina)).EndInit();
            this.bgManter.ResumeLayout(false);
            this.bgManter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNomeAnimal;
        private System.Windows.Forms.Label lbAnimal;
        private System.Windows.Forms.TextBox eCodigo;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbIdentificacao;
        private System.Windows.Forms.TextBox eIdentificacao;
        private System.Windows.Forms.Panel pnTituloVacinas;
        private System.Windows.Forms.Label lbVacinas;
        private System.Windows.Forms.Label lbDosagem;
        private System.Windows.Forms.TextBox eDosagem;
        private System.Windows.Forms.MaskedTextBox eDataVacina;
        private System.Windows.Forms.Label lbNomeVacina;
        private System.Windows.Forms.Label lbDataVacina;
        private System.Windows.Forms.Button btAdicionarVacina;
        private System.Windows.Forms.TextBox eNomeVacina;
        private System.Windows.Forms.DataGridView dgVacina;
        private System.Windows.Forms.GroupBox bgManter;
        private System.Windows.Forms.CheckBox ckTodos;
        private System.Windows.Forms.CheckBox ckDosagem;
        private System.Windows.Forms.CheckBox ckNomeVacina;
        private System.Windows.Forms.CheckBox ckData;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCadastro;
        private System.Windows.Forms.DataGridViewTextBoxColumn clVacinaData;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNomeVacina;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDosagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDVacina;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDAnimal;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.CheckBox ckCodigo;
        private System.Windows.Forms.CheckBox ckIdentificacao;
    }
}