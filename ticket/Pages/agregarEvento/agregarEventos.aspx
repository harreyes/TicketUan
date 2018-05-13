<%@ Page Title="" Language="C#" MasterPageFile="~/MPVacio.master" AutoEventWireup="true" CodeFile="agregarEventos.aspx.cs" Inherits="Pages_agregarEvento_agregarEventos" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table class="w-100">
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Sede" Width="200px"></asp:Label>
                <telerik:RadComboBox ID="rcbpropiedad" Width="200px" Skin="Metro" EmptyMessage="Seleccione sede" Filter="Contains" DataValueField="id" DataTextField="descripcion" runat="server"></telerik:RadComboBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Descripción del evento" Width="200px"></asp:Label>
                <telerik:RadTextBox ID="txbdescripcion" Width="200px" runat="server"></telerik:RadTextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Seleccione la fecha del evento"></asp:Label>
            </td>
        </tr>
        <tr >
            <td>
                <asp:Calendar ID="Calendar1" Width="200px" runat="server"></asp:Calendar>
            </td>
        </tr>
        <tr>
            <td>
                <telerik:RadButton ID="rbtguardar" runat="server" OnClick="rbtguardarEvento_Click" Text="AÑADIR EVENTO" Icon-PrimaryIconCssClass="rbSave"></telerik:RadButton>

                <telerik:RadButton ID="rbtCancelar" Width="115px" runat="server" OnClick="rbtCancelar_Click" Text="CANCELAR" Icon-PrimaryIconCssClass="rbCancel"></telerik:RadButton>
            </td>
        </tr>
    </table>
</asp:Content>

