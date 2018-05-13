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
    public class clstipos
    {
        Cltipo_identificacion objcltipoidentificacion = new Cltipo_identificacion();
        Ctrtipo_identificacion objctrtipoidentificacion = new Ctrtipo_identificacion();

        Clpais objclpais = new Clpais();
        Ctrpais objctrpais = new Ctrpais();

        Clciudad objclciudad = new Clciudad();
        Ctrciudad objctrciudad = new Ctrciudad();

        Cl_personas objcltipopersonas = new Cl_personas();
        Ctr_personas objctrtipopersonas = new Ctr_personas();

        Clpropiedad objclpropiedades = new Clpropiedad();
        Ctrpropiedad objctrpropiedades = new Ctrpropiedad();

        Clfacultad objclfacultades = new Clfacultad();
        Ctrfacultad objctrfacultades = new Ctrfacultad();

        //metodo para cargar los datos de la tabla tipoIdentificacion
        public DataTable cargarComboIdentificacion()
        {
            try
            {
                DataTable dtUsuario;
                dtUsuario = objctrtipoidentificacion.seleccionarTodos(objcltipoidentificacion, 5);
                return dtUsuario;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //metodo para cargar los paises
        public DataTable cargarComboPais()
        {
            try
            {
                DataTable dtPais;
                dtPais = objctrpais.seleccionarTodos(objclpais, 5);
                return dtPais;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //metodo para cargar las ciudades
        public DataTable cargarComboCiudad()
        {
            try
            {
                DataTable dtCiudad;
                dtCiudad = objctrciudad.seleccionarTodos(objclciudad, 5);
                return dtCiudad;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //metodo para cargar tiposPersonas
        public DataTable cargarComboTipoPersona()
        {
            try
            {
                DataTable dtTipoPersona;
                dtTipoPersona = objctrtipopersonas.seleccionarTodos(objcltipopersonas, 5);
                return dtTipoPersona;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //metodo para cargar propiedades(sedes)
        public DataTable cargarComboPropiedades()
        {
            try
            {
                DataTable dtPropiedad;
                dtPropiedad = objctrpropiedades.seleccionarTodos(objclpropiedades, 5);
                return dtPropiedad;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //metodo para cargar las facutades
        public DataTable cargarComboFacultades()
        {
            try
            {
                DataTable dtFacultad;
                dtFacultad = objctrfacultades.seleccionarTodos(objclfacultades, 5);
                return dtFacultad;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
