
namespace RuralSimples.View
{
    partial class fVacinas
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
            this.pnVacinas = new System.Windows.Forms.Panel();
            this.eDataVacina = new System.Windows.Forms.MaskedTextBox();
            this.pnTituloVacinas = new System.Windows.Forms.Panel();
            this.lbVacinas = new System.Windows.Forms.Label();
            this.lbNomeVacina = new System.Windows.Forms.Label();
            this.lbDataVacina = new System.Windows.Forms.Label();
            this.btAdicionarVacina = new System.Windows.Forms.Button();
            this.eNomeVacina = new System.Windows.Forms.TextBox();
            this.gdVacina = new System.Windows.Forms.DataGridView();
            this.clVacinaData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNomeVacina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.pnVacinas.SuspendLayout();
            this.pnTituloVacinas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdVacina)).BeginInit();
            this.SuspendLayout();
            // 
            // pnVacinas
            // 
            this.pnVacinas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnVacinas.Controls.Add(this.eDataVacina);
            this.pnVacinas.Controls.Add(this.pnTituloVacinas);
            this.pnVacinas.Controls.Add(this.lbNomeVacina);
            this.pnVacinas.Controls.Add(this.lbDataVacina);
            this.pnVacinas.Controls.Add(this.btAdicionarVacina);
            this.pnVacinas.Controls.Add(this.eNomeVacina);
            this.pnVacinas.Controls.Add(this.gdVacina);
            this.pnVacinas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnVacinas.Location = new System.Drawing.Point(2, 132);
            this.pnVacinas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnVacinas.Name = "pnVacinas";
            this.pnVacinas.Size = new System.Drawing.Size(391, 232);
            this.pnVacinas.TabIndex = 11;
            // 
            // eDataVacina
            // 
            this.eDataVacina.Location = new System.Drawing.Point(3, 50);
            this.eDataVacina.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eDataVacina.Mask = "00/00/0000";
            this.eDataVacina.Name = "eDataVacina";
            this.eDataVacina.Size = new System.Drawing.Size(83, 26);
            this.eDataVacina.TabIndex = 32;
            this.eDataVacina.ValidatingType = typeof(System.DateTime);
            // 
            // pnTituloVacinas
            // 
            this.pnTituloVacinas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnTituloVacinas.Controls.Add(this.lbVacinas);
            this.pnTituloVacinas.Location = new System.Drawing.Point(-1, -1);
            this.pnTituloVacinas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnTituloVacinas.Name = "pnTituloVacinas";
            this.pnTituloVacinas.Size = new System.Drawing.Size(391, 25);
            this.pnTituloVacinas.TabIndex = 31;
            // 
            // lbVacinas
            // 
            this.lbVacinas.AutoSize = true;
            this.lbVacinas.Location = new System.Drawing.Point(164, 2);
            this.lbVacinas.Name = "lbVacinas";
            this.lbVacinas.Size = new System.Drawing.Size(66, 20);
            this.lbVacinas.TabIndex = 23;
            this.lbVacinas.Text = "Vacinas";
            // 
            // lbNomeVacina
            // 
            this.lbNomeVacina.AutoSize = true;
            this.lbNomeVacina.Location = new System.Drawing.Point(98, 24);
            this.lbNomeVacina.Name = "lbNomeVacina";
            this.lbNomeVacina.Size = new System.Drawing.Size(51, 20);
            this.lbNomeVacina.TabIndex = 30;
            this.lbNomeVacina.Text = "Nome";
            // 
            // lbDataVacina
            // 
            this.lbDataVacina.AutoSize = true;
            this.lbDataVacina.Location = new System.Drawing.Point(3, 24);
            this.lbDataVacina.Name = "lbDataVacina";
            this.lbDataVacina.Size = new System.Drawing.Size(44, 20);
            this.lbDataVacina.TabIndex = 29;
            this.lbDataVacina.Text = "Data";
            // 
            // btAdicionarVacina
            // 
            this.btAdicionarVacina.Location = new System.Drawing.Point(296, 50);
            this.btAdicionarVacina.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btAdicionarVacina.Name = "btAdicionarVacina";
            this.btAdicionarVacina.Size = new System.Drawing.Size(90, 25);
            this.btAdicionarVacina.TabIndex = 8;
            this.btAdicionarVacina.Text = "Adicionar";
            this.btAdicionarVacina.UseVisualStyleBackColor = true;
            // 
            // eNomeVacina
            // 
            this.eNomeVacina.Location = new System.Drawing.Point(89, 50);
            this.eNomeVacina.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.eNomeVacina.Name = "eNomeVacina";
            this.eNomeVacina.Size = new System.Drawing.Size(202, 26);
            this.eNomeVacina.TabIndex = 7;
            // 
            // gdVacina
            // 
            this.gdVacina.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdVacina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdVacina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clVacinaData,
            this.clNomeVacina});
            this.gdVacina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gdVacina.Location = new System.Drawing.Point(2, 82);
            this.gdVacina.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gdVacina.MultiSelect = false;
            this.gdVacina.Name = "gdVacina";
            this.gdVacina.RowHeadersVisible = false;
            this.gdVacina.RowHeadersWidth = 51;
            this.gdVacina.RowTemplate.Height = 24;
            this.gdVacina.Size = new System.Drawing.Size(387, 146);
            this.gdVacina.TabIndex = 23;
            // 
            // clVacinaData
            // 
            this.clVacinaData.HeaderText = "Data Vacina";
            this.clVacinaData.MinimumWidth = 6;
            this.clVacinaData.Name = "clVacinaData";
            this.clVacinaData.Width = 150;
            // 
            // clNomeVacina
            // 
            this.clNomeVacina.HeaderText = "Nome Vacina";
            this.clNomeVacina.MinimumWidth = 6;
            this.clNomeVacina.Name = "clNomeVacina";
            this.clNomeVacina.Width = 345;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "label4";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 27);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(114, 58);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 20);
            this.textBox2.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(114, 92);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(76, 20);
            this.textBox3.TabIndex = 18;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(114, 115);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(76, 20);
            this.textBox4.TabIndex = 19;
            // 
            // fVacinas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 366);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnVacinas);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fVacinas";
            this.Text = "Vacinas";
            this.pnVacinas.ResumeLayout(false);
            this.pnVacinas.PerformLayout();
            this.pnTituloVacinas.ResumeLayout(false);
            this.pnTituloVacinas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdVacina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnVacinas;
        private System.Windows.Forms.MaskedTextBox eDataVacina;
        private System.Windows.Forms.Panel pnTituloVacinas;
        private System.Windows.Forms.Label lbVacinas;
        private System.Windows.Forms.Label lbNomeVacina;
        private System.Windows.Forms.Label lbDataVacina;
        private System.Windows.Forms.Button btAdicionarVacina;
        private System.Windows.Forms.TextBox eNomeVacina;
        private System.Windows.Forms.DataGridView gdVacina;
        private System.Windows.Forms.DataGridViewTextBoxColumn clVacinaData;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNomeVacina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}