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

    public class clsusuario
    {
        Clusuarios objclusuarios = new Clusuarios();
        Ctrusuarios objctrusuarios = new Ctrusuarios();

        public DataTable validarUsuario(string scode, string scontrasena)
        {
            try
            {
                DataTable dtUsuario;
                objclusuarios.codigo = scode;
                objclusuarios.password = scontrasena;
                dtUsuario = objctrusuarios.seleccionarTodos(objclusuarios, 5);
                return dtUsuario;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
