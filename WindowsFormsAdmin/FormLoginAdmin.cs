using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryUser;
using static System.Net.Mime.MediaTypeNames;

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


        private void btnFecharAdmin_Click(object sender, EventArgs e)
        {
           //Aplication.Exit(); //FEcha todos os Forms
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

        private void btnEntrarAdmin_Click_1(object sender, EventArgs e)
        {

            // Inicialização
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
            //    FormHome _formHome = new FormHome();
            //    _formHome.Show();
            //    this.Hide();
            //}

            DataTable dt = _user.Entrar(email, password);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Sucesso");
                FormHomeAdmin _formHomeAdmin = new FormHomeAdmin();
                _formHomeAdmin.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Sem Sucesso");

            }

        }

        private void llblRegistrarAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registrar _registrar = new Registrar();
            _registrar.Show();
            this.Hide();
        }

        private void tbxEmailAdmin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

//referenciar o botoes fechar 