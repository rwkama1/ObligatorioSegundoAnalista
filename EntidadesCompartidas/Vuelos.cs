using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
      [Serializable]
    public class Vuelos
    {
        private string codvuelo;
        private int asientos;
        private DateTime fechahora=DateTime.Now;
        private LineasAereas linea=null;
        private Aeropuerto aeropuertosalida=null;
        private Aeropuerto aeropuertollegada=null;
        private List<Reservas> reservas=null;
        
        //----------------------------------------------------------
        public string CodVuelo
        {
            get { return codvuelo; }
            set 
            {
                if (value.Trim().Length == 18)
                    codvuelo = value;

                else
                    throw new Exception("CodVuelo debe tener 18 caracteres");
            }
        }
        public int Asientos
        {
            get 
            {
                return asientos;
                
            }
            set
            {
                if (value<=0)
                    throw new Exception("No Hay Asientos ");


                else
                    asientos = value;
            }
        }
        public DateTime FechaHora
        {
            get { return fechahora; }
            set { fechahora = value; }
        }
        public LineasAereas Linea
        {
            get { return linea; }
            set
            {
                if (value == null)
                {
                    throw new Exception("No existe linea");

                }
                else
                {
                    linea = value;
                }
            }
        }
        public Aeropuerto Aeropuertosalida
        {
            get { return aeropuertosalida; }
            set
            {
                if (value == null)
                {
                    throw new Exception("No existe AeropuertoSalida");

                }
              
                else
                {
                    aeropuertosalida = value;
                }
            }
        }
        public Aeropuerto Aeropuertollegada
        {
            get { return aeropuertollegada; }
            set{

                if (value == null)
                {
                    throw new Exception("No existe Aeropuertollegada");

                }
                if (value.CodAero == Aeropuertosalida.CodAero)
                {
                    throw new Exception("Los aeropuertos no pueden ser iguales");
                }
                
              
                    aeropuertollegada = value;
               
            }
        }
        public List<Reservas> Reservas
        {
            get {
                return reservas;

            }
            set
            {

                if (value == null)
                {
                    throw new Exception("No existe Reservas");
                }
                else
                {
                    reservas = value;
                }
            }
          
            
        }
        //----------------------------------------------------------------------
          //Propiedades para mostrar los datos en una Grilla,Repeater etc
        public string SiglaLinea
        {
            get { return Linea.SiglaLinea; }
            set { }
        }
        public string CodAeropuertoSalida
        {
            get { return Aeropuertosalida.CodAero; }
            set { }
        }
        public string CodAeropuertoLlegada
        {
            get { return Aeropuertollegada.CodAero; }
            set { }
        }
        public Vuelos(string pcodvuelo, int pasiento,DateTime pfechahora,LineasAereas plineas,Aeropuerto paerosalida,Aeropuerto paerollegada,List<Reservas> preservas)
        {
            CodVuelo = pcodvuelo;
            Asientos = pasiento;
            FechaHora = pfechahora;
            Linea = plineas;
            Aeropuertosalida = paerosalida;
           Aeropuertollegada = paerollegada;
           Reservas = preservas;
        }
        public Vuelos()
        {
          
        }
        public int CantReservas
        {
            get
            {
                return Reservas.Count;
            }
            set 
            {

            }
        }

        public override string ToString()
        {
            return (CodVuelo.ToString() + Asientos.ToString() + FechaHora.ToString() + Linea.SiglaLinea.ToString() + Aeropuertosalida.CodAero.ToString() + Aeropuertollegada.CodAero.ToString());
        }
      
       
    
    }
}
