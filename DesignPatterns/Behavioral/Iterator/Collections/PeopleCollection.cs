using Iterator.Interfaces.Collections;
using Iterator.Interfaces.Iterators;
using Iterator.Iterators;
using Iterator.Models;

namespace Iterator.Collections
{
    /// <summary>
    /// Concrete Aggregate.
    /// </summary>
    public class PeopleCollection : List<Person>, IPeopleCollection
    {
        public IPeopleIterator CreateIterator() => new PeopleIterator(this);
    }
}
