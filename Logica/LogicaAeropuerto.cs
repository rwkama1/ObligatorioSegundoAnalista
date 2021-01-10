using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesCompartidas;
using Persistencia;
namespace Logica
{
    internal class LogicaAeropuerto:ILogicaAeropuerto
    {
          private static LogicaAeropuerto instancia = null;
          private LogicaAeropuerto() { }
          public static LogicaAeropuerto GetInstancia()
        {
            if (instancia == null)
                instancia = new LogicaAeropuerto();
            return instancia;
        }
        public void AltaAeropuerto(Aeropuerto A)
        {
            FabricaPersistencia.getPersistenciaAeropuertos().AltaAeropuerto(A);
           

        }
        public void BajaAeropuerto(Aeropuerto E)
        {
            FabricaPersistencia.getPersistenciaAeropuertos().BajaAeropuerto(E);
        }
        public void ModificarAero(Aeropuerto M)
        {
            FabricaPersistencia.getPersistenciaAeropuertos().ModificarAeropuerto(M);
        }
        public Aeropuerto BuscarAero(string b)
        {
            return FabricaPersistencia.getPersistenciaAeropuertos().BuscarAeropuerto(b);
        }
        public List<Aeropuerto> ListarAeropuerto()
        {
            return FabricaPersistencia.getPersistenciaAeropuertos().ListarAeropuerto();
        }
       
        public List<Aeropuerto> ListarAeropuertoCiudadPartida()
        {
            return FabricaPersistencia.getPersistenciaAeropuertos().ListarAeropuertoCiudadPartida();
 
        }
    }
}
