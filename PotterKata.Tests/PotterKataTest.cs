using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotterKata.BusinessLogic;
using PotterKata.BusinessLogic.Models;
using PotterKata.BusinessLogic.Services;

namespace PotterKata.Tests
{
    [TestClass]
    public class PotterKataTest
    {
        [TestMethod]
        public void Test_10_Books_With_6_Discount_Book()
        {
            var basket = new Basket(new List<Book>
            {
                new Book { Serie = 1 },
                new Book { Serie = 2 },
                new Book { Serie = 2 },
                new Book { Serie = 3 },
                new Book { Serie = 3 },
                new Book { Serie = 4 },
                new Book { Serie = 4 },
                new Book { Serie = 5 },
                new Book { Serie = 5 },
                new Book { Serie = 6 }
            });

            var priceCalculator = new PriceCalculator(new DiscountInformation());
            Assert.AreEqual(65.6m, priceCalculator.Calculate(basket.GetBooks()));
        }

        [TestMethod]
        public void Test_20_Books_With_6_Discount_Book()
        {
            var basket = new Basket(new List<Book>
            {
                new Book { Serie = 1 },
                new Book { Serie = 2 },
                new Book { Serie = 2 },
                new Book { Serie = 3 },
                new Book { Serie = 3 },
                new Book { Serie = 4 },
                new Book { Serie = 4 },
                new Book { Serie = 5 },
                new Book { Serie = 5 },
                new Book { Serie = 6 },

                new Book { Serie = 1 },
                new Book { Serie = 2 },
                new Book { Serie = 2 },
                new Book { Serie = 3 },
                new Book { Serie = 3 },
                new Book { Serie = 4 },
                new Book { Serie = 4 },
                new Book { Serie = 5 },
                new Book { Serie = 5 },
                new Book { Serie = 6 }
            });

            var priceCalculator = new PriceCalculator(new DiscountInformation());
            Assert.AreEqual(145.6m, priceCalculator.Calculate(basket.GetBooks()));
        }

        [TestMethod]
        public void Test_2_Books_With_2_Discount_Book()
        {
            var basket = new Basket(new List<Book>
            {
                new Book {Serie = 1},
                new Book {Serie = 2}
            });

            var priceCalculator = new PriceCalculator(new DiscountInformation());
            Assert.AreEqual(15.2m, priceCalculator.Calculate(basket.GetBooks()));
        }

        [TestMethod]
        public void Test_Empty_List_Of_Books()
        {
            var basket = new Basket(new List<Book> { });

            var priceCalculator = new PriceCalculator(new DiscountInformation());
            Assert.AreEqual(0m, priceCalculator.Calculate(basket.GetBooks()));
        }

        [TestMethod]
        public void Test_7_Books_With_7_Discount_Books()
        {
            var basket = new Basket(new List<Book>
            {
                new Book { Serie = 1 },
                new Book { Serie = 2 },
                new Book { Serie = 3 },
                new Book { Serie = 4 },
                new Book { Serie = 5 },
                new Book { Serie = 6 },
                new Book { Serie = 7 }
            });

            var priceCalculator = new PriceCalculator(new DiscountInformation());
            Assert.AreEqual(36.4m, priceCalculator.Calculate(basket.GetBooks()));
        }

        [TestMethod]
        public void Test_2_Books_With_Same_Serie()
        {
            var basket = new Basket(new List<Book>
            {
                new Book { Serie = 1 },
                new Book { Serie = 1 }
            });

            var priceCalculator = new PriceCalculator(new DiscountInformation());
            Assert.AreEqual(16m, priceCalculator.Calculate(basket.GetBooks()));
        }

        [TestMethod]
        public void Test_3_Books_With_Same_Serie()
        {
            var basket = new Basket(new List<Book>
            {
                new Book { Serie = 1 },
                new Book { Serie = 1 },
                new Book { Serie = 1 }
            });

            var priceCalculator = new PriceCalculator(new DiscountInformation());
            Assert.AreEqual(24m, priceCalculator.Calculate(basket.GetBooks()));
        }

        [TestMethod]
        public void Test_10_Books_With_4_Discount_Book()
        {
            var basket = new Basket(new List<Book>
            {
                new Book { Serie = 1 },
                new Book { Serie = 1 },
                new Book { Serie = 1 },

                new Book { Serie = 2 },
                new Book { Serie = 2 },
                new Book { Serie = 2 },

                new Book { Serie = 3 },
                new Book { Serie = 3 },
                new Book { Serie = 3 },

                new Book { Serie = 4 },
            });

            var priceCalculator = new PriceCalculator(new DiscountInformation());
            Assert.AreEqual(75.2m, priceCalculator.Calculate(basket.GetBooks()));
        }

        [TestMethod]
        public void Test_14_Books_With_7_Discount_Book()
        {
            var basket = new Basket(new List<Book>
            {
                new Book { Serie = 1 },
                new Book { Serie = 2 },
                new Book { Serie = 3 },
                new Book { Serie = 4 },
                new Book { Serie = 5 },
                new Book { Serie = 6 },
                new Book { Serie = 7 },

                new Book { Serie = 1 },
                new Book { Serie = 2 },
                new Book { Serie = 3 },
                new Book { Serie = 4 },
                new Book { Serie = 5 },
                new Book { Serie = 6 },
                new Book { Serie = 7 }
            });

            var priceCalculator = new PriceCalculator(new DiscountInformation());
            Assert.AreEqual(92.4m, priceCalculator.Calculate(basket.GetBooks()));
        }

        [TestMethod]
        public void Test_10_Books_With_2_Discount_Book()
        {
            var basket = new Basket(new List<Book>
            {
                new Book { Serie = 1 },
                new Book { Serie = 1 },
                new Book { Serie = 1 },
                new Book { Serie = 1 },
                new Book { Serie = 1 },
                new Book { Serie = 1 },
                new Book { Serie = 1 },
                new Book { Serie = 1 },
                new Book { Serie = 1 },

                new Book { Serie = 4 },
            });

            var priceCalculator = new PriceCalculator(new DiscountInformation());
            Assert.AreEqual(79.2m, priceCalculator.Calculate(basket.GetBooks()));
        }
    }
}
