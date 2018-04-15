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
    public class clseventos
    {
        Cleventos objcleventos = new Cleventos();
        Ctreventos objctreventos = new Ctreventos();
        public int insertarDatosEvento(DateTime eve_fecha_creacion, DateTime eve_fecha_evento, int iid, string sdescripcion, int ipropiedad, int iactivo)
        {
            try
            {
                objcleventos.fecha_creacion = eve_fecha_creacion;
                objcleventos.fecha_evento = eve_fecha_evento;
                objcleventos.id = iid;
                objcleventos.descripcion = sdescripcion;
                objcleventos.propiedad = ipropiedad;
                objcleventos.activo = iactivo;

                objctreventos.seleccionarTodos(objcleventos, 5);
                return 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
