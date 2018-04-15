<%@ page title="" language="C#" masterpagefile="~/MP.master" autoeventwireup="true" inherits="index, App_Web_2a0s023e" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">


    <div class="container-fluid">
        <h3 class="mt-4">Ingrese su requerimiento /           
            <asp:Label ID="lblnombre" runat="server"></asp:Label>
        </h3>
        <hr />
        <!-- Date/Time -->
        <p>
            <asp:Label ID="lblfecha" runat="server"></asp:Label>
        </p>
        <hr />
        <table class="w-100">
            <tr>
                <td>
                    <table cellspacing="1" style="width: 100%">
                        <tr>
                            <td style="width: 150px">
                                <asp:Label ID="Label1" runat="server" Text="Proyecto"></asp:Label>
                            </td>
                            <td>
                                <telerik:RadComboBox ID="rcbproyecto" DataValueField="id" DataTextField="descripcion" Width="350px" Filter="Contains" EmptyMessage="--Seleccione--" runat="server" Skin="Bootstrap"></telerik:RadComboBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 150px">
                                <asp:Label ID="Label2" runat="server" Text="Frecuencia de la inconsistencia"></asp:Label>
                            </td>
                            <td>
                                <telerik:RadComboBox ID="rcbfrecuencia" DataValueField="id" DataTextField="descripcion" Width="350px" Filter="Contains" EmptyMessage="--Seleccione--" runat="server" Skin="Bootstrap"></telerik:RadComboBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 150px">
                                <asp:Label ID="Label3" runat="server" Text="Tipo de inconsistencia"></asp:Label>
                            </td>
                            <td>
                                <telerik:RadComboBox ID="rcbtipoerror" DataValueField="id" DataTextField="descripcion" Width="350px" Filter="Contains" EmptyMessage="--Seleccione--" runat="server" Skin="Bootstrap"></telerik:RadComboBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 150px">&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 150px">
                                <asp:Label ID="Label4" runat="server" Text="Descripcion del  error "></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td valign="Top" colspan="2">
                                <asp:TextBox ID="txbobservacion" TextMode="MultiLine" CssClass="text-info " runat="server" Height="108px" Width="100%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 150px">
                                <asp:Label ID="Label5" runat="server" Text="Adjutar documento"></asp:Label>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                <table>
                                    <tr>
                                        <td>
                                            <telerik:RadAsyncUpload ID="FUDocumento" runat="server" Culture="es-ES" MultipleFileSelection="Automatic" resolvedrendermode="Classic" Skin="Metro" Style="text-align: center" Width="240px">
                                                <Localization Remove="ELIMINAR" Select="EXAMINAR" />
                                            </telerik:RadAsyncUpload>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnsubir" CssClass="btn btn-success" runat="server" Text="Subir" OnClick="btnsubir_Click" /></td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            <asp:Label ID="lbladjunto" CssClass="text-danger" runat="server" Visible="false">Documento adjunto</asp:Label></td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                  <asp:Button ID="btnguardar" CssClass="btn btn-primary" runat="server" Text="Enviar" OnClick="btnguardar_Click" />
                                <asp:Button ID="btncancelar" CssClass="btn btn-danger " runat="server" Text="Cancelar" OnClick="btncancelar_Click" />
                            </td>
                        </tr>
                   
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblruta" runat="server" Visible="false"></asp:Label>
                    <asp:Label ID="lblusuario" runat="server" Visible="false"></asp:Label>
                </td>
            </tr>
        </table>
    </div>

</asp:Content>

