using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryUser;


namespace WindowsFormsClient
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            //tela tamanho
        }
        private ClassUser _user = new ClassUser( 0, "", "", "");

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit(); //FEcha todos os Forms
            //this.Close(); fecha apenas o formulario Atual
        }

        private void pbxSenha_MouseDown(object sender, MouseEventArgs e)
        {
            tbxSenha.PasswordChar = '\0';

        }

        private void pbxSenha_MouseUp(object sender, MouseEventArgs e)
        {
            tbxSenha.PasswordChar = '*';
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //Inicialização
            string email = "";
            string password = "";

            //Entrada de dados
            email = tbxEmail.Text;
            password = tbxSenha.Text;

            //Processamento
            string mensagem = _user.Entrar(email, password);
            MessageBox.Show(mensagem, "Login"); //Saída

            if (mensagem == "Login feito com sucesso.")
            {
                FormHome _formHome = new FormHome();
                _formHome.Show();
                this.Hide();
            }
        }

    }
}
