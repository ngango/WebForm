using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Webform.Models;

namespace Webform.Logic
{
    public class ShoppingCartActions : IDisposable
    {
        
        public string ShoppingCartId { get; set; }
        private ProductContext _db = new ProductContext();
        public const string CartSessionKey = "CartId";
        public void AddToCart(int id)
        {
            ShoppingCartId = GetCartId();
            var cartItem = _db.ShoppingCartItems.SingleOrDefault(c => c.CartId == ShoppingCartId && c.ProductId == id);
            if(cartItem == null){
                cartItem = new CartItem
                {
                    ItemId = Guid.NewGuid().ToString(),
                    ProductId = id,
                    CartId = ShoppingCartId,
                    Product =  _db.Products.SingleOrDefault( p => p.ProductID == id),
                    Quantity =1,
                    DateCreadted = DateTime.Now
                };

                _db.ShoppingCartItems.Add(cartItem);
            }
            else
            {
                cartItem.Quantity++;
            }
            _db.SaveChanges();
        }
        public void Dispose()
        {
           if(_db != null)
            {
                _db.Dispose();
                _db = null;
            }
        }


        public string GetCartId()
        {
            if(HttpContext.Current.Session[CartSessionKey] == null)
            {
                if (!string.IsNullOrWhiteSpace(HttpContext.Current.User.Identity.Name))
                {
                    HttpContext.Current.Session[CartSessionKey] = HttpContext.Current.User.Identity.Name;
                }
                else
                {
                    Guid tempCartId = Guid.NewGuid();
                    HttpContext.Current.Session[CartSessionKey] = tempCartId.ToString();
                }
            }
            return HttpContext.Current.Session[CartSessionKey].ToString();
        }

        public List<CartItem> GetCartItems()
        {
            ShoppingCartId = GetCartId();
            return _db.ShoppingCartItems.Where(x => x.CartId == ShoppingCartId).ToList();
        }


        public decimal GetTotal()
        {
            ShoppingCartId = GetCartId();
            decimal? total = decimal.Zero;
            total = (decimal?)(from cartItems in _db.ShoppingCartItems
                               where cartItems.CartId == ShoppingCartId
                               select (int?)cartItems.Quantity * cartItems.Product.UnitPrice).Sum();
            return total ?? decimal.Zero;
        }
        public struct ShoppingCartUpdates
        {
            public int ProductId { get; set; }
            public int PurchaseQuantity { get; set; }
            public bool RemoveItem { get; set; }
        }

        public int GetCount()
        {
            ShoppingCartId = GetCartId();
            int? count = (from cartItem in _db.ShoppingCartItems
                          where cartItem.CartId == ShoppingCartId
                          select (int?)cartItem.Quantity).Sum();
            return count ?? 0;
        }

        public ShoppingCartActions GetCart(HttpContext context)
        {
            using(var cart = new ShoppingCartActions())
            {
                cart.ShoppingCartId = cart.GetCartId();
                return cart;
            }
        }

        public void UpdateShoppingCartDatabase(String cartId, ShoppingCartUpdates[] CartItemUpdates)
        {
            using(var db = new ProductContext())
            {
                try
                {
                    int CartItemCount = CartItemUpdates.Count();
                    List<CartItem> myCart = GetCartItems();
                    foreach(var cartItem in myCart)
                    {
                        for(int i=0; i< CartItemCount; i++)
                        {
                            if(cartItem.Product.ProductID == CartItemUpdates[i].ProductId)
                            {
                                if(CartItemUpdates[i].PurchaseQuantity < 1 || CartItemUpdates[i].RemoveItem == true)
                                {
                                    RemoveItem(cartId, cartItem.ProductId);
                                }
                                else
                                {
                                    UpdateItem(cartId, cartItem.ProductId, CartItemUpdates[i].PurchaseQuantity);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
        }

        public void RemoveItem(string removeCartID, int removeProductID)
        {
            using(var _db= new ProductContext())
            {
                try
                {
                    var myItem = (from c in _db.ShoppingCartItems
                                  where c.CartId == removeCartID
                                  && c.ProductId == removeProductID
                                  select c).FirstOrDefault();
                    if(myItem != null)
                    {
                        _db.ShoppingCartItems.Remove(myItem);
                        _db.SaveChanges();
                    }

                }
                catch (Exception ex)
                {

                    throw;
                }
            }
        }

        public void UpdateItem(string updateCartID, int updateProductID, int quantity)
        {
            using(var _db = new ProductContext())
            {
                try
                {
                    var myItem = (from c in _db.ShoppingCartItems where c.CartId == updateCartID && c.Product.ProductID == updateProductID select c).FirstOrDefault();
                    if(myItem != null)
                    {
                        myItem.Quantity = quantity;
                        _db.SaveChanges();
                    }
                }
                catch (Exception ex)
                {

                    throw;
                }
            }
        }

        public void EmptyCart()
        {
            ShoppingCartId = GetCartId();
            var cartItems = _db.ShoppingCartItems.Where(c => c.CartId == ShoppingCartId);
            foreach(var item in cartItems)
            {
                _db.ShoppingCartItems.Remove(item);
            }
            _db.SaveChanges();
        }
    }
}