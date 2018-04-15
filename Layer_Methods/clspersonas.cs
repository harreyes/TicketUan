using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Layer_Business.Entidades;
using Layer_Business.Controladoras;
using System.Data;

namespace Layer_Methods
{
   public class clspersonas
    {
       Clpersonas objclpersonas = new Clpersonas();
       Ctrpersonas objctrpersonas = new Ctrpersonas();
       public int insertarDatosPersona(int itipopersona,int ipais, string sidentificacion, int iciudad, string snombre, string scorreo, string scodigo, int iid, int iactivo, string sapellido, int itipoidentificacion)
       {
           try
           {
               objclpersonas.tipo_persona = itipopersona;
               objclpersonas.pais = ipais;
               objclpersonas.identificacion = sidentificacion;
               objclpersonas.ciudad = iciudad;
               objclpersonas.nombre = snombre;
               objclpersonas.correo = scorreo;
               objclpersonas.codigo = scodigo;
               objclpersonas.id = iid;
               objclpersonas.activo = iactivo;
               objclpersonas.apellido = sapellido;
               objclpersonas.tipo_identicicacion = itipoidentificacion;



               objctrpersonas.seleccionarTodos(objclpersonas, 5);
               return 1;
           }
           catch (Exception ex)
           {
               throw ex;
           }
       }

    }
}
