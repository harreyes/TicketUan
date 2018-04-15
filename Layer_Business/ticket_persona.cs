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
    public class Clticket_persona
    {
      #region PROPIEDADES
        private int tpe_id;
        private int tpe_usuario;
        private int tpe_persona;
        private int tpe_ticket;
        private int tpe_fecha_envio;
      #endregion
      #region CONSTRUCTORS
         public Clticket_persona()
         {
           tpe_id= 0;
           tpe_usuario= 0;
           tpe_persona= 0;
           tpe_ticket= 0;
           tpe_fecha_envio= 0;
         }
         public Clticket_persona( int  tpe_id , int  tpe_usuario, int  tpe_persona, int  tpe_ticket, int  tpe_fecha_envio  )
         {
          this.tpe_id = tpe_id;
          this.tpe_usuario = tpe_usuario;
          this.tpe_persona = tpe_persona;
          this.tpe_ticket = tpe_ticket;
          this.tpe_fecha_envio = tpe_fecha_envio;
         }
      #endregion
      #region GETTERS Y SETTER
        public int id 
        {
           get { return this.tpe_id; }
        
           set { this.tpe_id = value; }
        }
        public int usuario 
        {
           get { return this.tpe_usuario; }
        
           set { this.tpe_usuario = value; }
        }
        public int persona 
        {
           get { return this.tpe_persona; }
        
           set { this.tpe_persona = value; }
        }
        public int ticket 
        {
           get { return this.tpe_ticket; }
        
           set { this.tpe_ticket = value; }
        }
        public int fecha_envio 
        {
           get { return this.tpe_fecha_envio; }
        
           set { this.tpe_fecha_envio = value; }
        }
      #endregion
    }
   }
 
 
 
 

    namespace Controladoras
    {
      public class Ctrticket_persona
      {
        public int ejecutar(Clticket_persona x, int operacion = 0)
        {
         /// <summary>
         ///     Ejecuta una funcion de INSERTAR, ACTUALIZAR O ELIMINAR desde una operacion en SP_ADM_TICKET_PERSONA"
         /// </summary>
         /// <param name="x"></param>
         /// <param name="operacion"></param>
 
           Layer_Data.mdConexion md = new Layer_Data.mdConexion(); 
         try 
         { 
           return md.modificarTabla("sp_adm_ticket_persona", parametros(x, operacion));
         } 
          catch (Exception) 
         { 
          throw; 
         } 
        } 
 
 
 
        public Clticket_persona seleccionarUno(Clticket_persona x, int operacion = 0) 
        { 
         /// <summary>
         ///     Ejecuta una funcion SELECT y retorna un campo desde una operacion en SP_ADM_TICKET_PERSONA"
         /// </summary>
         /// <param name="x"></param>
         /// <param name="operacion"></param>
 
         Layer_Data.mdConexion md = new Layer_Data.mdConexion(); 
 
         DataTable dt = new DataTable(); 
 
         try 
         { 
          dt = md.ejecutarStoredProcedure("sp_adm_ticket_persona", parametros(x, operacion)); 
 
          if (dt.Rows.Count > 0) 
          { 
            if (dt.Rows[0]["tpe_id"] != DBNull.Value) 
            { 
              x.id = (int)dt.Rows[0]["tpe_id"]; 
            } 
            if (dt.Rows[0]["tpe_usuario"] != DBNull.Value) 
            { 
              x.usuario = (int)dt.Rows[0]["tpe_usuario"]; 
            } 
            if (dt.Rows[0]["tpe_persona"] != DBNull.Value) 
            { 
              x.persona = (int)dt.Rows[0]["tpe_persona"]; 
            } 
            if (dt.Rows[0]["tpe_ticket"] != DBNull.Value) 
            { 
              x.ticket = (int)dt.Rows[0]["tpe_ticket"]; 
            } 
            if (dt.Rows[0]["tpe_fecha_envio"] != DBNull.Value) 
            { 
              x.fecha_envio = (int)dt.Rows[0]["tpe_fecha_envio"]; 
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
 
        public DataTable seleccionarTodos(Clticket_persona x, int operacion = 0) 
        { 
         /// <summary>
         ///     Retorna un DataTable de una funcion SELECT en una operacion desde SP_ADM_TICKET_PERSONA"
         /// </summary>
         /// <param name="x"></param>
         /// <param name="operacion"></param>
 
         Layer_Data.mdConexion md = new Layer_Data.mdConexion(); 
         DataTable dt = new DataTable(); 
         try 
         { 
           dt = md.ejecutarStoredProcedure("sp_adm_ticket_persona", parametros(x, operacion)); 
           return dt; 
         } 
         catch (Exception) 
         { 
           return null;
           throw; 
         } 
        } 
 
 
        private Hashtable parametros(Clticket_persona x, int operation = 0) 
        { 
         try 
         { 
           Hashtable parametros = new Hashtable();
 
           parametros.Add("@tpe_id", x.id);
           parametros.Add("@tpe_usuario", x.usuario);
           parametros.Add("@tpe_persona", x.persona);
           parametros.Add("@tpe_ticket", x.ticket);
           parametros.Add("@tpe_fecha_envio", x.fecha_envio);
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
