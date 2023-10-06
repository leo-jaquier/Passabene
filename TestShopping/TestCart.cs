using Shopping;

namespace TestShopping
{
    public class TestCart
    {
        #region private attributes
        private Cart? _cart = null;
        #endregion private attributes

        [SetUp]
        public void Setup()
        {
            _cart = new Cart();
        }

        [Test]
        public void Add_FirstSingleCartItem_Success()
        {
            //given
            //refer to Setup
            float articlePrice = 4.5f;
            Article expectedArticle = new Article(articlePrice);
            int expectedQuantity = 1;
            CartItem expectedCartItem = new CartItem(expectedArticle, expectedQuantity);
            List<CartItem> expectedCartItems = new List<CartItem> { expectedCartItem };
            Assert.That(_cart.CartItems.Count(), Is.EqualTo(0));

            //when
            _cart.Add(expectedCartItems);

            //then
            Assert.That(_cart.CartItems.Count(), Is.EqualTo(1));
            Assert.That(_cart.Price, Is.EqualTo(articlePrice));
        }
    }
}