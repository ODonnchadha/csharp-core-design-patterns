namespace ChainOfResponsibility.Models
{
    public class Document
    {
        public string Title { get; set; }
        public DateTimeOffset LastModified { get; set; }
        public bool ApprovedByLitigation { get; set; }
        public bool ApprovedByManagement { get; set; }

        public Document(
            string title, 
            DateTimeOffset lastModified, 
            bool litigation, 
            bool management)
        {
            Title = title;
            LastModified = lastModified;
            ApprovedByLitigation = litigation;
            ApprovedByManagement = management;
        }
    }
}
