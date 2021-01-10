using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebFormService;
public partial class RegistroCliente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    private void LimpioControles()
    {
      txtndoc.Text = "";
      txtnombre.Text = "";
      txttargeta.Text = "";
      txtcontraseña.Text = "";
      txtusuario.Text = "";
        lblerror.Text = "";
    }
    protected void btnregistrarse_Click(object sender, EventArgs e)
    {
        try
        {

            WebService altaclienteservice = new WebService();
            Cliente cliservice = new Cliente();
            cliservice.Ndoc = Convert.ToInt32(txtndoc.Text.Trim());
            cliservice.NomUsu = txtnombre.Text.Trim();
            cliservice.Usuario = txtusuario.Text.Trim();
            cliservice.Contraseña = txtcontraseña.Text.Trim();
            cliservice.Targeta = Convert.ToInt64(txttargeta.Text.Trim());


            altaclienteservice.AltaUsuario(cliservice);
            this.LimpioControles();
          
            lblerror.Text = "Registro con Exito";
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
    protected void btnlimpiar_Click(object sender, EventArgs e)
    {
        this.LimpioControles();
    }
}