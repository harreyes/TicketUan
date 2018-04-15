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
    public class Cleventos
    {
      #region PROPIEDADES
        private DateTime eve_fecha_creacion;
        private DateTime eve_fecha_evento;
        private int eve_id;
        private string eve_descripcion;
        private int eve_propiedad;
        private int eve_activo;
      #endregion
      #region CONSTRUCTORS
         public Cleventos()
         {
           eve_fecha_creacion=  DateTime.Now;
           eve_fecha_evento=  DateTime.Now;
           eve_id= 0;
           eve_descripcion= "";
           eve_propiedad= 0;
           eve_activo= 0;
         }
         public Cleventos( DateTime  eve_fecha_creacion , DateTime  eve_fecha_evento, int  eve_id, string  eve_descripcion, int  eve_propiedad, int  eve_activo  )
         {
          this.eve_fecha_creacion = eve_fecha_creacion;
          this.eve_fecha_evento = eve_fecha_evento;
          this.eve_id = eve_id;
          this.eve_descripcion = eve_descripcion;
          this.eve_propiedad = eve_propiedad;
          this.eve_activo = eve_activo;
         }
      #endregion
      #region GETTERS Y SETTER
        public DateTime fecha_creacion 
        {
           get { return this.eve_fecha_creacion; }
        
           set { this.eve_fecha_creacion = value; }
        }
        public DateTime fecha_evento 
        {
           get { return this.eve_fecha_evento; }
        
           set { this.eve_fecha_evento = value; }
        }
        public int id 
        {
           get { return this.eve_id; }
        
           set { this.eve_id = value; }
        }
        public string descripcion 
        {
           get { return this.eve_descripcion; }
        
           set { this.eve_descripcion = value; }
        }
        public int propiedad 
        {
           get { return this.eve_propiedad; }
        
           set { this.eve_propiedad = value; }
        }
        public int activo 
        {
           get { return this.eve_activo; }
        
           set { this.eve_activo = value; }
        }
      #endregion
    }
   }
 
 
 
 

    namespace Controladoras
    {
      public class Ctreventos
      {
        public int ejecutar(Cleventos x, int operacion = 0)
        {
         /// <summary>
         ///     Ejecuta una funcion de INSERTAR, ACTUALIZAR O ELIMINAR desde una operacion en SP_ADM_EVENTOS"
         /// </summary>
         /// <param name="x"></param>
         /// <param name="operacion"></param>
 
           Layer_Data.mdConexion md = new Layer_Data.mdConexion(); 
         try 
         { 
           return md.modificarTabla("sp_adm_eventos", parametros(x, operacion));
         } 
          catch (Exception) 
         { 
          throw; 
         } 
        } 
 
 
 
        public Cleventos seleccionarUno(Cleventos x, int operacion = 0) 
        { 
         /// <summary>
         ///     Ejecuta una funcion SELECT y retorna un campo desde una operacion en SP_ADM_EVENTOS"
         /// </summary>
         /// <param name="x"></param>
         /// <param name="operacion"></param>
 
         Layer_Data.mdConexion md = new Layer_Data.mdConexion(); 
 
         DataTable dt = new DataTable(); 
 
         try 
         { 
          dt = md.ejecutarStoredProcedure("sp_adm_eventos", parametros(x, operacion)); 
 
          if (dt.Rows.Count > 0) 
          { 
            if (dt.Rows[0]["eve_fecha_creacion"] != DBNull.Value) 
            { 
              x.fecha_creacion = (DateTime)dt.Rows[0]["eve_fecha_creacion"]; 
            } 
            if (dt.Rows[0]["eve_fecha_evento"] != DBNull.Value) 
            { 
              x.fecha_evento = (DateTime)dt.Rows[0]["eve_fecha_evento"]; 
            } 
            if (dt.Rows[0]["eve_id"] != DBNull.Value) 
            { 
              x.id = (int)dt.Rows[0]["eve_id"]; 
            } 
            if (dt.Rows[0]["eve_descripcion"] != DBNull.Value) 
            { 
              x.descripcion = (string)dt.Rows[0]["eve_descripcion"]; 
            } 
            if (dt.Rows[0]["eve_propiedad"] != DBNull.Value) 
            { 
              x.propiedad = (int)dt.Rows[0]["eve_propiedad"]; 
            } 
            if (dt.Rows[0]["eve_activo"] != DBNull.Value) 
            { 
              x.activo = (int)dt.Rows[0]["eve_activo"]; 
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
 
        public DataTable seleccionarTodos(Cleventos x, int operacion = 0) 
        { 
         /// <summary>
         ///     Retorna un DataTable de una funcion SELECT en una operacion desde SP_ADM_EVENTOS"
         /// </summary>
         /// <param name="x"></param>
         /// <param name="operacion"></param>
 
         Layer_Data.mdConexion md = new Layer_Data.mdConexion(); 
         DataTable dt = new DataTable(); 
         try 
         { 
           dt = md.ejecutarStoredProcedure("sp_adm_eventos", parametros(x, operacion)); 
           return dt; 
         } 
         catch (Exception) 
         { 
           return null;
           throw; 
         } 
        } 
 
 
        private Hashtable parametros(Cleventos x, int operation = 0) 
        { 
         try 
         { 
           Hashtable parametros = new Hashtable();
 
           parametros.Add("@eve_fecha_creacion", x.fecha_creacion);
           parametros.Add("@eve_fecha_evento", x.fecha_evento);
           parametros.Add("@eve_id", x.id);
           parametros.Add("@eve_descripcion", x.descripcion);
           parametros.Add("@eve_propiedad", x.propiedad);
           parametros.Add("@eve_activo", x.activo);
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
