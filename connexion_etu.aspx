<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="connexion_etu.aspx.cs" Inherits="trombinoscope1.connexion_etu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Trombinoscope</title>
    <style>
        body{
            background-color: lightgray;
            font-family: Lato, sans-serif;
        }
        h1{
            text-align: center;
        }
        form{
            margin-left: 40%;
        }
        .inpuT{
            border-radius: 2px;
            width: 30%;
            margin-top: 5px;
        }
    </style>
</head>
<body>
    <h1>Connexion Etudiant</h1>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Label ID="Label1" runat="server" Text="identifiant"></asp:Label>
            <br />
            <asp:TextBox ID="idcoetu" runat="server" CssClass="inpuT"></asp:TextBox>
            <br />
            <asp:Label runat="server" Text="Mot de passe"></asp:Label>
            <br />
            <asp:TextBox ID="mdpcoetu" runat="server" TextMode="Password" CssClass="inpuT"></asp:TextBox>
            <br />
            <asp:Button ID="submitcoetu" runat="server" OnClick="submitcoetu_Click" Text="Connexion" />

        </div>
    </form>
</body>
</html>
