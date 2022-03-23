using Composite.Models;
using NUnit.Framework;

namespace DesignPatterns.Structural
{
    public class CompositeShould
    {
        private Directory? root;
        private File f = null!;

        [SetUp()]
        public void SetUp()
        {
            f = new File("File", 5);
            root = new Directory("Root", 0);
        }

        [TearDown()]
        public void TearDown() { }

        [Test()]
        public void Build()
        {
            root?.Add(f);

            Directory directory = new Directory("Directory", 84);
            directory.Add(f);
            directory.Add(f);

            root?.Add(directory);

            Assert.AreEqual(directory.GetSize(), 94);
            Assert.AreEqual(root?.GetSize(), 99);
        }
    }
}
