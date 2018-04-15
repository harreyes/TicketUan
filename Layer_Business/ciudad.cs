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
    public class Clciudad
    {
      #region PROPIEDADES
        private int ciu_activo;
        private string ciu_descripcion;
        private int ciu_pais;
        private int ciu_id;
      #endregion
      #region CONSTRUCTORS
         public Clciudad()
         {
           ciu_activo= 0;
           ciu_descripcion= "";
           ciu_pais= 0;
           ciu_id= 0;
         }
         public Clciudad( int  ciu_activo , string  ciu_descripcion, int  ciu_pais, int  ciu_id  )
         {
          this.ciu_activo = ciu_activo;
          this.ciu_descripcion = ciu_descripcion;
          this.ciu_pais = ciu_pais;
          this.ciu_id = ciu_id;
         }
      #endregion
      #region GETTERS Y SETTER
        public int activo 
        {
           get { return this.ciu_activo; }
        
           set { this.ciu_activo = value; }
        }
        public string descripcion 
        {
           get { return this.ciu_descripcion; }
        
           set { this.ciu_descripcion = value; }
        }
        public int pais 
        {
           get { return this.ciu_pais; }
        
           set { this.ciu_pais = value; }
        }
        public int id 
        {
           get { return this.ciu_id; }
        
           set { this.ciu_id = value; }
        }
      #endregion
    }
   }
 
 
 
 

    namespace Controladoras
    {
      public class Ctrciudad
      {
        public int ejecutar(Clciudad x, int operacion = 0)
        {
         /// <summary>
         ///     Ejecuta una funcion de INSERTAR, ACTUALIZAR O ELIMINAR desde una operacion en SP_SYS_CIUDAD"
         /// </summary>
         /// <param name="x"></param>
         /// <param name="operacion"></param>
 
           Layer_Data.mdConexion md = new Layer_Data.mdConexion(); 
         try 
         { 
           return md.modificarTabla("sp_sys_ciudad", parametros(x, operacion));
         } 
          catch (Exception) 
         { 
          throw; 
         } 
        } 
 
 
 
        public Clciudad seleccionarUno(Clciudad x, int operacion = 0) 
        { 
         /// <summary>
         ///     Ejecuta una funcion SELECT y retorna un campo desde una operacion en SP_SYS_CIUDAD"
         /// </summary>
         /// <param name="x"></param>
         /// <param name="operacion"></param>
 
         Layer_Data.mdConexion md = new Layer_Data.mdConexion(); 
 
         DataTable dt = new DataTable(); 
 
         try 
         { 
          dt = md.ejecutarStoredProcedure("sp_sys_ciudad", parametros(x, operacion)); 
 
          if (dt.Rows.Count > 0) 
          { 
            if (dt.Rows[0]["ciu_activo"] != DBNull.Value) 
            { 
              x.activo = (int)dt.Rows[0]["ciu_activo"]; 
            } 
            if (dt.Rows[0]["ciu_descripcion"] != DBNull.Value) 
            { 
              x.descripcion = (string)dt.Rows[0]["ciu_descripcion"]; 
            } 
            if (dt.Rows[0]["ciu_pais"] != DBNull.Value) 
            { 
              x.pais = (int)dt.Rows[0]["ciu_pais"]; 
            } 
            if (dt.Rows[0]["ciu_id"] != DBNull.Value) 
            { 
              x.id = (int)dt.Rows[0]["ciu_id"]; 
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
 
        public DataTable seleccionarTodos(Clciudad x, int operacion = 0) 
        { 
         /// <summary>
         ///     Retorna un DataTable de una funcion SELECT en una operacion desde SP_SYS_CIUDAD"
         /// </summary>
         /// <param name="x"></param>
         /// <param name="operacion"></param>
 
         Layer_Data.mdConexion md = new Layer_Data.mdConexion(); 
         DataTable dt = new DataTable(); 
         try 
         { 
           dt = md.ejecutarStoredProcedure("sp_sys_ciudad", parametros(x, operacion)); 
           return dt; 
         } 
         catch (Exception) 
         { 
           return null;
           throw; 
         } 
        } 
 
 
        private Hashtable parametros(Clciudad x, int operation = 0) 
        { 
         try 
         { 
           Hashtable parametros = new Hashtable();
 
           parametros.Add("@ciu_activo", x.activo);
           parametros.Add("@ciu_descripcion", x.descripcion);
           parametros.Add("@ciu_pais", x.pais);
           parametros.Add("@ciu_id", x.id);
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
