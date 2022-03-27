using Proxy.Interfaces;

namespace Proxy.Models
{
    /// <summary>
    /// Real subject.
    /// </summary>
    public class Document : IDocument
    {
        public string? Title { get; private set; }
        public string? Content { get; private set; }
        public int AuthorId { get; private set; }
        public DateTimeOffset LastAccessed { get; private set; }
        public Document(string fileName) => LoadDocument(fileName);

        /// <summary>
        /// NOTE: This is meant to be an expensive operation.
        /// </summary>
        /// <param name="fileName"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void LoadDocument(string fileName)
        {
            Thread.Sleep(1000);

            Title = "DOCUMENT";
            Content = "Lorem ipsum.";
            AuthorId = 40;
            LastAccessed = DateTimeOffset.Now;
        }
        public string DisplayDocument() => $"{Title} {Content}";
    }
}
