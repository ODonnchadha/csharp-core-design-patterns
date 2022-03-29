namespace Composite.Abstractions
{
    /// <summary>
    /// Component.
    /// </summary>
    public abstract class FileSystemItem
    {
        public string Name { get; private set; }
        public FileSystemItem(string name) => Name = name;
        public abstract long GetSize();

    }
}
