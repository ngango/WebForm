using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using Webform.Models;

namespace Webform
{
    public partial class ProductDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public Product GetProduct([QueryString("productID")]int? productID, [RouteData]string productName)
        {
            var _db = new ProductContext();
            Product product = new Product();
            if(productID.HasValue && productID > 0)
             product = _db.Products.FirstOrDefault(x => x.ProductID == productID);

            if(!string.IsNullOrEmpty(productName))
                product = _db.Products.FirstOrDefault(x => string.Compare(x.ProductName,productName) == 0);
            return product;
        }
    }
}