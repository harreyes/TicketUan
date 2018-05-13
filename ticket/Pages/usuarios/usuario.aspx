<%@ Page Title="" Language="C#" MasterPageFile="~/MPVacio.master" AutoEventWireup="true" CodeFile="usuario.aspx.cs" Inherits="Pages_usuario_usuario" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table class="w-100">
        <tr class="text-center">
            <td>
                <asp:Label ID="Label1" runat="server" Text="Nombre" Width="100px"></asp:Label>
                <telerik:RadTextBox ID="txbnombre" Width="200px" runat="server"></telerik:RadTextBox>
            </td>
        </tr>
        <tr class="text-center">
            <td>
                <asp:Label ID="Label2" runat="server" Text="Apellido" Width="100px"></asp:Label>
                <telerik:RadTextBox ID="txbapellido" Width="200px" runat="server"></telerik:RadTextBox>
            </td>
        </tr>
        <tr class="text-center">
            <td>
                <asp:Label ID="Label6" runat="server" Text="Tipo ID" Width="100px"></asp:Label>
                <telerik:RadComboBox ID="rcbtipoidentificacion" Width="200px" Skin="Metro" EmptyMessage="Seleccione Tipo de identificacion" Filter="Contains" DataValueField="id" DataTextField="descripcion" runat="server"></telerik:RadComboBox>
            </td>
        </tr>
        <tr class="text-center">
            <td>
                <asp:Label ID="Label4" runat="server" Text="Identificación" Width="100px"></asp:Label>
                <telerik:RadTextBox ID="txbidentificacion" Width="200px" runat="server"></telerik:RadTextBox>
            </td>
        </tr>
        <tr class="text-center">
            <td>
                <asp:Label ID="Label5" runat="server" Text="Correo" Width="100px"></asp:Label>
                <telerik:RadTextBox ID="txbcorreo" Width="200px" runat="server"></telerik:RadTextBox>
            </td>
        </tr>
        <tr class="text-center">
            <td>
                <asp:Label ID="Label7" runat="server" Text="País" Width="100px"></asp:Label>
                <telerik:RadComboBox ID="rcbpais" Width="200px" Skin="Metro" EmptyMessage="Seleccione el país" Filter="Contains" DataValueField="id" DataTextField="descripcion" runat="server"></telerik:RadComboBox>
            </td>
        </tr>
        <tr class="text-center">
            <td>
                <asp:Label ID="Label8" runat="server" Text="Ciudad" Width="100px"></asp:Label>
                <telerik:RadComboBox ID="rcbciudad" Width="200px" Skin="Metro" EmptyMessage="Seleccione la ciudad" Filter="Contains" DataValueField="id" DataTextField="descripcion" runat="server"></telerik:RadComboBox>
            </td>
        </tr>
        <tr class="text-center">
            <td>
                <asp:Label ID="Label9" runat="server" Text="Facultad" Width="100px"></asp:Label>
                <telerik:RadComboBox ID="rcbfacultades" Width="200px" Skin="Metro" EmptyMessage="Facultad" Filter="Contains" DataValueField="id" DataTextField="descripcion" runat="server"></telerik:RadComboBox>
            </td>
        </tr>
        <tr class="text-center">
            <td>
                <asp:Label ID="Label3" runat="server" Text="Usuario" Width="100px"></asp:Label>
                <telerik:RadTextBox ID="txbcodigo" Width="200px" runat="server"></telerik:RadTextBox>
            </td>
        </tr>
        <tr class="text-center">
            <td>
                <asp:Label ID="Label10" runat="server" Text="Contraseña" Width="100px"></asp:Label>
                <telerik:RadTextBox ID="txbpassword" Width="200px" runat="server"></telerik:RadTextBox>
            </td>
        </tr>

        <tr class="text-center">
            <td style="height: 10px;" colspan="3"></td>
        </tr>
        <tr class="text-center">
            <td>
                <telerik:RadButton ID="rbtguardar" runat="server" OnClick="rbtguardar_Click" Text="GUARDAR" Icon-PrimaryIconCssClass="rbSave"></telerik:RadButton>

                <telerik:RadButton ID="rbtCancelar" runat="server" OnClick="rbtCancelar_Click" Text ="CANCELAR" Icon-PrimaryIconCssClass="rbCancel"></telerik:RadButton>
            </td>
        </tr>

    </table>
</asp:Content>

