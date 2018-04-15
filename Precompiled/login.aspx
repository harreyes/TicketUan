<%@ page language="C#" autoeventwireup="true" inherits="login, App_Web_5nllffcv" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="UTF-8">
    <title>.::Tiket firsoft::.</title>

    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/normalize/5.0.0/normalize.min.css">

    <link rel="stylesheet" href="resources/css/style.css">
</head>
<body>
    <form id="form1" runat="server">
        <div class="login">

          <h2 style="color: #FFFFFF">.::Ticket::. </h2>
                 <h2 style="color: #FFFFFF">Firsoft sistemas integrales</h2>
            <fieldset>
                <asp:TextBox ID="txbcode" placeholder="Usuario" runat="server"></asp:TextBox>
                <asp:TextBox ID="txbcontrasena" placeholder="Contraseña" TextMode="Password" runat="server"></asp:TextBox>
            </fieldset>
            <asp:Button ID="btningreso" runat="server" Text="Ingresar" OnClick="btningreso_Click" />

        </div>
    </form>
</body>
</html>
