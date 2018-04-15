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
    public class Clpersonas
    {
      #region PROPIEDADES
        private int per_tipo_persona;
        private int per_pais;
        private string per_identificacion;
        private int per_ciudad;
        private string per_nombre;
        private string per_correo;
        private string per_codigo;
        private int per_id;
        private int per_activo;
        private string per_apellido;
        private int per_tipo_identicicacion;
      #endregion
      #region CONSTRUCTORS
         public Clpersonas()
         {
           per_tipo_persona= 0;
           per_pais= 0;
           per_identificacion= "";
           per_ciudad= 0;
           per_nombre= "";
           per_correo= "";
           per_codigo= "";
           per_id= 0;
           per_activo= 0;
           per_apellido= "";
           per_tipo_identicicacion= 0;
         }
         public Clpersonas( int  per_tipo_persona , int  per_pais, string  per_identificacion, int  per_ciudad, string  per_nombre, string  per_correo, string  per_codigo, int  per_id, int  per_activo, string  per_apellido, int  per_tipo_identicicacion  )
         {
          this.per_tipo_persona = per_tipo_persona;
          this.per_pais = per_pais;
          this.per_identificacion = per_identificacion;
          this.per_ciudad = per_ciudad;
          this.per_nombre = per_nombre;
          this.per_correo = per_correo;
          this.per_codigo = per_codigo;
          this.per_id = per_id;
          this.per_activo = per_activo;
          this.per_apellido = per_apellido;
          this.per_tipo_identicicacion = per_tipo_identicicacion;
         }
      #endregion
      #region GETTERS Y SETTER
        public int tipo_persona 
        {
           get { return this.per_tipo_persona; }
        
           set { this.per_tipo_persona = value; }
        }
        public int pais 
        {
           get { return this.per_pais; }
        
           set { this.per_pais = value; }
        }
        public string identificacion 
        {
           get { return this.per_identificacion; }
        
           set { this.per_identificacion = value; }
        }
        public int ciudad 
        {
           get { return this.per_ciudad; }
        
           set { this.per_ciudad = value; }
        }
        public string nombre 
        {
           get { return this.per_nombre; }
        
           set { this.per_nombre = value; }
        }
        public string correo 
        {
           get { return this.per_correo; }
        
           set { this.per_correo = value; }
        }
        public string codigo 
        {
           get { return this.per_codigo; }
        
           set { this.per_codigo = value; }
        }
        public int id 
        {
           get { return this.per_id; }
        
           set { this.per_id = value; }
        }
        public int activo 
        {
           get { return this.per_activo; }
        
           set { this.per_activo = value; }
        }
        public string apellido 
        {
           get { return this.per_apellido; }
        
           set { this.per_apellido = value; }
        }
        public int tipo_identicicacion 
        {
           get { return this.per_tipo_identicicacion; }
        
           set { this.per_tipo_identicicacion = value; }
        }
      #endregion
    }
   }
 
 
 
 

    namespace Controladoras
    {
      public class Ctrpersonas
      {
        public int ejecutar(Clpersonas x, int operacion = 0)
        {
         /// <summary>
         ///     Ejecuta una funcion de INSERTAR, ACTUALIZAR O ELIMINAR desde una operacion en SP_ADM_PERSONAS"
         /// </summary>
         /// <param name="x"></param>
         /// <param name="operacion"></param>
 
           Layer_Data.mdConexion md = new Layer_Data.mdConexion(); 
         try 
         { 
           return md.modificarTabla("sp_adm_personas", parametros(x, operacion));
         } 
          catch (Exception) 
         { 
          throw; 
         } 
        } 
 
 
 
        public Clpersonas seleccionarUno(Clpersonas x, int operacion = 0) 
        { 
         /// <summary>
         ///     Ejecuta una funcion SELECT y retorna un campo desde una operacion en SP_ADM_PERSONAS"
         /// </summary>
         /// <param name="x"></param>
         /// <param name="operacion"></param>
 
         Layer_Data.mdConexion md = new Layer_Data.mdConexion(); 
 
         DataTable dt = new DataTable(); 
 
         try 
         { 
          dt = md.ejecutarStoredProcedure("sp_adm_personas", parametros(x, operacion)); 
 
          if (dt.Rows.Count > 0) 
          { 
            if (dt.Rows[0]["per_tipo_persona"] != DBNull.Value) 
            { 
              x.tipo_persona = (int)dt.Rows[0]["per_tipo_persona"]; 
            } 
            if (dt.Rows[0]["per_pais"] != DBNull.Value) 
            { 
              x.pais = (int)dt.Rows[0]["per_pais"]; 
            } 
            if (dt.Rows[0]["per_identificacion"] != DBNull.Value) 
            { 
              x.identificacion = (string)dt.Rows[0]["per_identificacion"]; 
            } 
            if (dt.Rows[0]["per_ciudad"] != DBNull.Value) 
            { 
              x.ciudad = (int)dt.Rows[0]["per_ciudad"]; 
            } 
            if (dt.Rows[0]["per_nombre"] != DBNull.Value) 
            { 
              x.nombre = (string)dt.Rows[0]["per_nombre"]; 
            } 
            if (dt.Rows[0]["per_correo"] != DBNull.Value) 
            { 
              x.correo = (string)dt.Rows[0]["per_correo"]; 
            } 
            if (dt.Rows[0]["per_codigo"] != DBNull.Value) 
            { 
              x.codigo = (string)dt.Rows[0]["per_codigo"]; 
            } 
            if (dt.Rows[0]["per_id"] != DBNull.Value) 
            { 
              x.id = (int)dt.Rows[0]["per_id"]; 
            } 
            if (dt.Rows[0]["per_activo"] != DBNull.Value) 
            { 
              x.activo = (int)dt.Rows[0]["per_activo"]; 
            } 
            if (dt.Rows[0]["per_apellido"] != DBNull.Value) 
            { 
              x.apellido = (string)dt.Rows[0]["per_apellido"]; 
            } 
            if (dt.Rows[0]["per_tipo_identicicacion"] != DBNull.Value) 
            { 
              x.tipo_identicicacion = (int)dt.Rows[0]["per_tipo_identicicacion"]; 
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
 
        public DataTable seleccionarTodos(Clpersonas x, int operacion = 0) 
        { 
         /// <summary>
         ///     Retorna un DataTable de una funcion SELECT en una operacion desde SP_ADM_PERSONAS"
         /// </summary>
         /// <param name="x"></param>
         /// <param name="operacion"></param>
 
         Layer_Data.mdConexion md = new Layer_Data.mdConexion(); 
         DataTable dt = new DataTable(); 
         try 
         { 
           dt = md.ejecutarStoredProcedure("sp_adm_personas", parametros(x, operacion)); 
           return dt; 
         } 
         catch (Exception) 
         { 
           return null;
           throw; 
         } 
        } 
 
 
        private Hashtable parametros(Clpersonas x, int operation = 0) 
        { 
         try 
         { 
           Hashtable parametros = new Hashtable();
 
           parametros.Add("@per_tipo_persona", x.tipo_persona);
           parametros.Add("@per_pais", x.pais);
           parametros.Add("@per_identificacion", x.identificacion);
           parametros.Add("@per_ciudad", x.ciudad);
           parametros.Add("@per_nombre", x.nombre);
           parametros.Add("@per_correo", x.correo);
           parametros.Add("@per_codigo", x.codigo);
           parametros.Add("@per_id", x.id);
           parametros.Add("@per_activo", x.activo);
           parametros.Add("@per_apellido", x.apellido);
           parametros.Add("@per_tipo_identicicacion", x.tipo_identicicacion);
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
