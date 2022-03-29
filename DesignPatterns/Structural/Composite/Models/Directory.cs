using Composite.Abstractions;

namespace Composite.Models
{
    /// <summary>
    /// Composite.
    /// </summary>
    public class Directory : FileSystemItem
    {
        private List<FileSystemItem> _items = new List<FileSystemItem>();
        private long _size;
        public Directory(string name, long size) : base(name) => _size = size;
        public override long GetSize()
        {
            var tree = _size;

            _items.ForEach(i => tree += i.GetSize());

            return tree;
        }
        public void Add(FileSystemItem item) => _items.Add(item);
        public void Remove(FileSystemItem item) => _items.Remove(item);
    }
}
