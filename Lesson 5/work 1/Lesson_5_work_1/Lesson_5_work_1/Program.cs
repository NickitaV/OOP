using System;

namespace Lesson_5_work_1
{
    class Program
    {
        static void Main(string[] args)
        {
            RationalNumbers rationalNumbers1 = new RationalNumbers(1,2);
            Console.WriteLine("Первое число:"+rationalNumbers1.ToString());
            RationalNumbers rationalNumbers2 = new RationalNumbers(3, 4);
            Console.WriteLine("Второе число:"+rationalNumbers2.ToString());
            RationalNumbers plus = rationalNumbers1 + rationalNumbers2;
            Console.WriteLine(plus.ToString());
            RationalNumbers minus = rationalNumbers1 - rationalNumbers2;
            Console.WriteLine(minus.ToString());
            RationalNumbers proizvedeniye = rationalNumbers1 * rationalNumbers2;
            Console.WriteLine(proizvedeniye.ToString());
          
            Console.WriteLine(rationalNumbers1.Equals(rationalNumbers1));
            Console.WriteLine(rationalNumbers1.Equals(rationalNumbers2));
        }
    }
}
