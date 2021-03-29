using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webform
{
    public partial class UseSubmitBehavior : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Button btn = (Button)Wizard1.FindControl("StepNavigationTemplateContainerID").FindControl("StepNextButton");
            btn.OnClientClick = "return confirm('Are you sure?')";
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            if(Wizard1.ActiveStepIndex == 0)
            {
                txtText1.Focus();
            }else if(Wizard1.ActiveStepIndex == 1)
            {
                txtText2.Focus();
            }else if(Wizard1.ActiveStepIndex == 2)
            {
                txtText3.Focus();
            }
        }
    }
}