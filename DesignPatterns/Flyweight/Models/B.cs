using Flyweight.Interfaces.Flyweights;

namespace Flyweight.Models
{
    /// <summary>
    /// Concrete flyweight.
    /// </summary>
    public class B : ICharacter
    {
        private char _character = 'b';
        private string _family = string.Empty;
        private int _size;
        public void Draw(string family, int size)
        {
            _family = family;
            _size = size;
        }
    }
}
