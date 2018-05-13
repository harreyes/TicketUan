<%@ Page Title="" Language="C#" MasterPageFile="~/MPVacio.master" AutoEventWireup="true" CodeFile="configuracion.aspx.cs" Inherits="Pages_configuracion_configuracion" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table style="width: 100%; background-color: #C3E6CB">
        <tr>
            <td>&nbsp;</td>

            <tr class="text-center">
                <td>
                    <telerik:RadButton ID="rbtguardar" runat="server" OnClick="btnUsuarios_Click" Text="AGREGAR USUARIO ADMINISTRATIVO" Icon-PrimaryIconCssClass="rbAdd"></telerik:RadButton>
                </td>
            </tr>

            <tr class="text-center">
                <td>
                    <telerik:RadButton ID="RadButton2" runat="server" OnClick="btnListaUsers_Click" Text="VER USUARIOS ADMINISTRATIVOS" Icon-PrimaryIconCssClass="rbSearch"></telerik:RadButton>
                </td>
            </tr>

            <tr class="text-center">
                <td>
                    <telerik:RadButton ID="RadButton1" runat="server" OnClick="rbtVolver_Click" Text="VOLVER" Icon-PrimaryIconCssClass="rbPrevious"></telerik:RadButton>
                </td>
            </tr>
        </tr>
    </table>
</asp:Content>

