using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesCompartidas;
using System.Data.SqlClient;
using System.Data;


namespace Persistencia
{
    internal class PersistenciaTelLineas
    {
        internal static void Alta(TelLineas unTelefono, string sigla , SqlTransaction _transaccion)
        {
            
            SqlCommand _comando = new SqlCommand("AltaTelefono", _transaccion.Connection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@sigla", sigla);
            _comando.Parameters.AddWithValue("@NumTel", unTelefono.UnTel);
            SqlParameter _ParmRetorno = new SqlParameter("@Retorno", SqlDbType.Int);
            _ParmRetorno.Direction = ParameterDirection.ReturnValue;
            _comando.Parameters.Add(_ParmRetorno);
            try
            {


                _comando.Transaction = _transaccion;
                _comando.ExecuteNonQuery();

                int retorno = Convert.ToInt32(_ParmRetorno.Value);
                if (retorno == -1)
                    throw new Exception("No existe esa Linea");
                else if (retorno == -2)
                    throw new Exception("Telefono ya existente");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        internal static List<TelLineas> CargoTel(string plinea)
    
        {
            SqlConnection _cnn = new SqlConnection(Conexion.Cnn);

            SqlCommand _comando = new SqlCommand("ListadoTelefonosLinea", _cnn);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@sigla", plinea);

            List<TelLineas> _ListaTels = new List<TelLineas>();

            try
            {
                
                _cnn.Open();

                
                SqlDataReader _lector = _comando.ExecuteReader();

              
                if (_lector.HasRows)
                {
                    while (_lector.Read())
                    {
                        _ListaTels.Add(new TelLineas((string)_lector["NumTel"]));
                    }
                }

                _lector.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _cnn.Close();
            }

            return _ListaTels;
        }
        internal static void EliminarTels(LineasAereas unaLinea, SqlTransaction _pTransaccion)
        {
            SqlCommand _comando = new SqlCommand("EliminoTelsDeLinea", _pTransaccion.Connection);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@sigla", unaLinea.SiglaLinea);
            SqlParameter _ParmRetorno = new SqlParameter("@Retorno", SqlDbType.Int);
            _ParmRetorno.Direction = ParameterDirection.ReturnValue;
            _comando.Parameters.Add(_ParmRetorno);


            try
            {
               
                _comando.Transaction = _pTransaccion;

               
                _comando.ExecuteNonQuery();

                int retorno = Convert.ToInt32(_ParmRetorno.Value);
                if (retorno == -1)
                    throw new Exception("No existe esa Linea");

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
