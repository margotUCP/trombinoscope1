<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="connexion_prof.aspx.cs" Inherits="trombinoscope1.connexion_prof" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="label_idprof" runat="server" Text="Identifiant Prof"></asp:Label>
            <br />
            <asp:TextBox ID="txt_id_prof" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="label_passprof" runat="server" Text="Mot de passe Prof"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="text_passprof" runat="server" OnTextChanged="TextBox1_TextChanged" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Button ID="btn_submitprof" runat="server" OnClick="btn_submitprof_Click" Text="Button" />
        </div>
    </form>
</body>
</html>
