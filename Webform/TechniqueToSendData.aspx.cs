using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webform
{
    public partial class TechniqueToSendData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            Server.Transfer("TechniqueToSendData1.aspx");
        }
        public string Name { get { return txtName.Text; } }
        public string Email { get { return txtEmail.Text; } }

        protected void QueryString_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/TechniqueToSendData1?Name=" + Server.HtmlEncode(txtName.Text) + "&Email=" + Server.HtmlEncode(txtEmail.Text));
        }

        protected void Cookies_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("UserInfo");
            cookie["Name"] = txtName.Text;
            cookie["Email"] = txtName.Text;

            //cookie.Expires = DateTime.Now;
            Response.Cookies.Add(cookie);
            Response.Redirect("TechniqueToSendData1.aspx");
        }
    }
}