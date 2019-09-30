using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App_Registros.DAO;

namespace App_Registros.IU
{
    public partial class FormClientes : Form
    {
    //PATRON SINGLETON
    private FormClientes()
    {
        InitializeComponent();
    }
    private static FormClientes Instancia = null;

    public static FormClientes ObtenerInstancia()
    {
        if (Instancia == null)
        {
            Instancia = new FormClientes();
            Instancia.FormClosed += new FormClosedEventHandler(reset);//SOLO PARA FORMULARIOS
        }        

        return Instancia;
    }
    //FIN SINGLETON        
    private static void reset(object sender, FormClosedEventArgs e)//SOLO PARA FORMULARIOS
    {
        Instancia = null;      
    }

    private void FormClientes_Load(object sender, EventArgs e)
    {
        //MOSTRAR TODO
        VerRegistros("");
    }
    //METOOD VER REGISTROS
    private void VerRegistros(string condicion)
    {
        ClienteDao DAO = new ClienteDao();
        dataGridView1.DataSource = DAO.VerRegistros(condicion);
    }
    //BUSCAR 
    private void btnBuscar_Click(object sender, EventArgs e)
    {
        VerRegistros(txtBuscar.Text);
    }
    //FILTRAR
    private void txtBuscar_TextChanged(object sender, EventArgs e)
    {
        VerRegistros(txtBuscar.Text);
    }
}
}
