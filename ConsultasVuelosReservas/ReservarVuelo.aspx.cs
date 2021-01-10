using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Collections.Generic;
using WebFormService;


using System.Messaging;




public partial class ReservarVuelo : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            
            if (!IsPostBack)
            {
                 
                string ocodigo = (string)Session["VueloReserva"];
                Vuelos rvuelo = new WebFormService.WebService().BuscarVuelo(ocodigo);
                int asientoslibres = rvuelo.Asientos - rvuelo.CantReservas;
                ReservarVuelo1.PcodVuelo = rvuelo.CodVuelo.ToString();
                ReservarVuelo1.Pasiento=asientoslibres.ToString();
                ReservarVuelo1.Plinea = rvuelo.Linea.SiglaLinea.ToString();
                ReservarVuelo1.PAerosalida = rvuelo.Aeropuertosalida.CodAero.ToString();
                ReservarVuelo1.Paerollegada = rvuelo.Aeropuertollegada.CodAero.ToString();
                ReservarVuelo1.PFecha = rvuelo.FechaHora.ToString();
                txtcliente.Text = ((Cliente)Session["USU"]).Ndoc.ToString();
              

            }

        }
        catch (System.Web.Services.Protocols.SoapException ex)
        {

            ReservarVuelo1.lblerror.Text = ex.Detail.InnerText;
        }
         catch (Exception ex)
        {
            ReservarVuelo1.lblerror.Text = ex.Message;
        }

    }
    protected void btnreservarr_Click(object sender, EventArgs e)
    {

        try
        {

            string codvuelo = ReservarVuelo1.PcodVuelo;

            int asiento = Convert.ToInt32(ReservarVuelo1.Pasiento);

            int ndoc = Convert.ToInt32(txtcliente.Text);
            Usuarios usuario = new WebFormService.WebService().BuscarUsuario(ndoc);
            Vuelos vuelo = new WebFormService.WebService().BuscarVuelo(codvuelo);
            Cliente cliente = (Cliente)Session["USU"];
            cliente = ((Cliente)usuario);

            Reservas rva = new Reservas();
            rva.UnCliente = cliente;
            rva.Asiento = asiento;
            List<Reservas> _listarva = new List<Reservas>();
            _listarva.Add(rva);


            vuelo.CodVuelo = codvuelo;
            vuelo.Asientos = asiento;
            vuelo.Reservas = _listarva.ToArray();

            string _NombreCola = ConfigurationManager.AppSettings["ColaMsMq"];
            MessageQueue colareservas = new MessageQueue(_NombreCola);


            colareservas.MessageReadPropertyFilter.SetAll();


            ((XmlMessageFormatter)colareservas.Formatter).TargetTypes = new Type[] { typeof(WebFormService.Vuelos), typeof(WebFormService.Cliente), typeof(WebFormService.Reservas) };


            Message _MensajeEnviar = new Message(vuelo);


            MessageQueueTransaction _Transaccion = new MessageQueueTransaction();
            _Transaccion.Begin();
            colareservas.Send(_MensajeEnviar, _Transaccion);
            _Transaccion.Commit();


            ReservarVuelo1.lblerror.ForeColor = System.Drawing.Color.DarkBlue;
            ReservarVuelo1.lblerror.Text = "Su vuelo se ha enviado para que un Administrador la acepte";
        }
        catch (System.Web.Services.Protocols.SoapException ex)
        {

            ReservarVuelo1.lblerror.Text = ex.Detail.InnerText;
        }
        catch (Exception ex)
        {
            ReservarVuelo1.lblerror.Text = ex.Message;
        }

    }

}
