namespace WindowsFormsAdmin
{
    partial class FormHomeAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHomeAdmin));
            this.pnlDarkSlateGray = new System.Windows.Forms.Panel();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnControle = new System.Windows.Forms.Button();
            this.btnTerceiros = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnEmpresas = new System.Windows.Forms.Button();
            this._userControlControle = new WindowsFormsAdmin.UserControlControle();
            this._userControlEmpresas = new WindowsFormsAdmin.UserControlEmpresas();
            this._userControlUsuario = new WindowsFormsAdmin.UserControUsuario();
            this._userControlTerceiros = new WindowsFormsAdmin.UserControlTerceiros();
            this.pnlDarkSlateGray.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDarkSlateGray
            // 
            this.pnlDarkSlateGray.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlDarkSlateGray.Controls.Add(this.lblAdmin);
            this.pnlDarkSlateGray.Controls.Add(this.btnSair);
            this.pnlDarkSlateGray.Controls.Add(this.btnControle);
            this.pnlDarkSlateGray.Controls.Add(this.btnTerceiros);
            this.pnlDarkSlateGray.Controls.Add(this.btnUsuario);
            this.pnlDarkSlateGray.Controls.Add(this.pbxLogo);
            this.pnlDarkSlateGray.Controls.Add(this.btnEmpresas);
            resources.ApplyResources(this.pnlDarkSlateGray, "pnlDarkSlateGray");
            this.pnlDarkSlateGray.Name = "pnlDarkSlateGray";
            // 
            // lblAdmin
            // 
            resources.ApplyResources(this.lblAdmin, "lblAdmin");
            this.lblAdmin.Name = "lblAdmin";
            // 
            // btnSair
            // 
            resources.ApplyResources(this.btnSair, "btnSair");
            this.btnSair.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnSair.Name = "btnSair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnControle
            // 
            resources.ApplyResources(this.btnControle, "btnControle");
            this.btnControle.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnControle.Name = "btnControle";
            this.btnControle.UseVisualStyleBackColor = true;
            this.btnControle.Click += new System.EventHandler(this.btnControle_Click);
            // 
            // btnTerceiros
            // 
            resources.ApplyResources(this.btnTerceiros, "btnTerceiros");
            this.btnTerceiros.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnTerceiros.Name = "btnTerceiros";
            this.btnTerceiros.UseVisualStyleBackColor = true;
            this.btnTerceiros.Click += new System.EventHandler(this.btnTerceiros_Click);
            // 
            // btnUsuario
            // 
            resources.ApplyResources(this.btnUsuario, "btnUsuario");
            this.btnUsuario.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // pbxLogo
            // 
            resources.ApplyResources(this.pbxLogo, "pbxLogo");
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.TabStop = false;
            // 
            // btnEmpresas
            // 
            resources.ApplyResources(this.btnEmpresas, "btnEmpresas");
            this.btnEmpresas.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnEmpresas.Name = "btnEmpresas";
            this.btnEmpresas.UseVisualStyleBackColor = true;
            this.btnEmpresas.Click += new System.EventHandler(this.btnEmpresas_Click);
            // 
            // _userControlControle
            // 
            resources.ApplyResources(this._userControlControle, "_userControlControle");
            this._userControlControle.Name = "_userControlControle";
            // 
            // _userControlEmpresas
            // 
            resources.ApplyResources(this._userControlEmpresas, "_userControlEmpresas");
            this._userControlEmpresas.Name = "_userControlEmpresas";
            // 
            // _userControlUsuario
            // 
            resources.ApplyResources(this._userControlUsuario, "_userControlUsuario");
            this._userControlUsuario.Name = "_userControlUsuario";
            // 
            // _userControlTerceiros
            // 
            resources.ApplyResources(this._userControlTerceiros, "_userControlTerceiros");
            this._userControlTerceiros.Name = "_userControlTerceiros";
            // 
            // FormHomeAdmin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.pnlDarkSlateGray);
            this.Controls.Add(this._userControlControle);
            this.Controls.Add(this._userControlEmpresas);
            this.Controls.Add(this._userControlUsuario);
            this.Controls.Add(this._userControlTerceiros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHomeAdmin";
            this.pnlDarkSlateGray.ResumeLayout(false);
            this.pnlDarkSlateGray.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDarkSlateGray;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnControle;
        private System.Windows.Forms.Button btnTerceiros;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button btnEmpresas;
        private System.Windows.Forms.Label lblAdmin;
        private UserControlEmpresas _userControlEmpresas;
        private UserControUsuario _userControlUsuario;
        private UserControlTerceiros _userControlTerceiros;
        private UserControlControle _userControlControle;
    }
}