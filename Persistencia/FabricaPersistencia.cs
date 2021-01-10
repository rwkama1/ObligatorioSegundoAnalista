using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persistencia
{
    public class FabricaPersistencia
    {
        public static IPersistenciaAeropuerto getPersistenciaAeropuertos()
        {
            return (PersistenciaAeropuertos.GetInstancia());
        }
        public static IPersistenciaAdministrativo getadministrativo()
        {
            return (PersistenciaAdministrativos.GetInstancia());
        }
        public static IPersistenciaCliente getcliente()
        {
            return (PersistenciaClientes.GetInstancia());
        }
        public static IPersistenciaLineas getlineasaereas()
        {
            return (PersistenciaLineasAereas.GetInstancia());
        }
        public static IPersistenciaVuelos getvuelos()
        {
            return (PersistenciaVuelos.GetInstancia());
        }


    }
}
