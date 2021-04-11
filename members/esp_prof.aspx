<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="esp_prof.aspx.cs" Inherits="trombinoscope1.members.esp_prof" %>

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
    </style>
</head>
<body>
    <div>
    </div>
    <form id="form1" runat="server">
        <div>
            <h3>Rechercher un étudiant</h3>

            <br />

            <asp:Label runat="server" Text="nom de l'étudiant"></asp:Label>
            <br />
            <asp:TextBox ID="rechnometu" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Chercher" />

        </div>
    </form>
</body>
</html>
