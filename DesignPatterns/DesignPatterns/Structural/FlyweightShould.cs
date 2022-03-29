using Flyweight.Factories;
using Flyweight.Interfaces.Flyweights;
using NUnit.Framework;
using System.Collections.Generic;

namespace DesignPatterns.Structural
{
    public class FlyweightShould
    {
        private CharacterFactory? factory;

        [SetUp()]
        public void SetUp() => factory = new CharacterFactory { };

        [TearDown()]
        public void TearDown() => factory = null;

        [Test()]
        public void Flyweight()
        {
            string[] array = { "a", "b", "a", "b", "a", "b" };

            char[] characters = new char[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                characters[i] = char.Parse(array[i]);
            }

            List<ICharacter> flyweights = new();
            int objCreationCount = 0;
            foreach (char c in characters)
            {
                var obj = factory?.Get(c, out objCreationCount);
                obj?.Draw("Arial", 12);

#pragma warning disable CS8604 // Possible null reference argument.
                flyweights.Add(obj);
#pragma warning restore CS8604 // Possible null reference argument.
            }

            Assert.AreEqual(objCreationCount, 2);

            var paragraph = factory?.GetParagraph(flyweights, 0);
            paragraph?.Draw("Comic Sans", 12);
        }
    }
}
