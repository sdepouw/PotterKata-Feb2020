using System;
using PotterKata.Core;
using Xunit;

namespace PotterKata.Tests.BookSelectionTests
{
    public class Constructor
    {
        [Fact]
        public void ThrowsGivenNonDistinctBooks()
        {
            Action ctorCall = () => new BookSelection(1, 1, 2);
            Assert.Throws<InvalidOperationException>(ctorCall);
        }
    }
}