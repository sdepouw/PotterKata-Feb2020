using System;

namespace PotterKata.Core
{
    public class BookSelectionGroup
    {
        private readonly BookSelection[] _selections;

        public BookSelectionGroup(params BookSelection[] selections) => _selections = selections;

        public decimal CalculateTotalCost()
        {
            throw new NotImplementedException();
        }
    }
}