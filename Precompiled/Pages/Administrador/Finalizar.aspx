<%@ page title="" language="C#" masterpagefile="~/MPVacio.master" autoeventwireup="true" inherits="Pages_Administrador_Finalizar, App_Web_e5nmtpw2" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
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
                            <asp:Label ID="lblruta" runat="server" Visible="false"></asp:Label>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    <div class="container-fluid">

        <table cellspacing="1" class="w-100">
            <tr>
                <td class="auto-style1"></td>
                <td>Observacion final
                    <hr />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1"></td>
                <td>
                    <asp:TextBox ID="txbobservacion" runat="server" TextMode="MultiLine" Width="747px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>
                    <table>
                        <tr>
                            <td>
                                <telerik:RadAsyncUpload ID="FUDocumento" runat="server" Culture="es-ES" MultipleFileSelection="Automatic" resolvedrendermode="Classic" Skin="Metro" Style="text-align: center" Width="240px">
                                    <Localization Remove="ELIMINAR" Select="EXAMINAR" />
                                </telerik:RadAsyncUpload>
                            </td>
                            <td>
                                <asp:Button ID="btnsubir" CssClass="btn btn-success  btn-sm " Width="100px" runat="server" Text="Subir" OnClick="btnsubir_Click" /></td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <asp:Label ID="lbladjunto" CssClass="text-danger" runat="server" Visible="false">Documento adjunto</asp:Label></td>
                        </tr>
                    </table>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>
                    <asp:Button ID="btnguardar" CssClass="btn btn-primary  btn-sm" Width="100px" runat="server" Text="Enviar" OnClick="btnguardar_Click" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>

    </div>
</asp:Content>

