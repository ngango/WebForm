<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MutilViews.aspx.cs" Inherits="Webform.MutilView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:MultiView runat="server" ID="MutilView">
        <asp:View runat="server" ID="ViewPersonalDetails">
            <table style="border:1px solid black">
                <tr>
                    <td colspan="2">
                        <h2>Step 1</h2>
                    </td>
                </tr>
                <tr>
                    <td>First Name</td>
                    <td>
                        <asp:TextBox runat="server" ID="txtFirstName"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </asp:View>
         <asp:View runat="server" ID="View1">
            <table style="border:1px solid black">
                <tr>
                    <td colspan="2">
                        <h2>Step 1</h2>
                    </td>
                </tr>
                <tr>
                    <td>First Name</td>
                    <td>
                        <asp:TextBox runat="server" ID="TextBox1"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </asp:View>
    </asp:MultiView>
</asp:Content>
