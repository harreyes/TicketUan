using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Layer_Mensajes;
using Layer_Methods;

public partial class Pages_agregarPersona_agregarPersona : System.Web.UI.Page
{
    clstipos clstipos = new clstipos();
    clspersonas clspersonas = new clspersonas();
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
            this.rcbtipoidentificacion.DataSource = clstipos.cargarComboIdentificacion();
            this.rcbtipoidentificacion.DataBind();

            this.rcbpais.DataSource = clstipos.cargarComboPais();
            this.rcbpais.DataBind();

            this.rcbciudad.DataSource = clstipos.cargarComboCiudad();
            this.rcbciudad.DataBind();

            this.rcbtipoPersonas.DataSource = clstipos.cargarComboTipoPersona();
            this.rcbtipoPersonas.DataBind();
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }
    protected void rbtguardar_Click(object sender, EventArgs e)
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
                clspersonas.insertarDatosPersona(int.Parse(this.rcbtipoPersonas.SelectedValue), int.Parse(this.rcbpais.SelectedValue), this.txbidentificacion.Text, int.Parse(this.rcbciudad.SelectedValue), this.txbnombre.Text, this.txbcorreo.Text, this.txbcodigo.Text, 0, 1, this.txbapellido.Text, int.Parse(this.rcbtipoidentificacion.SelectedValue));
                Mensaje.mostrar("Persona Guardada", this.Page, TipoMensajes.Advertencia);
                
            }

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
            if (this.txbnombre.Text == "")
            {
                msj = "Debe insertar Nombre";
            }
            else
            {
                if (this.txbapellido.Text == "")
                {
                    msj = "Debe inserta Apellido";
                }
                else
                {
                    if (this.rcbtipoidentificacion.SelectedValue == "")
                    {
                        msj = "Debe seleccionar Tipo de Identificacion";
                    }
                    else
                    {
                        if (this.txbidentificacion.Text == "")
                        {
                            msj = "Debe insertar identificación";
                        }
                        else
                        {
                            if (this.txbcorreo.Text == "")
                            {
                                msj = "Debe insertar correo";

                            }
                            else
                            {
                                if (rcbpais.SelectedValue == "")
                                {
                                    msj = "Debe seleccionar Pais";
                                }
                                else
                                {
                                    if (rcbciudad.SelectedValue == "")
                                    {
                                        msj = "Debe seleccionar Ciudad";
                                    }
                                    else
                                    {
                                        if (rcbtipoPersonas.SelectedValue == "")
                                        {
                                            msj = "Debe seleccionar tipo persona";
                                        }
                                    }
                                }
                            }
                        }
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
}