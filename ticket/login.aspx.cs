using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Layer_Methods;
using Layer_Mensajes;
using System.Data;

public partial class login : System.Web.UI.Page
{
    clsusuario clsusuario = new clsusuario();
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                Session.Clear();
            }
        }
        catch (Exception ex)
        {
            Mensaje.mostrar(ex.Message, this.Page, TipoMensajes.Advertencia);
        }
    }
    protected void btningreso_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.txbcode.Text.Trim() != "" && this.txbcontrasena.Text.Trim() != "")
            {
                DataTable dtUsuario = clsusuario.validarUsuario(this.txbcode.Text, this.txbcontrasena.Text);
                if (dtUsuario.Rows.Count > 0)
                {
                    //    int iTipoUsuario = (int)dtUsuario.Rows[0]["usu_tipo_usuario"];
                    Session["id_i_usuario"] = (int)dtUsuario.Rows[0]["usu_id"];
                    Session["snombre"] = (string)dtUsuario.Rows[0]["usu_nombre"] + " " + (string)dtUsuario.Rows[0]["usu_apellido"];
                    Session["id_i_propiedad"] = (int)dtUsuario.Rows[0]["usu_propiedad"];
                    //    if (iTipoUsuario == 1)
                    //    {
                         Response.Redirect("~/Pages/inicio/inicio.aspx", false);
                    //    }
                    //    else
                    //    {
                    //        Session["sEmpresa"] = (string)dtUsuario.Rows[0]["emp_nombre"]; 
                    //        Response.Redirect("~/pages/usuario/home.aspx", false);
                    //    }
                }
                else
                {
                    Mensaje.mostrar("Usuario o Contraseña incorrectas", this.Page, TipoMensajes.Advertencia);
                }
            }
            else
            {
                Mensaje.mostrar("Debe ingresar el usuario y la contraseña", this.Page, TipoMensajes.Advertencia);
            }
        }
        catch (Exception ex)
        {
            Mensaje.mostrar(ex.Message, this.Page, TipoMensajes.Advertencia);
        }
    }
}