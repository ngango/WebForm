<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TechniqueToSendData.aspx.cs" Inherits="Webform.TechniqueToSendData" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td>Name</td>
            <td><asp:TextBox runat="server" ID="txtName" name="txtName"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Email</td>
            <td><asp:TextBox runat="server" ID="txtEmail"></asp:TextBox></td>
        </tr>
        <tr>
            <td colspan="2"><asp:Button runat="server" ID="Button" Text="Transfer" OnClick="Button_Click" /></td>
        </tr>
        <tr>
            <td colspan="2"><asp:Button runat="server" ID="QueryString" Text="QueryString" OnClick="QueryString_Click" /></td>
        </tr> 
        <tr>
            <td colspan="2"><asp:Button runat="server" ID="Cookies" Text="Cookies" OnClick="Cookies_Click" /></td>
        </tr>
    </table>
</asp:Content>
