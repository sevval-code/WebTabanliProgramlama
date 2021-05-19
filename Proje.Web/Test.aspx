<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="Proje.Web.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            DropDownList
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>--<asp:Button ID="Button1" runat="server" style="background-color:#ff6a00 color:#ff6a00" Text="Button" OnClick="Button1_Click" />

            <br />
            <asp:DropDownList ID="drp_liste" runat="server" Width="100%" AutoPostBack="True" OnSelectedIndexChanged="drp_liste_SelectedIndexChanged">
                <asp:ListItem Selected="True" Value="-1">Seciniz</asp:ListItem>

            </asp:DropDownList>
        </div>
         <p>
        Secilen Degerin Ozelligini Almak 
    </p>

    <p>
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </p>
        
    </form>
   
</body>
</html>
