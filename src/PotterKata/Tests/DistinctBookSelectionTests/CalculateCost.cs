using System.Linq;
using PotterKata.Core;
using Xunit;

namespace PotterKata.Tests.DistinctBookSelectionTests
{
    public class CalculateCost
    {
        private void Test(decimal expected, params int[] books) => Assert.Equal(expected, new DistinctBookSelection(books).CalculateCost());

        private void TestDiscount(decimal expectedDiscount, int numberOfDistinctBooks)
        {
            int[] books = Enumerable.Range(1, numberOfDistinctBooks).ToArray();
            decimal rawCost = 8m * numberOfDistinctBooks;
            decimal expected = (rawCost) - (rawCost * expectedDiscount);
            Test(expected, books);
        }

        [Fact]
        public void Is0WhenNoBooksSelected() => Test(0m);

        [Fact]
        public void Be8ForSingleBook() => Test(8m, 1);

        [Fact]
        public void Give5PercentOffForTwoDistinct() => TestDiscount(.05m, 2);

        [Fact]
        public void Give10PercentOffForThreeDistinct() => TestDiscount(.10m, 3);

        [Fact]
        public void Give15PercentOffForTwoDistinct() => TestDiscount(.15m, 4);

        [Fact]
        public void Give25PercentOffForTwoDistinct() => TestDiscount(.25m, 5);

        [Fact]
        public void Give30PercentOffForTwoDistinct() => TestDiscount(.30m, 6);

        [Fact]
        public void Give35PercentOffForTwoDistinct() => TestDiscount(.35m, 7);
    }
}