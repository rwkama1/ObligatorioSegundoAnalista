using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
    [Serializable]
    public class Administrador:Usuarios
    {
        private bool generavuelos;

        //----------------------------------------
        public bool Generavuelos
        {
            get { return generavuelos; }
            set { generavuelos = value; }
        }
       
        //----------------------------------------
       
        public Administrador(int pndoc, string pnomusu, string pusuario, string pcontr, bool pgeneravuelo)
           : base(pndoc, pnomusu, pusuario, pcontr)
       {
           Generavuelos = pgeneravuelo;
       }
       
         public Administrador()
        {
            
        }

         public override string ToString()
         {
             return base.ToString() + Generavuelos;
         }
        
    }
}
