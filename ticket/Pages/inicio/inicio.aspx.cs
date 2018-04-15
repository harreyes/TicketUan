using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_inicio_inicio : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnPersonas_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Pages/agregarPersona/agregarPersona.aspx", false);
    }

    protected void btnEventos_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Pages/agregarEvento/agregarEventos.aspx", false);
    }

    protected void btnConfiguracion_Click(object sender, EventArgs e)
    {

        Response.Redirect("~/Pages/configuracion/configuracion.aspx", false);

    }
}


