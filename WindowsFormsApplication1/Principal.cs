using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.ServicioWindows;
namespace WindowsFormsApplication1
{
    public partial class Principal : Form
    {
        private Usuarios usuario;
        public Principal(Usuarios usu)
        {
            InitializeComponent();
            usuario = usu;
            label1.Text ="BIENVENIDO:" +  usu.NomUsu;
        }

        private void vueloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vuelos frmvuelo = new Vuelos(usuario);
            frmvuelo.ShowDialog();
        }

        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adiministrador frmadmin = new Adiministrador(usuario);
            frmadmin.ShowDialog();
        }

        private void lineasAereasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LineasAereas frml = new LineasAereas(usuario);
            frml.ShowDialog();
        }

        private void aeropuertosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aeropuerto frma = new Aeropuerto(usuario);
            frma.ShowDialog();
        }

        private void listaGeneralVuelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListadoGeneralVuelos frmgeneral = new ListadoGeneralVuelos(usuario);
            frmgeneral.ShowDialog();
        }

        private void autorizacionReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutorizacionReservas frmgeneral = new AutorizacionReservas(usuario);
            frmgeneral.ShowDialog();
        }

    }
}
