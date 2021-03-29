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
    public partial class ProductList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<Product> GetProducts([QueryString("id")] int? categoryId, [RouteData]string categoryName)
        {
            var _db = new ProductContext();
            IQueryable<Product> products = _db.Products;
            if (categoryId.HasValue && categoryId > 0)
             products = products.Where(x => x.CategoryID == categoryId);

            if (!string.IsNullOrEmpty(categoryName))
                products = products.Where(p => String.Compare(p.Category.CategoryName, categoryName) == 0);
            return products;
        }
    }
}