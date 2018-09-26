<%@ Page Title="Update" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="A24sep2018Ado.net.Update" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <br />
        <br />
        <h2>UPDATE</h2>
        <table style="width: 100%; border: 1px solid #FF0000; background-color: #245269">
           
        <%--      <tr>
                <td>ProductId</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>--%>
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
        </table>
<%--        <asp:Button ID="Button1" runat="server" Text="INSERT" OnClick="Button1_Click1" />--%>
        <asp:Button ID="Button2" runat="server" Text="UPDATE" OnClick="Button2_Click" />
     <%--   <asp:Button ID="Button3" runat="server" Text="DELETE" OnClick="Button3_Click" />--%> </div>
</asp:Content>
<%--<img src="Content/Redmi-Black-A1-64-MB-SDL171943867-3-1f01f.jpeg" />--%>