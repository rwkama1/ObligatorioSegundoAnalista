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
    public partial class ListadoGeneralVuelos : Form
    {
        private ServicioWindows.Usuarios Usuario;
        private List<ServicioWindows.Vuelos> Vueloo;
        public ListadoGeneralVuelos(ServicioWindows.Usuarios usu)
        {
            InitializeComponent();
            Usuario = usu;
            
        }
        private void FrmListadoGVuelos_Load(object sender, EventArgs e)
        {
            try
            {
                WebService linqService = new WebService();
                List<ServicioWindows.Vuelos> V = linqService.ListarVuelo().ToList();
                DGVVuelo.AutoGenerateColumns = false;
                DGVVuelo.DataSource = V;
                Vueloo = V;
                this.LineaAeresCbo();
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
        protected void LineaAeresCbo()
        {
            WebService linqService = new WebService();
            List<ServicioWindows.LineasAereas> oLineas = linqService.ListarLineas().ToList();


            if (oLineas.Count > 0)
            {
               CBlineasF.DataSource = oLineas;
               CBlineasF.DisplayMember = "SiglaLinea";
               CBlineasF.ValueMember = "SiglaLinea";
             
            }
            else
            {
                lblerror.Text = "Error: no existe ninguna Linea. Debe ingresar una primero.";

                CBlineasF.Enabled = false;
            }
        }
        protected void Limpiar()
        {
            mtxtreserva.Text = "";
            mtxtfecha.Text = "";
            lblerror.Text = "";
        }
        protected void LinqLineasAereas()
        {
            List<ServicioWindows.Vuelos> Vue = Vueloo;

            List<ServicioWindows.Vuelos> resu = (from vuelos in Vue
                                                      where vuelos.Linea.SiglaLinea == CBlineasF.SelectedValue.ToString()
                                                 select vuelos).ToList<ServicioWindows.Vuelos>();

            Limpiar();
           DGVVuelo.DataSource = resu;
      

        }
        protected void LinqCantidadReservas()
        {
            try
            {
                List<ServicioWindows.Vuelos> Vue = Vueloo;

                List<ServicioWindows.Vuelos> resu = (from vuelos in Vue
                                                          where vuelos.CantReservas == Convert.ToInt32(mtxtreserva.Text)
                                                     select vuelos).ToList<ServicioWindows.Vuelos>();

                Limpiar();
               DGVVuelo.DataSource = resu;
            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {

                lblerror.Text = ex.Detail.InnerText;

            }
            catch(Exception ex)
            {
                lblerror.Text = ex.Message;

            }

        }
        protected void LinqFechaPartida()
        {
             try
            {
                    DateTime fecha = Convert.ToDateTime(mtxtfecha.Text);


                    List<ServicioWindows.Vuelos> Vue = Vueloo;

                    List<ServicioWindows.Vuelos> resu = (from vuelos in Vue
                                         where vuelos.FechaHora.ToShortDateString() == fecha.ToShortDateString()
                                                         select vuelos).ToList<ServicioWindows.Vuelos>();

                    Limpiar();
                   DGVVuelo.DataSource = resu;
                   
             }
             catch (System.Web.Services.Protocols.SoapException ex)
             {

                 lblerror.Text = ex.Detail.InnerText;

             }
                catch(Exception ex)
            {
                    
                lblerror.Text = ex.Message;

            }
            
         
        }

        private void btnlineas_Click(object sender, EventArgs e)
        {
            LinqLineasAereas();
        }

        private void btnconjunto_Click(object sender, EventArgs e)
        {
            List<ServicioWindows.Vuelos> _listaTotal = Vueloo;

        try
        {

            if (CBconjunto.SelectedIndex == -1)
            {

                MessageBox.Show("No se selecciono ninguna opcion ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (CBconjunto.SelectedIndex == 0)
            {
                LinqLineasAereas();
            }
            else if (CBconjunto.SelectedIndex == 1)
            {
                LinqCantidadReservas();
            }
            else if (CBconjunto.SelectedIndex == 2)
            {
                LinqFechaPartida();
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

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            List<ServicioWindows.Vuelos> Vue = Vueloo;

            List<ServicioWindows.Vuelos> resu = (from vuelos in Vue
                                                 select vuelos).ToList<ServicioWindows.Vuelos>();

            Limpiar();
           DGVVuelo.DataSource = resu;
           
        }


        private void btnreserva_Click(object sender, EventArgs e)
        {
 
                LinqCantidadReservas();

        }

        private void btnfecha_Click(object sender, EventArgs e)
        {

         LinqFechaPartida();

           
        }
        

        
    }
}
