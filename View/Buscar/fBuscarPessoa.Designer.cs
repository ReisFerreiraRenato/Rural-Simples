
namespace RuralSimples.View
{
    partial class fBuscarPessoa
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
            this.SuspendLayout();
            // 
            // eNome
            // 
            this.eNome.TextChanged += new System.EventHandler(this.eNome_TextChanged);
            // 
            // btSelecionar
            // 
            this.btSelecionar.Click += new System.EventHandler(this.btSelecionar_Click);
            // 
            // fBuscarPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(810, 565);
            this.Name = "fBuscarPessoa";
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.fBuscarPessoa_Scroll);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
