using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_work1
{
    class BCoder : ICoder
    {
        private char[] _stroke;

        private readonly Dictionary<char, Tuple<int, int>> _letters = new Dictionary<char, Tuple<int, int>>();


        private const int _rus = 32;
        private const int _eng = 26;
        public BCoder(string stroke)
        {
            _stroke = stroke.ToCharArray();

            for (int i = 0; i < _rus; i++)
            {
                _letters.Add((char)(1072 + i), new Tuple<int, int>(1072, 1072 + _rus - 1));
                _letters.Add((char)(1040 + i), new Tuple<int, int>(1040, 1040 + _rus - 1));

                if (i < _eng)
                {
                    _letters.Add((char)(97 + i), new Tuple<int, int>(97, 97 + _eng - 1));
                    _letters.Add((char)(65 + i), new Tuple<int, int>(65, 65 + _eng - 1));
                }
            }
        }

        public string Encode()
        {
            for (int i = 0; i < _stroke.Length; i++)
            {
                if (_letters.ContainsKey(_stroke[i]))
                {
                    var sym = _letters[_stroke[i]];
                    _stroke[i] = (char)(sym.Item2 - (_stroke[i] - sym.Item1));
                }
                else
                {
                    _stroke[i] = _stroke[i];
                }
            }
            return string.Concat(_stroke);
        }
        public string Decode()
        {

            for (int i = 0; i < _stroke.Length; i++)
            {
                if (_letters.ContainsKey(_stroke[i]))
                {
                    var sym = _letters[_stroke[i]];
                    _stroke[i] = (char)(sym.Item2 - (_stroke[i] - sym.Item1));
                }
                else
                {
                    _stroke[i] = _stroke[i];
                }

            }
            return string.Concat(_stroke);
        }


    }
}
