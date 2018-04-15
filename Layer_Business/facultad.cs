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
    public class Clfacultad
    {
      #region PROPIEDADES
        private int fac_activo;
        private int fac_id;
        private string fac_descripcion;
      #endregion
      #region CONSTRUCTORS
         public Clfacultad()
         {
           fac_activo= 0;
           fac_id= 0;
           fac_descripcion= "";
         }
         public Clfacultad( int  fac_activo , int  fac_id, string  fac_descripcion  )
         {
          this.fac_activo = fac_activo;
          this.fac_id = fac_id;
          this.fac_descripcion = fac_descripcion;
         }
      #endregion
      #region GETTERS Y SETTER
        public int activo 
        {
           get { return this.fac_activo; }
        
           set { this.fac_activo = value; }
        }
        public int id 
        {
           get { return this.fac_id; }
        
           set { this.fac_id = value; }
        }
        public string descripcion 
        {
           get { return this.fac_descripcion; }
        
           set { this.fac_descripcion = value; }
        }
      #endregion
    }
   }
 
 
 
 

    namespace Controladoras
    {
      public class Ctrfacultad
      {
        public int ejecutar(Clfacultad x, int operacion = 0)
        {
         /// <summary>
         ///     Ejecuta una funcion de INSERTAR, ACTUALIZAR O ELIMINAR desde una operacion en SP_SYS_FACULTAD"
         /// </summary>
         /// <param name="x"></param>
         /// <param name="operacion"></param>
 
           Layer_Data.mdConexion md = new Layer_Data.mdConexion(); 
         try 
         { 
           return md.modificarTabla("sp_sys_facultad", parametros(x, operacion));
         } 
          catch (Exception) 
         { 
          throw; 
         } 
        } 
 
 
 
        public Clfacultad seleccionarUno(Clfacultad x, int operacion = 0) 
        { 
         /// <summary>
         ///     Ejecuta una funcion SELECT y retorna un campo desde una operacion en SP_SYS_FACULTAD"
         /// </summary>
         /// <param name="x"></param>
         /// <param name="operacion"></param>
 
         Layer_Data.mdConexion md = new Layer_Data.mdConexion(); 
 
         DataTable dt = new DataTable(); 
 
         try 
         { 
          dt = md.ejecutarStoredProcedure("sp_sys_facultad", parametros(x, operacion)); 
 
          if (dt.Rows.Count > 0) 
          { 
            if (dt.Rows[0]["fac_activo"] != DBNull.Value) 
            { 
              x.activo = (int)dt.Rows[0]["fac_activo"]; 
            } 
            if (dt.Rows[0]["fac_id"] != DBNull.Value) 
            { 
              x.id = (int)dt.Rows[0]["fac_id"]; 
            } 
            if (dt.Rows[0]["fac_descripcion"] != DBNull.Value) 
            { 
              x.descripcion = (string)dt.Rows[0]["fac_descripcion"]; 
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
 
        public DataTable seleccionarTodos(Clfacultad x, int operacion = 0) 
        { 
         /// <summary>
         ///     Retorna un DataTable de una funcion SELECT en una operacion desde SP_SYS_FACULTAD"
         /// </summary>
         /// <param name="x"></param>
         /// <param name="operacion"></param>
 
         Layer_Data.mdConexion md = new Layer_Data.mdConexion(); 
         DataTable dt = new DataTable(); 
         try 
         { 
           dt = md.ejecutarStoredProcedure("sp_sys_facultad", parametros(x, operacion)); 
           return dt; 
         } 
         catch (Exception) 
         { 
           return null;
           throw; 
         } 
        } 
 
 
        private Hashtable parametros(Clfacultad x, int operation = 0) 
        { 
         try 
         { 
           Hashtable parametros = new Hashtable();
 
           parametros.Add("@fac_activo", x.activo);
           parametros.Add("@fac_id", x.id);
           parametros.Add("@fac_descripcion", x.descripcion);
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
