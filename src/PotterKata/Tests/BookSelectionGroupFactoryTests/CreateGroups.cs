using System.Linq;
using PotterKata.Core;
using Xunit;

namespace PotterKata.Tests.BookSelectionGroupFactoryTests
{
    public class CreateGroups
    {
        private readonly BookSelectionGroupOptimizer _factory = new BookSelectionGroupOptimizer();

        [Fact]
        public void ReturnsNoGroupGivenNoBooks()
        {
            var group = _factory.FindCheapestGroup();

            Assert.Null(group);
        }

        [Fact]
        public void RetunsSingleGroupForSingleBook()
        {
            var group = _factory.FindCheapestGroup(1);
            Assert.NotNull(group);
        }

        [Fact(Skip = "The hard part.")]
        public void ReturnsGroupWithDiscountedSelection()
        {
            var group = _factory.FindCheapestGroup(1, 2, 2);

            Assert.Equal(2, group.Selections.Count());
        }
    }
}