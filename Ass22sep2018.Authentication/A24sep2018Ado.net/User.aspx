<%@ Page Title="User" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="A24sep2018Ado.net.User" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
       <h2>
           <asp:Button ID="Button1" runat="server" Text="DisplayProducts" OnClick="Button1_Click" />
           <br />
           <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button ID="Button2" runat="server" Text="Search" OnClick="Button2_Click" />
          
           <br />
           <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder> 
           <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>
           <%: Title %>.</h2>
</asp:Content>
