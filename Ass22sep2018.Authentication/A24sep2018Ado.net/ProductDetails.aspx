<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs" Inherits="A24sep2018Ado.net.ProductDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h3>Information</h3>
    <form id="form1" runat="server">

        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>

      
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label><br />
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>     <div>

              <asp:Button ID="Button1" runat="server" Text="Update" BorderStyle="Ridge" BorderColor="#cc0000" BackColor="#003366" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Delete" BorderStyle="Ridge" BorderColor="#cc0000" BackColor="#003366" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
