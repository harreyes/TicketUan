<%@ page title="" language="C#" masterpagefile="~/MP.master" autoeventwireup="true" inherits="Pages_Usuario_Home, App_Web_2a0s023e" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <style type="text/css">
        .sombra {
            -webkit-box-shadow: 2px 3px 5px 0px rgba(184,177,184,1);
            -moz-box-shadow: 2px 3px 5px 0px rgba(184,177,184,1);
            box-shadow: 2px 3px 5px 0px rgba(184,177,184,1);
        }
    </style>

    <script type="text/javascript">
        function Comentario(id) {
            window.radopen("./comentario.aspx?id=" + id + "&tipo=1", "rwcomentarios");
        }

        function Finalizar(id) {
            window.radopen("./Finalizar.aspx?id=" + id, "rwReasinar");
        }

        function CargarEstado() {
            document.getElementById("<%= btnrecargar.ClientID %>").click();
        }
    </script>
    <div class="container-fluid">

        <h3 class="mt-4">Listado Ticket /<asp:Label ID="lblnombre" runat="server"></asp:Label></h3>
        <hr />
        <p>
            <asp:Label ID="lblfecha" runat="server"></asp:Label>
        </p>
        <hr />
        <asp:UpdatePanel ID="pnl" runat="server">
            <ContentTemplate>
                <div class="container-fluid">
                    <table class="w-100">
                        <tr>
                            <td>
                                <telerik:RadGrid ID="rgvticket" runat="server" CssClass="sombra " AutoGenerateColumns="False" Culture="es-ES" OnNeedDataSource="rgvticket_NeedDataSource" Skin="Bootstrap" Width="100%" GroupPanelPosition="Top">
                                    <GroupingSettings CollapseAllTooltip="Collapse all groups" />
                                    <ExportSettings>
                                        <Pdf PageWidth="">
                                        </Pdf>
                                    </ExportSettings>
                                    <MasterTableView DataKeyNames="id">
                                        <Columns>
                                            <telerik:GridBoundColumn DataField="id" FilterControlAltText="Filter column column" HeaderText="# Ticket" UniqueName="column">
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn DataField="proyecto" FilterControlAltText="Filter column column" HeaderText="Proyecto" UniqueName="column6">
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn DataField="frecuencia" FilterControlAltText="Filter column column" HeaderText="Frecuencia" UniqueName="column1">
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn DataField="error" FilterControlAltText="Filter column column" HeaderText="Tipo Inconsistencia" UniqueName="column2">
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn DataField="descripcion" FilterControlAltText="Filter column column" HeaderText="Observacion" UniqueName="column4">
                                            </telerik:GridBoundColumn>
                                            <telerik:GridBoundColumn DataField="estado" FilterControlAltText="Filter column column" HeaderText="Estado" UniqueName="column3">
                                            </telerik:GridBoundColumn>
                                            <telerik:GridTemplateColumn UniqueName="TemplateColumnCompleto">
                                                <ItemTemplate>
                                                    <asp:ImageButton ID="igbcomentarios" ImageUrl="~/resources/images/chat.png" runat="server" ToolTip="Comentarios" OnClick="igbcomentarios_Click" />
                                                </ItemTemplate>
                                                <ItemStyle HorizontalAlign="Left" Width="30px" />
                                            </telerik:GridTemplateColumn>
                                            <telerik:GridTemplateColumn UniqueName="TemplateColumnCompleto">
                                                <ItemTemplate>
                                                    <asp:ImageButton ID="ibgfinalizar" ImageUrl="~/resources/images/chat_1.png" runat="server" ToolTip="Finalizar" OnClick="ibgfinalizar_Click" Visible='<%# (int.Parse(Eval("idestado").ToString())==6 ? true: false) %>' />
                                                </ItemTemplate>
                                                <ItemStyle HorizontalAlign="Left" Width="30px" />
                                            </telerik:GridTemplateColumn>
                                        </Columns>
                                    </MasterTableView>
                                    <HeaderStyle BackColor="#0391FD" Font-Bold="true" ForeColor="White" />
                                </telerik:RadGrid>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblusuario" runat="server" Visible="false"></asp:Label>
                                 <asp:Button ID="btnrecargar" runat="server" Style="display: none" OnClick="btnrecargar_Click" />
                            </td>
                        </tr>
                    </table>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>

        <telerik:RadWindowManager Width="850px"
            Height="500px"
            ID="RadWindowManager"
            runat="server" RestrictionZoneID="RestrictionZone">
            <Windows>
                    <telerik:RadWindow ID="rwReasinar" runat="server" AutoSize="false" Skin="Bootstrap" Style="display: none;"
                    Behavior="Close" Behaviors="Close" VisibleStatusbar="False" Modal="True">
                </telerik:RadWindow>
                <telerik:RadWindow ID="rwcomentarios" runat="server" AutoSize="false" Skin="Bootstrap" Style="display: none;"
                    Behavior="Close" Behaviors="Close" VisibleStatusbar="False" Modal="True">
                </telerik:RadWindow>
            </Windows>
        </telerik:RadWindowManager>
    </div>

</asp:Content>

