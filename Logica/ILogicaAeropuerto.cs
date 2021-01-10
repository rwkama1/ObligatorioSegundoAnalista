using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesCompartidas;
namespace Logica
{
   public interface ILogicaAeropuerto
    {
        void AltaAeropuerto(Aeropuerto A);
        void BajaAeropuerto(Aeropuerto E);
        void ModificarAero(Aeropuerto M);
        Aeropuerto BuscarAero(string b);
        List<Aeropuerto> ListarAeropuerto();
       
        List<Aeropuerto> ListarAeropuertoCiudadPartida();
   
    }
}
