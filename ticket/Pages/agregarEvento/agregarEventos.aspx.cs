using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Layer_Mensajes;
using Layer_Methods;

public partial class Pages_agregarEvento_agregarEventos : System.Web.UI.Page
{
    clstipos clstipos = new clstipos();
    clseventos clseventos = new clseventos();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                cargarCombos();
            }
        }
        catch (Exception ex)
        {
            Mensaje.mostrar(ex.Message, this.Page, TipoMensajes.Advertencia);
        }
    }

        /// <summary>
    /// metodo para cargar los combos al iniciar la aplicacion
    /// </summary>
    protected void cargarCombos()
    {
        try
        {
            this.rcbpropiedad.DataSource = clstipos.cargarComboPropiedades();
            this.rcbpropiedad.DataBind();
        }
        catch (Exception ex)
        {
            
            throw ex;
        }
    }
    protected void rbtguardarEvento_Click(object sender, EventArgs e)
    {
        try
        {
            string msj = "";
            msj = validarInfo();
            if (msj != "")
            {
                Mensaje.mostrar(msj, this.Page, TipoMensajes.Advertencia);
            }
            else
            {
                clseventos.insertarDatosEvento(DateTime.Now, Calendar1.SelectedDate, 0, this.txbdescripcion.Text, int.Parse(this.rcbpropiedad.SelectedValue), 1);
                Mensaje.mostrar("Evento Guardado", this.Page, TipoMensajes.Advertencia);
            }
        }
        catch (Exception ex)
        {
            Mensaje.mostrar(ex.Message, this.Page, TipoMensajes.Advertencia);
        }
    }

    protected void rbtCancelar_Click(object sender, EventArgs e)
    {
        try
        {
            Response.Redirect("~/Pages/inicio/inicio.aspx", false);

        }
        catch (Exception ex)
        {
            Mensaje.mostrar(ex.Message, this.Page, TipoMensajes.Advertencia);
        }
    }

    public string validarInfo()
    {
        try
        {
            string msj = "";
            if (Calendar1.SelectedDate == null)
            {
                msj = "Debe seleccionar fecha del evento";
            }
            else
            {
                if (this.txbdescripcion.Text == "")
                {
                    msj = "Debe inserta descripción del evento";
                }
                else
                {
                    if (this.rcbpropiedad.SelectedValue == "")
                    {
                        msj = "Debe seleccionar sede";
                    }                                                      
                }
            }
            return msj;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }


}