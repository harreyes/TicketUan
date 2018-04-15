using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Layer_Data;
using Layer_Business.Entidades;

namespace Layer_Business
{
  namespace Entidades
  {
    public class Clusuarios
    {
      #region PROPIEDADES
        private int usu_tipo_identificacion;
        private int usu_pais;
        private string usu_nombre;
        private int usu_ciudad;
        private int usu_id;
        private string usu_codigo;
        private string usu_correo;
        private int usu_factultad;
        private string usu_password;
        private int usu_propiedad;
        private string usu_apellido;
        private string usu_identificacion;
      #endregion
      #region CONSTRUCTORS
         public Clusuarios()
         {
           usu_tipo_identificacion= 0;
           usu_pais= 0;
           usu_nombre= "";
           usu_ciudad= 0;
           usu_id= 0;
           usu_codigo= "";
           usu_correo= "";
           usu_factultad= 0;
           usu_password= "";
           usu_propiedad= 0;
           usu_apellido= "";
           usu_identificacion= "";
         }
         public Clusuarios( int  usu_tipo_identificacion , int  usu_pais, string  usu_nombre, int  usu_ciudad, int  usu_id, string  usu_codigo, string  usu_correo, int  usu_factultad, string  usu_password, int  usu_propiedad, string  usu_apellido, string  usu_identificacion  )
         {
          this.usu_tipo_identificacion = usu_tipo_identificacion;
          this.usu_pais = usu_pais;
          this.usu_nombre = usu_nombre;
          this.usu_ciudad = usu_ciudad;
          this.usu_id = usu_id;
          this.usu_codigo = usu_codigo;
          this.usu_correo = usu_correo;
          this.usu_factultad = usu_factultad;
          this.usu_password = usu_password;
          this.usu_propiedad = usu_propiedad;
          this.usu_apellido = usu_apellido;
          this.usu_identificacion = usu_identificacion;
         }
      #endregion
      #region GETTERS Y SETTER
        public int tipo_identificacion 
        {
           get { return this.usu_tipo_identificacion; }
        
           set { this.usu_tipo_identificacion = value; }
        }
        public int pais 
        {
           get { return this.usu_pais; }
        
           set { this.usu_pais = value; }
        }
        public string nombre 
        {
           get { return this.usu_nombre; }
        
           set { this.usu_nombre = value; }
        }
        public int ciudad 
        {
           get { return this.usu_ciudad; }
        
           set { this.usu_ciudad = value; }
        }
        public int id 
        {
           get { return this.usu_id; }
        
           set { this.usu_id = value; }
        }
        public string codigo 
        {
           get { return this.usu_codigo; }
        
           set { this.usu_codigo = value; }
        }
        public string correo 
        {
           get { return this.usu_correo; }
        
           set { this.usu_correo = value; }
        }
        public int factultad 
        {
           get { return this.usu_factultad; }
        
           set { this.usu_factultad = value; }
        }
        public string password 
        {
           get { return this.usu_password; }
        
           set { this.usu_password = value; }
        }
        public int propiedad 
        {
           get { return this.usu_propiedad; }
        
           set { this.usu_propiedad = value; }
        }
        public string apellido 
        {
           get { return this.usu_apellido; }
        
           set { this.usu_apellido = value; }
        }
        public string identificacion 
        {
           get { return this.usu_identificacion; }
        
           set { this.usu_identificacion = value; }
        }
      #endregion
    }
   }
 
 
 
 

    namespace Controladoras
    {
      public class Ctrusuarios
      {
        public int ejecutar(Clusuarios x, int operacion = 0)
        {
         /// <summary>
         ///     Ejecuta una funcion de INSERTAR, ACTUALIZAR O ELIMINAR desde una operacion en SP_ADM_USUARIOS"
         /// </summary>
         /// <param name="x"></param>
         /// <param name="operacion"></param>
 
           Layer_Data.mdConexion md = new Layer_Data.mdConexion(); 
         try 
         { 
           return md.modificarTabla("sp_adm_usuarios", parametros(x, operacion));
         } 
          catch (Exception) 
         { 
          throw; 
         } 
        } 
 
 
 
