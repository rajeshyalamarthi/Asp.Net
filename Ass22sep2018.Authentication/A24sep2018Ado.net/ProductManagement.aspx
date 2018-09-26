<%@ Page Title="ProductManagement" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProductManagement.aspx.cs" Inherits="A24sep2018Ado.net.ProductManagement" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
  <h2>
  <asp:Button ID="Button1" runat="server" Text="DisplayProducts" OnClick="Button1_Click" />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button2" runat="server" Text="Search" OnClick="Button2_Click" />
     <asp:Button ID="Button3" runat="server" Text="EDIT" OnClick="Button3_Click" />
  
 <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
    <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>
   </h2>
<%--    <asp:GridView ID="GridView1" runat="server"></asp:GridView>--%>
   
    <%--<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>--%>
<%--    <table id="tableContent" border="1" runat="server"></table>
   
    <table id="table1">

        <tr>

            <td>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </td>
           </tr>
         <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                 
            </td>
              </tr>
         <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>

        <tr>
              <td>
         <asp:Image ID="Image1" runat="server" Height="118px" Width="215px" />
                     <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                     </td>
                     </tr>
    </table>



          <table>

        <tr>

            <td>
                    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
            </td>
           </tr>
         <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                 
            </td>
              </tr>
         <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
            </td>
        </tr>

        <tr>
              <td>
         <asp:Image ID="Image2" runat="server" Height="118px" Width="215px" />
                     </td>
                     </tr>
    </table>--%>

           

</asp:Content>
