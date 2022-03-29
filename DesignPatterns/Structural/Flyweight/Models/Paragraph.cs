using Flyweight.Interfaces.Flyweights;

namespace Flyweight.Models
{
    public class Paragraph : ICharacter
    {
        private int _location;
        private List<ICharacter> _characters = new();

        public Paragraph(List<ICharacter> characters, int location)
        {
            _location = location;
            _characters = characters;
        }

        public void Draw(string family, int size)
        {
            foreach(var c in _characters)
            {
                c.Draw(family, size);
            }
        }
    }
}
