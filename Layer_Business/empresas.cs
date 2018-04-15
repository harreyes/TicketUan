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
    public class Clempresas
    {
      #region PROPIEDADES
        private string emp_direccion;
        private string emp_nombre;
        private string emp_telefono;
        private string emp_email;
        private int emp_activo;
        private int emp_id;
      #endregion
      #region CONSTRUCTORS
         public Clempresas()
         {
           emp_direccion= "";
           emp_nombre= "";
           emp_telefono= "";
           emp_email= "";
           emp_activo= 0;
           emp_id= 0;
         }
         public Clempresas( string  emp_direccion , string  emp_nombre, string  emp_telefono, string  emp_email, int  emp_activo, int  emp_id  )
         {
          this.emp_direccion = emp_direccion;
          this.emp_nombre = emp_nombre;
          this.emp_telefono = emp_telefono;
          this.emp_email = emp_email;
          this.emp_activo = emp_activo;
          this.emp_id = emp_id;
         }
      #endregion
      #region GETTERS Y SETTER
        public string direccion 
        {
           get { return this.emp_direccion; }
        
           set { this.emp_direccion = value; }
        }
        public string nombre 
        {
           get { return this.emp_nombre; }
        
           set { this.emp_nombre = value; }
        }
        public string telefono 
        {
           get { return this.emp_telefono; }
        
           set { this.emp_telefono = value; }
        }
        public string email 
        {
           get { return this.emp_email; }
        
           set { this.emp_email = value; }
        }
        public int activo 
        {
           get { return this.emp_activo; }
        
           set { this.emp_activo = value; }
        }
        public int id 
        {
           get { return this.emp_id; }
        
           set { this.emp_id = value; }
        }
      #endregion
    }
   }
 
 
 
 

    namespace Controladoras
    {
      public class Ctrempresas
      {
        public int ejecutar(Clempresas x, int operacion = 0)
        {
         /// <summary>
         ///     Ejecuta una funcion de INSERTAR, ACTUALIZAR O ELIMINAR desde una operacion en SP_ADM_EMPRESAS"
         /// </summary>
         /// <param name="x"></param>
         /// <param name="operacion"></param>
 
           Layer_Data.mdConexion md = new Layer_Data.mdConexion(); 
         try 
         { 
           return md.modificarTabla("sp_adm_empresas", parametros(x, operacion));
         } 
          catch (Exception) 
         { 
          throw; 
         } 
        } 
 
 
 
        public Clempresas seleccionarUno(Clempresas x, int operacion = 0) 
        { 
         /// <summary>
         ///     Ejecuta una funcion SELECT y retorna un campo desde una operacion en SP_ADM_EMPRESAS"
         /// </summary>
         /// <param name="x"></param>
         /// <param name="operacion"></param>
 
         Layer_Data.mdConexion md = new Layer_Data.mdConexion(); 
 
         DataTable dt = new DataTable(); 
 
         try 
         { 
          dt = md.ejecutarStoredProcedure("sp_adm_empresas", parametros(x, operacion)); 
 
          if (dt.Rows.Count > 0) 
          { 
            if (dt.Rows[0]["emp_direccion"] != DBNull.Value) 
            { 
              x.direccion = (string)dt.Rows[0]["emp_direccion"]; 
            } 
            if (dt.Rows[0]["emp_nombre"] != DBNull.Value) 
            { 
              x.nombre = (string)dt.Rows[0]["emp_nombre"]; 
            } 
            if (dt.Rows[0]["emp_telefono"] != DBNull.Value) 
            { 
              x.telefono = (string)dt.Rows[0]["emp_telefono"]; 
            } 
            if (dt.Rows[0]["emp_email"] != DBNull.Value) 
            { 
              x.email = (string)dt.Rows[0]["emp_email"]; 
            } 
            if (dt.Rows[0]["emp_activo"] != DBNull.Value) 
            { 
              x.activo = (int)dt.Rows[0]["emp_activo"]; 
            } 
            if (dt.Rows[0]["emp_id"] != DBNull.Value) 
            { 
              x.id = (int)dt.Rows[0]["emp_id"]; 
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
 
        public DataTable seleccionarTodos(Clempresas x, int operacion = 0) 
        { 
         /// <summary>
         ///     Retorna un DataTable de una funcion SELECT en una operacion desde SP_ADM_EMPRESAS"
         /// </summary>
         /// <param name="x"></param>
         /// <param name="operacion"></param>
 
         Layer_Data.mdConexion md = new Layer_Data.mdConexion(); 
         DataTable dt = new DataTable(); 
         try 
         { 
           dt = md.ejecutarStoredProcedure("sp_adm_empresas", parametros(x, operacion)); 
           return dt; 
         } 
         catch (Exception) 
         { 
           return null;
           throw; 
         } 
        } 
 
 
        private Hashtable parametros(Clempresas x, int operation = 0) 
        { 
         try 
         { 
           Hashtable parametros = new Hashtable();
 
           parametros.Add("@emp_direccion", x.direccion);
           parametros.Add("@emp_nombre", x.nombre);
           parametros.Add("@emp_telefono", x.telefono);
           parametros.Add("@emp_email", x.email);
           parametros.Add("@emp_activo", x.activo);
           parametros.Add("@emp_id", x.id);
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
