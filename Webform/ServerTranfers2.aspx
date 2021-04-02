<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" EnableViewStateMac="false" AutoEventWireup="true" CodeBehind="ServerTranfers2.aspx.cs" Inherits="Webform.ServerTranfers2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td>UserName</td>
            <td><asp:Label runat="server" ID="lbUsername"></asp:Label></td>
        </tr>
         <tr>
            <td>Email</td>
            <td><asp:Label runat="server" ID="lbEmail"></asp:Label></td>
        </tr></table>
</asp:Content>
