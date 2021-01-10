using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public class FabricaLogica
    {
        public static ILogicaAeropuerto getLogicaAeropuerto()
        {
            return (LogicaAeropuerto.GetInstancia());
        }
        public static ILogicaLineas getlogicalineas()
        {
            return (LogicaLineas.GetInstancia());
        }
        public static ILogicaUsuarios getLogicausuarios()
        {
            return (LogicaUsuario.GetInstancia());
        }
        public static ILogicaVuelos getLogicavuelos()
        {
            return (LogicaVuelos.GetInstancia());
        }
    }
}
