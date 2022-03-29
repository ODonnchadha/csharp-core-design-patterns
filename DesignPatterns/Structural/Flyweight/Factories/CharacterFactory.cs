using Flyweight.Interfaces.Flyweights;
using Flyweight.Models;

namespace Flyweight.Factories
{
    /// <summary>
    /// Flyweight factory.
    /// </summary>
    public class CharacterFactory
    {
        private int _count = 0;
        private readonly Dictionary<char, ICharacter> 
            _characters = new();

        public ICharacter? Get(char character, out int count)
        {
            count = _count;

            if (_characters.ContainsKey(character))
            {
                return _characters[character];
            }

            switch(character)
            {
                case 'a':
                    _characters[character] = new A { };
                    _count++;
                    return _characters[character];
                case 'b':
                    _characters[character] = new B { };
                    _count++;
                    return _characters[character];
            }

            return null;
        }

        public ICharacter? GetParagraph(List<ICharacter> characters, int location) 
            => new Paragraph(characters, location);
    }
}
