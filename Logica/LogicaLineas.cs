using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesCompartidas;
using Persistencia;
namespace Logica
{
    internal class LogicaLineas:ILogicaLineas
    {
          private static LogicaLineas instancia = null;
          private LogicaLineas() { }
          public static LogicaLineas GetInstancia()
        {
            if (instancia == null)
                instancia = new LogicaLineas();
            return instancia;
        }
        public void Alta(LineasAereas L)
        {
            FabricaPersistencia.getlineasaereas().Alta(L);

        }
        public LineasAereas Buscar(string l)
        {
            return FabricaPersistencia.getlineasaereas().Busco(l);

        }
        public List<LineasAereas> Listar()
        {

            return FabricaPersistencia.getlineasaereas().Listo();
        }
        public void Modificar(LineasAereas L)
        {
            FabricaPersistencia.getlineasaereas().Modificar(L);

        }
        public void Baja(LineasAereas L)
        {
            FabricaPersistencia.getlineasaereas().Baja(L);

        }
    }
}
