namespace WindowsFormsAdmin
{
    partial class Registrar
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxSenha = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.llblRegistrar = new System.Windows.Forms.LinkLabel();
            this.rbtnAdmin = new System.Windows.Forms.RadioButton();
            this.lblCargo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(66, 70);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(66, 142);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(66, 213);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha:";
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(198, 70);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(158, 20);
            this.tbxNome.TabIndex = 3;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(198, 135);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(158, 20);
            this.tbxEmail.TabIndex = 4;
            // 
            // tbxSenha
            // 
            this.tbxSenha.Location = new System.Drawing.Point(198, 210);
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.Size = new System.Drawing.Size(158, 20);
            this.tbxSenha.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(145, 307);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // llblRegistrar
            // 
            this.llblRegistrar.AutoSize = true;
            this.llblRegistrar.Location = new System.Drawing.Point(110, 272);
            this.llblRegistrar.Name = "llblRegistrar";
            this.llblRegistrar.Size = new System.Drawing.Size(144, 13);
            this.llblRegistrar.TabIndex = 7;
            this.llblRegistrar.TabStop = true;
            this.llblRegistrar.Text = "Já tem cadastro? Faça Login";
            
            // 
            // rbtnAdmin
            // 
            this.rbtnAdmin.AutoSize = true;
            this.rbtnAdmin.Location = new System.Drawing.Point(45, 379);
            this.rbtnAdmin.Name = "rbtnAdmin";
            this.rbtnAdmin.Size = new System.Drawing.Size(88, 17);
            this.rbtnAdmin.TabIndex = 8;
            this.rbtnAdmin.TabStop = true;
            this.rbtnAdmin.Text = "Administrador";
            this.rbtnAdmin.UseVisualStyleBackColor = true;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(42, 350);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(35, 13);
            this.lblCargo.TabIndex = 9;
            this.lblCargo.Text = "Cargo";
            // 
            // Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(451, 433);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.rbtnAdmin);
            this.Controls.Add(this.llblRegistrar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.tbxSenha);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Name = "Registrar";
            this.Text = "FormRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxSenha;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.LinkLabel llblRegistrar;
        private System.Windows.Forms.RadioButton rbtnAdmin;
        private System.Windows.Forms.Label lblCargo;
    }
}