<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ServerTransfer1.aspx.cs" Inherits="Webform.ServerTransfer1" %>

<asp:Content  ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td>UserName</td>
            <td>
                <asp:TextBox runat="server" ID="txtUseName"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Email</td>
            <td>
                <asp:TextBox runat="server" ID="txtEmail"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnTransfer" runat="server" Text="Transfer" OnClick="Unnamed_Click" /></td>
            <td>
                <input id="Button1" onclick="OpenNewWindow()" type="button" value="Window open" /></td>
        </tr>
       
    </table>
    <script type="text/javascript">
        function OpenNewWindow() {
            console.log($("#txtUseName").val());
            var name = $("#MainContent_txtUseName").val();
            var email = $("#MainContent_txtEmail").val();
            window.open("ServerTranfers2.aspx?Name="+name+"&Email="+email, "_blank", "location=no", true);
        }
    </script>
</asp:Content>


