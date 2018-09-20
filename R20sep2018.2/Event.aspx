<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Event.aspx.cs" Inherits="R20sep2018._2.Event" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:aqua">
  
    <form id="form1" runat="server">
    
        <div>
            <br />
            <br />
                <asp:Label ID="Label1" runat="server"  BorderColor="#009900"></asp:Label>

            <br />

              Enter value<asp:TextBox ID="TextBox1" runat="server" BorderColor="YellowGreen"></asp:TextBox>
    <br />
              Enter Value<asp:TextBox ID="TextBox2" runat="server" BorderColor="YellowGreen"></asp:TextBox>

            <br />

            <asp:Button ID="Button1" runat="server" Text="Button" BorderColor="YellowGreen" OnClick="Button1_Click" />

            <br />
            result:  <asp:TextBox ID="TextBox3" runat="server" BorderColor="Yellow"></asp:TextBox>
        </div>

        <div id="Hide"  style="background-color:brown">
            <p style="color:cornsilk ;font-size:large"> Please Hide Me</p>
                        <p style="color:cornsilk ;font-size:large"> OK Wait</p>
                        <p style="color:cornsilk ;font-size:large"> Click On Below Button To Hide</p>
            
            
               

        </div>
        <asp:Button ID="Button2" runat="server" Text="ClickME" BorderColor="#009933" ForeColor="#006699" OnClick="Button2_Click" />
      
     <div style="background-color:lightslategrey" id="practice">
         
         <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
         <br />
         <asp:Button ID="Button3" runat="server" Text="Button" OnClick="Button3_Click" />

         <p>**********************************************************</p>
        
         <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>

           <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
         <br />


            <asp:Button ID="Button4" runat="server" Text="Button" OnClick="Button4_Click" />
         
     </div>

      
    </form>
</body>
</html>
