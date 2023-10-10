using System;
using System.Net.Http.Headers;

namespace Shopping
{
    public class Cart
    {
        #region private attributes
        private List<CartItem> _cartItems = new List<CartItem>();
        #endregion private attributes

        #region public methods
        public void Add(List<CartItem> cartItems)
        {
            _cartItems=cartItems;
        }

        public void Remove(List<CartItem> cartItemsToRemove)
        {
            throw new NotImplementedException();
        }

        public List<CartItem> CartItems
        {
            get
            {
                return _cartItems;
            }
        }

        public float Price
        {
            get
            {
                float articlesPrice=0f;
               foreach (var item in _cartItems)
                {
                    articlesPrice += item.Quantity * item.Article.Price;
                    
                }
                return articlesPrice;
            }
        }
        #endregion public methods
    }
}
