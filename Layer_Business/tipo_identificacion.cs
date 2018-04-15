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
    public class Cltipo_identificacion
    {
      #region PROPIEDADES
        private int tid_id;
        private string tid_descripcion;
        private int tid_activo;
      #endregion
      #region CONSTRUCTORS
         public Cltipo_identificacion()
         {
           tid_id= 0;
           tid_descripcion= "";
           tid_activo= 0;
         }
         public Cltipo_identificacion( int  tid_id , string  tid_descripcion, int  tid_activo  )
         {
          this.tid_id = tid_id;
          this.tid_descripcion = tid_descripcion;
          this.tid_activo = tid_activo;
         }
      #endregion
      #region GETTERS Y SETTER
        public int id 
        {
           get { return this.tid_id; }
        
           set { this.tid_id = value; }
        }
        public string descripcion 
        {
           get { return this.tid_descripcion; }
        
           set { this.tid_descripcion = value; }
        }
        public int activo 
        {
           get { return this.tid_activo; }
        
           set { this.tid_activo = value; }
        }
      #endregion
    }
   }
 
 
 
 

    namespace Controladoras
    {
      public class Ctrtipo_identificacion
      {
        public int ejecutar(Cltipo_identificacion x, int operacion = 0)
        {
         /// <summary>
         ///     Ejecuta una funcion de INSERTAR, ACTUALIZAR O ELIMINAR desde una operacion en SP_SYS_TIPO_IDENTIFICACION"
         /// </summary>
         /// <param name="x"></param>
         /// <param name="operacion"></param>
 
           Layer_Data.mdConexion md = new Layer_Data.mdConexion(); 
         try 
         { 
           return md.modificarTabla("sp_sys_tipo_identificacion", parametros(x, operacion));
         } 
          catch (Exception) 
         { 
          throw; 
         } 
        } 
 
 
 
        public Cltipo_identificacion seleccionarUno(Cltipo_identificacion x, int operacion = 0) 
        { 
         /// <summary>
         ///     Ejecuta una funcion SELECT y retorna un campo desde una operacion en SP_SYS_TIPO_IDENTIFICACION"
         /// </summary>
         /// <param name="x"></param>
         /// <param name="operacion"></param>
 
         Layer_Data.mdConexion md = new Layer_Data.mdConexion(); 
 
         DataTable dt = new DataTable(); 
 
         try 
         { 
          dt = md.ejecutarStoredProcedure("sp_sys_tipo_identificacion", parametros(x, operacion)); 
 
          if (dt.Rows.Count > 0) 
          { 
            if (dt.Rows[0]["tid_id"] != DBNull.Value) 
            { 
              x.id = (int)dt.Rows[0]["tid_id"]; 
            } 
            if (dt.Rows[0]["tid_descripcion"] != DBNull.Value) 
            { 
              x.descripcion = (string)dt.Rows[0]["tid_descripcion"]; 
            } 
            if (dt.Rows[0]["tid_activo"] != DBNull.Value) 
            { 
              x.activo = (int)dt.Rows[0]["tid_activo"]; 
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
 
        public DataTable seleccionarTodos(Cltipo_identificacion x, int operacion = 0) 
        { 
         /// <summary>
         ///     Retorna un DataTable de una funcion SELECT en una operacion desde SP_SYS_TIPO_IDENTIFICACION"
         /// </summary>
         /// <param name="x"></param>
         /// <param name="operacion"></param>
 
         Layer_Data.mdConexion md = new Layer_Data.mdConexion(); 
         DataTable dt = new DataTable(); 
         try 
         { 
           dt = md.ejecutarStoredProcedure("sp_sys_tipo_identificacion", parametros(x, operacion)); 
           return dt; 
         } 
         catch (Exception) 
         { 
           return null;
           throw; 
         } 
        } 
 
 
        private Hashtable parametros(Cltipo_identificacion x, int operation = 0) 
        { 
         try 
         { 
           Hashtable parametros = new Hashtable();
 
           parametros.Add("@tid_id", x.id);
           parametros.Add("@tid_descripcion", x.descripcion);
           parametros.Add("@tid_activo", x.activo);
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
