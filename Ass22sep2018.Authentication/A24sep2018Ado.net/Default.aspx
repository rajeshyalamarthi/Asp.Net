<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="A24sep2018Ado.net._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   <%-- <asp:Button ID="Button1" runat="server" Text="DisplayProducts" BorderStyle="Outset" BorderColor="#00cc00" OnClick="Button1_Click" />--%>

    <div class="jumbotron">
        <h1>KIWI CART</h1>
        <p class="lead">The quickest way to know a woman is to go shopping with her.</p>
  
    </div>  <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:Button ID="Button2" runat="server" Text="Search" OnClick="Button2_Click" />
          
           <br />
           <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder> 
           <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>


    

</asp:Content>
