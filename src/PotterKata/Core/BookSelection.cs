using System;
using System.Linq;

namespace PotterKata.Core
{
    public class BookSelection
    {
        private readonly int[] _books;

        public BookSelection(params int[] books) => _books = books;

        public decimal CalculateCost()
        {
            decimal discount;
            int distinctBookCount = _books.Distinct().Count();
            switch (distinctBookCount)
            {
                case 2:
                    discount = .05m;
                    break;
                case 3:
                    discount = .10m;
                    break;
                case 4:
                    discount = .15m;
                    break;
                case 5:
                    discount = .25m;
                    break;
                case 6:
                    discount = .30m;
                    break;
                case 7:
                    discount = .35m;
                    break;
                default:
                    discount = 1m;
                    break;
            }
            return 8m * _books.Length * discount;
        }
    }
}