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
            _cartItems = cartItems;
        }

        public void Remove(List<CartItem> cartItemsToRemove)
        {
            List<CartItem> articlesAfterRemoving = new List<CartItem>();

            foreach (CartItem cartItem in _cartItems)
            {
                bool found = false;
                foreach (CartItem cartItemToRemove in cartItemsToRemove)
                {
                    if (cartItemToRemove.Article.Description == cartItem.Article.Description)
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    articlesAfterRemoving.Add(cartItem);
                }
            }
            _cartItems = articlesAfterRemoving;
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
                float price = 0;
                foreach (CartItem cartItem in _cartItems)
                {
                    price += cartItem.Article.Price * cartItem.Quantity;
                }
                return price;
            }
        }
        #endregion public methods
    }
}
