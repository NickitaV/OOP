using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_work1
{
    class ACoder : ICoder
    {
        private char[] _stroke;

        public ACoder(string stroke)
        {
            _stroke = stroke.ToCharArray();

        }
        public string Encode()
        {
            for (int i = 0; i < _stroke.Length; i++)
            {
                _stroke[i] = (char)(_stroke[i] + 1);
            }
            return string.Concat(_stroke);
        }


        public string Decode()
        {
            for (int i = 0; i < _stroke.Length; i++)
            {
                _stroke[i] = (char)(_stroke[i] - 1);
            }
            return string.Concat(_stroke);
        }




    }
}