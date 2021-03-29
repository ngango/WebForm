<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WizardControl.aspx.cs" Inherits="Webform.WizardControl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Wizard ID="Wizard1" runat="server" OnActiveStepChanged="Wizard1_ActiveStepChanged"
        DisplayCancelButton="true" OnCancelButtonClick="Wizard1_CancelButtonClick" OnNextButtonClick="Wizard1_NextButtonClick">
        <WizardSteps>
            <asp:WizardStep ID="WizardStep1" runat="server" Title="Step 1"></asp:WizardStep>
            <asp:WizardStep ID="WizardStep2" runat="server" Title="Step 2"></asp:WizardStep>
            <asp:WizardStep ID="WizardStep3" runat="server" Title="Step 3"></asp:WizardStep>
        </WizardSteps>
    </asp:Wizard>
</asp:Content>
