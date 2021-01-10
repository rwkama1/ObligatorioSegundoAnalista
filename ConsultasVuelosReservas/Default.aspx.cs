using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormService;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                Session["VueloReserva"] = null;

                WebService web = new WebService();
                List<Aeropuerto> Aeropuerto = web.ListarAeropuertoCiudadPartida().ToList();
                foreach (Aeropuerto A in Aeropuerto)
                {
                    MenuItem item = new MenuItem(A.Ciudad);
                    Menu2.Items.Add(item);
                }

            }
        }
        catch (System.Web.Services.Protocols.SoapException ex)
        {

            Label1.Text = ex.Detail.InnerText;
        }
        catch (Exception ex)
        {
            Label1.Text = ex.Message;
        }
    }
    protected void RpListar_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "Reservar")
        {
            try
            {
                if (Session["USU"] is Cliente)
                {
                    string ocodigo = ((TextBox)(e.Item.Controls[1])).Text;
                    Session["VueloReserva"] = ocodigo;
                    Response.Redirect("ReservarVuelo.aspx");


                }
                else
                {
                    Label1.Text = "Solo los clientes pueden entrar a Reservas de Vuelo ";
                }
            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {

                Label1.Text = ex.Detail.InnerText;
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message;

            }
        }
    }
    protected void Menu2_MenuItemClick(object sender, MenuEventArgs e)
    {
        try
        {
            WebService web = new WebService();
            lblmostrar.Text = Menu2.SelectedValue.ToString();
            List<Vuelos> _miLista = web.ListAeroPartidados(Menu2.SelectedValue).ToList();
            RpListar.DataSource = _miLista;
            RpListar.DataBind();

        }
        catch (System.Web.Services.Protocols.SoapException ex)
        {
            
                Label1.Text = ex.Detail.InnerText;
        }
        catch (Exception ex)
        {

            Label1.Text = ex.Message;

        }
    }
}