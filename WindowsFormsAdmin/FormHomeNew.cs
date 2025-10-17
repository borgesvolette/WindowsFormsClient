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

namespace WinFormsAdmin
{
    public partial class FormHomeNew : Form
    {
        public FormHomeNew()
        {
            InitializeComponent();
        }


        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (tbxSearch.Text != "")
            {
                string name = tbxSearch.Text;
                string description = tbxDescription.Text;
                ProductClass _product = new ProductClass(0, name, description, 0, true);

                DataTable _dt = _product.ProductSearch(name, description);
                dgvProduct.DataSource = _dt;
            }
            else
            {
                dgvProduct.DataSource = null;
            }
        }

        private void tbxDescription_TextChanged(object sender, EventArgs e)
        {
            if (tbxSearch.Text != "")
            {
                string name = tbxSearch.Text;
                string description = tbxDescription.Text;
                ProductClass _product = new ProductClass(0, name, description, 0, true);

                DataTable _dt = _product.ProductSearch(name, description);
                dgvProduct.DataSource = _dt;
            }
            else
            {
                dgvProduct.DataSource = null;
            }
        }

       
    }
}

