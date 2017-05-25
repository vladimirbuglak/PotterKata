using System.Collections.Generic;
using PotterKata.BusinessLogic.Models;

namespace PotterKata.BusinessLogic
{
    public class Basket
    {
        private readonly List<Book> _books;

        public Basket(List<Book> books)
        {
            _books = books;
        }

        public void Add(List<Book> books)
        {
            _books.AddRange(books);
        }

        public void Clear()
        {
            _books.Clear();
        }

        public List<Book> GetBooks()
        {
            return _books;
        }
    }
}
