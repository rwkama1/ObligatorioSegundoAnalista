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
    public partial class LineasAereas : Form
    {
        private Usuarios usuario;
        private ServicioWindows.LineasAereas linea;
        public LineasAereas(Usuarios usu)
        {
            InitializeComponent();
          
            usuario = usu;
            
        }

        private void FrmLineas_Load(object sender, EventArgs e)
        {

            ListoenGrilla();
            btnaltalineas.Enabled = false;
            btnbajalineas.Enabled = false;
            btnmodificarlineas.Enabled = false;
           

        }
        protected List<TelLineas> ListaTelefonos
        {
            get
            {
               
                List<TelLineas> _lista = new List<TelLineas>();
                
              
                foreach (Object objtel in LBTel.Items)
                {
                    TelLineas tel = new TelLineas() { UnTel = objtel.ToString() };
                    _lista.Add(tel);
                    
                }
                return _lista;
            }

            set
            {
                LBTel.Items.Clear();
                foreach (TelLineas unTel in value)
                {
                    LBTel.Items.Add(unTel.UnTel);
                }
            }
        }
        protected void Limpiar()
        {
            txtsigla.Text = "";
            txtdireccion.Text = "";

            mtxttel.Text = "";
            LBTel.Items.Clear();
            LBTel.SelectedIndex = -1;
            lblerror.Text = "";


            btnaltalineas.Enabled = false;
            btnbajalineas.Enabled = false;
            btnmodificarlineas.Enabled = false;
        }
        protected void ListoenGrilla()
        {
            WebService Lineaservice = new WebService();
            DGVLineas.DataSource = Lineaservice.ListarLineas();
         
        }

       

        private void btnaltatel_Click(object sender, EventArgs e)
        {
            try
            {
                if (mtxttel.Text.Trim().Length > 0)
                {
                    LBTel.Items.Add(mtxttel.Text.Trim());
                    mtxttel.Text = "";
                    lblerror.Text = "Se agrego Correctamente el Telefono a la Lista";
                }
                else
                    lblerror.Text = "No Hay nada ingresado";
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

        private void btnbajatel_Click(object sender, EventArgs e)
        {
            if (LBTel.SelectedIndex >= 0)
            {
                LBTel.Items.RemoveAt(LBTel.SelectedIndex);
                lblerror.Text = "Eliminacion del Telefono de la Lista con Exito";
            }
            else
                lblerror.Text = "Debe Seleccionar un telefono de la lista para eliminar";
        }

        private void btnaltalineas_Click(object sender, EventArgs e)
        {
            try
            {

                WebService lineaservicioalta=new WebService();

                ServicioWindows.LineasAereas linea = new ServicioWindows.LineasAereas();
                linea.SiglaLinea = txtsigla.Text;
                linea.DirLinea = txtdireccion.Text;
                linea.Telefonos = ListaTelefonos.ToArray();

                lineaservicioalta.AltaLineas(linea);


                ListoenGrilla();
                Limpiar();

                lblerror.Text = "Alta de Lineas Aereas + Telefonos  Correcta";



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

        private void btnlistar_Click(object sender, EventArgs e)
        {
            ListoenGrilla();
        }

        private void btnmodificarlineas_Click(object sender, EventArgs e)
        {
            try
            {
                WebService lineaserviciomod = new WebService();
                ServicioWindows.LineasAereas _unlinea = linea;
                _unlinea.SiglaLinea = txtsigla.Text.Trim();
                _unlinea.DirLinea = txtdireccion.Text.Trim();
                _unlinea.Telefonos = ListaTelefonos.ToArray();

                lineaserviciomod.ModificarLineas(_unlinea);
                ListoenGrilla();
                Limpiar();
                lblerror.Text = "Linea Modificada";


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

        private void btnbajalineas_Click(object sender, EventArgs e)
        {
            try
            {
                WebService lineaserviciobaja = new WebService();
                ServicioWindows.LineasAereas _unlinea = linea; ;
                lineaserviciobaja.BajaLineas(_unlinea);
                ListoenGrilla();
                Limpiar();
                lblerror.Text = "Linea Eliminada";


            }
            catch (System.Web.Services.Protocols.SoapException ex)
            {
                lblerror.Text = ex.Detail.InnerText;
            }
            catch (Exception ex)
            {
                btnaltalineas.Enabled = false;
                btnbajalineas.Enabled = false;
                btnmodificarlineas.Enabled = false;
                lblerror.Text = ex.Message;
            }
        }
        private void txtsigla_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                WebService lineaserviciobuscar = new WebService();
                string sigla = txtsigla.Text;
               ServicioWindows.LineasAereas _unaLinea = null;
               _unaLinea = lineaserviciobuscar.BuscarLineas(sigla);
                if (string.IsNullOrWhiteSpace(sigla))
                {
                    lblerror.Text = "No se escribio nada";
                }
                else if (_unaLinea == null)
                {
                  
                    btnaltalineas.Enabled = true;
                    btnmodificarlineas.Enabled = false;
                    btnbajalineas.Enabled = false;
                    lblerror.Text = "Esa Linea no existe,Boton ALTA Habilitado";

                }
                else
                {
                    Limpiar();
                    btnaltalineas.Enabled = false;
                    btnmodificarlineas.Enabled = true;
                    btnbajalineas.Enabled = true;
                    linea = _unaLinea;
                    txtsigla.Text = _unaLinea.SiglaLinea.ToString();
                    txtdireccion.Text = _unaLinea.DirLinea.ToString();

                    ListaTelefonos = _unaLinea.Telefonos.ToList();
                    LBTel.DisplayMember = "UnTel";


                    lblerror.Text = "";

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
