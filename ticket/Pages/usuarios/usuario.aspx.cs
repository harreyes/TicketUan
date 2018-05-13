using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Layer_Mensajes;
using Layer_Methods;

public partial class Pages_usuario_usuario : System.Web.UI.Page
{
    clstipos clstipos = new clstipos();
    clsusuario clsusuario = new clsusuario();
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

            this.rcbfacultades.DataSource = clstipos.cargarComboFacultades();
            this.rcbfacultades.DataBind();

        }
        catch (Exception ex)
        {

            throw ex;
        }
    }

    protected void btnUsuarios_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Pages/usuarios/usuario.aspx", false);

    }

    protected void rbtCancelar_Click(object sender, EventArgs e)
    {
        try
        {
            Response.Redirect("~/Pages/configuracion/configuracion.aspx", false);

        }
        catch (Exception ex)
        {
            Mensaje.mostrar(ex.Message, this.Page, TipoMensajes.Advertencia);
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
                clsusuario.insertarUsuario(1, this.txbnombre.Text, this.txbapellido.Text, this.txbcodigo.Text, int.Parse(this.rcbtipoidentificacion.SelectedValue), this.txbidentificacion.Text, this.txbcorreo.Text, this.txbpassword.Text, int.Parse(this.rcbpais.SelectedValue), int.Parse(this.rcbciudad.SelectedValue), int.Parse(this.rcbfacultades.SelectedValue));
                Mensaje.mostrar("Usuario Guardado", this.Page, TipoMensajes.Advertencia);

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
                                        if (rcbfacultades.SelectedValue == "")
                                        {
                                            msj = "Debe seleccionar facultad";
                                        }
                                        else
                                        {
                                            if (txbcodigo.Text == "")
                                            {
                                                msj = "Debe escribir usuario";
                                            }
                                            else
                                            {
                                                if (this.txbpassword.Text == "")
                                                {
                                                    msj = "Debe escribir una contraseña";
                                                }
                                            }
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

}