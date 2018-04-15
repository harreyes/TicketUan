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
    public class Clpropiedad
    {
      #region PROPIEDADES
        private string pro_nombre;
        private int pro_ciudad;
        private string pro_descripcion;
        private int pro_activo;
        private string pro_email;
        private string pro_direccion;
        private int pro_pais;
        private int pro_id;
        private string pro_telefono;
      #endregion
      #region CONSTRUCTORS
         public Clpropiedad()
         {
           pro_nombre= "";
           pro_ciudad= 0;
           pro_descripcion= "";
           pro_activo= 0;
           pro_email= "";
           pro_direccion= "";
           pro_pais= 0;
           pro_id= 0;
           pro_telefono= "";
         }
         public Clpropiedad( string  pro_nombre , int  pro_ciudad, string  pro_descripcion, int  pro_activo, string  pro_email, string  pro_direccion, int  pro_pais, int  pro_id, string  pro_telefono  )
         {
          this.pro_nombre = pro_nombre;
          this.pro_ciudad = pro_ciudad;
          this.pro_descripcion = pro_descripcion;
          this.pro_activo = pro_activo;
          this.pro_email = pro_email;
          this.pro_direccion = pro_direccion;
          this.pro_pais = pro_pais;
          this.pro_id = pro_id;
          this.pro_telefono = pro_telefono;
         }
      #endregion
      #region GETTERS Y SETTER
        public string nombre 
        {
           get { return this.pro_nombre; }
        
           set { this.pro_nombre = value; }
        }
        public int ciudad 
        {
           get { return this.pro_ciudad; }
        
           set { this.pro_ciudad = value; }
        }
        public string descripcion 
        {
           get { return this.pro_descripcion; }
        
           set { this.pro_descripcion = value; }
        }
        public int activo 
        {
           get { return this.pro_activo; }
        
           set { this.pro_activo = value; }
        }
        public string email 
        {
           get { return this.pro_email; }
        
           set { this.pro_email = value; }
        }
        public string direccion 
        {
           get { return this.pro_direccion; }
        
           set { this.pro_direccion = value; }
        }
        public int pais 
        {
           get { return this.pro_pais; }
        
           set { this.pro_pais = value; }
        }
        public int id 
        {
           get { return this.pro_id; }
        
           set { this.pro_id = value; }
        }
        public string telefono 
        {
           get { return this.pro_telefono; }
        
           set { this.pro_telefono = value; }
        }
      #endregion
    }
   }
 
 
 
 

    namespace Controladoras
    {
      public class Ctrpropiedad
      {
        public int ejecutar(Clpropiedad x, int operacion = 0)
        {
         /// <summary>
         ///     Ejecuta una funcion de INSERTAR, ACTUALIZAR O ELIMINAR desde una operacion en SP_ADM_PROPIEDAD"
         /// </summary>
         /// <param name="x"></param>
         /// <param name="operacion"></param>
 
           Layer_Data.mdConexion md = new Layer_Data.mdConexion(); 
         try 
         { 
           return md.modificarTabla("sp_adm_propiedad", parametros(x, operacion));
         } 
          catch (Exception) 
         { 
          throw; 
         } 
        } 
 
 
 
        public Clpropiedad seleccionarUno(Clpropiedad x, int operacion = 0) 
        { 
         /// <summary>
         ///     Ejecuta una funcion SELECT y retorna un campo desde una operacion en SP_ADM_PROPIEDAD"
         /// </summary>
         /// <param name="x"></param>
         /// <param name="operacion"></param>
 
         Layer_Data.mdConexion md = new Layer_Data.mdConexion(); 
 
         DataTable dt = new DataTable(); 
 
         try 
         { 
          dt = md.ejecutarStoredProcedure("sp_adm_propiedad", parametros(x, operacion)); 
 
          if (dt.Rows.Count > 0) 
          { 
            if (dt.Rows[0]["pro_nombre"] != DBNull.Value) 
            { 
              x.nombre = (string)dt.Rows[0]["pro_nombre"]; 
            } 
            if (dt.Rows[0]["pro_ciudad"] != DBNull.Value) 
            { 
              x.ciudad = (int)dt.Rows[0]["pro_ciudad"]; 
            } 
            if (dt.Rows[0]["pro_descripcion"] != DBNull.Value) 
            { 
              x.descripcion = (string)dt.Rows[0]["pro_descripcion"]; 
            } 
            if (dt.Rows[0]["pro_activo"] != DBNull.Value) 
            { 
              x.activo = (int)dt.Rows[0]["pro_activo"]; 
            } 
            if (dt.Rows[0]["pro_email"] != DBNull.Value) 
            { 
              x.email = (string)dt.Rows[0]["pro_email"]; 
            } 
            if (dt.Rows[0]["pro_direccion"] != DBNull.Value) 
            { 
              x.direccion = (string)dt.Rows[0]["pro_direccion"]; 
            } 
            if (dt.Rows[0]["pro_pais"] != DBNull.Value) 
            { 
              x.pais = (int)dt.Rows[0]["pro_pais"]; 
            } 
            if (dt.Rows[0]["pro_id"] != DBNull.Value) 
            { 
              x.id = (int)dt.Rows[0]["pro_id"]; 
            } 
            if (dt.Rows[0]["pro_telefono"] != DBNull.Value) 
            { 
              x.telefono = (string)dt.Rows[0]["pro_telefono"]; 
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
 
        public DataTable seleccionarTodos(Clpropiedad x, int operacion = 0) 
        { 
         /// <summary>
         ///     Retorna un DataTable de una funcion SELECT en una operacion desde SP_ADM_PROPIEDAD"
         /// </summary>
         /// <param name="x"></param>
         /// <param name="operacion"></param>
 
         Layer_Data.mdConexion md = new Layer_Data.mdConexion(); 
         DataTable dt = new DataTable(); 
         try 
         { 
           dt = md.ejecutarStoredProcedure("sp_adm_propiedad", parametros(x, operacion)); 
           return dt; 
         } 
         catch (Exception) 
         { 
           return null;
           throw; 
         } 
        } 
 
 
        private Hashtable parametros(Clpropiedad x, int operation = 0) 
        { 
         try 
         { 
           Hashtable parametros = new Hashtable();
 
           parametros.Add("@pro_nombre", x.nombre);
           parametros.Add("@pro_ciudad", x.ciudad);
           parametros.Add("@pro_descripcion", x.descripcion);
           parametros.Add("@pro_activo", x.activo);
           parametros.Add("@pro_email", x.email);
           parametros.Add("@pro_direccion", x.direccion);
           parametros.Add("@pro_pais", x.pais);
           parametros.Add("@pro_id", x.id);
           parametros.Add("@pro_telefono", x.telefono);
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
