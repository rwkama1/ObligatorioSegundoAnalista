using System;
using System.Collections.Generic;
using System.Linq;
using EntidadesCompartidas;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Persistencia
{
    public interface IPersistenciaLineas
    {
        void Alta(LineasAereas A);
        LineasAereas Busco(string psigla);
        List<LineasAereas> Listo();
        void Modificar(LineasAereas L);
        void Baja(LineasAereas L);
        LineasAereas BuscoSinBajaLogica(string psigla);
    }
}
