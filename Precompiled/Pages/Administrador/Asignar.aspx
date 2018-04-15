<%@ page title="" language="C#" masterpagefile="~/MPVacio.master" autoeventwireup="true" inherits="Pages_Administrador_Asignar, App_Web_e5nmtpw2" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <script type="text/javascript">
        function CargarEstado() {
            GetRadWindow().Close();
            GetRadWindow().BrowserWindow.CargarEstado();
        }

        function GetRadWindow() {
            var oWindow = null;
            if (window.radWindow) oWindow = window.radWindow; //Will work in Moz in all cases, including clasic dialog  
            else if (window.frameElement.radWindow) oWindow = window.frameElement.radWindow; //IE (and Moz az well)
            return oWindow;
        }
    </script>
    <style type="text/css">
        .auto-style1 {
            width: 89px;
        }
    </style>
    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="lblusuario" runat="server" Visible="false"></asp:Label>
                            <asp:Label ID="lblidticket" runat="server" Visible="false"></asp:Label>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    <div class="container-fluid">

        <table cellspacing="1" class="w-100">
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Prioridad</td>
                <td>
                    <telerik:RadComboBox ID="rcbprioridad" runat="server" DataValueField="id" DataTextField="descripcion" EmptyMessage="--Seleccione--" Width="350px" Filter="Contains" Skin="Bootstrap"></telerik:RadComboBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <label>
                        Tipo Ticket</label></td>
                <td>
                    <telerik:RadComboBox ID="rcbtipoticket" runat="server" DataValueField="id" DataTextField="descripcion" EmptyMessage="--Seleccione--" Width="350px" Filter="Contains" Skin="Bootstrap"></telerik:RadComboBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>
                    <asp:Button ID="btnguardar" CssClass="btn btn-primary" runat="server" Text="Enviar" OnClick="btnguardar_Click" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>

    </div>
</asp:Content>

