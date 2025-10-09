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

namespace WindowsFormsAdmin
{
    public partial class FormLoginAdmin : Form
    {
        public FormLoginAdmin()
        {
            InitializeComponent();
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.FlatAppearance.MouseOverBackColor = Color.Firebrick;

        }
        private ClassUser _user = new ClassUser(0, "", "", "");

        private void btnEntrarAdmin_Click_1(object sender, EventArgs e)
        {
            //Inicialização
            string email = "";
            string password = "";

            //Entrada de dados
            email = tbxEmailAdmin.Text;
            password = tbxSenhaAdmin.Text;

            //Processamento
            //string mensagem = _user.Entrar(email, password);
            //MessageBox.Show(mensagem, "Login"); //Saída

            //if (mensagem == "Login feito com sucesso.")
            //{
            //    FormHomeAdmin _formHomeAdmin = new FormHomeAdmin();
            //    _formHomeAdmin.Show();
            //    this.Hide();
            //}
        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
                Application.Exit(); //FEcha todos os Forms
                                    //this.Close(); fecha apenas o formulario Atual
        }

        private void pbxSenhaAdmin_MouseDown(object sender, MouseEventArgs e)
        {
            tbxSenhaAdmin.PasswordChar = '\0';
        }

        private void pbxSenhaAdmin_MouseUp(object sender, MouseEventArgs e)
        {
            tbxSenhaAdmin.PasswordChar = '*';
        }


    }
}
