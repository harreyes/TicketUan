using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Layer_Mensajes;
using Layer_Methods;

public partial class Pages_usuarios_usuarios : System.Web.UI.Page
{
    clsusuario clsusuario = new clsusuario();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                this.rgvusuarios.Rebind();
            }
        }
        catch (Exception ex)
        {
            Mensaje.mostrar(ex.Message, this.Page, TipoMensajes.Advertencia);
        }
    }

    /// <summary>
    /// Cargar personas
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void rgvusuarios_NeedDataSource(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
    {
        try
        {
            this.rgvusuarios.DataSource = clsusuario.cargarListaUsuarios();
        }
        catch (Exception ex)
        {

            //mensaej error
        }
    }

    protected void rbtVolver_Click(object sender, EventArgs e)
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

}