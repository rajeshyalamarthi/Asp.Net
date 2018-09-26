<%@ Page Title="Delete" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="A24sep2018Ado.net.Delete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  <h2>Information</h2>



     <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>

      <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br />
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label><br />
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>  <div>

            <h1 style="color:brown"> Click Below To DeleteData</h1>
            <asp:Button ID="Button1" runat="server" Text="Delete" BorderStyle="Double" BorderColor="#cc0000" BackColor="#3366ff" OnClick="Button1_Click1"></asp:Button>












            <%--<table style="width: 100%; border: 1px solid #FF0000; background-color:brown" >--%>
           
             <%-- <tr>
                <td>ProductId</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>ProductName</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>

            </tr>
            <tr>
                <td>Price</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>URL</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Description</td>
                <td>
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                </td>
            </tr>

             <tr>
           
                <td>Brand</td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="BrandName" DataValueField="BrandId">
                    </asp:DropDownList>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Auth1ConnectionString %>" SelectCommand="SELECT [BrandId], [BrandName] FROM [Brands]"></asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Submit" BorderStyle="Double" BorderColor="#33cccc" OnClick="Button1_Click" />

                </td>

            </tr>
            
           
    </table>--%>








    </div>
</asp:Content>
