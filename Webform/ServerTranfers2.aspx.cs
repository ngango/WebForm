using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webform
{
    public partial class ServerTranfers2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var previousFormCollection = Request.Form.AllKeys;
            //lbEmail.Text = previousFormCollection["$txtUseName"];
            //lbUsername.Text = previousFormCollection["txtUseName"];
            //ServerTransfer1 previousPage = (ServerTransfer1)this.PreviousPage;
            //if (previousPage != null)
            //    lbUsername.Text = previousPage.Username;
            lbUsername.Text = Request.QueryString["Name"];
            lbEmail.Text = Request.QueryString["Email"];
        }
    }
}