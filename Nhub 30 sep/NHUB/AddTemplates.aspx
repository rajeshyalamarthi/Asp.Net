<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddTemplates.aspx.cs" Inherits="NHUB.AddTemplates" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
    </p>
        <div style="height: 493px; position: relative;" class="text-center"> <br />
            <h1 class="text-center"> Add Template </h1>
            <div class="text-center">
            <br />
            </div>
            <h2 class="text-center">
                &nbsp;</h2>
                <table class="auto-style1">
                    <tr>
                        <td style="width: 382px"> Service Line : </td>
                        <td style="width: 486px">
                            &nbsp;
                            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style8" style="position: relative; left: -92px; top: -9px; width: 286px; height: 21px" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="Name" Height="100px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="200px">
                            </asp:DropDownList>
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NotificationHubConnectionString %>" SelectCommand="SELECT [Name], [Id] FROM [ServiceLine]"></asp:SqlDataSource>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 382px"> Notification : </td>
                        <td style="width: 486px">
                            <asp:DropDownList ID="DropDownList2" runat="server" CssClass="auto-style7" style="position: relative; left: -98px; top: 0px; width: 268px; height: 13px" Height="50px" Width="200px" DataSourceID="SqlDataSource2" DataTextField="Name" DataValueField="Name">
                            </asp:DropDownList>
                            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:NotificationHubConnectionString2 %>" SelectCommand="SELECT [Id], [Name] FROM [Event]"></asp:SqlDataSource>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 382px"> Template Name : </td>
                        <td style="width: 486px">
                            <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style4" style="position: relative; left: -42px; top: 0px; width: 240px" Height="30px" Width="200px"></asp:TextBox>
                        &nbsp;
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox1" ErrorMessage="Name is Mandatory" ForeColor="Red"></asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 382px"> Mandatory event :</td>
                        <td style="width: 486px">
                            <asp:CheckBox ID="CheckBox1" runat="server" />
&nbsp;&nbsp;
                            </td>
                    </tr>
                    <tr>
                        <td style="width: 382px"> Select Channel : </td>
                        <td style="width: 486px">
                            <asp:DropDownList ID="DropDownList3" runat="server" CssClass="auto-style6" style="position: relative; left: -93px; top: 0px; width: 262px; height: 9px" Height="50px" Width="200px" DataSourceID="SqlDataSource3" DataTextField="Name" DataValueField="Name">
                            </asp:DropDownList>
                            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:NotificationHubConnectionString3 %>" SelectCommand="SELECT [Name], [Id] FROM [Channel]"></asp:SqlDataSource>
                        &nbsp;</td>
                    </tr>
                    <tr>
                        <td style="width: 382px; height: 25px"></td>
                        <td style="width: 486px; height: 25px">
                            <asp:FileUpload ID="FileUpload1" runat="server" CssClass="auto-style5" style="position: relative; left: 13px; top: 0px; width: 263px" Height="30px" Width="200px" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            </td>
                    </tr>
                    <tr>
                        <td style="width: 382px; height: 50px"></td>
                        <td style="width: 486px; height: 50px"></td>
                    </tr>
                    <tr>
                        <td style="width: 382px; height: 54px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Button ID="Button4" runat="server" Text="Cancel" OnClick="Button4_Click" style="position: relative; left: -13px; top: 1px; height: 33px; width: 100px" />
                        </td>
                        <td class="auto-style3" style="width: 486px; height: 54px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="Button3" runat="server" Text="Create" OnClick="Button3_Click" style="position: relative; left: -109px; top: -1px; width: 106px; height: 32px" />
                        </td>
                    </tr>
                </table>
             <h2>
                 &nbsp;</h2>
             <h2>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                 &nbsp;&nbsp;&nbsp;
                 </h2>
            <h2>
                &nbsp;</h2>
        </div>
    <p>
        &nbsp;</p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
