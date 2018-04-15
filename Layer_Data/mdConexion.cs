using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;
using System.Configuration;

namespace Layer_Data
{
    public class mdConexion
    {

        public mdConexion() { }

        public SqlConnection conectarBD(string cConexion)
        {
            // GENERAR CONEXION ENTRE LA APLICACION Y LA BASE DE DATOS SQL SERVER 2008R2 Y POSTERIORES
            // CAMILO ROMERO - 19/08/2014

            SqlConnection obj;
            try
            {
                obj = new SqlConnection(cConexion);
                return obj;
            }
            catch (SqlException ex)
            {
                return null;
                throw ex;
            }
        }

        public SqlParameter obtenerParametro(string nombre, object valor)
        {
            SqlParameter spr = new SqlParameter(nombre, valor);
            return spr;
        }

        public DataTable obtenerDataTable(SqlConnection cs)
        {
            // FUNCION PARA OBTENER UNA DATATABLE COMPLETA A PARTIR DE UN STORED PROCEDURE EN LA CAPA BUSINESS.

            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = cs;
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.SelectCommand.CommandTimeout = 300;

                // ADAPTAR LOS DATOS A UNA DATATABLE
                adapter.Fill(dt);

                // CERRAR LA CONEXION ENTRE LA BASE DE DATOS Y LA APLICACION PARA NO GENERAR LATENCIA
                cs.Close();

                return dt;

            }
            catch (Exception ex)
            {
                // ESCRIBIR ERRORES EN EL LOG DE SIHO
                throw new Exception("ERROR AL OBTENER DATATABLE : " + ex.Message);
            }

        }

        public int modificarTabla(string nombreSP, Hashtable parametros)
        {
            /// <summary>
            ///     Ejecuta una operacion de INSERTAR, ACTUALIZAR O ELIMINAR en un STORED PROCEDURE de SQL SERVER
            /// </summary>
            /// <param name="nombreSP"></param>
            /// <param name="parametros"></param>
    

            SqlConnection cs = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            string llave = string.Empty;
            string nombreParametro = string.Empty;
            object valorParametro = null;
            int columnasAfectadas = 0;
            bool resultado = true;

            try
            {
                cs = this.conectarBD(ConfigurationManager.AppSettings["SQLCnnStr_DATA"]);

                if (cs != null)
                {
                    cmd.Connection = cs;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = nombreSP;
                    cmd.CommandTimeout = 6000000;

                    if (parametros != null)
                    {
                        foreach (string x in parametros.Keys)
                        {
                            llave = x;
                            nombreParametro = llave;
                            valorParametro = parametros[llave];
                            cmd.Parameters.Add(obtenerParametro(nombreParametro, valorParametro));
                        }

                        cs.Open();

                        if (cs.State != ConnectionState.Open)
                        {
                            resultado = false;
                            return 0;
                        }
                        else
                        {
                            columnasAfectadas = cmd.ExecuteNonQuery();
                            resultado = columnasAfectadas > 0;
                            cs.Close();
                            return columnasAfectadas;
                        }
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                cs.Close();
                resultado = false;
                throw ex;
            }
            finally
            {
                cs.Close();
            }

        }

        public DataTable ejecutarStoredProcedure(string nombreSP, Hashtable parametros)
        {
            /// <summary>
            ///     Retorna un SELECT desde una operacion en un STORED PROCEDURE de SQL SERVER
            /// </summary>
            /// <param name="nombreSP"></param>
            /// <param name="parametros"></param>


            SqlConnection cs = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            string llave = string.Empty;
            string nombreParametro = string.Empty;
            object valorParametro = null; 
            DataTable resultado = new DataTable();

            try
            {
                cs = this.conectarBD(ConfigurationManager.AppSettings["SQLCnnStr_DATA"]);

                if (cs != null)
                {
                    cmd.Connection = cs;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = nombreSP;
                    cmd.CommandTimeout = 6000000;

                    if (parametros != null)
                    {
                        foreach (string x in parametros.Keys)
                        {
                            llave = x;
                            nombreParametro = llave;
                            valorParametro = parametros[llave];
                            cmd.Parameters.Add(obtenerParametro(nombreParametro, valorParametro));
                        }

                        cs.Open();

                        if (cs.State != ConnectionState.Open)
                        {
                            resultado = null;
                            return resultado;
                        }
                        else
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(resultado);
                            adapter.Dispose();
                            cs.Close();
                            return resultado;
                        }
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                cs.Close();
                resultado = null;
                throw ex;
            }
            finally
            {
                cs.Close();
            }

        }

    }
}
