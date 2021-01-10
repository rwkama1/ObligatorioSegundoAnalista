using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesCompartidas;
using System.Data.SqlClient;
using System.Data;
namespace Persistencia
{
    internal class PersistenciaClientes : IPersistenciaCliente
    {
          private static PersistenciaClientes _instancia = null;
          private PersistenciaClientes() { }
          public static PersistenciaClientes GetInstancia()
        {
            if (_instancia == null)
                _instancia = new PersistenciaClientes();
            return _instancia;
        }
        public Usuarios Logueo(string usuario, string Pass)
        {
             SqlConnection _cnn = new SqlConnection(Conexion.Cnn);
            Usuarios usu = null;

            SqlCommand _comando = new SqlCommand("LogueoCliente", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@usuario", usuario);
            _comando.Parameters.AddWithValue("@contraseña", Pass);

            try
            {
                _cnn.Open();
                SqlDataReader _lector = _comando.ExecuteReader();
                if (_lector.HasRows)
                {
                    _lector.Read();
                    int pndoc = (int)_lector["Ndoc"];
                    string pnombre = (string)_lector["NomUsuario"];
                    string pusuario = (string)_lector["Usuario"];
                    string pcontraseña = (string)_lector["Constraseña"];
                    long ptargeta = (long)_lector["Targeta"];
                    usu = new Cliente(pndoc, pnombre, pusuario, pcontraseña, ptargeta);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _cnn.Close();
            }
            return usu;
        }

  
        public void Alta(Cliente A)
        {
            SqlConnection _cnn = new SqlConnection(Conexion.Cnn);

            SqlCommand _comando = new SqlCommand("AltaCliente", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@Ndoc", A.Ndoc);
            _comando.Parameters.AddWithValue("@Nom", A.NomUsu);
            _comando.Parameters.AddWithValue("@Usuario", A.Usuario);
            _comando.Parameters.AddWithValue("@Constraseña", A.Contraseña);
            _comando.Parameters.AddWithValue("@targeta", A.Targeta);
            SqlParameter _retorno = new SqlParameter("@Retorno", System.Data.SqlDbType.Int);
            _retorno.Direction = System.Data.ParameterDirection.ReturnValue;
            _comando.Parameters.Add(_retorno);

            try
            {
                _cnn.Open();
                _comando.ExecuteNonQuery();
                if ((int)_retorno.Value == -1)
                    throw new Exception("El Ndoc ya existe");
                if ((int)_retorno.Value == -3)
                    throw new Exception("Cuenta Usuario ya existente");
                if ((int)_retorno.Value == -5)
                    throw new Exception("Contraseña debe tener 8 caracteres");
                if ((int)_retorno.Value == -6)
                    throw new Exception("Targeta debe tener 16 digitos");
                
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
        public Cliente Buscar(int Ndoc)
        {


            Cliente a = null;
            SqlConnection oConexion = new SqlConnection(Conexion.Cnn);
            SqlCommand oComando = new SqlCommand("Exec BuscoCliente " + Ndoc, oConexion);

            SqlDataReader oReader;

            try
            {
                oConexion.Open();
                oReader = oComando.ExecuteReader();
                if (oReader.Read())
                {
                    int ndoc = (int)oReader["Ndoc"];
                    string nombre = (string)oReader["NomUsuario"];
                    string usuario = (string)oReader["Usuario"];
                    string contraseña = (string)oReader["Constraseña"];
                    long targeta = (long)oReader["Targeta"];


                    a = new Cliente(ndoc, nombre, usuario, contraseña, targeta);
                }
                oReader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                oConexion.Close();
            }
            return a;
        }
       
    }
}

