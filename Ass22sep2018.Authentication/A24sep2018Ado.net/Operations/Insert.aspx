<%@ Page Title="Insert" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Insert.aspx.cs" Inherits="A24sep2018Ado.net.Insert" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <br />
        <br />
        <h2>INSERT</h2>
        <table style="width: 100%; border: 1px solid #FF0000; background-color:brown" >
           
           <%--   <tr>
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
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Submit" BorderStyle="Double" BorderColor="#33cccc" OnClick="Button1_Click" />

                </td>

            </tr>
            
           
    </table>
</asp:Content>
<%--<img src="Images/mobile_phone_25.png" />--%>