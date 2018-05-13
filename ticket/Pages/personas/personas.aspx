<%@ Page Title="" Language="C#" MasterPageFile="~/MPVacio.master" AutoEventWireup="true" CodeFile="personas.aspx.cs" Inherits="Pages_personas_personas" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table cellspacing="1" style="width: 100%">
        <tr>
            <td></td>
        </tr>
        <tr>
            <td>
                <table cellspacing="1" style="width: 811px">
                    <tr>
                        <td>
                            <telerik:RadGrid ID="rgvpersonas" OnNeedDataSource="rgvpersonas_NeedDataSource" runat="server" AutoGenerateColumns="False" Culture="es-ES">
                                <MasterTableView>
                                    <Columns>
                                        <telerik:GridBoundColumn FilterControlAltText="Filter column column" UniqueName="column" HeaderText="Nombre" DataField="per_nombre">
                                        </telerik:GridBoundColumn>
                                        <telerik:GridBoundColumn FilterControlAltText="Filter column1 column" UniqueName="column1" HeaderText="Apellido" DataField="per_apellido">
                                        </telerik:GridBoundColumn>

                                        <telerik:GridBoundColumn FilterControlAltText="Filter column2 column" UniqueName="column2" HeaderText="Código" DataField="per_codigo">
                                        </telerik:GridBoundColumn>

                                        <telerik:GridBoundColumn FilterControlAltText="Filter column3 column" UniqueName="column3" HeaderText="Identificación" DataField="per_identificacion">
                                        </telerik:GridBoundColumn>

                                        <telerik:GridBoundColumn FilterControlAltText="Filter column4 column" UniqueName="column4" HeaderText="Correo" DataField="per_correo">
                                        </telerik:GridBoundColumn>

                                        <telerik:GridBoundColumn FilterControlAltText="Filter column5 column" UniqueName="column5" HeaderText="Nacionalidad" DataField="pai_descripcion">
                                        </telerik:GridBoundColumn>

                                        <telerik:GridBoundColumn FilterControlAltText="Filter column6 column" UniqueName="column6" HeaderText="Ciudad" DataField="ciu_descripcion">
                                        </telerik:GridBoundColumn>

                                        <telerik:GridBoundColumn FilterControlAltText="Filter column7 column" UniqueName="column7" HeaderText="Estado" DataField="tus_descripcion">
                                        </telerik:GridBoundColumn>

                                    </Columns>
                                </MasterTableView>
                            </telerik:RadGrid>
                        </td>
                    </tr>

                    <tr class="text-center">
                        <td>
                            <telerik:RadButton ID="rbtguardar" runat="server" OnClick="btnAddpersonas_Click" Text="AGREGAR PERSONAS" Icon-PrimaryIconCssClass="rbAdd"></telerik:RadButton>
                        </td>
                    </tr>

                    <tr class="text-center">
                        <td>
                            <telerik:RadButton ID="RadButton1" runat="server" OnClick="rbtVolver_Click" Text="VOLVER" Icon-PrimaryIconCssClass="rbPrevious"></telerik:RadButton>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>




</asp:Content>

