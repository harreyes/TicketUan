using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Layer_Mensajes;
using Layer_Methods;

public partial class Pages_personas_personas : System.Web.UI.Page
{
    clspersonas clspersonas = new clspersonas();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                this.rgvpersonas.Rebind();
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
    protected void rgvpersonas_NeedDataSource(object sender, Telerik.Web.UI.GridNeedDataSourceEventArgs e)
    {
        try
        {
            this.rgvpersonas.DataSource = clspersonas.cargarListaPersonas();
        }
        catch (Exception ex)
        {

            //mensaej error
        }
    }

    protected void btnAddpersonas_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Pages/agregarPersona/agregarPersona.aspx", false);

    }

    protected void rbtVolver_Click(object sender, EventArgs e)
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