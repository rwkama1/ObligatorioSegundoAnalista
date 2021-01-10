using System;
using System.Data;
using System.Collections.Generic;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Web.SessionState;
using System.Web.Services;

namespace Controles
{
    public class ReservarVuelo : WebControl, INamingContainer
    {
        private Label lblcodVuelo;
        private Label lblasiento;
        private Label lbllinea;
        private Label lblaerosalida;
        private Label lblaerollegada;
        private Label lblfechahora;
        private TextBox text;
        public Label lblerror;
        private Table Tabla;
        private Panel Unpanel;

        public string PcodVuelo
        {
            get {  return lblcodVuelo.Text; }
            set { EnsureChildControls(); lblcodVuelo.Text = value; }
          
        }
        public string Pasiento
        {
            get {  return lblasiento.Text; }
            set { EnsureChildControls(); lblasiento.Text = value; }
        }
        public string Plinea
        {
            get { return lbllinea.Text; }
            set { EnsureChildControls(); lbllinea.Text = value; }
        }
        public string PAerosalida
        {
            get {  return lblaerosalida.Text; }
            set { EnsureChildControls();  lblaerosalida.Text = value; }
        }
        public string Paerollegada
        {
            get {  return lblaerollegada.Text; }
            set { EnsureChildControls();  lblaerollegada.Text = value; }
        }
        public string PFecha
        {

            get {return lblfechahora.Text; }
            set { EnsureChildControls(); lblfechahora.Text = value; }
        }
        protected override void CreateChildControls()
        {
          
                base.CreateChildControls();
                Unpanel = new Panel();
                    text = new TextBox();
                    text.Text = "RESERVAR VUELO";
                    text.Font.Size = 15;
                    text.Font.Bold = true;
                    text.Font.Underline = true;
                    text.ReadOnly = true;
                    Unpanel.Controls.Add(text);
                    Unpanel.Controls.Add(new LiteralControl("<BR />"));

                    Tabla = new Table();

                    TableRow fila2 = new TableRow();
                    TableRow fila3 = new TableRow();
                    TableRow fila4 = new TableRow();
                    TableRow fila5 = new TableRow();
                    TableRow fila6 = new TableRow();
                    TableRow fila7 = new TableRow();

                    TableCell celda1 = new TableCell();
                    TableCell celda2 = new TableCell();
                    TableCell celda3 = new TableCell();
                    TableCell celda4 = new TableCell();
                    TableCell celda5 = new TableCell();
                    TableCell celda6 = new TableCell();

                    lblcodVuelo = new Label();
                    lblcodVuelo.ForeColor = System.Drawing.Color.Green;
                    lblcodVuelo.Font.Bold = true;
                    lblcodVuelo.Height = Unit.Pixel(15);
                    lblcodVuelo.Width = Unit.Pixel(200);
                    celda1.Controls.Add(lblcodVuelo);
                    fila2.Cells.Add(celda1);
                   
                    Unpanel.Controls.Add(new LiteralControl("CodVuelo:"));
                    Unpanel.Controls.Add(lblcodVuelo);
                 
                    Unpanel.Controls.Add(new LiteralControl("<BR/>"));

 
                    lblasiento = new Label();
                    lblasiento.ForeColor = System.Drawing.Color.Green;
                    lblasiento.Font.Bold = true;
                    lblasiento.Height = Unit.Pixel(15);
                    lblasiento.Width = Unit.Pixel(200);
                    celda2.Controls.Add(lblasiento);
                    fila3.Cells.Add(celda2);
                    Unpanel.Controls.Add(new LiteralControl("Asientos Libres:"));
                    Unpanel.Controls.Add(lblasiento);
                    
                    Unpanel.Controls.Add(new LiteralControl("<BR/>"));

                    lbllinea = new Label();
                    lbllinea.ForeColor = System.Drawing.Color.Green;
                    lbllinea.Font.Bold = true;
                    lbllinea.Height = Unit.Pixel(15);
                    lbllinea.Width = Unit.Pixel(200);
                    celda3.Controls.Add(lbllinea);
                    fila4.Cells.Add(celda3);
                    Unpanel.Controls.Add(new LiteralControl("LineaAerea:"));
                    Unpanel.Controls.Add(lbllinea);
                    Unpanel.Controls.Add(new LiteralControl("<BR/>"));

                    lblaerosalida = new Label();
                    lblaerosalida.ForeColor = System.Drawing.Color.Green;
                    lblaerosalida.Font.Bold = true;
                    lblaerosalida.Height = Unit.Pixel(15);
                    lblaerosalida.Width = Unit.Pixel(200);
                    celda4.Controls.Add(lblaerosalida);
                    fila5.Cells.Add(celda4);
                    Unpanel.Controls.Add(new LiteralControl("Aeropuerto Salida:"));
                    Unpanel.Controls.Add(lblaerosalida);
                    
                    Unpanel.Controls.Add(new LiteralControl("<BR/>"));

                    lblaerollegada = new Label();
                    lblaerollegada.ForeColor = System.Drawing.Color.Green;
                    lblaerollegada.Font.Bold = true;
                    lblaerollegada.Height = Unit.Pixel(15);
                    lblaerollegada.Width = Unit.Pixel(200);
                    celda5.Controls.Add(lblaerollegada);
                    fila6.Cells.Add(celda5);
                    
                    Unpanel.Controls.Add(new LiteralControl("Aeropuerto Llegada: "));
                    Unpanel.Controls.Add(lblaerollegada);
                    
                    Unpanel.Controls.Add(new LiteralControl("<BR/>"));


                    lblfechahora = new Label();
                    lblfechahora.ForeColor = System.Drawing.Color.Green;
                    lblfechahora.Font.Bold = true;
                    lblfechahora.Height = Unit.Pixel(15);
                    lblfechahora.Width = Unit.Pixel(200);
                    celda6.Controls.Add(lblfechahora);
                    fila7.Cells.Add(celda6);
                    Unpanel.Controls.Add(new LiteralControl("FechaHora:"));
                    Unpanel.Controls.Add(lblfechahora);
                    Unpanel.Controls.Add(new LiteralControl("<BR/>"));
                    Unpanel.Controls.Add(new LiteralControl("<BR/>"));

                    Tabla.Rows.Add(fila2);
                    Tabla.Rows.Add(fila3);
                    Tabla.Rows.Add(fila4);
                    Tabla.Rows.Add(fila5);
                    Tabla.Rows.Add(fila6);
                    Tabla.Rows.Add(fila7);

                    Unpanel.Controls.Add(Tabla);
                   
                    lblerror = new Label();
                    lblerror.Text = "";
                    Unpanel.Controls.Add(lblerror);
                    Unpanel.Controls.Add(new LiteralControl("<BR />"));
                    Unpanel.Controls.Add(new LiteralControl("<BR />"));
                
               
                this.Controls.Add(Unpanel);
          
        }
    }
}
