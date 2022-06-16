<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Motorcycles.aspx.cs" Inherits="Que_2.Motorcycles" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Select any name :<asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="207px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
</asp:DropDownList>
<br />
<asp:Image ID="Image1" runat="server" Height="429px" Width="691px" />
<p>
Check the price of this Bike : <asp:Button ID="Price" runat="server" OnClick="Button1_Click1" style="margin-left: 43px" Text="Price" Width="119px" />
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
