using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Controles
{
    public class ControlLoguin:ContainerControl
    {
        private Label Logueo;
        private TextBox TxtUsuario;
        private Button btnLoguear;
        private TextBox Txtpass;
      
        public ControlLoguin()
        {
            Logueo = new Label();
            Logueo.Text = "LOGUEO ADMINISTRADOR";
            this.Controls.Add(Logueo);

            TxtUsuario = new TextBox();
            TxtUsuario.Text = "";
            TxtUsuario.Width = 150;
            this.Controls.Add(TxtUsuario);

            Txtpass = new TextBox();
            Txtpass.Text = "";
            Txtpass.Width = 150;
            this.Controls.Add(Txtpass);

            btnLoguear = new Button();
            btnLoguear.Text = "Loguear";
            btnLoguear.Click += new EventHandler(MetodoLogueo);
            this.Controls.Add(btnLoguear);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            
            base.OnPaint(e);
            Logueo.Location = new System.Drawing.Point(40, 0);
            TxtUsuario.Location = new System.Drawing.Point(5, 24);
            Txtpass.Location = new System.Drawing.Point(5, 50);
            btnLoguear.Location = new System.Drawing.Point(5, 90);
           
            
        }
        public event EventHandler Solicitar;

        private void MetodoLogueo(object sender, EventArgs e)
        {
            Solicitar(this, new EventArgs());
 
        }
        public string Usuario
        {
            get { return TxtUsuario.Text.Trim(); }
        }

        public string Contraseña
        {
            get { return Txtpass.Text.Trim(); }
        }

        
     
    }
}
