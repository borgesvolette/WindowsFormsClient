namespace WindowsFormsAdmin
{
    partial class FormLoginAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoginAdmin));
            this.pbxSenhaAdmin = new System.Windows.Forms.PictureBox();
            this.pbxEmailAdmin = new System.Windows.Forms.PictureBox();
            this.btnEntrarAdmin = new System.Windows.Forms.Button();
            this.tbxSenhaAdmin = new System.Windows.Forms.TextBox();
            this.lblSenhaAdmin = new System.Windows.Forms.Label();
            this.tbxEmailAdmin = new System.Windows.Forms.TextBox();
            this.lblEmailAdmin = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pnlDarkSlateGray = new System.Windows.Forms.Panel();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblBemVindo3 = new System.Windows.Forms.Label();
            this.lblBemVindo2 = new System.Windows.Forms.Label();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.pbxLogoAdmin = new System.Windows.Forms.PictureBox();
            this.llblRegistrarAdmin = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSenhaAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmailAdmin)).BeginInit();
            this.pnlDarkSlateGray.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxSenhaAdmin
            // 
            this.pbxSenhaAdmin.Image = ((System.Drawing.Image)(resources.GetObject("pbxSenhaAdmin.Image")));
            this.pbxSenhaAdmin.Location = new System.Drawing.Point(495, 383);
            this.pbxSenhaAdmin.Name = "pbxSenhaAdmin";
            this.pbxSenhaAdmin.Size = new System.Drawing.Size(40, 40);
            this.pbxSenhaAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxSenhaAdmin.TabIndex = 17;
            this.pbxSenhaAdmin.TabStop = false;
            // 
            // pbxEmailAdmin
            // 
            this.pbxEmailAdmin.Image = ((System.Drawing.Image)(resources.GetObject("pbxEmailAdmin.Image")));
            this.pbxEmailAdmin.Location = new System.Drawing.Point(495, 275);
            this.pbxEmailAdmin.Name = "pbxEmailAdmin";
            this.pbxEmailAdmin.Size = new System.Drawing.Size(40, 40);
            this.pbxEmailAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxEmailAdmin.TabIndex = 16;
            this.pbxEmailAdmin.TabStop = false;
            // 
            // btnEntrarAdmin
            // 
            this.btnEntrarAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrarAdmin.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnEntrarAdmin.Location = new System.Drawing.Point(606, 440);
            this.btnEntrarAdmin.Name = "btnEntrarAdmin";
            this.btnEntrarAdmin.Size = new System.Drawing.Size(84, 29);
            this.btnEntrarAdmin.TabIndex = 15;
            this.btnEntrarAdmin.Text = "Entrar";
            this.btnEntrarAdmin.UseVisualStyleBackColor = true;
            this.btnEntrarAdmin.Click += new System.EventHandler(this.btnEntrarAdmin_Click_1);
            // 
            // tbxSenhaAdmin
            // 
            this.tbxSenhaAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSenhaAdmin.Location = new System.Drawing.Point(541, 387);
            this.tbxSenhaAdmin.MaxLength = 12;
            this.tbxSenhaAdmin.Name = "tbxSenhaAdmin";
            this.tbxSenhaAdmin.PasswordChar = '*';
            this.tbxSenhaAdmin.Size = new System.Drawing.Size(107, 24);
            this.tbxSenhaAdmin.TabIndex = 14;
            // 
            // lblSenhaAdmin
            // 
            this.lblSenhaAdmin.AutoSize = true;
            this.lblSenhaAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaAdmin.Location = new System.Drawing.Point(537, 359);
            this.lblSenhaAdmin.Name = "lblSenhaAdmin";
            this.lblSenhaAdmin.Size = new System.Drawing.Size(134, 21);
            this.lblSenhaAdmin.TabIndex = 13;
            this.lblSenhaAdmin.Text = "Digite sua senha:";
            // 
            // tbxEmailAdmin
            // 
            this.tbxEmailAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmailAdmin.Location = new System.Drawing.Point(541, 288);
            this.tbxEmailAdmin.Name = "tbxEmailAdmin";
            this.tbxEmailAdmin.Size = new System.Drawing.Size(237, 24);
            this.tbxEmailAdmin.TabIndex = 12;
            this.tbxEmailAdmin.TextChanged += new System.EventHandler(this.tbxEmailAdmin_TextChanged);
            // 
            // lblEmailAdmin
            // 
            this.lblEmailAdmin.AutoSize = true;
            this.lblEmailAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailAdmin.Location = new System.Drawing.Point(537, 255);
            this.lblEmailAdmin.Name = "lblEmailAdmin";
            this.lblEmailAdmin.Size = new System.Drawing.Size(138, 21);
            this.lblEmailAdmin.TabIndex = 11;
            this.lblEmailAdmin.Text = "Digite seu e-mail:";
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnFechar.Location = new System.Drawing.Point(822, -4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(83, 59);
            this.btnFechar.TabIndex = 10;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // pnlDarkSlateGray
            // 
            this.pnlDarkSlateGray.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlDarkSlateGray.Controls.Add(this.lblAdmin);
            this.pnlDarkSlateGray.Controls.Add(this.lblBemVindo3);
            this.pnlDarkSlateGray.Controls.Add(this.lblBemVindo2);
            this.pnlDarkSlateGray.Controls.Add(this.lblBemVindo);
            this.pnlDarkSlateGray.Controls.Add(this.pbxLogoAdmin);
            this.pnlDarkSlateGray.Location = new System.Drawing.Point(0, 0);
            this.pnlDarkSlateGray.Name = "pnlDarkSlateGray";
            this.pnlDarkSlateGray.Size = new System.Drawing.Size(400, 700);
            this.pnlDarkSlateGray.TabIndex = 9;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(119, 279);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(58, 21);
            this.lblAdmin.TabIndex = 4;
            this.lblAdmin.Text = "Admin";
            // 
            // lblBemVindo3
            // 
            this.lblBemVindo3.AutoSize = true;
            this.lblBemVindo3.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo3.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblBemVindo3.Location = new System.Drawing.Point(115, 432);
            this.lblBemVindo3.Name = "lblBemVindo3";
            this.lblBemVindo3.Size = new System.Drawing.Size(162, 45);
            this.lblBemVindo3.TabIndex = 3;
            this.lblBemVindo3.Text = " Resíduos";
            // 
            // lblBemVindo2
            // 
            this.lblBemVindo2.AutoSize = true;
            this.lblBemVindo2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo2.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblBemVindo2.Location = new System.Drawing.Point(33, 387);
            this.lblBemVindo2.Name = "lblBemVindo2";
            this.lblBemVindo2.Size = new System.Drawing.Size(340, 45);
            this.lblBemVindo2.TabIndex = 2;
            this.lblBemVindo2.Text = "Sistema de Gestão de";
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblBemVindo.Location = new System.Drawing.Point(68, 342);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(301, 45);
            this.lblBemVindo.TabIndex = 1;
            this.lblBemVindo.Text = "Seja Bem Vindo ao";
            // 
            // pbxLogoAdmin
            // 
            this.pbxLogoAdmin.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogoAdmin.Image")));
            this.pbxLogoAdmin.Location = new System.Drawing.Point(127, 146);
            this.pbxLogoAdmin.Name = "pbxLogoAdmin";
            this.pbxLogoAdmin.Size = new System.Drawing.Size(130, 130);
            this.pbxLogoAdmin.TabIndex = 0;
            this.pbxLogoAdmin.TabStop = false;
            // 
            // llblRegistrarAdmin
            // 
            this.llblRegistrarAdmin.AutoSize = true;
            this.llblRegistrarAdmin.Location = new System.Drawing.Point(616, 516);
            this.llblRegistrarAdmin.Name = "llblRegistrarAdmin";
            this.llblRegistrarAdmin.Size = new System.Drawing.Size(153, 13);
            this.llblRegistrarAdmin.TabIndex = 18;
            this.llblRegistrarAdmin.TabStop = true;
            this.llblRegistrarAdmin.Text = "Não tem cadastro? Registre-se";
            this.llblRegistrarAdmin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblRegistrarAdmin_LinkClicked);
            // 
            // FormLoginAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.llblRegistrarAdmin);
            this.Controls.Add(this.pbxSenhaAdmin);
            this.Controls.Add(this.pbxEmailAdmin);
            this.Controls.Add(this.btnEntrarAdmin);
            this.Controls.Add(this.tbxSenhaAdmin);
            this.Controls.Add(this.lblSenhaAdmin);
            this.Controls.Add(this.tbxEmailAdmin);
            this.Controls.Add(this.lblEmailAdmin);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pnlDarkSlateGray);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLoginAdmin";
            this.Text = "FormLoginAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.pbxSenhaAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmailAdmin)).EndInit();
            this.pnlDarkSlateGray.ResumeLayout(false);
            this.pnlDarkSlateGray.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxSenhaAdmin;
        private System.Windows.Forms.PictureBox pbxEmailAdmin;
        private System.Windows.Forms.Button btnEntrarAdmin;
        private System.Windows.Forms.TextBox tbxSenhaAdmin;
        private System.Windows.Forms.Label lblSenhaAdmin;
        private System.Windows.Forms.TextBox tbxEmailAdmin;
        private System.Windows.Forms.Label lblEmailAdmin;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel pnlDarkSlateGray;
        private System.Windows.Forms.Label lblBemVindo3;
        private System.Windows.Forms.Label lblBemVindo2;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.PictureBox pbxLogoAdmin;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.LinkLabel llblRegistrarAdmin;
    }
}

