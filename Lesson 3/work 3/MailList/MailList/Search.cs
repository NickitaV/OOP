using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailList
{
    class Search
    {

        public string SearchMail(ref string s)
        {

            string[] newStr = s.Split(new char[] { '&' });
            s = newStr[1];
            return s;
        }

    }
}
