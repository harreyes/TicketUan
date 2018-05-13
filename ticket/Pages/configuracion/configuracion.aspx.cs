using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Layer_Mensajes;
using Layer_Methods;

public partial class Pages_configuracion_configuracion : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
            }
        }
        catch (Exception ex)
        {
            Mensaje.mostrar(ex.Message, this.Page, TipoMensajes.Advertencia);
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
            Response.Redirect("~/Pages/inicio/inicio.aspx", false);

        }
        catch (Exception ex)
        {
            Mensaje.mostrar(ex.Message, this.Page, TipoMensajes.Advertencia);
        }
    }

}