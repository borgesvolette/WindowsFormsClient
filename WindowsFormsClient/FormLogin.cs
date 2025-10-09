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
using System.Data.SqlClient;


namespace WindowsFormsClient
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            //tela tamanho

            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.FlatAppearance.MouseOverBackColor = Color.Firebrick;
        }
        private ClassUser _user = new ClassUser( 0, "", "", "");
        //private ConnClass _conn = new ConnClass ();

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
                FormHome _formHome = new FormHome();
                _formHome.Show();
                this.Hide();

            }
            else 
            {
                MessageBox.Show("Sem Sucesso");
            
            }

           
            //if (mensagem == "Login feito com sucesso.")
            //{
            //    FormHome _formHome = new FormHome();
            //    _formHome.Show();
            //    this.Hide();
            //}
        }

        /*private void button1_Click(object sender, EventArgs e) // somente para teste // incluir o button // depois e excluir usar somente para teste
        {
            try //tentar executar / try e catch para informar o erro
            {
                using (SqlConnection cn = _conn.GetConnection()) // sql conection cn(variavel)= _conn(objeto)Getconnection(metodo) 
                {
                    cn.Open();
                    MessageBox.Show(cn.ToString(), "Banco de Dados");
                }
             

            }
            catch(Exception erro) //pegar um erro 
            {
                MessageBox.Show(erro.ToString(), "Erro no banco de Dados");

            }
            //finally { }// fecha a porta do codigo// executar mesmo que try falha
        }*/
    }
}
