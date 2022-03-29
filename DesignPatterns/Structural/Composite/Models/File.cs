using Composite.Abstractions;

namespace Composite.Models
{
    /// <summary>
    /// Leaf.
    /// </summary>
    public class File : FileSystemItem
    {
        private long _size;
        public File(string name, long size) : base(name) => _size = size;
        public override long GetSize() => _size;
    }
}
