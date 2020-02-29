using System;

namespace PotterKata.Core
{
    public class BookSelection
    {
        private readonly int[] _books;

        public BookSelection(params int[] books) => _books = books;

        public double CalculateCost()
        {
            throw new NotImplementedException();
        }
    }
}