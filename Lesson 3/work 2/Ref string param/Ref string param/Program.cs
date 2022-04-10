using System;

namespace Ref_string_param
{
    class Program
    {
        static void Main(string[] args)
        {
            StringParam stringParam = new StringParam();
            string Hello = "Hello World!";
            Console.Write(stringParam.StringNew(ref Hello));


        }
    }
}
