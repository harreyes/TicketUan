<%@ page title="" language="C#" masterpagefile="~/MPAdmon.master" autoeventwireup="true" inherits="Pages_Administrador_Home, App_Web_e5nmtpw2" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <script type="text/javascript">
        function CargarEstado() {
            document.getElementById("<%= btnrecargar.ClientID %>").click();
        }

        function Asignar(id) {
            window.radopen("./Asignar.aspx?id=" + id, "rwReasinar");
        }

        function AbrirVentana(dato) {
            window.open(dato, '_blank');
            return false;
        }

        function Comentario(id) {
            window.radopen("../Usuario/comentario.aspx?id=" + id + "&tipo=1", "rwcomentarios");
        }

        function Finalizar(id) {
            window.radopen("./Finalizar.aspx?id=" + id + "&tipo=1", "rwReasinar");
        }

    </script>
    <div class="container-fluid">
        <asp:UpdatePanel ID="pnl" runat="server">
            <ContentTemplate>
                <asp:Timer ID="tmp" runat="server" OnTick="tmp_Tick" Interval="600000"></asp:Timer>
                <h3 class="mt-4">Listado Ticket /           
                    <asp:Label ID="lblnombre" runat="server"></asp:Label></h3>
                <!-- Author -->
                <p class="lead">
                </p>
                <hr />
                <!-- Date/Time -->
                <p>
                    <asp:Label ID="lblfecha" runat="server"></asp:Label>
                </p>
                <hr />
                <table class="w-100">
                    <tr>
                        <td>
                            <h4>Ticket Solicitados</h4>
                            <telerik:RadGrid ID="rgvticketllegada" runat="server" AutoGenerateColumns="False" Culture="es-ES" OnNeedDataSource="rgvticketllegada_NeedDataSource" Skin="Bootstrap" Height="150px" Width="1300px" GroupPanelPosition="Top">
                                <GroupingSettings CollapseAllTooltip="Collapse all groups" />
                                <ClientSettings>
                                    <Scrolling AllowScroll="True" UseStaticHeaders="True" />
                                </ClientSettings>
                                <MasterTableView DataKeyNames="id, adjunto">
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
                                                <asp:ImageButton ID="ibtpdf" runat="server" OnClick="ibtpdf_Click1"  ImageUrl="~/resources/images/chat.png" ToolTip="Adjunto" Visible='<%# (Eval("adjunto")=="" ? false: true) %>' />
                                            </ItemTemplate>
                                            <ItemStyle HorizontalAlign="Left" Width="30px" />
                                        </telerik:GridTemplateColumn>
                                        <telerik:GridTemplateColumn UniqueName="TemplateColumnCompleto">
                                            <ItemTemplate>
                                                <asp:ImageButton ID="igbrecepcion" runat="server" ImageUrl="~/resources/images/chat_1.png" OnClick="igbrecepcion_Click" ToolTip="Asignar" />
                                            </ItemTemplate>
                                            <ItemStyle HorizontalAlign="Left" Width="30px" />
                                        </telerik:GridTemplateColumn>
                                    </Columns>
                                </MasterTableView>
                                <HeaderStyle BackColor="#D585FF" Font-Bold="true" ForeColor="White" />
                            </telerik:RadGrid>
                        </td>
                    </tr>

                    <tr>
                        <td>
                            <hr />
                            <h4>Ticket Asignados</h4>
                            <telerik:RadGrid ID="rgvticket" runat="server" AutoGenerateColumns="False" Culture="es-ES" OnNeedDataSource="rgvticket_NeedDataSource" Skin="Bootstrap" Height="150px" Width="1300px" GroupPanelPosition="Top">
                                <GroupingSettings CollapseAllTooltip="Collapse all groups" />
                                <ClientSettings>
                                    <Scrolling AllowScroll="True" UseStaticHeaders="True" />
                                </ClientSettings>
                                <MasterTableView DataKeyNames="id, adjunto">
                                    <Columns>
                                        <telerik:GridBoundColumn DataField="id" FilterControlAltText="Filter column column" HeaderText="# Ticket" UniqueName="column">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="proyecto" FilterControlAltText="Filter column column" HeaderText="Proyecto" UniqueName="column7">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="frecuencia" FilterControlAltText="Filter column column" HeaderText="Frecuencia" UniqueName="column1">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="error" FilterControlAltText="Filter column column" HeaderText="Tipo Inconsistencia" UniqueName="column2">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="descripcion" FilterControlAltText="Filter column column" HeaderText="Observacion" UniqueName="column4">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="prioridad" FilterControlAltText="Filter column column" HeaderText="Prioridad" UniqueName="column5">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="solicitud" FilterControlAltText="Filter column column" HeaderText="Ticket" UniqueName="column6">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn DataField="estado" FilterControlAltText="Filter column column" HeaderText="Estado" UniqueName="column3">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridTemplateColumn UniqueName="TemplateColumnCompleto">
                                            <ItemTemplate>
                                                <asp:ImageButton ID="ibtpdf" runat="server" OnClick="ibtpdf_Click" ImageUrl="~/resources/images/pdf.png" ToolTip="Asignar" Visible='<%# (Eval("adjunto")=="" ? false: true) %>' />
                                            </ItemTemplate>
                                            <ItemStyle HorizontalAlign="Left" Width="30px" />
                                        </telerik:GridTemplateColumn>
                                        <telerik:GridTemplateColumn UniqueName="TemplateColumnCompleto">
                                            <ItemTemplate>
                                                <asp:ImageButton ID="igbcomentarios" runat="server" ImageUrl="~/resources/images/chat.png" OnClick="igbcomentarios_Click" ToolTip="Comentarios" />
                                            </ItemTemplate>
                                            <ItemStyle HorizontalAlign="Left" Width="30px" />
                                        </telerik:GridTemplateColumn>
                                        <telerik:GridTemplateColumn UniqueName="TemplateColumnCompleto">
                                            <ItemTemplate>
                                                <asp:ImageButton ID="ibgfinalizar" runat="server" ImageUrl="~/resources/images/chat_1.png" OnClick="ibgfinalizar_Click" ToolTip="Finalizar" />
                                            </ItemTemplate>
                                            <ItemStyle HorizontalAlign="Left" Width="30px" />
                                        </telerik:GridTemplateColumn>
                                    </Columns>
                                </MasterTableView>
                                <HeaderStyle BackColor="#3A3897" Font-Bold="true" ForeColor="White" />

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
            </ContentTemplate>
        </asp:UpdatePanel>
        <telerik:RadWindowManager Skin="Bootstrap" Width="850px"
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

