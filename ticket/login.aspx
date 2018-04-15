<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="UTF-8">
    <title>.::Tiket UAN::.</title>

    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/normalize/5.0.0/normalize.min.css">

    <link rel="stylesheet" href="resources/css/style.css">
</head>
<body>
    <form id="form1" runat="server">
        <div class="login">

          <h2 class="centrar" style="color: #050D5A">.::Ticket UAN::. </h2>
                 <h2 class="centrar" style="color: #050D5A">GESTOR DE EVENTOS</h2>
         <asp:Image ID="imagenuan" ImageUrl="~/resources/images/LogoUAN.png"  runat="server" />
            <fieldset>               
                <asp:TextBox ID="txbcode" placeholder="Usuario" style="color: white" runat="server"></asp:TextBox>
                
                <asp:TextBox ID="txbcontrasena" placeholder="Contraseña" style="color: white" TextMode="Password" runat="server"></asp:TextBox>
            </fieldset>
           
            <asp:Button ID="btningreso" runat="server" Text="Ingresar" style="color: white"  OnClick="btningreso_Click" />

        </div>
    </form>
</body>
</html>
