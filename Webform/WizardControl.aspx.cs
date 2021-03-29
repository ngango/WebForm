using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webform
{
    public partial class WizardControl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Wizard1_ActiveStepChanged(object sender, EventArgs e)
        {
            Response.Write("Active Step changed" + Wizard1.ActiveStepIndex.ToString());
        }

        protected void Wizard1_CancelButtonClick(object sender, EventArgs e)
        {
            Response.Write("Cancel button clicked");
        }

        protected void Wizard1_NextButtonClick(object sender, WizardNavigationEventArgs e)
        {
            Response.Write("CurrentStepIndex" + e.CurrentStepIndex +"<br/>");
            Response.Write("NextStepIndex" + e.NextStepIndex + "<br/>");
            e.Cancel = true;
        }
    }
}