namespace Shopping
{
    public class PaymentTerminal
    {
        #region private attributes
        private Checkout _checkout = new Checkout();
        #endregion private attributes

        #region public methods
        public PaymentTerminal(Checkout checkout)
        {
            throw new NotImplementedException();
        }

        public object? CreditCard { get; set; }

        public void Cash(float balance)
        {
            throw new NotImplementedException();
        }

        public void InsertCard(CreditCard creditCard)
        {
            throw new NotImplementedException();
        }

        public void RemoveCard()
        {
            throw new NotImplementedException();
        }
        #endregion public methods
    }
}
