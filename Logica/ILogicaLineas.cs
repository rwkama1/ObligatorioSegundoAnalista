using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesCompartidas;
namespace Logica
{
    public interface ILogicaLineas
    {
        void Alta(LineasAereas L);
        LineasAereas Buscar(string l);
        List<LineasAereas> Listar();
        void Baja(LineasAereas L);
        void Modificar(LineasAereas L);
    }
}
