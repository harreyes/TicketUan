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
    public class Clticket
    {
      #region PROPIEDADES
        private int tic_id;
        private int tic_propiedad;
        private string tic_ticket;
        private int tic_usuario;
      #endregion
      #region CONSTRUCTORS
         public Clticket()
         {
           tic_id= 0;
           tic_propiedad= 0;
           tic_ticket= "";
           tic_usuario= 0;
         }
         public Clticket( int  tic_id , int  tic_propiedad, string  tic_ticket, int  tic_usuario  )
         {
          this.tic_id = tic_id;
          this.tic_propiedad = tic_propiedad;
          this.tic_ticket = tic_ticket;
          this.tic_usuario = tic_usuario;
         }
      #endregion
      #region GETTERS Y SETTER
        public int id 
        {
           get { return this.tic_id; }
        
           set { this.tic_id = value; }
        }
        public int propiedad 
        {
           get { return this.tic_propiedad; }
        
           set { this.tic_propiedad = value; }
        }
        public string ticket 
        {
           get { return this.tic_ticket; }
        
           set { this.tic_ticket = value; }
        }
        public int usuario 
        {
           get { return this.tic_usuario; }
        
           set { this.tic_usuario = value; }
        }
      #endregion
    }
   }
 
 
 
 

    namespace Controladoras
    {
      public class Ctrticket
      {
        public int ejecutar(Clticket x, int operacion = 0)
        {
         /// <summary>
         ///     Ejecuta una funcion de INSERTAR, ACTUALIZAR O ELIMINAR desde una operacion en SP_ADM_TICKET"
         /// </summary>
         /// <param name="x"></param>
         /// <param name="operacion"></param>
 
           Layer_Data.mdConexion md = new Layer_Data.mdConexion(); 
         try 
         { 
           return md.modificarTabla("sp_adm_ticket", parametros(x, operacion));
         } 
          catch (Exception) 
         { 
          throw; 
         } 
        } 
 
 
 
        public Clticket seleccionarUno(Clticket x, int operacion = 0) 
        { 
         /// <summary>
         ///     Ejecuta una funcion SELECT y retorna un campo desde una operacion en SP_ADM_TICKET"
         /// </summary>
         /// <param name="x"></param>
         /// <param name="operacion"></param>
 
         Layer_Data.mdConexion md = new Layer_Data.mdConexion(); 
 
         DataTable dt = new DataTable(); 
 
         try 
         { 
          dt = md.ejecutarStoredProcedure("sp_adm_ticket", parametros(x, operacion)); 
 
          if (dt.Rows.Count > 0) 
          { 
            if (dt.Rows[0]["tic_id"] != DBNull.Value) 
            { 
              x.id = (int)dt.Rows[0]["tic_id"]; 
            } 
            if (dt.Rows[0]["tic_propiedad"] != DBNull.Value) 
            { 
              x.propiedad = (int)dt.Rows[0]["tic_propiedad"]; 
            } 
            if (dt.Rows[0]["tic_ticket"] != DBNull.Value) 
            { 
              x.ticket = (string)dt.Rows[0]["tic_ticket"]; 
            } 
            if (dt.Rows[0]["tic_usuario"] != DBNull.Value) 
            { 
              x.usuario = (int)dt.Rows[0]["tic_usuario"]; 
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
 
        public DataTable seleccionarTodos(Clticket x, int operacion = 0) 
        { 
         /// <summary>
         ///     Retorna un DataTable de una funcion SELECT en una operacion desde SP_ADM_TICKET"
         /// </summary>
         /// <param name="x"></param>
         /// <param name="operacion"></param>
 
         Layer_Data.mdConexion md = new Layer_Data.mdConexion(); 
         DataTable dt = new DataTable(); 
         try 
         { 
           dt = md.ejecutarStoredProcedure("sp_adm_ticket", parametros(x, operacion)); 
           return dt; 
         } 
         catch (Exception) 
         { 
           return null;
           throw; 
         } 
        } 
 
 
        private Hashtable parametros(Clticket x, int operation = 0) 
        { 
         try 
         { 
           Hashtable parametros = new Hashtable();
 
           parametros.Add("@tic_id", x.id);
           parametros.Add("@tic_propiedad", x.propiedad);
           parametros.Add("@tic_ticket", x.ticket);
           parametros.Add("@tic_usuario", x.usuario);
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
