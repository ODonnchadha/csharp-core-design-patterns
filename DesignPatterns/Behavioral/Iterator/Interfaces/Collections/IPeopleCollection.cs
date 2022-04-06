using Iterator.Interfaces.Iterators;

namespace Iterator.Interfaces.Collections
{
    /// <summary>
    /// Aggregate.
    /// </summary>
    public interface IPeopleCollection
    {
        IPeopleIterator CreateIterator();
    }
}
