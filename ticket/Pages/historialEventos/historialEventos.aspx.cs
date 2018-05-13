using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Layer_Mensajes;
using Layer_Methods;

public partial class Pages_historialEventos_historialEventos : System.Web.UI.Page
{
    clseventos clseventos = new clseventos();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.rgveventos.Rebind();
        }
    }

   

    protected void rgveventos_NeedDataSource(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
    {
        try
        {
            this.rgveventos.DataSource=clseventos.cargarListaEventos();          
        }
        catch (Exception ex)
        {
            
           //mensaej error
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