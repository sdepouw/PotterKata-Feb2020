using System.Collections.Generic;
using System.Linq;

namespace PotterKata.Core
{
    public class BookSelectionGroupOptimizer
    {
        // TODO: Take in all the books that are desired for purchase, and create every possible grouping collection.
        // E.g. if [1, 2, 2] is given, the result should be:
        // [ [1], [2], [2] ]
        // [ [1, 2], [2] ]
        public BookSelectionGroup FindCheapestGroup(params int[] books)
        {
            if (books.Length == 0)
            {
                return null;
            }

            List<BookSelectionGroup> groups = new List<BookSelectionGroup>();


            // Individual case.
            groups.Add(new BookSelectionGroup(books.Select(b => new DistinctBookSelection(b)).ToArray()));

            return groups.Min();
        }
    }
}
