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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            _userControlHome.Visible = true;
            //_userControlFAQ.Visible = false;
            //_userControlAbout.Visible = false;
            //_userControlBooks.visible = false
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            _userControlHome.Visible = false;
        }

        private void btnFaq_Click(object sender, EventArgs e)
        {
            _userControlFAQ.Visible = true;
            _userControlHome.Visible = false;
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            _userControlHome.Visible = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            FormLogin _formlogin = new FormLogin();
            _formlogin.Show();
            this.Hide();
        }

        
    }
}
