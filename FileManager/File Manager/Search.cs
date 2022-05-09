using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace File_Manager
{
    public class Search
    {
        public void SearchFile()
        {
            Console.WriteLine("Введите название директории для поиска");
            string catalog = Console.ReadLine();
            Console.WriteLine("Введите маску для поиска(например *.txt или c*)");
            string mask = Console.ReadLine();
            GetFiles();
            void GetFiles()
            {

                string[] files = Directory.GetFiles(@$"{catalog}", $"{mask}");
                Console.WriteLine("Всего файлов по заданной маске {0}.", files.Length);
                foreach (string f in files)
                {
                    Console.WriteLine(f);
                }
            }



            GetDirs();

            void GetDirs()
            {

                string[] dirs = Directory.GetDirectories(@$"{catalog}", $"{mask}");
                Console.WriteLine("Всего каталогов по заданной маске: {0}", dirs.Length);

                foreach (string d in dirs)
                {
                    Console.WriteLine(d);
                }
            }

   
        }
    }
}
