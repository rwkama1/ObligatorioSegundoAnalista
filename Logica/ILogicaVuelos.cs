using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public interface ILogicaVuelos
    {
        void Alta(EntidadesCompartidas.Vuelos V);
        EntidadesCompartidas.Vuelos Buscar(string v);
        List<EntidadesCompartidas.Vuelos> Listar();
        void Baja(EntidadesCompartidas.Vuelos V);
        void Modificar(EntidadesCompartidas.Vuelos vuelo);
      
   
        void Reserva(EntidadesCompartidas.Vuelos v);
        List<EntidadesCompartidas.Vuelos> ListAeroPartidados(string Ae);
        List<EntidadesCompartidas.Vuelos> ListaVuelosXmlCliente(EntidadesCompartidas.Cliente c);
    }
}
