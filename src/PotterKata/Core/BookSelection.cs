using System;

namespace PotterKata.Core
{
    public class BookSelection
    {
        private readonly int[] _books;

        public BookSelection(params int[] books) => _books = books;

        public decimal CalculateCost()
        {
            throw new NotImplementedException();
        }
    }
}