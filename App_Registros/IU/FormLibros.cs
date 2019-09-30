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
    public partial class FormLibros : Form
    {
        private FormLibros()
        {
            InitializeComponent();
        }
private static FormLibros instancia = null;

public static FormLibros ObtenerInstancia() {
    if (instancia == null)
    {              
        instancia = new FormLibros();
        instancia.FormClosed += new FormClosedEventHandler(reset);//SOLO PARA FORMULARIOS
    }
    return instancia;
}
                
private static void reset(object sender, FormClosedEventArgs e)//SOLO PARA FORMULARIOS
{
    instancia = null;
}

        private void FormLibros_Load(object sender, EventArgs e)
        {

        }
    }
}
