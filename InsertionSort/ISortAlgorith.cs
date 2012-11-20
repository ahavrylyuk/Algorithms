using System.Collections.Generic;

namespace InsertionSort
{
    public interface ISortAlgorith<T>
    {
        IEnumerable<T> Sort(T[] source);
        IEnumerable<T> SortInplace(T[] source);
    }
}