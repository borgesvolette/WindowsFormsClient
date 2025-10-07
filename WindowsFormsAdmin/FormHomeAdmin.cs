using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAdmin
{
    public partial class FormHomeAdmin : Form
    {
        public FormHomeAdmin()
        {
            InitializeComponent();
        }

        private void btnEmpresas_Click(object sender, EventArgs e)
        {
            _userControlEmpresas.Visible = true;
            _userControlUsuario.Visible = false;
            _userControlControle.Visible = false;
            _userControlTerceiros.Visible = false;
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            _userControlEmpresas.Visible = false;
            _userControlUsuario.Visible = true;
            _userControlControle.Visible = false;
            _userControlTerceiros.Visible = false;
        }

        private void btnTerceiros_Click(object sender, EventArgs e)
        {
            _userControlEmpresas.Visible = false;
            _userControlUsuario.Visible = false;
            _userControlControle.Visible = false;
            _userControlTerceiros.Visible = true;
        }

        private void btnControle_Click(object sender, EventArgs e)
        {
            _userControlEmpresas.Visible = false;
            _userControlUsuario.Visible = false;
            _userControlControle.Visible = true;
            _userControlTerceiros.Visible = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            FormLoginAdmin _formloginAdmin = new FormLoginAdmin();
            _formloginAdmin.Show();
            this.Hide();
        }
    }
}
