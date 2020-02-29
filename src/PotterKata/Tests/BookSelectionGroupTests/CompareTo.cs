using System;
using PotterKata.Core;
using Xunit;

namespace PotterKata.Tests.BookSelectionGroupTests
{
    public class CompareTo
    {
        private readonly BookSelectionGroup _groupWithNoCost = new BookSelectionGroup();
        private readonly BookSelectionGroup _groupWithSomeCost = new BookSelectionGroup(new DistinctBookSelection(1));

        [Fact]
        public void Returns1OnNullObject()
        {
            int result = _groupWithNoCost.CompareTo((BookSelectionGroup)null);
            Assert.Equal(1, result);
        }

        [Fact]
        public void ThrowsGivenNonGroupToCompareTo()
        {
            Action compareCall = () => _groupWithNoCost.CompareTo(5);
            Assert.Throws<ArgumentException>(compareCall);
        }

        [Fact]
        public void ReturnsNegative1GivenGroupWithHigherCost()
        {
            int result = _groupWithNoCost.CompareTo(_groupWithSomeCost);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void Returns0GivenGroupWithEqualCost()
        {
            int result = _groupWithNoCost.CompareTo(new BookSelectionGroup());
            Assert.Equal(0, result);
        }

        [Fact]
        public void Returns1GivenGroupWithLowerCost()
        {
            int result = _groupWithSomeCost.CompareTo(_groupWithNoCost);
            Assert.Equal(1, result);
        }
    }
}