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
    public partial class Aeropuerto : Form
    {
        private ServicioWindows.Usuarios usuario;
        ServicioWindows.Aeropuerto aero;
        public Aeropuerto(ServicioWindows.Usuarios usu)
        {
            InitializeComponent();
           
                usuario=usu;
              
        }
        private void FrmAeropuerto_Load(object sender, EventArgs e)
        {
           
                Grilla();
                  DesActivoBotones();
          
        }

        private void DesActivoBotones()
        {
            btnalta.Enabled = false;
            btnbaja.Enabled = false;
            btnmodificar.Enabled = false;
        }

        private void LimpioControles()
        {
            mtxtcodaero.Text = "";
            txtnombre.Text = "";
            txtciudad.Text = "";
            lblerror.Text = "";
        }
        private void Grilla()
        {
            LimpioControles();
            WebService serviceaeropuerto = new WebService();
            List<ServicioWindows.Aeropuerto> _lista = serviceaeropuerto.ListarAeropuerto().ToList();

           DGVAero.DataSource = _lista;
            DesActivoBotones();
        }


        private void btnbaja_Click(object sender, EventArgs e)
        {
            try
            {
                ServicioWindows.Aeropuerto _unAero = aero;
                WebService aeroservice = new WebService();
                aeroservice.BajaAeropuerto(_unAero);
                this.DesActivoBotones();
                this.LimpioControles();
                Grilla();
                lblerror.Text = "Baja con Exito";
            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {

                lblerror.Text = ex.Detail.InnerText;
                this.DesActivoBotones();
            }
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
                this.DesActivoBotones();
            }
        }

        private void btnalta_Click(object sender, EventArgs e)
        {
            try
            {
               
             
            
                ServicioWindows.Aeropuerto _unAeropuerto = new ServicioWindows.Aeropuerto();
                _unAeropuerto.CodAero = mtxtcodaero.Text;
                _unAeropuerto.Ciudad = txtciudad.Text.Trim();
                _unAeropuerto.NomAero = txtnombre.Text.Trim();
                new WindowsFormsApplication1.ServicioWindows.WebService().AltaAeropuerto(_unAeropuerto);

              
                this.DesActivoBotones();
                this.LimpioControles();
                Grilla();
                lblerror.Text = "Alta con Exito";
            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {

                lblerror.Text = ex.Detail.InnerText;

            }
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
               
                aero.NomAero = txtnombre.Text.Trim();
                aero.Ciudad = txtciudad.Text.Trim();
                WebService aeroservice = new WebService();
               aeroservice.ModificarAero(aero);
                this.DesActivoBotones();
                this.LimpioControles();
                Grilla();
                lblerror.Text = "Modificacion con Exito";

            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {

                lblerror.Text = ex.Detail.InnerText;
                this.DesActivoBotones();
            }
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
                this.DesActivoBotones();
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            LimpioControles();
        }

      

      
        private void txtcodigo_Validating(object sender, CancelEventArgs e)
        {
            try
            {

                string codigo = mtxtcodaero.Text;
                ServicioWindows.Aeropuerto _unAero = null;
                WebService servicioaero = new WebService();
                _unAero =servicioaero.BuscarAeropuerto(codigo);
                if (string.IsNullOrWhiteSpace(codigo))
                {
                    lblerror.Text = "No se escribio nada";
                }

                else if (codigo.Length > 3 || codigo.Length < 3)
                {
                   EPerror.SetError(mtxtcodaero, "El Codigo de Aeropuerto debe tener 3 caracteres");
                    e.Cancel = true;

                }
                else if (_unAero == null)
                {
                    EPerror.Clear();
                    btnalta.Enabled = true;
                    btnmodificar.Enabled = false;
                    btnbaja.Enabled = false;
                    lblerror.Text = "";
                    lblerror.Text = " Aeropuerto no existe,Boton ALTA Habilitado";

                }
                else
                {
                    EPerror.Clear();
                    btnalta.Enabled = false;
                    btnmodificar.Enabled = true;
                    btnbaja.Enabled = true;
                    aero = _unAero;
                    mtxtcodaero.Text = _unAero.CodAero;
                    txtnombre.Text = _unAero.NomAero;
                    txtciudad.Text = _unAero.Ciudad;
                    lblerror.Text = "";
                }
            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {

                lblerror.Text = ex.Detail.InnerText;
                this.DesActivoBotones();
            }
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
               
               
                this.DesActivoBotones();
            }
        }
        

       

       

    }
}
