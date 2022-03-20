namespace Prototype.Abstractions.Models
{
    public abstract class Person
    {
        public abstract string Name { get; set; }
        public abstract Person Clone(bool isDeepCopy);
        //{
        //    if (isDeepCopy)
        //    {
        //        //var formatter = new BinaryFormatter { };
        //        //using (var stream = new MemoryStream())
        //        //{
        //        //    formatter.Serialize(stream, this);
        //        //    stream.Seek(0, SeekOrigin.Begin);
        //        //    return (Person)formatter.Deserialize(stream);
        //        //}
        //    }
        //    return (Person)MemberwiseClone();
        //}
    }
}
