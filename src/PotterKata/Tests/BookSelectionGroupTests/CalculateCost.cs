using System.Linq;
using PotterKata.Core;
using Xunit;

namespace PotterKata.Tests.BookSelectionGroupTests
{
    public class CalculateCost
    {
        [Fact]
        public void Returns0GivenNoSelections()
        {
            BookSelectionGroup group = new BookSelectionGroup();

            Assert.Equal(0m, group.CalculateTotalCost());
        }

        [Fact]
        public void MatchesSingleSelectionCost()
        {
            DistinctBookSelection selection = new DistinctBookSelection(1, 2, 3);
            decimal expectedCost = selection.CalculateCost();
            BookSelectionGroup group = new BookSelectionGroup(selection);

            Assert.Equal(expectedCost, group.CalculateTotalCost());
        }

        [Fact]
        public void TallySelectionCosts()
        {
            var selection = new[]
            {
                new DistinctBookSelection(1, 2),
                new DistinctBookSelection(2, 3),
                new DistinctBookSelection(3, 4)
            };
            decimal expectedCost = selection.Sum(selection => selection.CalculateCost());

            BookSelectionGroup group = new BookSelectionGroup(selection);

            Assert.Equal(expectedCost, group.CalculateTotalCost());
        }
    }
}