        public Clusuarios seleccionarUno(Clusuarios x, int operacion = 0) 
        { 
         /// <summary>
         ///     Ejecuta una funcion SELECT y retorna un campo desde una operacion en SP_ADM_USUARIOS"
         /// </summary>
         /// <param name="x"></param>
         /// <param name="operacion"></param>
 
         Layer_Data.mdConexion md = new Layer_Data.mdConexion(); 
 
         DataTable dt = new DataTable(); 
 
         try 
         { 
          dt = md.ejecutarStoredProcedure("sp_adm_usuarios", parametros(x, operacion)); 
 
          if (dt.Rows.Count > 0) 
          { 
            if (dt.Rows[0]["usu_tipo_identificacion"] != DBNull.Value) 
            { 
              x.tipo_identificacion = (int)dt.Rows[0]["usu_tipo_identificacion"]; 
            } 
            if (dt.Rows[0]["usu_pais"] != DBNull.Value) 
            { 
              x.pais = (int)dt.Rows[0]["usu_pais"]; 
            } 
            if (dt.Rows[0]["usu_nombre"] != DBNull.Value) 
            { 
              x.nombre = (string)dt.Rows[0]["usu_nombre"]; 
            } 
            if (dt.Rows[0]["usu_ciudad"] != DBNull.Value) 
            { 
              x.ciudad = (int)dt.Rows[0]["usu_ciudad"]; 
            } 
            if (dt.Rows[0]["usu_id"] != DBNull.Value) 
            { 
              x.id = (int)dt.Rows[0]["usu_id"]; 
            } 
            if (dt.Rows[0]["usu_codigo"] != DBNull.Value) 
            { 
              x.codigo = (string)dt.Rows[0]["usu_codigo"]; 
            } 
            if (dt.Rows[0]["usu_correo"] != DBNull.Value) 
            { 
              x.correo = (string)dt.Rows[0]["usu_correo"]; 
            } 
            if (dt.Rows[0]["usu_factultad"] != DBNull.Value) 
            { 
              x.factultad = (int)dt.Rows[0]["usu_factultad"]; 
            } 
            if (dt.Rows[0]["usu_password"] != DBNull.Value) 
            { 
              x.password = (string)dt.Rows[0]["usu_password"]; 
            } 
            if (dt.Rows[0]["usu_propiedad"] != DBNull.Value) 
            { 
              x.propiedad = (int)dt.Rows[0]["usu_propiedad"]; 
            } 
            if (dt.Rows[0]["usu_apellido"] != DBNull.Value) 
            { 
              x.apellido = (string)dt.Rows[0]["usu_apellido"]; 
            } 
            if (dt.Rows[0]["usu_identificacion"] != DBNull.Value) 
            { 
              x.identificacion = (string)dt.Rows[0]["usu_identificacion"]; 
            } 
            return x; 
          } 
          else 
          { 
            return null; 
          } 
         } 
          catch (Exception) 
          { 
            return null;
            throw; 
          } 
        } 
 
        public DataTable seleccionarTodos(Clusuarios x, int operacion = 0) 
        { 
         /// <summary>
         ///     Retorna un DataTable de una funcion SELECT en una operacion desde SP_ADM_USUARIOS"
         /// </summary>
         /// <param name="x"></param>
         /// <param name="operacion"></param>
 
         Layer_Data.mdConexion md = new Layer_Data.mdConexion(); 
         DataTable dt = new DataTable(); 
         try 
         { 
           dt = md.ejecutarStoredProcedure("sp_adm_usuarios", parametros(x, operacion)); 
           return dt; 
         } 
         catch (Exception) 
         { 
           return null;
           throw; 
         } 
        } 
 
 
        private Hashtable parametros(Clusuarios x, int operation = 0) 
        { 
         try 
         { 
           Hashtable parametros = new Hashtable();
 
           parametros.Add("@usu_tipo_identificacion", x.tipo_identificacion);
           parametros.Add("@usu_pais", x.pais);
           parametros.Add("@usu_nombre", x.nombre);
           parametros.Add("@usu_ciudad", x.ciudad);
           parametros.Add("@usu_id", x.id);
           parametros.Add("@usu_codigo", x.codigo);
           parametros.Add("@usu_correo", x.correo);
           parametros.Add("@usu_factultad", x.factultad);
           parametros.Add("@usu_password", x.password);
           parametros.Add("@usu_propiedad", x.propiedad);
           parametros.Add("@usu_apellido", x.apellido);
           parametros.Add("@usu_identificacion", x.identificacion);
           parametros.Add("@operation", operation);
 
           return parametros; 
 
         }
         catch (Exception ex) 
         {
          throw ex;
         }
        } 
        }
    }
 
}
