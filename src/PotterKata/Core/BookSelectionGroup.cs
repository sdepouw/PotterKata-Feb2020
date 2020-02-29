using System.Linq;

namespace PotterKata.Core
{
    public class BookSelectionGroup
    {
        private readonly DistinctBookSelection[] _selections;

        public BookSelectionGroup(params DistinctBookSelection[] selections) => _selections = selections;

        public decimal CalculateTotalCost() => _selections.Sum(selection => selection.CalculateCost());
    }
}