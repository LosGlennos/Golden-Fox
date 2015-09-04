using System.Collections.Generic;
using System.Linq;

namespace GoldenFox.Parsing
{
    public class PartsTraverser
    {
        private List<string> _parts;

        public PartsTraverser(List<string> parts)
        {
            _parts = parts;
        }

        public string NextPart()
        {
            if (!_parts.Any())
            {
                return null;
            }

            var n = _parts.First();
            _parts = _parts.Skip(1).ToList();
            return n;
        }

        public PartsTraverser Skip(string expected)
        {
            if (_parts.First() != expected)
            {
                throw new ParsingException("Golden fox did not expect \"" + _parts.First() + "\" to show up here");
            }

            _parts = _parts.Skip(1).ToList();
            return this;
        }

        public string Peek()
        {
            return _parts.First();
        }

        public bool Peek(string expected)
        {
            return expected == Peek();
        }

        public bool SkipIf(string expected)
        {
            if (Peek() == expected)
            {
                Skip(expected);
                return true;
            }

            return false;
        }

        public bool NextIf(string expected)
        {
            if (Peek() == expected)
            {
                NextPart();
                return true;
            }

            return false;
        }
    }
}