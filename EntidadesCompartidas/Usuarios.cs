using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntidadesCompartidas
{
      [Serializable]
    public class Usuarios
    {
        private int ndoc;
        private string nomUsu;
        private string usuario;
        private string contraseña;
        //------------------------------------------------------------------
        public int Ndoc
        {
            get { return ndoc; }
            set { ndoc = value; }
        }
        public string NomUsu
        {
            get { return nomUsu; }
            set
            {
                if (value.Trim().Length > 20 || value.Trim().Length <= 0)
                    throw new Exception("Error en caracteres de Nombre Usuario");


                else
                    nomUsu = value;
            }
        }
        public string Usuario
        {
            get { return usuario; }
            set
            {
                if (value.Trim().Length > 20 || value.Trim().Length <= 0)
                    throw new Exception("Error en caracteres de Usuario");


                else
                    usuario = value;
            }
        }
        public string Contraseña
        {
            get { return contraseña; }
            set
            {
                if (value.Trim().Length > 8 || value.Trim().Length<8)
                    throw new Exception("Contraseña debe tener 8 caracteres");
                   
                else
                    contraseña = value;
               
            }
        }
       
        //------------------------------------------------------------------   //------------------------------------------------------------------
        public Usuarios(int pndoc, string pnomusu, string pusuario, string pcontr)
        {
            
            Ndoc = pndoc;
            NomUsu = pnomusu;
            Usuario = pusuario;
            Contraseña = pcontr;
        }
         public Usuarios()
        {
           
        }
         public override string ToString()
         {
             return (this.Ndoc.ToString() + this.NomUsu + this.Usuario + this.Contraseña);
         }
      
        
    }
}
