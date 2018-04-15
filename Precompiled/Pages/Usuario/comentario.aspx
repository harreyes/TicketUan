<%@ page title="" language="C#" masterpagefile="~/MPVacio.master" autoeventwireup="true" inherits="Pages_Usuario_comentario, App_Web_2a0s023e" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <script type="text/javascript">

        function AbrirVentana(dato) {
            window.open(dato, '_blank');
            return false;
        }
    </script>
    <div class="container-fluid">
        <h1 class="mt-4">Comentarios</h1>
        <table>
            <tr>
                <td>
                    <table>
                        <asp:Panel ID="pnlinicio" runat="server">
                            <tr>
                                <td colspan="2">
                                    <asp:TextBox ID="txbcomentario" Width="400px" CssClass="card-text " runat="server" TextMode="MultiLine"></asp:TextBox>
                                </td>
                                <td valign="Top">
                                    <table>
                                        <tr>
                                            <td>
                                                <telerik:RadAsyncUpload ID="FUDocumento" runat="server" Culture="es-ES" MultipleFileSelection="Automatic" resolvedrendermode="Classic" Skin="Metro" Style="text-align: center" Width="240px">
                                                    <Localization Remove="ELIMINAR" Select="EXAMINAR" />
                                                </telerik:RadAsyncUpload>
                                            </td>
                                            <td>
                                                <asp:Button ID="btnsubir" CssClass="btn btn-success btn-sm" runat="server" Width="80px" Text="Subir" OnClick="btnsubir_Click" /></td>
                                        </tr>
                                        <tr>
                                            <td colspan="2">
                                                <asp:Label ID="lbladjunto" CssClass="text-danger" runat="server" Visible="false">Documento adjunto</asp:Label></td>
                                        </tr>
                                    </table>
                               </td>
                            </tr>
                            <tr>
                                <td>
                                    
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <asp:Button ID="btnguardar"  runat="server" Width="100px" CssClass="btn btn-primary btn-sm" Text="Enviar" OnClick="btnguardar_Click" />
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>

                        </asp:Panel>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <telerik:RadGrid ID="rgvcomentario" runat="server" AutoGenerateColumns="False" Culture="es-ES" OnNeedDataSource="rgvcomentario_NeedDataSource" Skin="Bootstrap" Width="747px" GroupPanelPosition="Top">
                        <GroupingSettings CollapseAllTooltip="Collapse all groups"></GroupingSettings>
                        <MasterTableView DataKeyNames="adjunto">
                            <Columns>
                                <telerik:GridBoundColumn DataField="comentario" FilterControlAltText="Filter column column" HeaderText="Comentario" UniqueName="column">
                                </telerik:GridBoundColumn>
                                <telerik:GridBoundColumn DataField="usuario" FilterControlAltText="Filter column column" HeaderText="Usuario" UniqueName="column1">
                                </telerik:GridBoundColumn>
                            
                                <telerik:GridBoundColumn DataField="fecha" FilterControlAltText="Filter column column" HeaderText="Fecha" UniqueName="column2" DataFormatString="{0:MM/dd/yyyy hh:mm tt}">
                                </telerik:GridBoundColumn>
                                    <telerik:GridTemplateColumn UniqueName="TemplateColumnCompleto">
                                    <ItemTemplate>
                                        <asp:ImageButton ID="ibtpdf" runat="server" ImageUrl="~/resources/images/documentos.png" OnClick="ibtpdf_Click" ToolTip="Adjunto" Visible='<%# (Eval("adjunto").ToString().Any() ? true: false) %>' />
                                    </ItemTemplate>
                                    <ItemStyle HorizontalAlign="Left" Width="30px" />
                                </telerik:GridTemplateColumn>
                            </Columns>
                        </MasterTableView>
                    </telerik:RadGrid></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblusuario" runat="server" Visible="false"></asp:Label>
                    <asp:Label ID="lblidTicket" runat="server" Visible="false"></asp:Label>
                    <asp:Label ID="lblruta" runat="server" Visible="false"></asp:Label>
                </td>
            </tr>
        </table>
    </div>

</asp:Content>

