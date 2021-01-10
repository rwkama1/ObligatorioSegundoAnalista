using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
      [Serializable]
    public class LineasAereas
    {
        private string siglalinea;
        private string dirlinea;
        private List<TelLineas> telefonos=null;
        //------------------------------------------------------------------
        public string SiglaLinea
        {
            get { return siglalinea; }
            set
            {
                if (value.Trim().Length > 20 || value.Trim().Length <= 0)
                    throw new Exception("Error en caracteres de SiglaLinea");


                else
                    siglalinea = value;
            }
        }
        public string DirLinea
        {
            get { return dirlinea; }
            set
            {
                if (value.Trim().Length > 20 || value.Trim().Length <= 0)
                    throw new Exception("Error en caracteres de Direccion");


                else
                    dirlinea = value;
            }
        }
        public List<TelLineas> Telefonos
        {
            get { return telefonos;}
            set {
                if (value == null)
                {
                    throw new Exception("No hay telefonos");
                }
                else
                {
                    telefonos = value;
                }
                }
           
        }
     //----------------------------------------------------------
       
        public LineasAereas(string psigla, string pdireccion,List<TelLineas> ptelefonos)
        {
            SiglaLinea = psigla;
            DirLinea = pdireccion;
            Telefonos = ptelefonos;
        }
        public LineasAereas()
        {
            

        }
       
        public override string ToString()
        {
            return (SiglaLinea.ToString());
        }
    }
}
