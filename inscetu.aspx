<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inscetu.aspx.cs" Inherits="trombinoscope1.inscetu" %>

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
    <h1>Inscription Etudiants </h1>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Nom de l'éudiant"></asp:Label>
        </div>
        <asp:TextBox ID="nom_inscetu" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Prénom de l'étudiant"></asp:Label>
        <br />
        <asp:TextBox ID="prenom_inscetu" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="E-mail"></asp:Label>
        <br />
        <asp:TextBox ID="mail_inscetu" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Numéro de Téléphone "></asp:Label>
        <br />
        <asp:TextBox ID="phone_inscetu" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="N° Etudiant"></asp:Label>
        <br />
        <asp:TextBox ID="no_inscetu" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Niveau de l'étudiant"></asp:Label>
        <br />
        <asp:ListBox ID="niv_inscetu" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged">
            <asp:ListItem>L1</asp:ListItem>
            <asp:ListItem>L2</asp:ListItem>
            <asp:ListItem>L3</asp:ListItem>
            <asp:ListItem>M1</asp:ListItem>
            <asp:ListItem>M2</asp:ListItem>
        </asp:ListBox>
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="Adresse de l'étudiant"></asp:Label>
        <br />
        <asp:TextBox ID="ad_inscetu" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label8" runat="server" Text="Filière "></asp:Label>
        <br />
        <br />
        <asp:ListBox ID="filiere_inscetu" runat="server">
            <asp:ListItem>EG</asp:ListItem>
            <asp:ListItem>MIPI</asp:ListItem>
            <asp:ListItem>WS</asp:ListItem>
            <asp:ListItem>BIO</asp:ListItem>
        </asp:ListBox>
        <br />
        <br />
        <asp:Label ID="Label9" runat="server" Text="Nom d'Utilisateur "></asp:Label>
        <br />
        <asp:TextBox ID="username_inscetu" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label10" runat="server" Text="Mot de passe"></asp:Label>
        <br />
        <asp:TextBox ID="pass_inscetu" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="submit_inscetu" runat="server" OnClick="submit_inscetu_Click" Text="Button" />
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
