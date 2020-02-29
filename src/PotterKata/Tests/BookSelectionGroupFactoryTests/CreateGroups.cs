using System.Linq;
using PotterKata.Core;
using Xunit;

namespace PotterKata.Tests.BookSelectionGroupFactoryTests
{
    public class CreateGroups
    {
        private readonly BookSelectionGroupFactory _factory = new BookSelectionGroupFactory();

        [Fact]
        public void ReturnsNoGroupsGivenNoBooks()
        {
            var groups = _factory.CreateGroups();

            Assert.NotNull(groups);
            Assert.Empty(groups);
        }

        [Fact]
        public void RetunsSingleGroupForSingleBook()
        {
            var groups = _factory.CreateGroups(1);
            Assert.Single(groups);
        }

        [Fact(Skip = "This is the hard part.")]
        public void Returns2GroupsFor3Books2Distinct()
        {
            var groups = _factory.CreateGroups(1, 2, 2);

            Assert.Equal(2, groups.Length);
        }
    }
}