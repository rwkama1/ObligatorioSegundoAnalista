using System;
using System.Collections.Generic;
using System.Linq;
using EntidadesCompartidas;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Persistencia
{
    internal class PersistenciaAdministrativos:IPersistenciaAdministrativo
    {
        private static PersistenciaAdministrativos _instancia = null;
        private PersistenciaAdministrativos() { }
        public static PersistenciaAdministrativos GetInstancia()
        {
            if (_instancia == null)
                _instancia = new PersistenciaAdministrativos();
            return _instancia;
        }
        public  Usuarios Logueo(string usuario, string contraseña)
        {
            SqlConnection _cnn = new SqlConnection(Conexion.Cnn);
            Usuarios usu = null;

            SqlCommand _comando = new SqlCommand("LogueoAdministrador", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@usuario", usuario);
            _comando.Parameters.AddWithValue("@contraseña", contraseña);

            try
            {
                _cnn.Open();
                SqlDataReader _lector = _comando.ExecuteReader();
                if (_lector.HasRows)
                {
                    _lector.Read();
                    int pndoc=(int)_lector["Ndoc"];
                     string pnombre = (string)_lector["NomUsuario"];
                    string pusuario = (string)_lector["Usuario"];
                    string pcontraseña = (string)_lector["Constraseña"];
                    usu = new Administrador
                        (pndoc, pnombre, pusuario, pcontraseña, false);
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
        public void Alta(Administrador A)
        {
            SqlConnection _cnn = new SqlConnection(Conexion.Cnn);

            SqlCommand _comando = new SqlCommand("AltaAdministrador", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@Ndoc", A.Ndoc);
            _comando.Parameters.AddWithValue("@Nom", A.NomUsu);
            _comando.Parameters.AddWithValue("@Usuario",A.Usuario);
            _comando.Parameters.AddWithValue("@Constraseña", A.Contraseña);
            _comando.Parameters.AddWithValue("@generavuelos", A.Generavuelos);
            SqlParameter _retorno = new SqlParameter("@Retorno", System.Data.SqlDbType.Int);
            _retorno.Direction = System.Data.ParameterDirection.ReturnValue;
            _comando.Parameters.Add(_retorno);

            try
            {
                _cnn.Open();
                _comando.ExecuteNonQuery();
                if ((int)_retorno.Value == -1)
                    throw new Exception("El Administrador ya existe");
                 if ((int)_retorno.Value == -3)
                    throw new Exception("Usuario ya existente");
                 if ((int)_retorno.Value == -4)
                     throw new Exception("La contraseña debe tener 8 Caracteres");
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
        public void Baja(Administrador B)
        {
            SqlConnection _cnn = new SqlConnection(Conexion.Cnn);

            SqlCommand _comando = new SqlCommand("BajaAdmin", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@Ndoc", B.Ndoc);
            SqlParameter _retorno = new SqlParameter("@Retorno", System.Data.SqlDbType.Int);
            _retorno.Direction = System.Data.ParameterDirection.ReturnValue;
            _comando.Parameters.Add(_retorno);

            try
            {
                _cnn.Open();
                _comando.ExecuteNonQuery();
                if ((int)_retorno.Value == -1)
                    throw new Exception("El administrador no existe");
              

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
        public void Modificar(Administrador A)
        {
            SqlConnection _cnn = new SqlConnection(Conexion.Cnn);

            SqlCommand _comando = new SqlCommand("ModificoAdministrador", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@Ndoc", A.Ndoc);
            _comando.Parameters.AddWithValue("@Nom", A.NomUsu);
            _comando.Parameters.AddWithValue("@Usuario", A.Usuario);
            _comando.Parameters.AddWithValue("@Constraseña", A.Contraseña);
            _comando.Parameters.AddWithValue("@generavuelos", A.Generavuelos);
            SqlParameter _retorno = new SqlParameter("@Retorno", System.Data.SqlDbType.Int);
            _retorno.Direction = System.Data.ParameterDirection.ReturnValue;
            _comando.Parameters.Add(_retorno);

            try
            {
                _cnn.Open();
                _comando.ExecuteNonQuery();
                if ((int)_retorno.Value == -1)
                    throw new Exception("El Administrador no existe");
                if ((int)_retorno.Value == -3)
                    throw new Exception("Usuario ya existente");
                if ((int)_retorno.Value == -4)
                    throw new Exception("La contraseña debe tener 8 Caracteres");
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
        public Administrador Buscar(int Ndoc)//
        {
   

            Administrador a = null;
            SqlConnection oConexion = new SqlConnection(Conexion.Cnn);
            SqlCommand oComando = new SqlCommand("Exec BuscoAdmin " + Ndoc, oConexion);

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
                    bool genvuelos = (bool)oReader["GenVuelos"];


                  a= new Administrador(ndoc,nombre,usuario,contraseña,genvuelos);
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
