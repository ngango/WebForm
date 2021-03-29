<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Webform.Account.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-md-4">
        <label>Email</label>
        <asp:TextBox runat="server" ID="txtEmail"></asp:TextBox>
    </div>

     <div class="col-md-4">
        <label>Password</label>
        <asp:TextBox runat="server" ID="txtPassword"></asp:TextBox>
    </div>
        <div class="col-md-4">
            <asp:CheckBox runat="server" ID="cbRemember" /> <label>Remember me?</label>
        </div>
        <asp:Button runat="server" Text="LogIn" />
        <asp:HyperLink runat="server" ID="RegisterHyperLink">Register as one user new</asp:HyperLink>
    </div>
   <div class="row">
        <label>Use another service to log in</label>
        <asp:LinkButton runat="server" ID="OpenAuthLogin" Text="Google" />
    </div>

</asp:Content>
