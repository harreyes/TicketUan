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
    public class Clpais
    {
      #region PROPIEDADES
        private string pai_codigo;
        private int pai_activo;
        private string pai_abreviatura;
        private int pai_id;
        private string pai_descripcion;
      #endregion
      #region CONSTRUCTORS
         public Clpais()
         {
           pai_codigo= "";
           pai_activo= 0;
           pai_abreviatura= "";
           pai_id= 0;
           pai_descripcion= "";
         }
         public Clpais( string  pai_codigo , int  pai_activo, string  pai_abreviatura, int  pai_id, string  pai_descripcion  )
         {
          this.pai_codigo = pai_codigo;
          this.pai_activo = pai_activo;
          this.pai_abreviatura = pai_abreviatura;
          this.pai_id = pai_id;
          this.pai_descripcion = pai_descripcion;
         }
      #endregion
      #region GETTERS Y SETTER
        public string codigo 
        {
           get { return this.pai_codigo; }
        
           set { this.pai_codigo = value; }
        }
        public int activo 
        {
           get { return this.pai_activo; }
        
           set { this.pai_activo = value; }
        }
        public string abreviatura 
        {
           get { return this.pai_abreviatura; }
        
           set { this.pai_abreviatura = value; }
        }
        public int id 
        {
           get { return this.pai_id; }
        
           set { this.pai_id = value; }
        }
        public string descripcion 
        {
           get { return this.pai_descripcion; }
        
           set { this.pai_descripcion = value; }
        }
      #endregion
    }
   }
 
 
 
 

    namespace Controladoras
    {
      public class Ctrpais
      {
        public int ejecutar(Clpais x, int operacion = 0)
        {
         /// <summary>
         ///     Ejecuta una funcion de INSERTAR, ACTUALIZAR O ELIMINAR desde una operacion en SP_SYS_PAIS"
         /// </summary>
         /// <param name="x"></param>
         /// <param name="operacion"></param>
 
           Layer_Data.mdConexion md = new Layer_Data.mdConexion(); 
         try 
         { 
           return md.modificarTabla("sp_sys_pais", parametros(x, operacion));
         } 
          catch (Exception) 
         { 
          throw; 
         } 
        } 
 
 
 
        public Clpais seleccionarUno(Clpais x, int operacion = 0) 
        { 
         /// <summary>
         ///     Ejecuta una funcion SELECT y retorna un campo desde una operacion en SP_SYS_PAIS"
         /// </summary>
         /// <param name="x"></param>
         /// <param name="operacion"></param>
 
         Layer_Data.mdConexion md = new Layer_Data.mdConexion(); 
 
         DataTable dt = new DataTable(); 
 
         try 
         { 
          dt = md.ejecutarStoredProcedure("sp_sys_pais", parametros(x, operacion)); 
 
          if (dt.Rows.Count > 0) 
          { 
            if (dt.Rows[0]["pai_codigo"] != DBNull.Value) 
            { 
              x.codigo = (string)dt.Rows[0]["pai_codigo"]; 
            } 
            if (dt.Rows[0]["pai_activo"] != DBNull.Value) 
            { 
              x.activo = (int)dt.Rows[0]["pai_activo"]; 
            } 
            if (dt.Rows[0]["pai_abreviatura"] != DBNull.Value) 
            { 
              x.abreviatura = (string)dt.Rows[0]["pai_abreviatura"]; 
            } 
            if (dt.Rows[0]["pai_id"] != DBNull.Value) 
            { 
              x.id = (int)dt.Rows[0]["pai_id"]; 
            } 
            if (dt.Rows[0]["pai_descripcion"] != DBNull.Value) 
            { 
              x.descripcion = (string)dt.Rows[0]["pai_descripcion"]; 
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
 
        public DataTable seleccionarTodos(Clpais x, int operacion = 0) 
        { 
         /// <summary>
         ///     Retorna un DataTable de una funcion SELECT en una operacion desde SP_SYS_PAIS"
         /// </summary>
         /// <param name="x"></param>
         /// <param name="operacion"></param>
 
         Layer_Data.mdConexion md = new Layer_Data.mdConexion(); 
         DataTable dt = new DataTable(); 
         try 
         { 
           dt = md.ejecutarStoredProcedure("sp_sys_pais", parametros(x, operacion)); 
           return dt; 
         } 
         catch (Exception) 
         { 
           return null;
           throw; 
         } 
        } 
 
 
        private Hashtable parametros(Clpais x, int operation = 0) 
        { 
         try 
         { 
           Hashtable parametros = new Hashtable();
 
           parametros.Add("@pai_codigo", x.codigo);
           parametros.Add("@pai_activo", x.activo);
           parametros.Add("@pai_abreviatura", x.abreviatura);
           parametros.Add("@pai_id", x.id);
           parametros.Add("@pai_descripcion", x.descripcion);
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
