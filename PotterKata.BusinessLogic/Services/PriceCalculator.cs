using System.Collections.Generic;
using System.Linq;
using PotterKata.BusinessLogic.Models;

namespace PotterKata.BusinessLogic.Services
{
    public class PriceCalculator
    {
        private const decimal Price = 8;
        private DiscountInformation DiscountInformation { get; }

        public PriceCalculator()
        {
            DiscountInformation = new DiscountInformation();
        }

        public decimal Calculate(ICollection<Book> books)
        {
            var countOfBooksWithDiscount = books.GroupBy(x => x.Serie).Count();
            var countOfBooksWithoutDiscount = books.Count - countOfBooksWithDiscount;

            var discount = DiscountInformation.Get(countOfBooksWithDiscount);
            var discountPrice = Price * (100 - discount) / 100;

            return (countOfBooksWithDiscount * discountPrice) + (countOfBooksWithoutDiscount * Price);
        }
    }
}
