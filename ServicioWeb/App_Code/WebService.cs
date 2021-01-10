using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;



using EntidadesCompartidas;
using Logica;
using System.Xml;
using System.Web.Services.Protocols;




/// <summary>
/// Descripción breve de WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio Web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{

    public WebService()
    {

        //Eliminar la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }
    #region SoapOperacion
    private void GeneroSoapException(Exception ex)
    {
      

       
        XmlDocument _undoc = new System.Xml.XmlDocument();
        XmlNode _NodoError = _undoc.CreateNode(XmlNodeType.Element, SoapException.DetailElementName.Name, SoapException.DetailElementName.Namespace);

       
        XmlNode _NodoDetalle = _undoc.CreateNode(XmlNodeType.Element, "Error", "");
        _NodoDetalle.InnerText = ex.Message;
        _NodoError.AppendChild(_NodoDetalle);

       
        SoapException _MiEx = new SoapException("Error WS", SoapException.ClientFaultCode, Context.Request.Url.AbsoluteUri, _NodoError);
        throw _MiEx;
    }
    #endregion
   
    [WebMethod]
    public Cliente SerializarCliente(Cliente cliente)
    {
        return cliente;
    }
    [WebMethod]
    public Administrador SerializarAdmin(Administrador admin)
    {
        return admin;
    }

   
    #region Aeropuerto
    [WebMethod]
    public void AltaAeropuerto(Aeropuerto aero)
    {
        try
        {
            FabricaLogica.getLogicaAeropuerto().AltaAeropuerto(aero);
        }
        catch (Exception ex)
        {
            this.GeneroSoapException(ex);
        }
    }
    [WebMethod]
    public Aeropuerto BuscarAeropuerto(string codigo)
    {
        Aeropuerto aero = null;
        try
        {
            aero = FabricaLogica.getLogicaAeropuerto().BuscarAero(codigo);
        }
        catch (Exception ex)
        {
            this.GeneroSoapException(ex);
        }
        return aero;
    }
    [WebMethod]
    public List<Aeropuerto> ListarAeropuerto()
    {

        List<Aeropuerto> _lista = null;
        try
        {
            _lista = FabricaLogica.getLogicaAeropuerto().ListarAeropuerto();
        }
        catch (Exception ex)
        {
            this.GeneroSoapException(ex);
        }

        return _lista;
    }
    [WebMethod]
    public void BajaAeropuerto(Aeropuerto aero)
    {
        try
        {
            FabricaLogica.getLogicaAeropuerto().BajaAeropuerto(aero);
        }
        catch (Exception ex)
        {
            this.GeneroSoapException(ex);
        }
    }
    [WebMethod]
    public void ModificarAero(Aeropuerto aerom)
    {
        try
        {
            FabricaLogica.getLogicaAeropuerto().ModificarAero(aerom);
        }
        catch (Exception ex)
        {
            this.GeneroSoapException(ex);
        }
    }
    [WebMethod]
    public List<Aeropuerto> ListarAeropuertoCiudadPartida()
    {

        List<Aeropuerto> _listap = null;
        try
        {
            _listap = FabricaLogica.getLogicaAeropuerto().ListarAeropuertoCiudadPartida();
        }
        catch (Exception ex)
        {
            this.GeneroSoapException(ex);
        }

        return _listap;
    }

    #endregion
    #region Lineas
    [WebMethod]
    public void AltaLineas(LineasAereas lineas)
    {
        try
        {
            FabricaLogica.getlogicalineas().Alta(lineas);
        }
        catch (Exception ex)
        {
            this.GeneroSoapException(ex);
        }
    }
     [WebMethod]
    public LineasAereas BuscarLineas(string sigla)
    {
        LineasAereas lineas = null;
        try
        {
            lineas = FabricaLogica.getlogicalineas().Buscar(sigla);
        }
        catch (Exception ex)
        {
            this.GeneroSoapException(ex);
        }
        return lineas;
    }

     [WebMethod]
     public List<LineasAereas> ListarLineas()
     {

         List<LineasAereas> _listal = null;
         try
         {
             _listal = FabricaLogica.getlogicalineas().Listar();
         }
         catch (Exception ex)
         {
             this.GeneroSoapException(ex);
         }

         return _listal;
     }
     [WebMethod]
     public void BajaLineas(LineasAereas linea)
     {
         try
         {
             FabricaLogica.getlogicalineas().Baja(linea);
         }
         catch (Exception ex)
         {
             this.GeneroSoapException(ex);
         }
     }
     [WebMethod]
     public void ModificarLineas(LineasAereas lineam)
     {
         try
         {
             FabricaLogica.getlogicalineas().Modificar(lineam);
         }
         catch (Exception ex)
         {
             this.GeneroSoapException(ex);
         }
     }
    #endregion
    #region Vuelos
     [WebMethod]
     public void AltaVuelos(Vuelos vuelo)
     {
         try
         {
             FabricaLogica.getLogicavuelos().Alta(vuelo);
         }
         catch (Exception ex)
         {
             this.GeneroSoapException(ex);
         }
     }
     [WebMethod]
     public Vuelos BuscarVuelo(string codigo)
     {
         Vuelos vue = null;
         try
         {
             vue = FabricaLogica.getLogicavuelos().Buscar(codigo);
         }
         catch (Exception ex)
         {
             this.GeneroSoapException(ex);
         }
         return vue;
     }
     [WebMethod]
     public List<Vuelos> ListarVuelo()
     {

         List<Vuelos> _listav = null;
         try
         {
             _listav = FabricaLogica.getLogicavuelos().Listar();
         }
         catch (Exception ex)
         {
             this.GeneroSoapException(ex);
         }

         return _listav;
     }
     [WebMethod]
     public void BajaVuelo(Vuelos vuelob)
     {
         try
         {
             FabricaLogica.getLogicavuelos().Baja(vuelob);
         }
         catch (Exception ex)
         {
             this.GeneroSoapException(ex);
         }
     }
     [WebMethod]
     public void ModificarVuelo(Vuelos vuelom)
     {
         try
         {
             FabricaLogica.getLogicavuelos().Modificar(vuelom);
         }
         catch (Exception ex)
         {
             this.GeneroSoapException(ex);
         }
     }
     [WebMethod]
     public void Reserva(Vuelos reserva)
     {
         try
         {
             FabricaLogica.getLogicavuelos().Reserva(reserva);
         }
         catch (Exception ex)
         {
             this.GeneroSoapException(ex);
         }
     }
     [WebMethod]
     public List<Vuelos> ListAeroPartidados(string Ae)
     {

         List<Vuelos> _listava = null;
         try
         {
             _listava = FabricaLogica.getLogicavuelos().ListAeroPartidados(Ae);
         }
         catch (Exception ex)
         {
             this.GeneroSoapException(ex);
         }

         return _listava;
     }
    #endregion
    #region Usuarios
     [WebMethod]
     public Usuarios Logueo(string pUsu, string pPass)
     {
         Usuarios Usuarios = null;
         try
         {
             Usuarios = FabricaLogica.getLogicausuarios().Logueo(pUsu, pPass);
         }
         catch (Exception ex)
         {
             this.GeneroSoapException(ex);
         }
         return Usuarios;
     }
     [WebMethod]
     public void AltaUsuario(Usuarios usu)
     {
         try
         {
             FabricaLogica.getLogicausuarios().Alta(usu);
         }
         catch (Exception ex)
         {
             this.GeneroSoapException(ex);
         }
     }
     [WebMethod]
     public void BajaUsuario(Usuarios usub)
     {
         try
         {
             FabricaLogica.getLogicausuarios().Baja(usub);
         }
         catch (Exception ex)
         {
             this.GeneroSoapException(ex);
         }
     }
     [WebMethod]
     public void ModificarUsuario(Usuarios usum)
     {
         try
         {
             FabricaLogica.getLogicausuarios().Modificar(usum);
         }
         catch (Exception ex)
         {
             this.GeneroSoapException(ex);
         }
     }
     [WebMethod]
     public Usuarios BuscarUsuario(int ndoc)
     {
         Usuarios usu = null;
         try
         {
             usu = FabricaLogica.getLogicausuarios().Buscar(ndoc);
         }
         catch (Exception ex)
         {
             this.GeneroSoapException(ex);
         }
         return usu;
     }

    #endregion
    #region Xml
    [WebMethod]
     public XmlDocument Listavuelosxml(Cliente cli)
     {
         XmlDocument _Documento = new XmlDocument();
         try
         {
             List<Vuelos> listvuelos = FabricaLogica.getLogicavuelos().ListaVuelosXmlCliente(cli);

             _Documento.LoadXml("<?xml version='1.0' encoding='utf-8' ?> <Raiz> </Raiz>");
             XmlNode _raiz = _Documento.DocumentElement;


             foreach (Vuelos V in listvuelos)
             {

                 XmlNode fechaHora = _Documento.CreateElement("FechaHora");
                 fechaHora.InnerText = V.FechaHora.ToString("yyyyMMddHHmm");

                 XmlNode aerosalida = _Documento.CreateElement("Aeropuertosalida");
                 aerosalida.InnerText = V.Aeropuertosalida.CodAero.ToString();
             
                 XmlNode aerollegada = _Documento.CreateElement("Aeropuertollegada");
                 aerollegada.InnerText = V.Aeropuertollegada.CodAero.ToString();
                 XmlNode asiento = _Documento.CreateElement("Asiento");
                 asiento.InnerText = V.Reservas.Last().Asiento.ToString();

                 XmlNode _Nodo = _Documento.CreateElement("Reservas");
                 _Nodo.AppendChild(fechaHora);
                 _Nodo.AppendChild(aerosalida);
                 _Nodo.AppendChild(aerollegada);
                 _Nodo.AppendChild(asiento);
                 _raiz.AppendChild(_Nodo);

             }
         }
         catch (Exception ex)
         {
             this.GeneroSoapException(ex);
         }
     
         return _Documento;
     }

    #endregion
    
}
   

