using System;

namespace MailList
{
    class Program
    {
        static void Main(string[] args)
        {
            Search search = new Search();
            string stroke1 = "Кучма Андрей Витальевич & Kuchma@mail.ru";
            string stroke2 = "Мизинцев Павел Николаевич & Pasha@mail.ru";
            Console.WriteLine($"1. { search.SearchMail(ref stroke1)}\n2. { search.SearchMail(ref stroke2)}\n");
        }
    }
}
