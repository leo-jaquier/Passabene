using System.Text.RegularExpressions;

namespace Shopping
{
    public class Article
    {
        #region private attributes
        private int _id;
        private string _description = "";
        private float _price = 0f;
        #endregion private attributes

        #region public methods
        public Article(int id, string description, float price)
        {
           _price = price;
            _id = id;
            _description = description;
        }


        public int Id
        {
            get
            {
                return _id;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                char specialChar = '+';
                if (value.Length >50)
                {
                    throw new TooLongDescriptionException();
                }
                if (value.Contains(specialChar))
                {
                    throw new SpecialCharInDescriptionException();
                }
                if (value.Split(' ').Length<=1)
                {
                    throw new TooShortDescriptionException();
                }
                _description = value;
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

        public class ArticleException : Exception { }
        public class TooShortDescriptionException : ArticleException { }
        public class SpecialCharInDescriptionException : ArticleException { }
        public class TooLongDescriptionException : ArticleException { }
    }
}
