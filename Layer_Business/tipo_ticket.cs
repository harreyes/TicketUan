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
    public class Cltipo_ticket
    {
      #region PROPIEDADES
        private string tti_descripcion;
        private int tti_id;
        private int tti_activo;
      #endregion
      #region CONSTRUCTORS
         public Cltipo_ticket()
         {
           tti_descripcion= "";
           tti_id= 0;
           tti_activo= 0;
         }
         public Cltipo_ticket( string  tti_descripcion , int  tti_id, int  tti_activo  )
         {
          this.tti_descripcion = tti_descripcion;
          this.tti_id = tti_id;
          this.tti_activo = tti_activo;
         }
      #endregion
      #region GETTERS Y SETTER
        public string descripcion 
        {
           get { return this.tti_descripcion; }
        
           set { this.tti_descripcion = value; }
        }
        public int id 
        {
           get { return this.tti_id; }
        
           set { this.tti_id = value; }
        }
        public int activo 
        {
           get { return this.tti_activo; }
        
           set { this.tti_activo = value; }
        }
      #endregion
    }
   }
 
 
 
 

    namespace Controladoras
    {
      public class Ctrtipo_ticket
      {
        public int ejecutar(Cltipo_ticket x, int operacion = 0)
        {
         /// <summary>
         ///     Ejecuta una funcion de INSERTAR, ACTUALIZAR O ELIMINAR desde una operacion en SP_SYS_TIPO_TICKET"
         /// </summary>
         /// <param name="x"></param>
         /// <param name="operacion"></param>
 
           Layer_Data.mdConexion md = new Layer_Data.mdConexion(); 
         try 
         { 
           return md.modificarTabla("sp_sys_tipo_ticket", parametros(x, operacion));
         } 
          catch (Exception) 
         { 
          throw; 
         } 
        } 
 
 
 
        public Cltipo_ticket seleccionarUno(Cltipo_ticket x, int operacion = 0) 
        { 
         /// <summary>
         ///     Ejecuta una funcion SELECT y retorna un campo desde una operacion en SP_SYS_TIPO_TICKET"
         /// </summary>
         /// <param name="x"></param>
         /// <param name="operacion"></param>
 
         Layer_Data.mdConexion md = new Layer_Data.mdConexion(); 
 
         DataTable dt = new DataTable(); 
 
         try 
         { 
          dt = md.ejecutarStoredProcedure("sp_sys_tipo_ticket", parametros(x, operacion)); 
 
          if (dt.Rows.Count > 0) 
          { 
            if (dt.Rows[0]["tti_descripcion"] != DBNull.Value) 
            { 
              x.descripcion = (string)dt.Rows[0]["tti_descripcion"]; 
            } 
            if (dt.Rows[0]["tti_id"] != DBNull.Value) 
            { 
              x.id = (int)dt.Rows[0]["tti_id"]; 
            } 
            if (dt.Rows[0]["tti_activo"] != DBNull.Value) 
            { 
              x.activo = (int)dt.Rows[0]["tti_activo"]; 
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
 
        public DataTable seleccionarTodos(Cltipo_ticket x, int operacion = 0) 
        { 
         /// <summary>
         ///     Retorna un DataTable de una funcion SELECT en una operacion desde SP_SYS_TIPO_TICKET"
         /// </summary>
         /// <param name="x"></param>
         /// <param name="operacion"></param>
 
         Layer_Data.mdConexion md = new Layer_Data.mdConexion(); 
         DataTable dt = new DataTable(); 
         try 
         { 
           dt = md.ejecutarStoredProcedure("sp_sys_tipo_ticket", parametros(x, operacion)); 
           return dt; 
         } 
         catch (Exception) 
         { 
           return null;
           throw; 
         } 
        } 
 
 
        private Hashtable parametros(Cltipo_ticket x, int operation = 0) 
        { 
         try 
         { 
           Hashtable parametros = new Hashtable();
 
           parametros.Add("@tti_descripcion", x.descripcion);
           parametros.Add("@tti_id", x.id);
           parametros.Add("@tti_activo", x.activo);
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
