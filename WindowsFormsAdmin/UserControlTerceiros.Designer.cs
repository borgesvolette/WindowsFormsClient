namespace WindowsFormsAdmin
{
    partial class UserControlTerceiros
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
            this.lblTerceiros = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTerceiros
            // 
            this.lblTerceiros.AutoSize = true;
            this.lblTerceiros.Location = new System.Drawing.Point(233, 216);
            this.lblTerceiros.Name = "lblTerceiros";
            this.lblTerceiros.Size = new System.Drawing.Size(51, 13);
            this.lblTerceiros.TabIndex = 0;
            this.lblTerceiros.Text = "Terceiros";
            // 
            // UserControlTerceiros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblTerceiros);
            this.Name = "UserControlTerceiros";
            this.Size = new System.Drawing.Size(600, 700);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTerceiros;
    }
}
