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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.pnlDarkSlateGray = new System.Windows.Forms.Panel();
            this.lblBemVindo3 = new System.Windows.Forms.Label();
            this.lblBemVindo2 = new System.Windows.Forms.Label();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.tbxSenha = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.pbxEmail = new System.Windows.Forms.PictureBox();
            this.pbxSenha = new System.Windows.Forms.PictureBox();
            this.pnlDarkSlateGray.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSenha)).BeginInit();
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
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(598, 267);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(141, 21);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Degite seu e-mail:";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmail.Location = new System.Drawing.Point(602, 306);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(237, 24);
            this.tbxEmail.TabIndex = 3;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(598, 371);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(134, 21);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Digite sua senha:";
            // 
            // tbxSenha
            // 
            this.tbxSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSenha.Location = new System.Drawing.Point(616, 395);
            this.tbxSenha.MaxLength = 12;
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.PasswordChar = '*';
            this.tbxSenha.Size = new System.Drawing.Size(107, 24);
            this.tbxSenha.TabIndex = 5;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnEntrar.Location = new System.Drawing.Point(671, 454);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(84, 29);
            this.btnEntrar.TabIndex = 6;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            // 
            // pbxEmail
            // 
            this.pbxEmail.Image = ((System.Drawing.Image)(resources.GetObject("pbxEmail.Image")));
            this.pbxEmail.Location = new System.Drawing.Point(556, 286);
            this.pbxEmail.Name = "pbxEmail";
            this.pbxEmail.Size = new System.Drawing.Size(40, 40);
            this.pbxEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEmail.TabIndex = 7;
            this.pbxEmail.TabStop = false;
            // 
            // pbxSenha
            // 
            this.pbxSenha.Image = ((System.Drawing.Image)(resources.GetObject("pbxSenha.Image")));
            this.pbxSenha.Location = new System.Drawing.Point(556, 379);
            this.pbxSenha.Name = "pbxSenha";
            this.pbxSenha.Size = new System.Drawing.Size(40, 40);
            this.pbxSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSenha.TabIndex = 8;
            this.pbxSenha.TabStop = false;
            this.pbxSenha.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbxSenha_MouseDown);
            this.pbxSenha.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbxSenha_MouseUp);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.pbxSenha);
            this.Controls.Add(this.pbxEmail);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.tbxSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pnlDarkSlateGray);
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.Text = "FormLogin";
            this.pnlDarkSlateGray.ResumeLayout(false);
            this.pnlDarkSlateGray.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSenha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDarkSlateGray;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Label lblBemVindo3;
        private System.Windows.Forms.Label lblBemVindo2;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox tbxSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.PictureBox pbxEmail;
        private System.Windows.Forms.PictureBox pbxSenha;
    }
}

