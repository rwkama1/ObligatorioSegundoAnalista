using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesCompartidas;
using System.Data.SqlClient;
using System.Data;

namespace Persistencia
{
    internal class PersistenciaAeropuertos:IPersistenciaAeropuerto

    {
        private static PersistenciaAeropuertos _instancia = null;
        private PersistenciaAeropuertos() { }
        public static PersistenciaAeropuertos GetInstancia()
        {
            if (_instancia == null)
                _instancia = new PersistenciaAeropuertos();
            return _instancia;
        }

        public void AltaAeropuerto(Aeropuerto A)
        {
            SqlConnection oConexion = new SqlConnection(Conexion.Cnn);
            SqlCommand oComando = new SqlCommand("AltaAeropuerto", oConexion);
            oComando.CommandType = CommandType.StoredProcedure;

            SqlParameter _codigo = new SqlParameter("@codaero", A.CodAero);
            SqlParameter _nombre = new SqlParameter("@nomaero", A.NomAero);
            SqlParameter _ciudad = new SqlParameter("@ciudad", A.Ciudad);
            SqlParameter _Retorno = new SqlParameter("@Retorno", SqlDbType.Int);
            _Retorno.Direction = ParameterDirection.ReturnValue;

            int oAfectados = -1;

            oComando.Parameters.Add(_codigo);
            oComando.Parameters.Add(_nombre);
            oComando.Parameters.Add(_ciudad);
            oComando.Parameters.Add(_Retorno);

            try
            {
                oConexion.Open();
                oComando.ExecuteNonQuery();
                oAfectados = (int)oComando.Parameters["@Retorno"].Value;
                if (oAfectados == -1)
                    throw new Exception("El codigo de Aeropuerto ya existe");
                else if(oAfectados==-4)
                    throw new Exception("El codigo no puede ser numerico");
            }
            catch (Exception ex)
            {
                throw new ApplicationException( ex.Message);
            }
            finally
            {
                oConexion.Close();
            }
        }

