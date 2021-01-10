using System;
using System.Collections.Generic;
using System.Linq;
using EntidadesCompartidas;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Persistencia
{
    public interface IPersistenciaVuelos
    {
        void Alta(Vuelos vuelo);
        Vuelos Buscar(string pvuelo);
        List<Vuelos> Listo();
        void Baja(Vuelos vuelo);
        void Modificar(Vuelos vuelo);
        void Reserva(Vuelos v);
        List<Vuelos> ListAeroPartidados(string Ae);
        List<Vuelos> ListaVuelosXmlCliente(Cliente c);
    }
}
