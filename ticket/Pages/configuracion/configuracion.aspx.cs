﻿using System;
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
    //boton pagina agregar usuarios
    protected void btnUsuarios_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Pages/agregarUsuario/agregarUsuario.aspx", false);

    }
    //boton volver a inicio
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
    //ir a ver lista usuarios
    //boton volver a inicio
    protected void btnListaUsers_Click(object sender, EventArgs e)
    {
        try
        {
            Response.Redirect("~/Pages/usuarios/usuarios.aspx", false);

        }
        catch (Exception ex)
        {
            Mensaje.mostrar(ex.Message, this.Page, TipoMensajes.Advertencia);
        }
    }

}