using Shopping;
using System.ComponentModel.DataAnnotations;

namespace TestShopping
{
    public class TestIntegration
    {
        [Test]
        public void CheckoutProcess_NominalCase_Success()
        {
            //given
            //refer to Setup
            Cart cart = new Cart();
            Checkout checkout = new Checkout();
            ShoppingBag shoppingBag = new ShoppingBag();
            PaymentTerminal paymentTerminal = new PaymentTerminal(checkout);
            CreditCard creditCard = new CreditCard();
            cart.Add(ArticleGenerator.Generate(15));
            Assert.That(cart.Articles.Count(), Is.EqualTo(15));

            //when
            while (cart.Articles.Count() > 0)
            {
                //Step 01 - Remove one article from cart
                List<Article> articleReadyToCheckout = cart.Remove();
                //Step 02 - Add this article in checkout
                checkout.Add(articleReadyToCheckout);
                //Step 03 - Remove this article from checkout
                List<Article> articleReadyToShoppingBag = checkout.Remove();
                //Step 04 - Add this article in shopping bag
                shoppingBag.Add(articleReadyToShoppingBag);
            }

            //Step 05 - StartingCashingProcess
            Assert.That(checkout.Balance, Is.EqualTo(120.00f));
            checkout.StartCashingProcess();
            //Step 06 - InsertCard
            paymentTerminal.InsertCard(creditCard);
            Assert.NotNull(paymentTerminal.CreditCard);
            //Step 07 - Cash
            paymentTerminal.Cash(checkout.Balance);
            Assert.That(checkout.Balance, Is.EqualTo(0.00f));
            //Step 08 - Remove card
            paymentTerminal.RemoveCard();
            Assert.Null(paymentTerminal.CreditCard);
            //Step 09 - Release Cart
            cart.Release();
            Assert.IsTrue(cart.IsReleased);

        }
    }
}