using System.Collections.Generic;
using PotterKata.Core;
using Xunit;

namespace PotterKata.Tests
{
    public class AcceptanceTest
    {
        [Fact(Skip = "Make the code work first. :)")]
        public void KataExampleCase()
        {
            const decimal expectedTotalCost = 60m;
            List<BookSelectionGroup> groups = new BookSelectionGroupFactory().CreateGroups(1, 2, 2, 3, 3, 4, 4, 5, 5, 6);
            BookSelectionGroup optimalGroup = new DiscountOptimizer().SelectOptimalGroup(groups);

            decimal totalCost = optimalGroup.CalculateTotalCost();

            Assert.Equal(expectedTotalCost, totalCost);
        }
    }
}