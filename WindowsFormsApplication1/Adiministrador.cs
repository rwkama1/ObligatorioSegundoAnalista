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
    public partial class Adiministrador : Form
    {
        
        Usuarios usuario;
        Administrador admin;
        public Adiministrador(Usuarios usu)
        {
            InitializeComponent();
            usuario = usu;
            this.DesActivoBotones();
        }
        private void DesActivoBotones()
        {
            btnalta.Enabled = false;
            btnbaja.Enabled = false;
            btnmod.Enabled = false;
        }

        private void LimpioControles()
        {
            mtxtndoc.Text = "";
            txtusu.Text = "";
            txtcontraseña.Text = "";
            chcGenera.Checked = false;
            txtnombre.Text = "";
            lblerror.Text = "";
        }
        private void txtndoc_Validating(object sender, CancelEventArgs e)
        {
          
            try
            {
                Usuarios usu = null;
                WebService adminservice = new WebService();
                usu = adminservice.BuscarUsuario(Convert.ToInt32(mtxtndoc.Text));
              

                if (usu is Administrador)
                {
                  
                    Administrador admini = ((Administrador)usu);
                    btnalta.Enabled = false;
                    btnbaja.Enabled = true;
                    btnmod.Enabled = true;
                    lblerror.Text = "";

                    admin = admini;
                    mtxtndoc.Text = admin.Ndoc.ToString();
                    txtnombre.Text = admin.NomUsu;
                    txtusu.Text = admin.Usuario;
                    txtcontraseña.Text = admin.Contraseña;
                    chcGenera.Checked = admin.Generavuelos;



                }
                if (usu is Cliente)
                {
                    lblerror.Text = "Eso es un cliente, aca se busca solo Administradores";
                }

                if (usu == null)
                {
                    btnalta.Enabled = true;
                    btnbaja.Enabled = false;
                    btnmod.Enabled = false;
                
                    lblerror.Text = "Ese Administrador no existe,Boton ALTA Habilitado";

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

       

        private void btnalta_Click(object sender, EventArgs e)
        {
            try
            {
                WebService servicioadministrador=new WebService();
                Administrador adminusu = new Administrador()
                {
                    Ndoc = Convert.ToInt32(mtxtndoc.Text.Trim()),
                    NomUsu = txtnombre.Text.Trim(),
                    Usuario = txtusu.Text.Trim(),
                    Contraseña = txtcontraseña.Text.Trim(),
                    Generavuelos = chcGenera.Checked
                };

               

                servicioadministrador.AltaUsuario(adminusu);
                this.DesActivoBotones();
                this.LimpioControles();
                lblerror.Text = "Alta con Exito";
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

        private void btnbaja_Click(object sender, EventArgs e)
        {
            try
            {
                Administrador ad = admin;
                WebService admminservice = new WebService();
                admminservice.BajaUsuario(ad);
                this.DesActivoBotones();
                this.LimpioControles();
                lblerror.Text = "Baja con Exito";
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

        private void btnmod_Click(object sender, EventArgs e)
        {
            try
            {
                WebService admminservice = new WebService();
                Administrador ad = admin;
                admin.Ndoc = Convert.ToInt32(mtxtndoc.Text);
                admin.NomUsu = txtnombre.Text;
                admin.Usuario = txtusu.Text;
                admin.Contraseña = txtcontraseña.Text;
                admin.Generavuelos = chcGenera.Checked;
                admminservice.ModificarUsuario(ad);
                this.DesActivoBotones();
                this.LimpioControles();
                lblerror.Text = "Modificacion con Exito";
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
            LimpioControles();
        }
       
     

       
    }
}
