using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
  [Serializable]
   public  class Cliente:Usuarios
    {
       private long targeta;
        //------------------------------------------------------------------
       public long Targeta
       {
           get { return targeta; }
           set
           {
               if (value.ToString().Length == 16)
               { targeta = value; }
               else
                   throw new Exception("Targeta debe ser con 16 digitos");
           }
       }
     
        //------------------------------------------------------------------
       public Cliente(int pndoc, string pnomusu, string pusuario, string pcontr, long ptargeta)
           : base(pndoc, pnomusu, pusuario, pcontr)
       {
           Targeta = ptargeta;
       }
       public Cliente()
        {
          
         
        }

       public override string ToString()
       {
           return (Ndoc.ToString());
       }
    }
}
