using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesCompartidas;
using System.Data.SqlClient;
using System.Data;

namespace Persistencia
{
    internal class PersistenciaLineasAereas:IPersistenciaLineas
    {
          private static PersistenciaLineasAereas _instancia = null;
          private PersistenciaLineasAereas() { }
          public static PersistenciaLineasAereas GetInstancia()
        {
            if (_instancia == null)
                _instancia = new PersistenciaLineasAereas();
            return _instancia;
        }

        public void Alta(LineasAereas L)
        {
       
            
            SqlConnection _cnn = new SqlConnection(Conexion.Cnn);
            SqlCommand _comando = new SqlCommand("AltaLineas", _cnn);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@sigla", L.SiglaLinea);
            _comando.Parameters.AddWithValue("@direccion", L.DirLinea);
            SqlParameter _ParmRetorno = new SqlParameter("@Retorno", SqlDbType.Int);
            _ParmRetorno.Direction = ParameterDirection.ReturnValue;
            _comando.Parameters.Add(_ParmRetorno);
            SqlTransaction _miTransaccion = null;
            try
            {
              
                _cnn.Open();
          
                _miTransaccion = _cnn.BeginTransaction();
              
                _comando.Transaction = _miTransaccion;
                _comando.ExecuteNonQuery();
          
                int afectados = Convert.ToInt32(_ParmRetorno.Value);
                if (afectados == -1)
                    throw new Exception("Linea ya existente");
                else if (afectados == -2)
                    throw new Exception("Error no especificado");

                foreach (TelLineas unTel in L.Telefonos)
                {
                   
                    PersistenciaTelLineas.Alta(unTel, L.SiglaLinea, _miTransaccion);
                }
              
                _miTransaccion.Commit();



            }
            catch (Exception ex)
            {
                _miTransaccion.Rollback();
                throw new Exception(ex.Message);
            }

     
            finally
            {
                _cnn.Close();
            }


        }
        public LineasAereas Busco(string psigla)
        {
            SqlConnection _cnn = new SqlConnection(Conexion.Cnn);
            LineasAereas _unaLinea = null;
            SqlCommand _comando = new SqlCommand("BuscarLineas", _cnn);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@sigla", psigla);

        

            try
            {
                //me conecto
                _cnn.Open();

                //ejecuto consulta
                SqlDataReader _lector = _comando.ExecuteReader();

                //verifico si hay telefonos
                if (_lector.HasRows)
                {
                    _lector.Read();
                    string _sigla = (string)_lector["SiglaLinea"];
                    string _direccion = (string)_lector["Direccion"];
                    _unaLinea = new LineasAereas(_sigla,_direccion,PersistenciaTelLineas.CargoTel(psigla));
                   
                    
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

            //retorno el cliente
            return _unaLinea;
        }
        public List<LineasAereas> Listo()
        {
            SqlConnection _cnn = new SqlConnection(Conexion.Cnn);

            SqlCommand _comando = new SqlCommand("ListoLineas", _cnn);
            _comando.CommandType = CommandType.StoredProcedure;

            List<LineasAereas> _Lista = new List<LineasAereas>();
            LineasAereas linea = null;

            try
            {
                
                _cnn.Open();

              
                SqlDataReader _lector = _comando.ExecuteReader();

              
                if (_lector.HasRows)
                {
                    while (_lector.Read())
                    {
                        string _sigla = (string)_lector["SiglaLinea"];
                        string _direccion = (string)_lector["Direccion"];
                        linea = new LineasAereas(_sigla,_direccion,
                        PersistenciaTelLineas.CargoTel((string)_lector["SiglaLinea"]));
                        

                        _Lista.Add(linea);
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

           
            return _Lista;
        }
        public void Modificar(LineasAereas L)
        {
            SqlConnection _cnn = new SqlConnection(Conexion.Cnn);

            SqlCommand _comando = new SqlCommand("ModificarLineas", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@sigla", L.SiglaLinea);
            _comando.Parameters.AddWithValue("@direccion", L.DirLinea);
            SqlParameter _retorno = new SqlParameter("@Retorno", System.Data.SqlDbType.Int);
            _retorno.Direction = System.Data.ParameterDirection.ReturnValue;
            _comando.Parameters.Add(_retorno);

            SqlTransaction _miTransaccion = null;

            try
            {
               
                _cnn.Open();

                
                _miTransaccion = _cnn.BeginTransaction();



                PersistenciaTelLineas.EliminarTels(L, _miTransaccion);
               
                _comando.Transaction = _miTransaccion;
                _comando.ExecuteNonQuery();
                if ((int)_retorno.Value == -1)
                    throw new Exception("La Linea no existe");
                else if ((int)_retorno.Value == -2)
                    throw new Exception("Error en Modificacion de la linea");

              
                foreach (TelLineas unTel in L.Telefonos)
                {
                    
                    PersistenciaTelLineas.Alta(unTel,L.SiglaLinea,_miTransaccion);
                }

              
                _miTransaccion.Commit();
            }
            catch (Exception ex)
            {
                _miTransaccion.Rollback();
                throw ex;
            }
            finally
            {
                _cnn.Close();
            }
        }
        public void Baja(LineasAereas L)
        {
            SqlConnection _cnn = new SqlConnection(Conexion.Cnn);

            SqlCommand _comando = new SqlCommand("BajaLineas", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@sigla", L.SiglaLinea);
            SqlParameter _retorno = new SqlParameter("@Retorno", System.Data.SqlDbType.Int);
            _retorno.Direction = System.Data.ParameterDirection.ReturnValue;
            _comando.Parameters.Add(_retorno);

            try
            {
                _cnn.Open();
                _comando.ExecuteNonQuery();
                if ((int)_retorno.Value == -1)
                    throw new Exception("Linea No existe");
              
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _cnn.Close();
            }
        }
        public LineasAereas BuscoSinBajaLogica(string psigla)
        {
            SqlConnection _cnn = new SqlConnection(Conexion.Cnn);
            LineasAereas _unaLinea = null;
            SqlCommand _comando = new SqlCommand("BuscarLineassinbajalogica", _cnn);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@sigla", psigla);



            try
            {
                //me conecto
                _cnn.Open();

                //ejecuto consulta
                SqlDataReader _lector = _comando.ExecuteReader();

                //verifico si hay telefonos
                if (_lector.HasRows)
                {
                    _lector.Read();
                    string _sigla = (string)_lector["SiglaLinea"];
                    string _direccion = (string)_lector["Direccion"];
                    _unaLinea = new LineasAereas(_sigla, _direccion, PersistenciaTelLineas.CargoTel(psigla));


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

            //retorno el cliente
            return _unaLinea;
        }
    }
}
