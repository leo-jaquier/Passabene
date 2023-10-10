using System.Net.Http.Headers;

namespace Shopping
{
    public class Cart : ICollectionOfArticles
    {
        #region private attributes
        private List<CartItem> _articleItems = new List<CartItem>();
        #endregion private attributes

        #region public methods
        public void Add(List<CartItem> articleItems)
        {
           _articleItems=articleItems;
        }

        public List<CartItem> Remove(Boolean clearCart = false)
        {
            throw new NotImplementedException();
        }

        public List<CartItem> Remove(CartItem cartItemToRemove)
        {
            throw new NotImplementedException();
        }

        public void Release()
        {
            throw new NotImplementedException();
        }

        public List<CartItem> CartItems
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float Price
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool? IsReleased { get; set; }
        #endregion public methods
    }
}
