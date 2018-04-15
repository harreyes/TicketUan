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
    public class Cl_personas
    {
      #region PROPIEDADES
        private int tus_activo;
        private int tus_id;
        private string tus_descripcion;
      #endregion
      #region CONSTRUCTORS
         public Cl_personas()
         {
           tus_activo= 0;
           tus_id= 0;
           tus_descripcion= "";
         }
         public Cl_personas( int  tus_activo , int  tus_id, string  tus_descripcion  )
         {
          this.tus_activo = tus_activo;
          this.tus_id = tus_id;
          this.tus_descripcion = tus_descripcion;
         }
      #endregion
      #region GETTERS Y SETTER
        public int activo 
        {
           get { return this.tus_activo; }
        
           set { this.tus_activo = value; }
        }
        public int id 
        {
           get { return this.tus_id; }
        
           set { this.tus_id = value; }
        }
        public string descripcion 
        {
           get { return this.tus_descripcion; }
        
           set { this.tus_descripcion = value; }
        }
      #endregion
    }
   }
 
 
 
 

    namespace Controladoras
    {
      public class Ctr_personas
      {
        public int ejecutar(Cl_personas x, int operacion = 0)
        {
         /// <summary>
         ///     Ejecuta una funcion de INSERTAR, ACTUALIZAR O ELIMINAR desde una operacion en SP_TIPO_PERSONAS"
         /// </summary>
         /// <param name="x"></param>
         /// <param name="operacion"></param>
 
           Layer_Data.mdConexion md = new Layer_Data.mdConexion(); 
         try 
         { 
           return md.modificarTabla("sp_tipo_personas", parametros(x, operacion));
         } 
          catch (Exception) 
         { 
          throw; 
         } 
        } 
 
 
 
        public Cl_personas seleccionarUno(Cl_personas x, int operacion = 0) 
        { 
         /// <summary>
         ///     Ejecuta una funcion SELECT y retorna un campo desde una operacion en SP_TIPO_PERSONAS"
         /// </summary>
         /// <param name="x"></param>
         /// <param name="operacion"></param>
 
         Layer_Data.mdConexion md = new Layer_Data.mdConexion(); 
 
         DataTable dt = new DataTable(); 
 
         try 
         { 
          dt = md.ejecutarStoredProcedure("sp_tipo_personas", parametros(x, operacion)); 
 
          if (dt.Rows.Count > 0) 
          { 
            if (dt.Rows[0]["tus_activo"] != DBNull.Value) 
            { 
              x.activo = (int)dt.Rows[0]["tus_activo"]; 
            } 
            if (dt.Rows[0]["tus_id"] != DBNull.Value) 
            { 
              x.id = (int)dt.Rows[0]["tus_id"]; 
            } 
            if (dt.Rows[0]["tus_descripcion"] != DBNull.Value) 
            { 
              x.descripcion = (string)dt.Rows[0]["tus_descripcion"]; 
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
 
        public DataTable seleccionarTodos(Cl_personas x, int operacion = 0) 
        { 
         /// <summary>
         ///     Retorna un DataTable de una funcion SELECT en una operacion desde SP_TIPO_PERSONAS"
         /// </summary>
         /// <param name="x"></param>
         /// <param name="operacion"></param>
 
         Layer_Data.mdConexion md = new Layer_Data.mdConexion(); 
         DataTable dt = new DataTable(); 
         try 
         { 
           dt = md.ejecutarStoredProcedure("sp_tipo_personas", parametros(x, operacion)); 
           return dt; 
         } 
         catch (Exception) 
         { 
           return null;
           throw; 
         } 
        } 
 
 
        private Hashtable parametros(Cl_personas x, int operation = 0) 
        { 
         try 
         { 
           Hashtable parametros = new Hashtable();
 
           parametros.Add("@tus_activo", x.activo);
           parametros.Add("@tus_id", x.id);
           parametros.Add("@tus_descripcion", x.descripcion);
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
