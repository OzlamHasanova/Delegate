

namespace ConsoleApp7
{
    class Book : Product
    {
       
            public string authorName;
            public int pageCount;
            public int discountPercent;


            public Book(string authorName, int pageCount, int discountPercent, string name, int costPrice, int saledPrice) : base(name, costPrice, saledPrice)
            {
                this.authorName = authorName;
                this.pageCount = pageCount;
                this.discountPercent = discountPercent;
            }
            public string GetInfo()
            {
                return $"{authorName} {pageCount} {discountPercent}";
            }

        public string GetDiscountedPrice()
        {
            return $"{saledPrice}, {discountPercent}";
        }



    }
}
