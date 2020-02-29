namespace PotterKata.Core
{
    public class BookSelectionGroupFactory
    {
        public BookSelectionGroup[] CreateGroups(params int[] selectedBooks)
        {
            if (selectedBooks.Length == 0)
            {
                return new BookSelectionGroup[0];
            }

            // TODO: Take in all the books that are desired for purchase, and create every possible grouping collection.
            // E.g. if [1, 2, 2] is given, the result should be:
            // [ [1], [2], [2] ]
            // [ [1, 2], [2] ]
            return new[]
            {
                new BookSelectionGroup(new DistinctBookSelection(selectedBooks))
            };
        }
    }
}
