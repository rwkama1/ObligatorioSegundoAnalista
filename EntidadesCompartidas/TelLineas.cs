using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
   [Serializable]
    public class TelLineas
    {
        private string untel;
        //------------------------------------------------------------------ //------------------------------------------------------------------
        public string UnTel
        {
            get { return untel; }
            set
            {
                if (value.Trim().Length > 20)
                    throw new Exception("Muchos Numeros para el Telefono");

                if (value.Trim().Length == 0)
                    throw new Exception("El telefono no debe ser null");
                try
                {
                    Convert.ToInt64(value);
                }
                catch
                {
                    throw new Exception("El telefono solo puede tener numeros");
                }
                untel = value;
            }
        }
        //------------------------------------------------------------------
        public TelLineas()
        {

        }
        public TelLineas(string ptel)
        {
            UnTel = ptel;
        }
        
    }
}
