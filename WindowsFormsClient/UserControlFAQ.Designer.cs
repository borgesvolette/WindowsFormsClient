namespace WindowsFormsClient
{
    partial class UserControlFAQ
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFAQ = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFAQ
            // 
            this.lblFAQ.AutoSize = true;
            this.lblFAQ.Location = new System.Drawing.Point(264, 255);
            this.lblFAQ.Name = "lblFAQ";
            this.lblFAQ.Size = new System.Drawing.Size(28, 13);
            this.lblFAQ.TabIndex = 0;
            this.lblFAQ.Text = "FAQ";
            // 
            // UserControlFAQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblFAQ);
            this.Name = "UserControlFAQ";
            this.Size = new System.Drawing.Size(600, 700);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFAQ;
    }
}
