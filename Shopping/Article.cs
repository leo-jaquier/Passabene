﻿namespace Shopping
{
    public class Article
    {
        #region private attributes
        private float _price = 0f;
        #endregion private attributes

        #region public methods
        public Article(float price)
        {
           _price = price;
        }


        public int Id
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Description
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
                return _price;
            }
        }
        #endregion public methods
    }
}
