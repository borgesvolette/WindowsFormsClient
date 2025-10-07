namespace WindowsFormsClient
{
    partial class FormHome
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
            this.pnlDarkSlateGray = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnFaq = new System.Windows.Forms.Button();
            this.btnLista = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnInicio = new System.Windows.Forms.Button();
            this._userControlHome = new WindowsFormsClient.UserControlHome();
            this._userControlFAQ = new WindowsFormsClient.UserControlFAQ();
            this._userControlAbout = new WindowsFormsClient.UserControlAbout();
            this._userControlLista = new WindowsFormsClient.UserControlLista();
            this.pnlDarkSlateGray.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDarkSlateGray
            // 
            this.pnlDarkSlateGray.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlDarkSlateGray.Controls.Add(this.btnSair);
            this.pnlDarkSlateGray.Controls.Add(this.btnSobre);
            this.pnlDarkSlateGray.Controls.Add(this.btnFaq);
            this.pnlDarkSlateGray.Controls.Add(this.btnLista);
            this.pnlDarkSlateGray.Controls.Add(this.pbxLogo);
            this.pnlDarkSlateGray.Controls.Add(this.btnInicio);
            this.pnlDarkSlateGray.Location = new System.Drawing.Point(0, 0);
            this.pnlDarkSlateGray.Name = "pnlDarkSlateGray";
            this.pnlDarkSlateGray.Size = new System.Drawing.Size(300, 700);
            this.pnlDarkSlateGray.TabIndex = 9;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnSair.Location = new System.Drawing.Point(37, 659);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(186, 29);
            this.btnSair.TabIndex = 15;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSobre
            // 
            this.btnSobre.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobre.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnSobre.Location = new System.Drawing.Point(58, 400);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(186, 29);
            this.btnSobre.TabIndex = 14;
            this.btnSobre.Text = "Sobre";
            this.btnSobre.UseVisualStyleBackColor = true;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // btnFaq
            // 
            this.btnFaq.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaq.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnFaq.Location = new System.Drawing.Point(58, 348);
            this.btnFaq.Name = "btnFaq";
            this.btnFaq.Size = new System.Drawing.Size(186, 29);
            this.btnFaq.TabIndex = 13;
            this.btnFaq.Text = "FAQ";
            this.btnFaq.UseVisualStyleBackColor = true;
            this.btnFaq.Click += new System.EventHandler(this.btnFaq_Click);
            // 
            // btnLista
            // 
            this.btnLista.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLista.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnLista.Location = new System.Drawing.Point(58, 304);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(186, 29);
            this.btnLista.TabIndex = 12;
            this.btnLista.Text = "Lista";
            this.btnLista.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::WindowsFormsClient.Properties.Resources.recycling_truck;
            this.pbxLogo.Location = new System.Drawing.Point(69, 12);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(130, 130);
            this.pbxLogo.TabIndex = 11;
            this.pbxLogo.TabStop = false;
            // 
            // btnInicio
            // 
            this.btnInicio.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnInicio.Location = new System.Drawing.Point(58, 258);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(186, 29);
            this.btnInicio.TabIndex = 10;
            this.btnInicio.Text = "Início";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // _userControlHome
            // 
            this._userControlHome.Location = new System.Drawing.Point(306, 0);
            this._userControlHome.Name = "_userControlHome";
            this._userControlHome.Size = new System.Drawing.Size(600, 700);
            this._userControlHome.TabIndex = 10;
            // 
            // _userControlFAQ
            // 
            this._userControlFAQ.Location = new System.Drawing.Point(288, 0);
            this._userControlFAQ.Name = "_userControlFAQ";
            this._userControlFAQ.Size = new System.Drawing.Size(600, 700);
            this._userControlFAQ.TabIndex = 11;
            // 
            // _userControlAbout
            // 
            this._userControlAbout.Location = new System.Drawing.Point(306, 0);
            this._userControlAbout.Name = "_userControlAbout";
            this._userControlAbout.Size = new System.Drawing.Size(600, 700);
            this._userControlAbout.TabIndex = 12;
            // 
            // _userControlLista
            // 
            this._userControlLista.Location = new System.Drawing.Point(306, 3);
            this._userControlLista.Name = "_userControlLista";
            this._userControlLista.Size = new System.Drawing.Size(600, 700);
            this._userControlLista.TabIndex = 13;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.pnlDarkSlateGray);
            this.Controls.Add(this._userControlHome);
            this.Controls.Add(this._userControlFAQ);
            this.Controls.Add(this._userControlAbout);
            this.Controls.Add(this._userControlLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.pnlDarkSlateGray.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlDarkSlateGray;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.Button btnFaq;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.PictureBox pbxLogo;
        private UserControlHome _userControlHome;
        private UserControlFAQ _userControlFAQ;
        private UserControlAbout _userControlAbout;
        private UserControlLista _userControlLista;
    }
}