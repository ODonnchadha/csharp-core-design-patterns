using Iterator.Collections;
using Iterator.Interfaces.Iterators;
using Iterator.Models;

namespace Iterator.Iterators
{
    public class PeopleIterator : IPeopleIterator
    {
        private PeopleCollection _collection;
        private int _index = 0;
        public PeopleIterator(PeopleCollection collection) => _collection = collection;
        public bool IsDone => _index >= _collection.Count;
        public Person CurrentItem => _collection.OrderBy(p => p.Name).ToList()[_index];
        public Person First()
        {
            _index = 0;

            return _collection.OrderBy(p => p.Name).ToList()[_index];
        }
        public Person Next()
        {
            _index++;

            if (IsDone.Equals(false))
            {
                return _collection.OrderBy(p => p.Name).ToList()[_index];
            }
            else
            {
#pragma warning disable CS8603 // Possible null reference return.
                return null;
#pragma warning restore CS8603 // Possible null reference return.
            }
        }
    }
}
