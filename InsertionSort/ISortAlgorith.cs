using System.Collections.Generic;

namespace InsertionSort
{
    public enum SortDirection
    {
        Asc,
        Desc
    }

    public interface ISortAlgorith<T>
    {
        IEnumerable<T> SortAscending(T[] source);
        IEnumerable<T> SortDescending(T[] source);
    }
}