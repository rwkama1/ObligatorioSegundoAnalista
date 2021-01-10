using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormService;
public partial class Clientes : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

       
        if (Session["USU"] == null)
        {
            
            Response.Redirect("~/Default.aspx");

        }
        if (Session["USU"] is WebFormService.Cliente)
        {
            lblmostrar.Text = "BIENVENIDO:" + ((WebFormService.Cliente)Session["USU"]).NomUsu;
 
        }
        if (Session["USU"] is WebFormService.Administrador)
        {

            Response.Redirect("~/Default.aspx");

        }
     
    }
    protected void btndeslogeuo_Click(object sender, EventArgs e)
    {
        Session["USU"] = null;
        Response.Redirect("~/Default.aspx");
    }
}
