<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="add_filiere.aspx.cs" Inherits="trombinoscope1.add_filiere" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <h1>Ajouter une filière</h1>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Nom de la filière "></asp:Label>
            <br />
            <asp:TextBox ID="nom_new_filiere" runat="server" OnTextChanged="nom_new_filiere_TextChanged"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Ufr"></asp:Label>
            <br />
            <asp:TextBox ID="ufr_filiere" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="submit_addfiliere" runat="server" OnClick="submit_addfiliere_Click" Text="Ajouter" />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="fil"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="filrech" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="submitrechfil" />
        </div>
    </form>
</body>
</html>
