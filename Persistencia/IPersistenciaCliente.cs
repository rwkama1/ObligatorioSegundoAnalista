using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesCompartidas;
namespace Persistencia
{
   public interface IPersistenciaCliente
    {
        void Alta(Cliente A);
        Usuarios Logueo(string usuario, string contraseña);
        Cliente Buscar(int Ndoc);
    }
}
