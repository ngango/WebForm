using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webform
{
    public partial class ServerTransfer1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            // Server.Transfer("~/ServerTranfers2.aspx",true);
            string str = "<script>window.open('ServerTranfers2.aspx?Name=" + txtUseName.Text + "&Email=" + txtEmail.Text + "');</script>";
            Response.Write(str);
        }
        public string Username
        {
            get { return txtUseName.Text; }
        }

        public string Email
        {
            get { return txtEmail.Text; }
        }
    }
}