using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.ServicioWindows;
using System.Messaging;
using System.Configuration;

namespace WindowsFormsApplication1
{
    public partial class AutorizacionReservas : Form
    {
        MessageQueue ColaReservass;
        List<ServicioWindows.Vuelos> _ListaReservasVuelo;
        ServicioWindows.Vuelos objvuelo;

        Usuarios usuario;
        public AutorizacionReservas(Usuarios usu)
        {
            InitializeComponent();
            usuario = usu;
            string _NombreCola = ConfigurationManager.AppSettings["ColaMsMq"];
            ColaReservass = new MessageQueue(_NombreCola);


            ColaReservass.MessageReadPropertyFilter.SetAll();


            ((XmlMessageFormatter)ColaReservass.Formatter).TargetTypes = new Type[] { typeof(ServicioWindows.Vuelos), typeof(ServicioWindows.Cliente) };


            _ListaReservasVuelo = new List<ServicioWindows.Vuelos>();


            objvuelo = null;

        }

        private void AutorizacionReservas_Load(object sender, EventArgs e)
        {
            try
            {

                ColaReservass.ReceiveCompleted += new ReceiveCompletedEventHandler(Recepcion);


                ColaReservass.BeginReceive(new TimeSpan(1, 0, 0, 0));


                DGVPendientes.AutoGenerateColumns = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en MSMQ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AutorizacionReservas_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
          
                if (_ListaReservasVuelo.Count > 0)
                {
                    DialogResult _respuesta = MessageBox.Show("Hay Reservas sin Evaluar. \nSi continua dichas solicitudes se perderan. \nEsta seguro que desea abandonar igual?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                    if (_respuesta == System.Windows.Forms.DialogResult.No)
                        e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                
                    lblerror.Text = ex.Message;
            }
        }

        private void Recepcion(object sender, ReceiveCompletedEventArgs args)
        {
            try
            {

                System.Messaging.Message _unMensaje = ColaReservass.EndReceive(args.AsyncResult);
                ServicioWindows.Vuelos vueloaut = (ServicioWindows.Vuelos)_unMensaje.Body;


                _ListaReservasVuelo.Add(vueloaut);


                ColaReservass.BeginReceive(new TimeSpan(1, 0, 0, 0));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en MSMQ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DGVPendientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnactalizar_Click(object sender, EventArgs e)
        {
            try
            {
                DGVPendientes.DataSource = null;
                DGVPendientes.DataSource = _ListaReservasVuelo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en MSMQ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnautorizar_Click(object sender, EventArgs e)
        {
            try
            {
                new WindowsFormsApplication1.ServicioWindows.WebService().Reserva(objvuelo);

               
                _ListaReservasVuelo.Remove(objvuelo);
                DGVPendientes.DataSource = null;
                DGVPendientes.DataSource = _ListaReservasVuelo;


                lblerror.ForeColor = System.Drawing.Color.DarkGreen;
               lblerror.Text = "Reserva Generada Correctamente";

               txtasiento.Text = "";
               txtcliente.Text = "";
               txtvuelo.Text = "";
        
               btnautorizar.Enabled = false;

               btnRechazado.Enabled = false;
               
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

        private void btnRechazado_Click(object sender, EventArgs e)
        {
            try
             {
                 lblerror.ForeColor = System.Drawing.Color.Red;
                _ListaReservasVuelo.Remove(objvuelo);
                DGVPendientes.DataSource = null;
                DGVPendientes.DataSource = _ListaReservasVuelo;

               
               lblerror.Text = "La Reserva ha sido Rechazada";

               txtasiento.Text = "";
               txtcliente.Text = "";
               txtvuelo.Text = "";
              btnRechazado.Enabled = false;
              btnautorizar.Enabled = false;
               
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

        private void DGVPendientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                objvuelo = _ListaReservasVuelo[e.RowIndex];


                txtcliente.Text = objvuelo.Reservas.Last().UnCliente.Ndoc.ToString();
                txtvuelo.Text = objvuelo.CodVuelo;
                txtasiento.Text = objvuelo.Reservas.Last().Asiento.ToString();

                btnRechazado.Enabled = true;
                btnautorizar.Enabled = true;
            }
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
            }
        }

       
    }
}
