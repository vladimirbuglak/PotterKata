using System.Collections.Generic;

namespace PotterKata.BusinessLogic
{
    public class DiscountInformation : IDiscountInformation
    {
        public Dictionary<int, decimal> Discounts { get; set; }

        public DiscountInformation()
        {
            Discounts = new Dictionary<int, decimal>
            {
                { 2, 5 },
                { 3, 10 },
                { 4, 15 },
                { 5, 25 },
                { 6, 30 },
                { 7, 35 }
            };
        }

        public decimal Get(int countOfUniqueBookSeries)
        {
            if (countOfUniqueBookSeries > 7)
            {
                return 35;
            }
            return countOfUniqueBookSeries < 2 ? 0 : Discounts[countOfUniqueBookSeries];
        }
    }
}
