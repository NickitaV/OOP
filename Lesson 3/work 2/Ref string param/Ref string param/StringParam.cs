using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref_string_param
{
    class StringParam
    {
        public string StringNew(ref string Hello)
        {
            char[] HelloNew = new char[Hello.Length];
            int j = 0;
            for (int i = Hello.Length - 1; i >= 0; i--)
            {
                HelloNew[j] = Hello[i];
                j++;
            }


            string HelloReturn = new string(HelloNew);
            return HelloReturn;
        }

    }
}
