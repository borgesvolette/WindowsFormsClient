using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsClient
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            //tela tamanho
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit(); //FEcha todos os Forms
            //this.Close(); fecha apenas o formulario Atual
        }

    }
}
