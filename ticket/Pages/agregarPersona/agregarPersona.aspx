<%@ Page Title="" Language="C#" MasterPageFile="~/MPVacio.master" AutoEventWireup="true" CodeFile="agregarPersona.aspx.cs" Inherits="Pages_agregarPersona_agregarPersona" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table class="w-100">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <telerik:RadTextBox ID="txbnombre" Width="200px" runat="server"></telerik:RadTextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Apellido"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <telerik:RadTextBox ID="txbapellido" Width="200px" runat="server"></telerik:RadTextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Código"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <telerik:RadTextBox ID="txbcodigo" Width="200px" runat="server"></telerik:RadTextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Tipo Identificacion"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <telerik:RadComboBox ID="rcbtipoidentificacion" Width="200px" Skin="Metro" EmptyMessage="Seleccione Tipo de identificacion" Filter="Contains" DataValueField="id" DataTextField="descripcion" runat="server"></telerik:RadComboBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Identificación"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <telerik:RadTextBox ID="txbidentificacion" Width="200px" runat="server"></telerik:RadTextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Correo"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <telerik:RadTextBox ID="txbcorreo" Width="200px" runat="server"></telerik:RadTextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="País"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <telerik:RadComboBox ID="rcbpais" Width="200px" Skin="Metro" EmptyMessage="Seleccione el país" Filter="Contains" DataValueField="id" DataTextField="descripcion" runat="server"></telerik:RadComboBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label8" runat="server" Text="Ciudad"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <telerik:RadComboBox ID="rcbciudad"  Width="200px" Skin="Metro" EmptyMessage="Seleccione la ciudad" Filter="Contains" DataValueField="id" DataTextField="descripcion" runat="server"></telerik:RadComboBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label9" runat="server" Text="Tipo persona"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <telerik:RadComboBox ID="rcbtipoPersonas" Width="200px" Skin="Metro" EmptyMessage="Tipo persona" Filter="Contains" DataValueField="id" DataTextField="descripcion" runat="server"></telerik:RadComboBox>
            </td>
        </tr>
        <tr>
            <td style="height: 10px;" colspan="3"></td>
        </tr>
        <tr>
            <td>
                <telerik:RadButton ID="rbtguardar" runat="server" OnClick="rbtguardar_Click"  Text="GUARDAR" Icon-PrimaryIconCssClass="rbSave" ></telerik:RadButton>              
           
                <telerik:RadButton ID="rbtCancelar" runat="server" OnClick="rbtCancelar_Click"  Text="CANCELAR" Icon-PrimaryIconCssClass="rbCancel" ></telerik:RadButton>
            </td>
        </tr>

    </table>
</asp:Content>

