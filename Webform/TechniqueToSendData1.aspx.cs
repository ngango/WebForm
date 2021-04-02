using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webform
{
    public partial class TechniqueToSendData1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Page lastPage = (Page)Context.Handler;
                //if(lastPage is TechniqueToSendData)
                //lbName.Text = ((TechniqueToSendData)lastPage).Name;
                //lbEmail.Text = ((TechniqueToSendData)lastPage).Email;


                //lbName.Text = Request.QueryString["Name"];
                //lbEmail.Text = Request.QueryString["Email"];
                //lbName.Text = Server.HtmlDecode(Request.QueryString[0]);
                //lbEmail.Text = Server.HtmlDecode(Request.QueryString[1]);

                HttpCookie cookie = Request.Cookies["UserInfo"];
                if(cookie != null)
                {
                    lbName.Text = cookie["Name"];
                    lbEmail.Text = cookie["Email"];
                }
                
            }
           
        }
    }
}