﻿
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPrincipal = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.animaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pessoasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentacaoDeMontaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbReproducao = new System.Windows.Forms.PictureBox();
            this.pbCadastroAnimais = new System.Windows.Forms.PictureBox();
            this.pbCadastroPessoas = new System.Windows.Forms.PictureBox();
            this.reproducaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vacinacaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vermifugacaoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.mnPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReproducao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCadastroAnimais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCadastroPessoas)).BeginInit();
            this.SuspendLayout();
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
            this.movimentacaoDeMontaToolStripMenuItem,
            this.relatoriosToolStripMenuItem,
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
            this.animaisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.animaisToolStripMenuItem.Text = "&Animais";
            this.animaisToolStripMenuItem.Click += new System.EventHandler(this.pbCadastroAnimais_Click);
            // 
            // pessoasToolStripMenuItem1
            // 
            this.pessoasToolStripMenuItem1.Name = "pessoasToolStripMenuItem1";
            this.pessoasToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.pessoasToolStripMenuItem1.Text = "&Pessoas";
            this.pessoasToolStripMenuItem1.Click += new System.EventHandler(this.pbCadastroPessoas_Click);
            // 
            // movimentacaoDeMontaToolStripMenuItem
            // 
            this.movimentacaoDeMontaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reproducaoToolStripMenuItem,
            this.vacinacaoToolStripMenuItem,
            this.vermifugacaoToolStripMenuItem1});
            this.movimentacaoDeMontaToolStripMenuItem.Name = "movimentacaoDeMontaToolStripMenuItem";
            this.movimentacaoDeMontaToolStripMenuItem.Size = new System.Drawing.Size(122, 27);
            this.movimentacaoDeMontaToolStripMenuItem.Text = "&Movimentação";
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
            // reproducaoToolStripMenuItem
            // 
            this.reproducaoToolStripMenuItem.Name = "reproducaoToolStripMenuItem";
            this.reproducaoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reproducaoToolStripMenuItem.Text = "&Reprodução";
            this.reproducaoToolStripMenuItem.Click += new System.EventHandler(this.pbReproducao_Click);
            // 
            // vacinacaoToolStripMenuItem
            // 
            this.vacinacaoToolStripMenuItem.Name = "vacinacaoToolStripMenuItem";
            this.vacinacaoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vacinacaoToolStripMenuItem.Text = "&Vacinação";
            this.vacinacaoToolStripMenuItem.Click += new System.EventHandler(this.vacinacaoToolStripMenuItem_Click);
            // 
            // vermifugacaoToolStripMenuItem1
            // 
            this.vermifugacaoToolStripMenuItem1.Name = "vermifugacaoToolStripMenuItem1";
            this.vermifugacaoToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.vermifugacaoToolStripMenuItem1.Text = "&Vermifugação";
            this.vermifugacaoToolStripMenuItem1.Click += new System.EventHandler(this.vermifugacaoToolStripMenuItem1_Click);
            // 
            // relatoriosToolStripMenuItem
            // 
            this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
            this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(91, 27);
            this.relatoriosToolStripMenuItem.Text = "Relatórios";
            // 
            // fPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mnPrincipal);
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
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.ToolStripMenuItem movimentacaoDeMontaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbReproducao;
        private System.Windows.Forms.ToolStripMenuItem reproducaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vacinacaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vermifugacaoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
    }
}

