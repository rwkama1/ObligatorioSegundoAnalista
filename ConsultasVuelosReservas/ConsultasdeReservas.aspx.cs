using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.XPath;
using WebFormService;

public partial class ConsultasdeReservas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {

           
                WebService xmlweb = new WebService();
                int ndoc=((Cliente)Session["USU"]).Ndoc;
                Usuarios usuarioo = xmlweb.BuscarUsuario(ndoc);
                Cliente cli = ((Cliente)usuarioo);
                XmlNode _MiDoc = new WebFormService.WebService().Listavuelosxml(cli);
                XmlDocument _documento = new XmlDocument();
                _documento.LoadXml(_MiDoc.OuterXml);
                Session["Documento"] = _documento;
                XMLListado.DocumentContent = _documento.OuterXml;
          
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
    protected void btnlimpiarfiltroxml_Click(object sender, EventArgs e)
    {
        try
        {
            
            XmlDocument _documento = (XmlDocument)Session["Documento"];


            XmlDocument _DocumentoFiltrado = new XmlDocument();
            _DocumentoFiltrado.LoadXml("<?xml version='1.0' encoding='utf-8' ?> <Raiz> </Raiz>");
            XmlNode _raiz = _DocumentoFiltrado.DocumentElement;


            XPathNavigator _Navegador = _documento.CreateNavigator();
            XPathNodeIterator _Resultado = _Navegador.Select("Raiz/Reservas");
            if (_Resultado.Count > 0)
            {
                while (_Resultado.MoveNext())
                {

                    XmlNode fechaxml = _DocumentoFiltrado.CreateElement("FechaHora");
                    fechaxml.InnerText = _Resultado.Current.SelectSingleNode("FechaHora").ToString();

                    XmlNode aerosalidaxml = _DocumentoFiltrado.CreateElement("Aeropuertosalida");
                    aerosalidaxml.InnerText = _Resultado.Current.SelectSingleNode("Aeropuertosalida").ToString();

                    XmlNode aerollegadaxml = _DocumentoFiltrado.CreateElement("Aeropuertollegada");
                    aerollegadaxml.InnerText = _Resultado.Current.SelectSingleNode("Aeropuertollegada").ToString();

                    XmlNode asiento = _DocumentoFiltrado.CreateElement("Asiento");
                    asiento.InnerText = _Resultado.Current.SelectSingleNode("Asiento").ToString();


                    XmlNode _Nodo = _DocumentoFiltrado.CreateElement("Reservas");
                    _Nodo.AppendChild(fechaxml);
                    _Nodo.AppendChild(aerosalidaxml);
                    _Nodo.AppendChild(aerollegadaxml);
                    _Nodo.AppendChild(asiento);


                    _raiz.AppendChild(_Nodo);

                }


                XMLListado.DocumentContent = _DocumentoFiltrado.OuterXml;
                txtfechaxml.Text = "";
                txtaerosalidaxml.Text = "";
                lblerror.Text = "";
               
            }
            else
                lblerror.Text = "No se pudo limpiar filtro";
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
    protected void btnfechaxml_Click(object sender, EventArgs e)
    {
        lblerror.Text = "";
        try
        {
           
            XmlDocument _documento = (XmlDocument)Session["Documento"];

            XmlDocument _DocumentoFiltrado = new XmlDocument();
            _DocumentoFiltrado.LoadXml("<?xml version='1.0' encoding='utf-8' ?> <Raiz> </Raiz>");
            XmlNode _raiz = _DocumentoFiltrado.DocumentElement;

   
            XPathNavigator _Navegador = _documento.CreateNavigator();
            XPathNodeIterator _Resultado = _Navegador.Select("Raiz/Reservas[FechaHora = " + txtfechaxml.Text + " ]");
            if (_Resultado.Count > 0)
            {
               
                while (_Resultado.MoveNext())
                {

                    XmlNode fechaxml = _DocumentoFiltrado.CreateElement("FechaHora");
                    fechaxml.InnerText = _Resultado.Current.SelectSingleNode("FechaHora").ToString();

                    XmlNode aerosalidaxml = _DocumentoFiltrado.CreateElement("Aeropuertosalida");
                    aerosalidaxml.InnerText = _Resultado.Current.SelectSingleNode("Aeropuertosalida").ToString();

                    XmlNode aerollegadaxml = _DocumentoFiltrado.CreateElement("Aeropuertollegada");
                    aerollegadaxml.InnerText = _Resultado.Current.SelectSingleNode("Aeropuertollegada").ToString();

                    XmlNode asiento = _DocumentoFiltrado.CreateElement("Asiento");
                    asiento.InnerText = _Resultado.Current.SelectSingleNode("Asiento").ToString();



                    XmlNode _Nodo = _DocumentoFiltrado.CreateElement("Reservas");
                    _Nodo.AppendChild(fechaxml);
                    _Nodo.AppendChild(aerosalidaxml);
                    _Nodo.AppendChild(aerollegadaxml);
                    _Nodo.AppendChild(asiento);
                    

                    _raiz.AppendChild(_Nodo);

                }

            
                XMLListado.DocumentContent = _DocumentoFiltrado.OuterXml;

            }
            else
                lblerror.Text = "No existe la fecha";
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
    protected void btnaerosalidaxml_Click(object sender, EventArgs e)
    {
        lblerror.Text = "";
        try
        {
         
          
            XmlDocument _documento = (XmlDocument)Session["Documento"];

         
            XmlDocument _DocumentoFiltrado = new XmlDocument();
            _DocumentoFiltrado.LoadXml("<?xml version='1.0' encoding='utf-8' ?> <Raiz> </Raiz>");
            XmlNode _raiz = _DocumentoFiltrado.DocumentElement;

          
            XPathNavigator _Navegador = _documento.CreateNavigator();
            XPathNodeIterator _Resultado = _Navegador.Select("Raiz/Reservas[Aeropuertosalida = '" + txtaerosalidaxml.Text.ToUpper() + "' ]");
            if (_Resultado.Count > 0)
            {
                while (_Resultado.MoveNext())
                {

                    XmlNode fechaxml = _DocumentoFiltrado.CreateElement("FechaHora");
                    fechaxml.InnerText = _Resultado.Current.SelectSingleNode("FechaHora").ToString();

                    XmlNode aerosalidaxml = _DocumentoFiltrado.CreateElement("Aeropuertosalida");
                    aerosalidaxml.InnerText = _Resultado.Current.SelectSingleNode("Aeropuertosalida").ToString();

                    XmlNode aerollegadaxml = _DocumentoFiltrado.CreateElement("Aeropuertollegada");
                    aerollegadaxml.InnerText = _Resultado.Current.SelectSingleNode("Aeropuertollegada").ToString();

                    XmlNode asiento = _DocumentoFiltrado.CreateElement("Asiento");
                    asiento.InnerText = _Resultado.Current.SelectSingleNode("Asiento").ToString();


                    XmlNode _Nodo = _DocumentoFiltrado.CreateElement("Reservas");
                    _Nodo.AppendChild(fechaxml);
                    _Nodo.AppendChild(aerosalidaxml);
                    _Nodo.AppendChild(aerollegadaxml);
                    _Nodo.AppendChild(asiento);



                    _raiz.AppendChild(_Nodo);

                }


                XMLListado.DocumentContent = _DocumentoFiltrado.OuterXml;

            }
            else
                lblerror.Text = "No existe ese Aeropuerto de Salida";
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