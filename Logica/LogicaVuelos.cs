using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using EntidadesCompartidas;
using Persistencia;
using System.Data.SqlClient;
using System.Data;

namespace Logica
{
   internal class LogicaVuelos:ILogicaVuelos
    {
        private static LogicaVuelos instancia = null;
        private LogicaVuelos() { }
        public static LogicaVuelos GetInstancia()
        {
            if (instancia == null)
                instancia = new LogicaVuelos();
            return instancia;
        }
       public void Alta(Vuelos V)
       {
           if (V.FechaHora.AddMinutes(-120) < DateTime.Now)
           {
               throw new Exception("La fecha y hora ingresada debe ser mayor a la actual, y se debe dejar tiempo para reservar");

           }
         FabricaPersistencia.getvuelos().Alta(V);
  
       }
       public Vuelos Buscar(string v)
       {
           return FabricaPersistencia.getvuelos().Buscar(v);
           
       }
       public List<Vuelos> Listar()
       {

           return FabricaPersistencia.getvuelos().Listo();
       }
       public void Baja(Vuelos V)
       {
           FabricaPersistencia.getvuelos().Baja(V);
       }
       public void Modificar(Vuelos vuelo)
       {
           FabricaPersistencia.getvuelos().Modificar(vuelo);
 
       }
       
     
       public void Reserva(Vuelos v)
       {
           if (v.CantReservas == v.Asientos)
           {
               throw new Exception("Todos los Asientos estan Reservados");
 
           }
           if (v.FechaHora.AddMinutes(-120) < DateTime.Now)
           {
               throw new Exception("Para reservar un vuelo se deben tener 2 horas anticipacion");
 
           }
     
               FabricaPersistencia.getvuelos().Reserva(v);
               
           
       }
       public List<Vuelos> ListAeroPartidados(string Ae)
       {
           

           return FabricaPersistencia.getvuelos().ListAeroPartidados(Ae);
 
       }
       public List<Vuelos> ListaVuelosXmlCliente(Cliente c)
       {
           return FabricaPersistencia.getvuelos().ListaVuelosXmlCliente(c);

       }
    }
}
