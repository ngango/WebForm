<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ValidateGroup.aspx.cs" Inherits="Webform.ValidateGroup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td colspan="2"><h2>Login</h2></td>
        </tr>
        <tr>
            <td>UserName</td>
            <td><asp:TextBox runat="server" ID="txtUsernameL" ValidationGroup="Login"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ErrorMessage="Username Login" ControlToValidate="txtUsernameL" ValidationGroup="Login"></asp:RequiredFieldValidator>
            </td>
        </tr>
         <tr>
            <td>Password</td>
            <td><asp:TextBox runat="server" ID="txtPasswordL" ValidationGroup="Login"></asp:TextBox>
                 <asp:RequiredFieldValidator runat="server" ErrorMessage="Password Login" ControlToValidate="txtPasswordL" ValidationGroup="Login"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="2"><asp:Button runat="server" Text="LogIn" ValidationGroup="Login" /></td>
        </tr>
    </table>

     <table>
        <tr>
            <td colspan="2"><h2>Login</h2></td>
        </tr>
        <tr>
            <td>UserName</td>
            <td><asp:TextBox runat="server" ID="txtUsernameR" ValidationGroup="Register"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ErrorMessage="Username Register" ControlToValidate="txtUsernameR" ValidationGroup="Register"></asp:RequiredFieldValidator>
            </td>
        </tr>
         <tr>
            <td>Password</td>
            <td><asp:TextBox runat="server" ID="txtPasswordR" ValidationGroup="Register"></asp:TextBox>
                 <asp:RequiredFieldValidator runat="server" ErrorMessage="Password Register" ControlToValidate="txtPasswordR" ValidationGroup="Register"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="2"><asp:Button runat="server" Text="Register" ValidationGroup="Register" /></td>
        </tr>
    </table>
</asp:Content>
