using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
      [Serializable]
    public class Aeropuerto
    {
        private string codAero;
        private string nomAero;
        private string ciudad;

        //------------------------------------------------------------------ //------------------------------------------------------------------
        public string CodAero
        {
            get { return codAero; }
            set
            {
               
               
                if (value.Length > 3||value.Length <3)
                {
                    throw new Exception("CodAero debe tener 3 caracteres");
                }
               
                codAero = value;
            }
           
        }
        public string NomAero
        {
            get { return nomAero; }
            set
            {
                if (value.Trim().Length > 20 || value.Trim().Length <= 0)
                      throw new Exception("Error en caracteres de Nombre");
                   

                else
                    nomAero = value;
            }
        }
        public string Ciudad
        {
            get { return ciudad; }
            set
            {
                if (value.Trim().Length > 20 || value.Trim().Length <= 0)
                    throw new Exception("Error en caracteres de ciudad");


                else
                    ciudad = value;
            }
        }
        //------------------------------------------------------------------ //------------------------------------------------------------------

        public Aeropuerto(string pcodaero, string pnomaero, string pciudad)
        {
            CodAero = pcodaero;
            NomAero = pnomaero;
            Ciudad= pciudad;

        }
        public Aeropuerto()
        {
    
        }
        
        public override string ToString()
        {
            return ( CodAero.ToString() );
        }
    }
}
