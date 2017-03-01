<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BuildingMobileWebSites.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <input id="TextBox1a" runat="server" placeholder="Enter an email" required="required" autofocus="autofocus" textmode="Email" />
            <asp:TextBox ID="TextBox2" runat="server" placeholder="Enter a date" required="required" TextMode="Date"></asp:TextBox>

            <asp:Button ID="Button1" runat="server" required="required" Text="Button" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
