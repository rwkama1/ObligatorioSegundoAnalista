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
    public partial class Vuelos : Form
    {
        private ServicioWindows.Usuarios usuario;
        private ServicioWindows.Vuelos vue;
        public Vuelos(ServicioWindows.Usuarios usu)
        {
            InitializeComponent();
            
            usuario = usu;
            
       
        }
        private void FrmVuelos_Load(object sender, EventArgs e)
        {
            Grilla();
            LineasEnDropDownList();
            AeroSalidaEnDropDownList();
            AeroLlegadaEnDropDownList();
            CBAeroSalida.Enabled = true;
            CBAerollegada.Enabled = true;
            btnaltavuelo.Enabled = false;
            btnmodificarvuelo.Enabled = false;
            btnbajavuelo.Enabled = false;
 
        }
        private void LimpioControles()
        {
            mtxtCodigo.Text = "";
            mtxtcantasientos.Text = "";
           mtxtfechahora.Text = "";
           AeroSalidaEnDropDownList();
           AeroLlegadaEnDropDownList();
            lblerror.Text = "";
            LineasEnDropDownList();


           vue = null;
            btnaltavuelo.Enabled = false;
            btnmodificarvuelo.Enabled = false;
            btnbajavuelo.Enabled = false;

        }
        protected void LineasEnDropDownList()
        {
            WebService vueloservice = new WebService();

            List<ServicioWindows.LineasAereas> oLineas = vueloservice.ListarLineas().ToList();


            if (oLineas.Count > 0)
            {
                CBLineas.DataSource = oLineas;
                CBLineas.DisplayMember = "SiglaLinea";
                CBLineas.ValueMember = "SiglaLinea";

            }
            else
            {
                lblerror.Text = "Error: no existe ninguna Linea. Debe ingresar una primero.";

                CBLineas.Enabled = false;
            }

        }
        protected void AeroSalidaEnDropDownList()
        {
           

            List<ServicioWindows.Aeropuerto> oAerosalida =new WindowsFormsApplication1.ServicioWindows.WebService().ListarAeropuerto().ToList();


            if (oAerosalida.Count > 0)
            {
               CBAeroSalida.DataSource = oAerosalida;
               CBAeroSalida.DisplayMember = "CodAero";
               CBAeroSalida.ValueMember = "CodAero";

            }
            else
            {
                lblerror.Text = "Error: no existe ningun Aeropuerto. Debe ingresar una primero.";

                CBAeroSalida.Enabled = false;
            }
        }
        protected void AeroLlegadaEnDropDownList()
        {
            WebService vueloservice = new WebService();

            List<ServicioWindows.Aeropuerto> oAerollegada = vueloservice.ListarAeropuerto().ToList();


            if (oAerollegada.Count > 0)
            {
                CBAerollegada.DataSource = oAerollegada;
                CBAerollegada.DisplayMember = "CodAero";
                CBAerollegada.ValueMember = "CodAero";

            }
            else
            {
                lblerror.Text = "Error: no existe ningun Aeropuerto. Debe ingresar una primero.";

                CBAerollegada.Enabled = false;
            }
        }
        protected void Grilla()
        {
            WebService vueloservice = new WebService();
            DGVVuelo.AutoGenerateColumns = false;
            DGVVuelo.DataSource = vueloservice.ListarVuelo().ToList() ;
        }
     
       
           

        private void btnaltavuelo_Click(object sender, EventArgs e)
        {

            {

                try
                {
                    WebService vueloservice = new WebService();
                    string codvuelo = "";
                    int asiento = 0;
                    DateTime fecha = DateTime.Now;
                    string aerosalida = "";
                    string aerollegada = "";
                    string linea = "";


                    asiento = Convert.ToInt32(mtxtcantasientos.Text);
                    codvuelo = mtxtCodigo.Text.Trim();
                    fecha = Convert.ToDateTime(mtxtfechahora.Text);
                    linea = CBLineas.SelectedValue.ToString();
                  
                    aerosalida = CBAeroSalida.Text;
                    aerollegada = CBAerollegada.Text;
                    List<ServicioWindows.Reservas> r = new List<ServicioWindows.Reservas>();
                    ServicioWindows.LineasAereas unalinea = vueloservice.BuscarLineas(linea);
                    
                    ServicioWindows.Aeropuerto salida = vueloservice.BuscarAeropuerto(aerosalida);
                    ServicioWindows.Aeropuerto llegada = vueloservice.BuscarAeropuerto(aerollegada);
                    ServicioWindows.Vuelos altavuelo = new ServicioWindows.Vuelos();
                    altavuelo.CodVuelo = codvuelo;
                    altavuelo.Asientos = asiento;
                    altavuelo.FechaHora = fecha;
                    altavuelo.Aeropuertosalida = salida;
                    altavuelo.Aeropuertollegada = llegada;
                    altavuelo.Linea = unalinea;
                    altavuelo.Reservas = r.ToArray();
                    vueloservice.AltaVuelos(altavuelo);
                    Grilla();
                    LimpioControles();

                    lblerror.Text = "Alta de Vuelos Correcta";
                    CBAeroSalida.Enabled = true;
                    CBAerollegada.Enabled = true;




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
        }

        private void btnbajavuelo_Click(object sender, EventArgs e)
        {

            {
                try
                {

                    WebService vueloservice = new WebService();
                   ServicioWindows.Vuelos V = vue;
                   vueloservice.BajaVuelo(V);


                   CBAeroSalida.Enabled = true;
                   CBAerollegada.Enabled = true;
                    Grilla();
                    LimpioControles();
                    lblerror.Text = "Vuelo Eliminado";


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
        }

        private void btnmodificarvuelo_Click(object sender, EventArgs e)
        {
            try
            {
                WebService vueloservice = new WebService();

                ServicioWindows.Vuelos _unvuelo = vue;
                _unvuelo.Asientos = Convert.ToInt32(mtxtcantasientos.Text);
                _unvuelo.Linea.SiglaLinea = CBLineas.SelectedValue.ToString();

                CBAeroSalida.Enabled = true;
                CBAerollegada.Enabled = true;
                vueloservice.ModificarVuelo(_unvuelo);
                Grilla();
                LimpioControles();
                lblerror.Text = "Vuelo Modificado(Solo se Modifica LineaAerea y Asientos)";


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

        private void btnlimpiarvuelo_Click(object sender, EventArgs e)
        {
            LimpioControles();
            CBAeroSalida.Enabled = true;
            CBAerollegada.Enabled = true;
        }
        private void txtcodigo_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                WebService vueloservice = new WebService();

               
                string cod = mtxtCodigo.Text;
                ServicioWindows.Vuelos _unvuelo = null;
                _unvuelo = vueloservice.BuscarVuelo(cod);
                if (string.IsNullOrWhiteSpace(cod))
                {
                    lblerror.Text = "No se escribio nada";
                }
                else if (cod.Length > 18 || cod.Length < 18)
                {
                   errorProvider1.SetError(mtxtCodigo, "El Codigo de Vuelo debe tener 18 caracteres");
                    e.Cancel = true;
               
                }
             


               
                else if (_unvuelo == null)
                {
                    mtxtfechahora.Mask = "0000/00/00 00:00";
                    mtxtfechahora.Text = cod.Substring(6, 12);
                   CBAerollegada.Text = cod.Substring(3, 3);
                    CBAeroSalida.Text = cod.Substring(0, 3);

                    CBAeroSalida.Enabled = false;
                    CBAerollegada.Enabled = false;
                    btnaltavuelo.Enabled = true;
                    btnmodificarvuelo.Enabled = false;
                    btnbajavuelo.Enabled = false;
                    lblerror.Text = "Ese Vuelo no existe,Boton ALTA Habilitado";
                    errorProvider1.Clear();
                }
                else
                {
                    LimpioControles();
                    btnaltavuelo.Enabled = false;
                    btnmodificarvuelo.Enabled = true;
                    btnbajavuelo.Enabled = true;
                    mtxtfechahora.Mask = "00/00/0000 00:00";
                    vue = _unvuelo;
                    mtxtCodigo.Text = _unvuelo.CodVuelo;
                    mtxtcantasientos.Text = _unvuelo.Asientos.ToString();
                    mtxtfechahora.Text = _unvuelo.FechaHora.ToString();
                    lblerror.Text = "";
                    CBAeroSalida.Text = _unvuelo.Aeropuertosalida.CodAero;
                    CBAerollegada.Text = _unvuelo.Aeropuertollegada.CodAero;
                    CBAeroSalida.Enabled = false;
                    CBAerollegada.Enabled = false;
                       CBLineas.Text = _unvuelo.Linea.SiglaLinea;
                       errorProvider1.Clear();
 
                }
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
      
        
    }
}
