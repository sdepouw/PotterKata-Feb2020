using System;
using PotterKata.Core;
using Xunit;

namespace PotterKata.Tests.DistinctBookSelectionTests
{
    public class Constructor
    {
        [Fact]
        public void ThrowsGivenNonDistinctBooks()
        {
            Action ctorCall = () => new DistinctBookSelection(1, 1, 2);
            Assert.Throws<InvalidOperationException>(ctorCall);
        }
    }
}