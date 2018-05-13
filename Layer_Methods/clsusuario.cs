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

        public int insertarUsuario(int ipropiedad, string snombre, string sapellido, string scodigo, int itipoidentificacion, string sidentificacion, string scorreo, string spassword, int ipais, int iciudad, int ifacultad)
        {
            try
            {
                objclusuarios.propiedad = ipropiedad;
                objclusuarios.nombre = snombre;
                objclusuarios.apellido = sapellido;
                objclusuarios.codigo = scodigo;
                objclusuarios.tipo_identificacion = itipoidentificacion;
                objclusuarios.identificacion = sidentificacion;
                objclusuarios.correo = scorreo;
                objclusuarios.password = spassword;
                objclusuarios.pais = ipais;
                objclusuarios.ciudad = iciudad;
                objclusuarios.factultad = ifacultad;



                objctrusuarios.seleccionarTodos(objclusuarios, 6);
                return 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //metodo para traer los usuarios
        public DataTable cargarListaUsuarios()
        {
            try
            {
                DataTable dtUsuarios;
                dtUsuarios = objctrusuarios.seleccionarTodos(objclusuarios, 8);
                return dtUsuarios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
