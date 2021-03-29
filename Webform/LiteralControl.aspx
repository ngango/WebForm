<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LiteralControl.aspx.cs" Inherits="Webform.LiteralControl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label runat="server" ID="lb" Text="<script>alert('label')</script>"></asp:Label>
    <asp:Literal runat="server" ID="liter" Text="<script>alert('literal')</script>"></asp:Literal>
</asp:Content>
