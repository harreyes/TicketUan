using System;
using System.Collections.Generic;
//using System.Linq;
using System.Web;
using System.Web.UI;

namespace Layer_Mensajes
{

    public static class Mensaje
    {

        public static void mostrar(string mensaje, Page pagina, TipoMensajes tipo, String procedimiento = "SIN DEFINIR", int usuario = 0)
        {
            if (tipo == TipoMensajes.Advertencia)
            {
                
              // //  string script = "<script> $.prompt('" + mensaje + "',{title:'Prometeo',buttons:{'Aceptar':true}});</script>"
                      
                ScriptManager.RegisterStartupScript(pagina, typeof(Page), "msjAdvertencia", "alert('" + mensaje + "');", true);
              ////  ScriptManager.RegisterStartupScript(pagina, typeof(Page), "msjAdvertencia", script, true);
            }
        }

    }

    public enum TipoMensajes
    {
        Informacion = 64,
        Advertencia = 48,
        Error = 16,
        Log = 32

    }

}