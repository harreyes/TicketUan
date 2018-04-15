<%@ page title="" language="C#" masterpagefile="~/MP.master" autoeventwireup="true" inherits="Pages_Usuario_Historialticket, App_Web_2a0s023e" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <style type="text/css">
        .radiobuttonlist {
            font: 12px Verdana, sans-serif;
            color: #000; /* non selected color */
        }

            .radiobuttonlist input {
                width: 0px;
                height: 0px;
            }

            .radiobuttonlist label {
                color: #fff;
                background-color: #B066FE;
                padding-left: 6px;
                padding-right: 6px;
                padding-top: 2px;
                padding-bottom: 2px;
                margin: 0px 0px 0px 0px;
                white-space: nowrap;
                clear: left;
                margin-right: 5px;
                -webkit-box-shadow: 4px 6px 5px 0px rgba(217,217,217,1);
                -moz-box-shadow: 4px 6px 5px 0px rgba(217,217,217,1);
                box-shadow: 4px 6px 5px 0px rgba(217,217,217,1);
            }

            .radiobuttonlist span.selectedradio label {
                background-color: #F7F5E8;
                color: #000000;
                font-weight: bold;
                border-bottom-color: #F3F2E7;
                padding-top: 4px;
            }

            .radiobuttonlist label:hover {
                color: #B066FE;
                background: #fff;
            }

        .radiobuttoncontainer {
            position: relative;
            z-index: 1;
        }

        .radiobuttonbackground {
            position: relative;
            z-index: 0;
            padding: 10px;
            background-color: #B066FE;
        }
    </style>

    <script type="text/javascript">
        function Comentario(id) {
            window.radopen("./comentario.aspx?id=" + id + "&tipo=0", "rwcomentarios");
        }

        function Finalizar(id) {
            window.radopen("./Finalizar.aspx?id=" + id + "&tipo=0", "rwReasinar");
        }
    </script>
    <div class="container-fluid">
        <h3 class="mt-4">Historial Ticket /
            <asp:Label ID="lblnombre" runat="server"></asp:Label>
        </h3>


        <hr />

        <p>
            <asp:Label ID="lblfecha" runat="server"></asp:Label>
        </p>
        <hr />
        <asp:UpdatePanel ID="pnl" runat="server">
            <ContentTemplate>
                <table class="w-100">
                    <tr>
                        <td>
                            <table cellspacing="1" style="width: 549px">
                                <tr>
                                    <td>
                                        <label>Fecha Inicio</label>
                                    </td>
                                    <td>
                                        <label>Fecha Fin</label>
                                    </td>
                                    <td>
                                        <label>
                                            Estado</label></td>
                                </tr>
                                <tr>
                                    <td valign="top">
                                        <telerik:RadDatePicker ID="rdpfechainicio" runat="server" Skin="Bootstrap" OnSelectedDateChanged="rdpfechainicio_SelectedDateChanged" AutoPostBack="true">
                                            <Calendar Culture="es-ES" EnableWeekends="True" FastNavigationNextText="&amp;lt;&amp;lt;" Skin="Bootstrap" UseColumnHeadersAsSelectors="False" UseRowHeadersAsSelectors="False" >
                                            </Calendar>
                                            <DateInput DateFormat="d/MM/yyyy" DisplayDateFormat="d/MM/yyyy" LabelWidth="40%">
                                                <EmptyMessageStyle Resize="None" />
                                                <ReadOnlyStyle Resize="None" />
                                                <FocusedStyle Resize="None" />
                                                <DisabledStyle Resize="None" />
                                                <InvalidStyle Resize="None" />
                                                <HoveredStyle Resize="None" />
                                                <EnabledStyle Resize="None" />
                                            </DateInput>
                                            <DatePopupButton HoverImageUrl="" ImageUrl="" />
                                        </telerik:RadDatePicker>
                                    </td>
                                    <td valign="top">
                                        <telerik:RadDatePicker ID="rdpfechafin" runat="server" Skin="Bootstrap" OnSelectedDateChanged="rdpfechainicio_SelectedDateChanged" AutoPostBack="true">
                                            <Calendar Culture="es-ES" EnableWeekends="True" FastNavigationNextText="&amp;lt;&amp;lt;" Skin="Bootstrap" UseColumnHeadersAsSelectors="False" UseRowHeadersAsSelectors="False">
                                            </Calendar>
                                            <DateInput DateFormat="d/MM/yyyy" DisplayDateFormat="d/MM/yyyy" LabelWidth="40%">
                                                <EmptyMessageStyle Resize="None" />
                                                <ReadOnlyStyle Resize="None" />
                                                <FocusedStyle Resize="None" />
                                                <DisabledStyle Resize="None" />
                                                <InvalidStyle Resize="None" />
                                                <HoveredStyle Resize="None" />
                                                <EnabledStyle Resize="None" />
                                            </DateInput>
                                            <DatePopupButton HoverImageUrl="" ImageUrl="" />
                                        </telerik:RadDatePicker>
                                    </td>
                                    <td>
                                        <div class="radiobuttoncontainer">
                                            <asp:RadioButtonList ID="rblestado" CssClass="radiobuttonlist" runat="server" DataTextField="descripcion" DataValueField="id" RepeatDirection="Horizontal" AutoPostBack="True" OnSelectedIndexChanged="rblestado_SelectedIndexChanged">
                                            </asp:RadioButtonList>
                                            <asp:Label ID="lblestado" runat="server" CssClass="text-danger" Text="Todos"></asp:Label>
                                        </div>
                                        &nbsp;</td>
                                </tr>
                            </table>
                        </td>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:CheckBox ID="ckbfecha" runat="server" Text="Filtrar por fecha" Visible="false" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <telerik:RadGrid ID="rgvticket" runat="server" AllowFilteringByColumn="false" AutoGenerateColumns="False" Culture="es-ES" Skin="Bootstrap" Width="100%">
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
                                                <asp:ImageButton ID="igbcomentarios" runat="server" ImageUrl="~/resources/images/chat.png" ToolTip="Comentarios" OnClick="igbcomentarios_Click" />
                                            </ItemTemplate>
                                            <ItemStyle HorizontalAlign="Left" Width="30px" />
                                        </telerik:GridTemplateColumn>
                                            <telerik:GridTemplateColumn UniqueName="TemplateColumnCompleto">
                                                <ItemTemplate>
                                                    <asp:ImageButton ID="ibgfinalizar" ImageUrl="~/resources/images/chat_1.png" runat="server" ToolTip="Finalizar" OnClick="ibgfinalizar_Click" Visible='<%# (int.Parse(Eval("idestado").ToString())==4 ? true: false) %>' />
                                                </ItemTemplate>
                                                <ItemStyle HorizontalAlign="Left" Width="30px" />
                                            </telerik:GridTemplateColumn>
                                    </Columns>
                                </MasterTableView>
                                <HeaderStyle BackColor="#B066FE" Font-Bold="true" ForeColor="White" />
                            </telerik:RadGrid>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblusuario" runat="server" Visible="false"></asp:Label>
                        </td>
                    </tr>
                </table>
            </ContentTemplate>
        </asp:UpdatePanel>
        <telerik:RadWindowManager Skin="Metro" Width="800px"
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

