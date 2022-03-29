using Flyweight.Interfaces.Flyweights;

namespace Flyweight.Models
{
    /// <summary>
    /// Concrete flyweight.
    /// </summary>
    public class A : ICharacter
    {
        // NOTE: Intrisic state.
        private char _character = 'a';
        // NOTE: Extrinsic state.
        private string _family = string.Empty;
        private int _size;
        public void Draw(string family, int size)
        {
            _family = family;
            _size = size;
        }
    }
}
