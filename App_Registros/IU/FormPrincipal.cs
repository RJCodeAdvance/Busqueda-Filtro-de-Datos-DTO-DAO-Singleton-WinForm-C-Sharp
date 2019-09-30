using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Registros.IU
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClientes frm = FormClientes.ObtenerInstancia();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLibros frm = FormLibros.ObtenerInstancia();
            frm.MdiParent = this;
            frm.Show();
            frm.BringToFront();
        }
    }
}
