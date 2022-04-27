using System;

namespace Lesson8_work1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любую строку");
            string newStroke = Console.ReadLine();
            ACoder aCoder = new ACoder(newStroke);
            Console.WriteLine(aCoder.Encode());
            Console.WriteLine(aCoder.Decode());
            BCoder bCoder = new BCoder(newStroke);
            Console.WriteLine(bCoder.Encode());
            Console.WriteLine(bCoder.Decode());


        }
    }
}
