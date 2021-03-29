<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UseSubmitBehavior.aspx.cs" Inherits="Webform.UseSubmitBehavior" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Wizard ID="Wizard1" runat="server">
        <StartNavigationTemplate>
            <asp:Button runat="server" ID="StartNextButton" CommandName="MoveNext" Text="Next"
                OnClientClick="return confirm('Are you sure?')"/>
        </StartNavigationTemplate>
        <StepNavigationTemplate>
            <asp:Button runat="server" ID="StepPreviousButton" UseSubmitBehavior="false" CommandName="MovePrevious" Text="Previous" CausesValidation="false" />
            <asp:Button runat="server" ID="StepNextButton" CommandName="MoveNext" Text="Next" />
        </StepNavigationTemplate>
        <FinishNavigationTemplate>
          
            <asp:Button runat="server" ID="StepFinishButton" CommandName="MoveFinish" Text="Finish" />
        </FinishNavigationTemplate>
    <WizardSteps>
        <asp:WizardStep ID="WizardStep1" runat="server" Title="Step 1">
            <asp:TextBox runat="server" ID="txtText1"></asp:TextBox>
        </asp:WizardStep>
        <asp:WizardStep ID="WizardStep2" runat="server" Title="Step 2">
             <asp:TextBox runat="server" ID="txtText2"></asp:TextBox>
        </asp:WizardStep>
        <asp:WizardStep ID="WizardStep3" runat="server" Title="Step 3">
             <asp:TextBox runat="server" ID="txtText3"></asp:TextBox>
        </asp:WizardStep>
    </WizardSteps>
</asp:Wizard>
</asp:Content>

