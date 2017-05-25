using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotterKata.BusinessLogic.Models;
using PotterKata.BusinessLogic.Services;

namespace PotterKata.Tests
{
    [TestClass]
    public class PotterKataTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var books = new List<Book>(new List<Book>
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

            var priceCalculator = new PriceCalculator();
            Assert.AreEqual(65.6m, priceCalculator.Calculate(books));
        }
    }
}
