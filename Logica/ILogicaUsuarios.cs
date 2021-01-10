using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesCompartidas;

namespace Logica
{
    public interface ILogicaUsuarios
    {
        void Alta(Usuarios U);
        Usuarios Logueo(string usuario, string contraseña);
        void Baja(Usuarios B);
        void Modificar(Usuarios A);
       Usuarios Buscar(int Ndoc);
   
    }
    
}
