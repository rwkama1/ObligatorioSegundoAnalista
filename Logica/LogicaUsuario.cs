using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesCompartidas;
using Persistencia;

namespace Logica
{
   internal class LogicaUsuario:ILogicaUsuarios
    {
         private static LogicaUsuario instancia = null;
         private LogicaUsuario() { }
         public static LogicaUsuario GetInstancia()
        {
            if (instancia == null)
                instancia = new LogicaUsuario();
            return instancia;
        }
       public void Alta(Usuarios U)
       {
           if (U is Administrador)
           {
               FabricaPersistencia.getadministrativo().Alta((Administrador)U);
           }
           else if(U is Cliente)
           {
               FabricaPersistencia.getcliente().Alta((Cliente)U);
           }
       }
       public Usuarios Logueo(string usuario,string contraseña)
       {
           Usuarios _unusuario = null;
           _unusuario = FabricaPersistencia.getadministrativo().Logueo(usuario, contraseña);
           if (_unusuario == null)
               _unusuario = FabricaPersistencia.getcliente().Logueo(usuario, contraseña);
           return _unusuario;

       }
       public void Baja(Usuarios B)
       {
           if (B is Administrador)
           {
              
               FabricaPersistencia.getadministrativo().Baja((Administrador)B);
           }
       }
       public void Modificar(Usuarios A)
       {
           if (A is Administrador)
           {
               FabricaPersistencia.getadministrativo().Modificar((Administrador)A);
           }
       }
       public Usuarios Buscar(int Ndoc)
       {


           Usuarios usu = null;
           usu = FabricaPersistencia.getadministrativo().Buscar(Ndoc);
           if (usu == null)
           {
               usu = FabricaPersistencia.getcliente().Buscar(Ndoc);
           }
           return usu;
          
       }
      
      
    }
}
