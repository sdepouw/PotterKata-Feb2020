using System;
using System.Linq;

namespace PotterKata.Core
{
    public class BookSelectionGroup : IComparable
    {
        private readonly DistinctBookSelection[] _selections;
        public DistinctBookSelection[] Selections => _selections;

        public BookSelectionGroup(params DistinctBookSelection[] selections) => _selections = selections;

        public decimal CalculateTotalCost() => Selections.Sum(selection => selection.CalculateCost());

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }
            if (!(obj is BookSelectionGroup))
            {
                throw new ArgumentException("Groups can only be compared to other Groups.", nameof(obj));
            }
            var myCost = CalculateTotalCost();
            var theirCost = ((BookSelectionGroup)obj).CalculateTotalCost();
            if (myCost < theirCost)
            {
                return -1;
            }
            else if (myCost > theirCost)
            {
                return 1;
            }
            return 0;
        }
    }
}