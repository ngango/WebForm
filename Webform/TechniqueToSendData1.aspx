<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TechniqueToSendData1.aspx.cs" Inherits="Webform.TechniqueToSendData1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <table>
        <tr>
            <td>Name</td>
            <td><asp:Label runat="server" ID="lbName"></asp:Label></td>
        </tr>
        <tr>
            <td>Email</td>
            <td><asp:Label runat="server" ID="lbEmail"></asp:Label></td>
        </tr>
        
    </table>
</asp:Content>
