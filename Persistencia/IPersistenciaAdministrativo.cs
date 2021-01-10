using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesCompartidas;
namespace Persistencia
{
    public interface IPersistenciaAdministrativo
    {
        void Alta(Administrador A);
        Usuarios Logueo(string usuario, string contraseña);
        void Baja(Administrador B);
        void Modificar(Administrador A);
        Administrador Buscar(int Ndoc);
     
    }
}
