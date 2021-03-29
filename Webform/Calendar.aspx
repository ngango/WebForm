<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Calendar.aspx.cs" Inherits="Webform.Calendar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<asp:Calendar ID="Calendar1" runat="server" Caption="Tranning" FirstDayOfWeek="Monday" NextPrevFormat="ShortMonth" OnDayRender="Calendar1_DayRender">
    <DayHeaderStyle BackColor="Red" ForeColor="#0066FF" />
    </asp:Calendar>
</asp:Content>