        public void BajaAeropuerto(Aeropuerto A)
        {
            SqlConnection oConexion = new SqlConnection(Conexion.Cnn);
            SqlCommand oComando = new SqlCommand("BajaAeropuerto", oConexion);
            oComando.CommandType = CommandType.StoredProcedure;

            SqlParameter _codigo = new SqlParameter("@codaero", A.CodAero);
            SqlParameter _Retorno = new SqlParameter("@Retorno", SqlDbType.Int);
            _Retorno.Direction = ParameterDirection.ReturnValue;

            int oAfectados = -1;

            oComando.Parameters.Add(_codigo);
            oComando.Parameters.Add(_Retorno);

            try
            {
                oConexion.Open();
                oComando.ExecuteNonQuery();
                oAfectados = (int)oComando.Parameters["@Retorno"].Value;
                if (oAfectados == -1)
                    throw new Exception("El Aeropuerto no existe");
               
                if (oAfectados == 2)
                    throw new Exception("Baja logica con exito");
              

            }
            catch (Exception ex)
            {
                throw new ApplicationException(  ex.Message);
            }
            finally
            {
                oConexion.Close();
            }

        }
        public void ModificarAeropuerto(Aeropuerto A)
        {
            SqlConnection oConexion = new SqlConnection(Conexion.Cnn);
            SqlCommand oComando = new SqlCommand("ModificarAeropuerto", oConexion);
            oComando.CommandType = CommandType.StoredProcedure;

            SqlParameter _codigo = new SqlParameter("@codaero", A.CodAero);
            SqlParameter _nombre = new SqlParameter("@Nomaero", A.NomAero);
            SqlParameter _ciudad = new SqlParameter("@ciudad", A.Ciudad);
            SqlParameter _Retorno = new SqlParameter("@Retorno", SqlDbType.Int);
            _Retorno.Direction = ParameterDirection.ReturnValue;

            int oAfectados = -1;

            oComando.Parameters.Add(_codigo);
            oComando.Parameters.Add(_nombre);
            oComando.Parameters.Add(_ciudad);
            oComando.Parameters.Add(_Retorno);

            try
            {
                oConexion.Open();
                oComando.ExecuteNonQuery();
                oAfectados = (int)oComando.Parameters["@Retorno"].Value;
                if (oAfectados == -1)
                    throw new Exception("El Aeropuerto no existe");
            }
            catch (Exception ex)
            {
                throw new ApplicationException(  ex.Message);
            }
            finally
            {
                oConexion.Close();
            }

        }
        public Aeropuerto BuscarAeropuerto(string pCodigo)
        {
            string _codigo;
            string _nombre;
            string _ciudad;
            Aeropuerto a = null;
            SqlConnection oConexion = new SqlConnection(Conexion.Cnn);
            SqlCommand oComando = new SqlCommand("BuscarAeropuerto", oConexion);
            oComando.CommandType = CommandType.StoredProcedure;
            oComando.Parameters.AddWithValue("@Codaero", pCodigo);
            SqlDataReader oReader;

            try
            {
                oConexion.Open();
                oReader = oComando.ExecuteReader();
                if (oReader.Read())
                {
                    _codigo = (string)oReader["CodAero"];
                    _nombre = (string)oReader["NomAero"];
                    _ciudad = (string)oReader["Ciudad"];
    
                    a = new Aeropuerto(_codigo, _nombre, _ciudad);
                }
                oReader.Close();
            }
            catch (Exception ex)
            {
                throw new ApplicationException( ex.Message);
            }
            finally
            {
                oConexion.Close();
            }
            return a;
        }
        public List<Aeropuerto> ListarAeropuerto()
        {
            string _codigo;
            string _nombre;
            string _ciudad;
            List<Aeropuerto> _Lista = new List<Aeropuerto>();
            SqlConnection _Conexion = new SqlConnection(Conexion.Cnn);
            SqlCommand _Comando = new SqlCommand("Exec ListarAeropuertos", _Conexion);
            SqlDataReader _Reader;
            try
            {
                _Conexion.Open();
                _Reader = _Comando.ExecuteReader();
                while (_Reader.Read())
                {
                    _codigo = (string)_Reader["CodAero"];
                    _nombre = (string)_Reader["NomAero"];
                    _ciudad = (string)_Reader["Ciudad"];
                    
                    Aeropuerto a = new Aeropuerto(_codigo, _nombre, _ciudad);
                    _Lista.Add(a);
                }
                _Reader.Close();
            }
            catch (Exception ex)
            {
                throw new ApplicationException(  ex.Message);
            }
            finally
            {
                _Conexion.Close();
            }
            return _Lista;
        }
        public Aeropuerto BuscarAeropuertosinBaja(string pCodigo)
        {
            string _codigo;
            string _nombre;
            string _ciudad;
            Aeropuerto a = null;
            SqlConnection oConexion = new SqlConnection(Conexion.Cnn);
            SqlCommand oComando = new SqlCommand("Exec BAperV " + pCodigo, oConexion);

            SqlDataReader oReader;

            try
            {
                oConexion.Open();
                oReader = oComando.ExecuteReader();
                if (oReader.Read())
                {
                    _codigo = (string)oReader["CodAero"];
                    _nombre = (string)oReader["NomAero"];
                    _ciudad = (string)oReader["Ciudad"];

                    a = new Aeropuerto(_codigo, _nombre, _ciudad);
                }
                oReader.Close();
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            finally
            {
                oConexion.Close();
            }
            return a;
        }
        
        public List<Aeropuerto> ListarAeropuertoCiudadPartida()
        {
            string _codigo = "Aer";
            string _nombre="Aeropuerto";
            string _ciudad;
            List<Aeropuerto> _Lista = new List<Aeropuerto>();
            SqlConnection _Conexion = new SqlConnection(Conexion.Cnn);
            SqlCommand _Comando = new SqlCommand("procListarAeropuertoCiudadPartida", _Conexion);
            _Comando.CommandType = CommandType.StoredProcedure;
            SqlDataReader _Reader;
            try
            {
                _Conexion.Open();
                _Reader = _Comando.ExecuteReader();
                while (_Reader.Read())
                {

                    _ciudad = (string)_Reader["Ciudad"];

                    Aeropuerto a = new Aeropuerto(_codigo, _nombre, _ciudad);
                    _Lista.Add(a);
                }
                _Reader.Close();
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
            finally
            {
                _Conexion.Close();
            }
            return _Lista;
        }
    }
}
