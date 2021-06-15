<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication6.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="drinks" runat="server" OnSelectedIndexChanged ="drinks_SelectedIndexChanged1" AutoPostBack ="true">
                <asp:ListItem>綠茶</asp:ListItem>
                <asp:ListItem>紅茶</asp:ListItem>
                <asp:ListItem>奶茶</asp:ListItem>
            </asp:DropDownList><br/>
            <asp:DropDownList ID="other" runat="server">
                </asp:DropDownList><br/>
            <asp:DropDownList ID="ice" runat="server"></asp:DropDownList><br/>
            <asp:DropDownList ID="sugar" runat="server"></asp:DropDownList><br/>
            <asp:TextBox ID="tbx_Number" runat="server" AutoPostBack="true" OnTextChanged="tbx_Number_TextChanged"></asp:TextBox><br />
        <asp:Label ID="lb_Txt" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
