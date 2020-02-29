using System;

namespace PotterKata.Core
{
    public class BookSelectionGroup
    {
        private readonly DistinctBookSelection[] _selections;

        public BookSelectionGroup(params DistinctBookSelection[] selections) => _selections = selections;

        public decimal CalculateTotalCost()
        {
            throw new NotImplementedException();
        }
    }
}