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
    public partial class Form1 : Form//Logueo
    {
        public Form1()
        {
            InitializeComponent();
            controlLoguin1.Solicitar += new EventHandler(Autenticar);
        }
        public void Autenticar(object sender, EventArgs e)
        {
            try
            {
                WebService logueoservice = new WebService();
                Usuarios usuario =logueoservice.Logueo(controlLoguin1.Usuario, controlLoguin1.Contraseña);
                if (usuario is Administrador)
                {
                    this.Hide();
                    Form _unForm = new Principal(usuario);
                    _unForm.ShowDialog();
                    this.Close();

                }

                else
                {
                    lblerror.Text = "Usuario y/o contraseña incorrectas";
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

    }
}
