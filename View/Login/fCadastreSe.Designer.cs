
namespace RuralSimples.View
{
    partial class fCadastreSe
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
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.lbConfirmarSenha = new System.Windows.Forms.Label();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.eLogin = new System.Windows.Forms.TextBox();
            this.eSenha = new System.Windows.Forms.TextBox();
            this.eConfirmarSenha = new System.Windows.Forms.TextBox();
            this.eEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.btSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Location = new System.Drawing.Point(51, 44);
            this.lbLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(51, 19);
            this.lbLogin.TabIndex = 0;
            this.lbLogin.Text = "Login";
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Location = new System.Drawing.Point(51, 117);
            this.lbSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(51, 19);
            this.lbSenha.TabIndex = 1;
            this.lbSenha.Text = "Senha";
            // 
            // lbConfirmarSenha
            // 
            this.lbConfirmarSenha.AutoSize = true;
            this.lbConfirmarSenha.Location = new System.Drawing.Point(51, 199);
            this.lbConfirmarSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbConfirmarSenha.Name = "lbConfirmarSenha";
            this.lbConfirmarSenha.Size = new System.Drawing.Size(126, 19);
            this.lbConfirmarSenha.TabIndex = 2;
            this.lbConfirmarSenha.Text = "Confirmar senha";
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(55, 352);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(140, 48);
            this.btCadastrar.TabIndex = 4;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // eLogin
            // 
            this.eLogin.Location = new System.Drawing.Point(56, 66);
            this.eLogin.Name = "eLogin";
            this.eLogin.Size = new System.Drawing.Size(272, 26);
            this.eLogin.TabIndex = 0;
            // 
            // eSenha
            // 
            this.eSenha.Location = new System.Drawing.Point(56, 139);
            this.eSenha.Name = "eSenha";
            this.eSenha.PasswordChar = '*';
            this.eSenha.Size = new System.Drawing.Size(272, 26);
            this.eSenha.TabIndex = 1;
            // 
            // eConfirmarSenha
            // 
            this.eConfirmarSenha.Location = new System.Drawing.Point(56, 221);
            this.eConfirmarSenha.Name = "eConfirmarSenha";
            this.eConfirmarSenha.PasswordChar = '*';
            this.eConfirmarSenha.Size = new System.Drawing.Size(272, 26);
            this.eConfirmarSenha.TabIndex = 2;
            // 
            // eEmail
            // 
            this.eEmail.Location = new System.Drawing.Point(55, 295);
            this.eEmail.Name = "eEmail";
            this.eEmail.PasswordChar = '*';
            this.eEmail.Size = new System.Drawing.Size(272, 26);
            this.eEmail.TabIndex = 3;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(52, 273);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(56, 19);
            this.lbEmail.TabIndex = 5;
            this.lbEmail.Text = "E-mail";
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(201, 352);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(127, 48);
            this.btSair.TabIndex = 6;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // fCadastreSe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 412);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.eEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.eConfirmarSenha);
            this.Controls.Add(this.eSenha);
            this.Controls.Add(this.eLogin);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.lbConfirmarSenha);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.lbLogin);
            this.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fCadastreSe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rural Simples - Cadastre-se";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Label lbConfirmarSenha;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.TextBox eLogin;
        private System.Windows.Forms.TextBox eSenha;
        private System.Windows.Forms.TextBox eConfirmarSenha;
        private System.Windows.Forms.TextBox eEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Button btSair;
    }
}