<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="WebApplication.WebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Welcome to chocolate Store</h1>
        
        <label for="ddlItems">Select an Item:</label>
        <asp:DropDownList ID="ddlItems" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlItems_SelectedIndexChanged">
            <asp:ListItem Text="Select an item" Value="" />
            <asp:ListItem Text="Dairy Milk" Value="DairyMilk.jpg" />
            <asp:ListItem Text="Kitkat" Value="Kitkat.jpg" />
            <asp:ListItem Text="5 Star" Value="5 Star.jpg" />
            <asp:ListItem Text="Perk" Value="Perk.jpg" />
            <asp:ListItem Text="Munch" Value="Munch.jpg" />
        </asp:DropDownList>
        <br />

        <asp:Image ID="imgItem" runat="server" AlternateText="Item Image" CssClass="item-image" Height="240px" Width="296px" />
        <br />

        <asp:Button ID="btnShowCost" runat="server" Text="Show Cost" OnClick="btnShowCost_Click" />
        <br />

        <asp:Label ID="lblCost" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
