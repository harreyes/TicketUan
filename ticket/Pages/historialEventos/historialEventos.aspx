<%@ Page Title="" Language="C#" MasterPageFile="~/MPVacio.master" AutoEventWireup="true" CodeFile="historialEventos.aspx.cs" Inherits="Pages_historialEventos_historialEventos" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <table cellspacing="1" style="width: 100%">
        <tr>
            <td>
                <label>EVENTOS</label>
            </td>
        </tr>
        <tr>
            <td>
                <table cellspacing="1" style="width: 484px">
                    <tr>
                        <td>
                            <telerik:RadGrid ID="rgveventos" OnNeedDataSource="rgveventos_NeedDataSource" runat="server" AutoGenerateColumns="False" Culture="es-ES">
                                <MasterTableView>
                                    <Columns>
                                        <telerik:GridBoundColumn FilterControlAltText="Filter column column" UniqueName="column" HeaderText="Eventos" DataField="eve_descripcion">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn FilterControlAltText="Filter column1 column" UniqueName="column1" HeaderText="Fecha evento" DataField="eve_fecha_evento">
                                        </telerik:GridBoundColumn>

                                    </Columns>
                                </MasterTableView>
                            </telerik:RadGrid>
                        </td>
                    </tr>

                    <tr class="text-center">
                        <td>
                            <telerik:RadButton ID="RadButton1" runat="server" OnClick="rbtCancelar_Click" Text="VOLVER" Icon-PrimaryIconCssClass="rbCancel"></telerik:RadButton>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>






</asp:Content>

