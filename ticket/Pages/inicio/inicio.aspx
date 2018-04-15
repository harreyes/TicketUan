<%@ Page Title="" Language="C#" MasterPageFile="~/MP.master" AutoEventWireup="true" CodeFile="inicio.aspx.cs" Inherits="Pages_inicio_inicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table cellspacing="1" class="w-100">
        <tr>
            <td>
                <table cellspacing="1" class="w-100">


                    <tr>
                        <td style="height: 53px;" colspan="3"></td>

                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td style="height: 53px;" colspan="3"></td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td style="height: 53px;" colspan="3"></td>
                        <td></td>
                        <td></td>
                    </tr>
                    <tr>
                        <td style="height: 153px; width: 423px" class="text-center">
                            <asp:ImageButton ID="ImageButton7" ImageUrl="~/resources/images/calendar.png" ToolTip="EVENTOS" OnClick="btnEventos_Click" runat="server" Height="180px" Width="200px" />
                        </td>
                        <td style="height: 153px; width: 156px" class="text-center">&nbsp;</td>
                        <td style="height: 153px">
                            <asp:ImageButton ID="ImageButton3" ImageUrl="~/resources/images/users-group.png" ToolTip="PERSONAS" OnClick="btnPersonas_Click" runat="server" Height="180px" Width="200px" />
                        </td>
                        <td style="height: 153px; width: 156px" class="text-center">&nbsp;</td>
                        <td style="height: 153px">
                            <asp:ImageButton ID="ImageButton1" ImageUrl="~/resources/images/settings.png" ToolTip="CONFIGURACIÓN" OnClick="btnConfiguracion_Click" runat="server" Height="180px" Width="200px" />
                        </td>
                    </tr>
                    <tr>
                        <td style="height: 53px; width: 423px">&nbsp;</td>
                        <td style="width: 156px; height: 53px">&nbsp;</td>
                        <td style="height: 53px">&nbsp;</td>
                    </tr>

                </table>
            </td>
        </tr>
    </table>
</asp:Content>

