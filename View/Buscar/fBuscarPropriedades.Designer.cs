
namespace RuralSimples.View
{
    partial class fBuscarPropriedades
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
            this.eNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eNome.TextChanged += new System.EventHandler(this.eNome_TextChanged);
            // 
            // fBuscarPropriedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.ClientSize = new System.Drawing.Size(1080, 706);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "fBuscarPropriedades";
            this.Text = "Buscar Propriedades";
            this.Shown += new System.EventHandler(this.fBuscarPropriedades_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
