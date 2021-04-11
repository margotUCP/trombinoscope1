<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="connexion_etu.aspx.cs" Inherits="trombinoscope1.connexion_etu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Connexion Etudiant</h1>

            <br />
            <asp:Label ID="Label1" runat="server" Text="identifiant"></asp:Label>
            <br />
            <asp:TextBox ID="idcoetu" runat="server"></asp:TextBox>
            <br />
            <asp:Label runat="server" Text="Mot de passe"></asp:Label>
            <br />
            <asp:TextBox ID="mdpcoetu" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Button ID="submitcoetu" runat="server" OnClick="submitcoetu_Click" Text="Connexion" />

        </div>
    </form>
</body>
</html>
