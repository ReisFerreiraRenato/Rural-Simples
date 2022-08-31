
namespace RuralSimples
{
    partial class fPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPrincipal));
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPrincipal = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.animaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.estaçãoDeMontaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbReproducao = new System.Windows.Forms.PictureBox();
            this.pbCadastroAnimais = new System.Windows.Forms.PictureBox();
            this.pbCadastroPessoas = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbTelefone = new System.Windows.Forms.Label();
            this.eNome = new System.Windows.Forms.TextBox();
            this.eTelefone = new System.Windows.Forms.MaskedTextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.mnPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReproducao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCadastroAnimais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCadastroPessoas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 247);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 56);
            this.button1.TabIndex = 2;
            this.button1.Text = "Teste";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(127, 26);
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pessoasToolStripMenuItem});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // pessoasToolStripMenuItem
            // 
            this.pessoasToolStripMenuItem.Name = "pessoasToolStripMenuItem";
            this.pessoasToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.pessoasToolStripMenuItem.Text = "Pessoas";
            // 
            // mnPrincipal
            // 
            this.mnPrincipal.AutoSize = false;
            this.mnPrincipal.Font = new System.Drawing.Font("Arial", 12F);
            this.mnPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem1,
            this.estaçãoDeMontaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.mnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnPrincipal.Name = "mnPrincipal";
            this.mnPrincipal.Padding = new System.Windows.Forms.Padding(0);
            this.mnPrincipal.Size = new System.Drawing.Size(1200, 27);
            this.mnPrincipal.TabIndex = 2;
            this.mnPrincipal.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem1
            // 
            this.cadastrosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.animaisToolStripMenuItem,
            this.pessoasToolStripMenuItem1});
            this.cadastrosToolStripMenuItem1.Name = "cadastrosToolStripMenuItem1";
            this.cadastrosToolStripMenuItem1.Size = new System.Drawing.Size(93, 27);
            this.cadastrosToolStripMenuItem1.Text = "&Cadastros";
            // 
            // animaisToolStripMenuItem
            // 
            this.animaisToolStripMenuItem.Name = "animaisToolStripMenuItem";
            this.animaisToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.animaisToolStripMenuItem.Text = "&Animais";
            this.animaisToolStripMenuItem.Click += new System.EventHandler(this.pbCadastroAnimais_Click);
            // 
            // pessoasToolStripMenuItem1
            // 
            this.pessoasToolStripMenuItem1.Name = "pessoasToolStripMenuItem1";
            this.pessoasToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.pessoasToolStripMenuItem1.Text = "&Pessoas";
            this.pessoasToolStripMenuItem1.Click += new System.EventHandler(this.pbCadastroPessoas_Click);
            // 
            // estaçãoDeMontaToolStripMenuItem
            // 
            this.estaçãoDeMontaToolStripMenuItem.Name = "estaçãoDeMontaToolStripMenuItem";
            this.estaçãoDeMontaToolStripMenuItem.Size = new System.Drawing.Size(106, 27);
            this.estaçãoDeMontaToolStripMenuItem.Text = "&Reprodução";
            this.estaçãoDeMontaToolStripMenuItem.Click += new System.EventHandler(this.pbReproducao_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(49, 27);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pbReproducao);
            this.panel1.Controls.Add(this.pbCadastroAnimais);
            this.panel1.Controls.Add(this.pbCadastroPessoas);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1199, 65);
            this.panel1.TabIndex = 3;
            // 
            // pbReproducao
            // 
            this.pbReproducao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbReproducao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbReproducao.Image = ((System.Drawing.Image)(resources.GetObject("pbReproducao.Image")));
            this.pbReproducao.Location = new System.Drawing.Point(128, -1);
            this.pbReproducao.Margin = new System.Windows.Forms.Padding(0);
            this.pbReproducao.Name = "pbReproducao";
            this.pbReproducao.Size = new System.Drawing.Size(65, 65);
            this.pbReproducao.TabIndex = 2;
            this.pbReproducao.TabStop = false;
            this.pbReproducao.Click += new System.EventHandler(this.pbReproducao_Click);
            // 
            // pbCadastroAnimais
            // 
            this.pbCadastroAnimais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCadastroAnimais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCadastroAnimais.Image = ((System.Drawing.Image)(resources.GetObject("pbCadastroAnimais.Image")));
            this.pbCadastroAnimais.Location = new System.Drawing.Point(63, 0);
            this.pbCadastroAnimais.Margin = new System.Windows.Forms.Padding(0);
            this.pbCadastroAnimais.Name = "pbCadastroAnimais";
            this.pbCadastroAnimais.Size = new System.Drawing.Size(65, 65);
            this.pbCadastroAnimais.TabIndex = 1;
            this.pbCadastroAnimais.TabStop = false;
            this.pbCadastroAnimais.Click += new System.EventHandler(this.pbCadastroAnimais_Click);
            // 
            // pbCadastroPessoas
            // 
            this.pbCadastroPessoas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCadastroPessoas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbCadastroPessoas.Image = ((System.Drawing.Image)(resources.GetObject("pbCadastroPessoas.Image")));
            this.pbCadastroPessoas.Location = new System.Drawing.Point(-1, 0);
            this.pbCadastroPessoas.Margin = new System.Windows.Forms.Padding(0);
            this.pbCadastroPessoas.Name = "pbCadastroPessoas";
            this.pbCadastroPessoas.Size = new System.Drawing.Size(65, 65);
            this.pbCadastroPessoas.TabIndex = 0;
            this.pbCadastroPessoas.TabStop = false;
            this.pbCadastroPessoas.Click += new System.EventHandler(this.pbCadastroPessoas_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(535, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(358, 202);
            this.dataGridView1.TabIndex = 4;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(64, 147);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(55, 20);
            this.lbNome.TabIndex = 5;
            this.lbNome.Text = "Nome:";
            // 
            // lbTelefone
            // 
            this.lbTelefone.AutoSize = true;
            this.lbTelefone.Location = new System.Drawing.Point(54, 196);
            this.lbTelefone.Name = "lbTelefone";
            this.lbTelefone.Size = new System.Drawing.Size(75, 20);
            this.lbTelefone.TabIndex = 6;
            this.lbTelefone.Text = "Telefone:";
            // 
            // eNome
            // 
            this.eNome.Location = new System.Drawing.Point(140, 141);
            this.eNome.Name = "eNome";
            this.eNome.Size = new System.Drawing.Size(330, 26);
            this.eNome.TabIndex = 0;
            // 
            // eTelefone
            // 
            this.eTelefone.Location = new System.Drawing.Point(140, 193);
            this.eTelefone.Mask = "(99) 00000-0000";
            this.eTelefone.Name = "eTelefone";
            this.eTelefone.Size = new System.Drawing.Size(130, 26);
            this.eTelefone.TabIndex = 1;
            // 
            // fPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.eTelefone);
            this.Controls.Add(this.eNome);
            this.Controls.Add(this.lbTelefone);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mnPrincipal);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fPrincipal";
            this.Text = "Rural Simples";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.contextMenuStrip1.ResumeLayout(false);
            this.mnPrincipal.ResumeLayout(false);
            this.mnPrincipal.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbReproducao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCadastroAnimais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCadastroPessoas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pessoasToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mnPrincipal;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pessoasToolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbCadastroPessoas;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbCadastroAnimais;
        private System.Windows.Forms.ToolStripMenuItem animaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estaçãoDeMontaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbReproducao;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbTelefone;
        private System.Windows.Forms.TextBox eNome;
        private System.Windows.Forms.MaskedTextBox eTelefone;
    }
}

