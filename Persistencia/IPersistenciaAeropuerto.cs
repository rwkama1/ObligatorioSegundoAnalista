using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesCompartidas;
namespace Persistencia
{
    public interface IPersistenciaAeropuerto
    {
        void AltaAeropuerto(Aeropuerto A);
        void BajaAeropuerto(Aeropuerto A);
        void ModificarAeropuerto(Aeropuerto A);
        Aeropuerto BuscarAeropuerto(string pCodigo);
        List<Aeropuerto> ListarAeropuerto();
        Aeropuerto BuscarAeropuertosinBaja(string pCodigo);
       
        List<Aeropuerto> ListarAeropuertoCiudadPartida();
    }
}
