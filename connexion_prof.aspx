<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="connexion_prof.aspx.cs" Inherits="trombinoscope1.connexion_prof" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <h1>Connexion Profeseurs</h1>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Identifiant "></asp:Label>
            <br />
            <asp:TextBox ID="username_connprof" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Mot de Passe"></asp:Label>
            <br />
            <asp:TextBox ID="pass_connprof" runat="server" OnTextChanged="pass_connprof_TextChanged" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Button ID="submit_connprof" runat="server" OnClick="submit_connprof_Click" Text="Se connecter" />
        </div>
    </form>
</body>
</html>
