using System;
using System.Linq;

namespace PotterKata.Core
{
    public class DistinctBookSelection
    {
        private readonly int[] _books;

        public DistinctBookSelection(params int[] books)
        {
            if (books.Distinct().Count() != books.Count())
            {
                throw new InvalidOperationException("Distinct collection of books required.");
            }
            _books = books;
        }

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
                    discount = 0m;
                    break;
            }
            decimal rawCost = 8m * _books.Length;
            decimal discountCost = rawCost * discount;
            return rawCost - discountCost;
        }
    }
}