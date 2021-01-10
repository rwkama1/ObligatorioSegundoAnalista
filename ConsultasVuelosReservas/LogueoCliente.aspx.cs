using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormService;

public partial class LogueoCliente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
    {
        try
        {
            WebService web = new WebService();
            Session["USU"] = null;
            string usuario = Login1.UserName.Trim();
            string pass = Login1.Password.Trim();
            Usuarios usu = web.Logueo(usuario, pass);
            Session["USU"] = usu;
            if (usu is Cliente)

                Response.Redirect("ConsultasdeReservas.aspx");
            else
            {
                Label1.Text = "Usuario y/o Contraseña del Cliente incorrectas";
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