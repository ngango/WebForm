<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HiddenField.aspx.cs" Inherits="Webform.HiddenField" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div style="font-family:Arial">
        <asp:HiddenField runat="server" ID="ID" />
        <table>
            <tr>
                <td>Name</td><td><asp:TextBox runat="server" ID="txtName"></asp:TextBox></td>
            </tr>
             <tr>
                <td>Gender</td><td><asp:TextBox runat="server" ID="txtGender"></asp:TextBox></td>
            </tr>
             <tr>
                <td>DeptName</td><td><asp:TextBox runat="server" ID="txtDeptName"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Button runat="server" Text="Update" ID="btnUpdate" OnClick="btnUpdate_Click" />
                    
                </td>
                <td>
                    <asp:Button runat="server" Text="Load" ID="btnLoad" OnClick="btnLoad_Click" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
