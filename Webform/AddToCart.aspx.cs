using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Webform.Logic;

namespace Webform
{
    public partial class AddToCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string rawId = Request.QueryString["productID"];
            int productID;
            if(!string.IsNullOrEmpty(rawId) && int.TryParse(rawId,out productID))
            {
                using(ShoppingCartActions userShoppingCart = new ShoppingCartActions())
                {
                    userShoppingCart.AddToCart(Convert.ToInt16(rawId));
                }
            }
            else
            {
                Debug.Fail("ERROR");
            }
            Response.Redirect("ShoppingCart.aspx");
        }
    }
}