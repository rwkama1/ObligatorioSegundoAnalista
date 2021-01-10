using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
    [Serializable]
    public class Reservas
    {
      
        private Cliente uncliente=null;
        private int asiento;
      //-----------------------------------------
       
        public Cliente UnCliente
        {
            get { return uncliente; }
            set {
                if (value == null)
                {
                    throw new Exception("No existe el cliente");

                }
                else
                    uncliente = value;
            }
        }
        public int Asiento
        {
            get { return asiento; }
            set
            {
                if (value<=0)
                    throw new Exception("El numero de asiento debe ser mayor a 0");


                else
                    asiento = value;
            }
        }
        //-------------------------------------------------------------
        public Reservas( Cliente puncliente,int pasiento)
        {
           
            UnCliente = puncliente;
            Asiento = pasiento;
                

        }
        public Reservas()
        {

        }
        public override string ToString()
        {
            return (this.UnCliente.Ndoc.ToString() + "  " + this.Asiento.ToString());
        }
    }
}
