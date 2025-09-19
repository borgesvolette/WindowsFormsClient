namespace WindowsFormsClient
{
    partial class FormLogin
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
            this.pnlDarkSlateGray = new System.Windows.Forms.Panel();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.lblBemVindo2 = new System.Windows.Forms.Label();
            this.lblBemVindo3 = new System.Windows.Forms.Label();
            this.pnlDarkSlateGray.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDarkSlateGray
            // 
            this.pnlDarkSlateGray.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlDarkSlateGray.Controls.Add(this.lblBemVindo3);
            this.pnlDarkSlateGray.Controls.Add(this.lblBemVindo2);
            this.pnlDarkSlateGray.Controls.Add(this.lblBemVindo);
            this.pnlDarkSlateGray.Controls.Add(this.pbxLogo);
            this.pnlDarkSlateGray.Location = new System.Drawing.Point(0, 0);
            this.pnlDarkSlateGray.Name = "pnlDarkSlateGray";
            this.pnlDarkSlateGray.Size = new System.Drawing.Size(400, 700);
            this.pnlDarkSlateGray.TabIndex = 0;
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::WindowsFormsClient.Properties.Resources.recycling_truck;
            this.pbxLogo.Location = new System.Drawing.Point(135, 200);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(130, 130);
            this.pbxLogo.TabIndex = 0;
            this.pbxLogo.TabStop = false;
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnFechar.Location = new System.Drawing.Point(836, 12);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(40, 40);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblBemVindo.Location = new System.Drawing.Point(55, 366);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(301, 45);
            this.lblBemVindo.TabIndex = 1;
            this.lblBemVindo.Text = "Seja Bem Vindo ao";
            // 
            // lblBemVindo2
            // 
            this.lblBemVindo2.AutoSize = true;
            this.lblBemVindo2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo2.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblBemVindo2.Location = new System.Drawing.Point(30, 411);
            this.lblBemVindo2.Name = "lblBemVindo2";
            this.lblBemVindo2.Size = new System.Drawing.Size(367, 45);
            this.lblBemVindo2.TabIndex = 2;
            this.lblBemVindo2.Text = "Sistema de Controle de";
            // 
            // lblBemVindo3
            // 
            this.lblBemVindo3.AutoSize = true;
            this.lblBemVindo3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo3.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblBemVindo3.Location = new System.Drawing.Point(101, 467);
            this.lblBemVindo3.Name = "lblBemVindo3";
            this.lblBemVindo3.Size = new System.Drawing.Size(197, 45);
            this.lblBemVindo3.TabIndex = 3;
            this.lblBemVindo3.Text = " Reciclagem";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pnlDarkSlateGray);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.pnlDarkSlateGray.ResumeLayout(false);
            this.pnlDarkSlateGray.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDarkSlateGray;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Label lblBemVindo3;
        private System.Windows.Forms.Label lblBemVindo2;
    }
}

