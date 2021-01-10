using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntidadesCompartidas;
using System.Data.SqlClient;
using System.Data;
using Persistencia;
namespace Persistencia
{
    internal class PersistenciaVuelos : IPersistenciaVuelos
    {
           private static PersistenciaVuelos _instancia = null;
           private PersistenciaVuelos() { }
           public static PersistenciaVuelos GetInstancia()
        {
            if (_instancia == null)
                _instancia = new PersistenciaVuelos();
            return _instancia;
        }
        public void Alta(Vuelos vuelo)
        {
            SqlConnection _cnn = new SqlConnection(Conexion.Cnn);

            SqlCommand _comando = new SqlCommand("AltaVuelos", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@codvuelo", vuelo.CodVuelo);
            _comando.Parameters.AddWithValue("@asientos", vuelo.Asientos);
            _comando.Parameters.AddWithValue("@fechahora", vuelo.FechaHora);
            _comando.Parameters.AddWithValue("@sigla", vuelo.Linea.SiglaLinea);
            _comando.Parameters.AddWithValue("@aerosalida", vuelo.Aeropuertosalida.CodAero);
            _comando.Parameters.AddWithValue("@aerodllegada", vuelo.Aeropuertollegada.CodAero);
            SqlParameter _retorno = new SqlParameter("@Retorno", System.Data.SqlDbType.Int);
            _retorno.Direction = System.Data.ParameterDirection.ReturnValue;
            _comando.Parameters.Add(_retorno);

            try
            {
                _cnn.Open();
                _comando.ExecuteNonQuery();
                if ((int)_retorno.Value == -1)
                    throw new Exception("El vuelo ya existe");
                if ((int)_retorno.Value == -2)
                    throw new Exception("No existe esa linea");
                if ((int)_retorno.Value == -3)
                    throw new Exception("No existe ese aeropuerto");
                if ((int)_retorno.Value == -4)
                    throw new Exception("No existe ese aeropuerto");
                if ((int)_retorno.Value == -5)
                    throw new Exception("La fecha y hora ingresada debe ser mayor a la actual, y se debe dejar tiempo para reservar");
                if ((int)_retorno.Value == -6)
                    throw new Exception("Error en caracteres de vuelo");
               
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _cnn.Close();
            }

        }
        public Vuelos Buscar(string pvuelo)
        {
            SqlConnection _cnn = new SqlConnection(Conexion.Cnn);

            SqlCommand _comando = new SqlCommand("BuscoVuelos", _cnn);
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@codvuelo", pvuelo);

            Vuelos unvuelo = null;


            try
            {
              
                _cnn.Open();

             
                SqlDataReader _lector = _comando.ExecuteReader();

             
                if (_lector.HasRows)
                {
                    _lector.Read();
                    string codigo = (string)_lector["CodVuelo"];
                    int asiento = (int)_lector["Asientos"];
                    DateTime fecha = (DateTime)_lector["FechaHora"];
                    string linea = (string)_lector["SiglaLinea"];
                    string aersalida = (string)_lector["Aeropuertosalida"];
                    string aerollegada = (string)_lector["Aeropuertollegada"];
                    LineasAereas unalinea = FabricaPersistencia.getlineasaereas().Busco(linea);
                    Aeropuerto salida = FabricaPersistencia.getPersistenciaAeropuertos().BuscarAeropuertosinBaja(aersalida);
                    Aeropuerto llegada = FabricaPersistencia.getPersistenciaAeropuertos().BuscarAeropuertosinBaja(aerollegada);

                    unvuelo = new Vuelos(codigo, asiento, fecha, unalinea, salida, llegada, ListaReservasdeVueloo(codigo));


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

            
            return unvuelo;
        }
        public List<Vuelos> Listo()
        {
            List<Vuelos> _Lista = new List<Vuelos>();

            Vuelos vuelo = null;
            SqlConnection _cnn = new SqlConnection(Conexion.Cnn);

            SqlCommand _comando = new SqlCommand("ListoVuelos", _cnn);

            _comando.CommandType = CommandType.StoredProcedure;



            try
            {
             
                _cnn.Open();

               
                SqlDataReader _lector = _comando.ExecuteReader();


                if (_lector.HasRows)
                {
                    while (_lector.Read())
                    {
                        string codigo = (string)_lector["CodVuelo"];
                        int asiento = (int)_lector["Asientos"];
                        DateTime fecha = (DateTime)_lector["FechaHora"];
                        string linea = (string)_lector["SiglaLinea"];
                        string aersalida = (string)_lector["Aeropuertosalida"];
                        string aerollegada = (string)_lector["Aeropuertollegada"];
                        LineasAereas unalinea = FabricaPersistencia.getlineasaereas().BuscoSinBajaLogica(linea);
                        Aeropuerto salida = FabricaPersistencia.getPersistenciaAeropuertos().BuscarAeropuertosinBaja(aersalida);
                        Aeropuerto llegada = FabricaPersistencia.getPersistenciaAeropuertos().BuscarAeropuertosinBaja(aerollegada);

                        vuelo = new Vuelos(codigo, asiento, fecha, unalinea, salida, llegada, ListaReservasdeVueloo(codigo));


                        _Lista.Add(vuelo);
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
        public void Baja(Vuelos vuelo)
        {
            SqlConnection _cnn = new SqlConnection(Conexion.Cnn);

            SqlCommand _comando = new SqlCommand("BajaVuelos", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@codvuelo", vuelo.CodVuelo);
            SqlParameter _retorno = new SqlParameter("@Retorno", System.Data.SqlDbType.Int);
            _retorno.Direction = System.Data.ParameterDirection.ReturnValue;
            _comando.Parameters.Add(_retorno);

            try
            {
                _cnn.Open();
                _comando.ExecuteNonQuery();
                if ((int)_retorno.Value == -1)
                    throw new Exception("El vuelo no existe");
                else if ((int)_retorno.Value == -2)
                    throw new Exception("El vuelo tiene reservas");
            }
            catch (Exception ex)
            {
                throw  ex;
            }
            finally
            {
                _cnn.Close();
            }
        }
        public void Modificar(Vuelos vuelo)
        {
            SqlConnection _cnn = new SqlConnection(Conexion.Cnn);

            SqlCommand _comando = new SqlCommand("ModificarVuelos", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@codvuelo", vuelo.CodVuelo);
            _comando.Parameters.AddWithValue("@asientos", vuelo.Asientos);
            _comando.Parameters.AddWithValue("@sigla", vuelo.Linea.SiglaLinea);
            SqlParameter _retorno = new SqlParameter("@Retorno", System.Data.SqlDbType.Int);
            _retorno.Direction = System.Data.ParameterDirection.ReturnValue;
            _comando.Parameters.Add(_retorno);

            try
            {
                _cnn.Open();
                _comando.ExecuteNonQuery();
                if ((int)_retorno.Value == -1)
                    throw new Exception("El vuelo no existe");
                if ((int)_retorno.Value == -2)
                    throw new Exception("No existe esa linea");
                if ((int)_retorno.Value == -5)
                    throw new Exception("Ese vuelo tiene reservas");
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _cnn.Close();
            }

        }

        public void Reserva( Vuelos v)
        {
        
         SqlConnection _cnn = new SqlConnection(Conexion.Cnn);
         SqlCommand _comando = new SqlCommand("ReservaAsiento", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter cod = new SqlParameter("@codvuelo", v.CodVuelo); 
            SqlParameter Ndoc = new SqlParameter("@Ndoc", v.Reservas.Last().UnCliente.Ndoc);
            SqlParameter Nasiento = new SqlParameter("@Nasiento",v.Reservas.Last().Asiento);

                SqlParameter _retorno = new SqlParameter("@Retorno", System.Data.SqlDbType.Int);
                _retorno.Direction = System.Data.ParameterDirection.ReturnValue;

                _comando.Parameters.Add(cod);
                _comando.Parameters.Add(Ndoc);
                _comando.Parameters.Add(Nasiento);
                _comando.Parameters.Add(_retorno);
            

            try
            {
                _cnn.Open();
                _comando.ExecuteNonQuery();
                if ((int)_retorno.Value == -1)
                    throw new Exception("El vuelo no existe");
                if ((int)_retorno.Value == -2)
                    throw new Exception("No existe ese cliente");
                if ((int)_retorno.Value == -3)
                    throw new Exception("Cliente ya existente en ese vuelo, o El asiento esta ocupado");

                if ((int)_retorno.Value == -4)
                    throw new Exception("Ese asiento no esta dentro del Total de Asientos");

             
                

            }
                 
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _cnn.Close();
            }

        }
        public List<Vuelos> ListAeroPartidados(string Ae)//Listar Vuelos segun Ciudad Partida
        {
            SqlConnection _cnn = new SqlConnection(Conexion.Cnn);
            Vuelos vuelos = null;
            List<Vuelos> _lista = new List<Vuelos>();

            SqlCommand _comando = new SqlCommand("ListAeroPartidados", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@Ciudad", Ae);

            try
            {
                _cnn.Open();
                SqlDataReader _lector = _comando.ExecuteReader();
                if (_lector.HasRows)
                {
                    while (_lector.Read())
                    {
                        string codigo = (string)_lector["CodVuelo"];
                        int asiento = (int)_lector["Asientos"];
                        DateTime fecha = (DateTime)_lector["FechaHora"];
                        string linea = (string)_lector["SiglaLinea"];
                        string aersalida = (string)_lector["Aeropuertosalida"];
                        string aerollegada = (string)_lector["Aeropuertollegada"];
                        LineasAereas unalinea = FabricaPersistencia.getlineasaereas().BuscoSinBajaLogica(linea);
                        Aeropuerto salida = FabricaPersistencia.getPersistenciaAeropuertos().BuscarAeropuertosinBaja(aersalida);
                        Aeropuerto llegada = FabricaPersistencia.getPersistenciaAeropuertos().BuscarAeropuertosinBaja(aerollegada);

                        vuelos = new Vuelos(codigo, asiento, fecha, unalinea, salida, llegada, ListaReservasdeVueloo(codigo));
                        _lista.Add(vuelos);
                    }
                }
                _lector.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _cnn.Close();
            }
            return _lista;
        }
        public List<Vuelos> ListaVuelosXmlCliente(Cliente c)//Listo Vuelos segun la reserva del Cliente para XML
        {
            SqlConnection _cnn = new SqlConnection(Conexion.Cnn);
            Vuelos vuelos = null;
            List<Vuelos> _lista = new List<Vuelos>();

            SqlCommand _comando = new SqlCommand("ReservasporClienteXml", _cnn);
            _comando.Parameters.AddWithValue("@Cliente",c.Ndoc);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            try
            {
                _cnn.Open();
                SqlDataReader _lector = _comando.ExecuteReader();
                if (_lector.HasRows)
                {
                    while (_lector.Read())
                    {
                        string codigo = (string)_lector["CodVuelo"];
                        int asiento = (int)_lector["Asientos"];
                        DateTime fecha = (DateTime)_lector["FechaHora"];
                        string linea = (string)_lector["SiglaLinea"];
                        string aersalida = (string)_lector["Aeropuertosalida"];
                        string aerollegada = (string)_lector["Aeropuertollegada"];
                        LineasAereas unalinea = FabricaPersistencia.getlineasaereas().BuscoSinBajaLogica(linea);
                        Aeropuerto salida = FabricaPersistencia.getPersistenciaAeropuertos().BuscarAeropuertosinBaja(aersalida);
                        Aeropuerto llegada = FabricaPersistencia.getPersistenciaAeropuertos().BuscarAeropuertosinBaja(aerollegada);

                        vuelos = new Vuelos(codigo, asiento, fecha, unalinea, salida, llegada, ListaReservasdeVueloo(codigo));
                        _lista.Add(vuelos);
                    }
                }
                _lector.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                _cnn.Close();
            }
            return _lista;
        }
        internal static List<Reservas> ListaReservasdeVueloo(string cod)
        {
            SqlConnection _cnn = new SqlConnection(Conexion.Cnn);
            Reservas reservas = null;
            List<Reservas> _lista = new List<Reservas>();

            SqlCommand _comando = new SqlCommand("LPerV", _cnn);
            _comando.CommandType = System.Data.CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@v", cod);

            try
            {
                _cnn.Open();
                SqlDataReader _lector = _comando.ExecuteReader();
                if (_lector.HasRows)
                {
                    while (_lector.Read())
                    {
                       
                        int Ndoc = (int)_lector["Ndoc"];
                        int Nasiento = (int)_lector["NAsiento"];

                        Cliente C = FabricaPersistencia.getcliente().Buscar(Ndoc);
                       
                        reservas = new Reservas(C, Nasiento);
                        _lista.Add(reservas);
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
            return _lista;
        }
      
    }
}
