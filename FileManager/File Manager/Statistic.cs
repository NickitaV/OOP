using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace File_Manager
{
    class Statistic
    {
        public void StaticticTextWord(string[] FArr, int Index)
        {

            var text = File.ReadAllText(@$"{FArr[Index]}");
            int countWords = 0, countLetters = 0;



            for (int i = 0; i < text.Length; i++)
            {
                if (isLetter(text[i]))
                {
                    countLetters++;
                }
                else
                {
                    if (countLetters > 0)
                    {
                        countWords++;
                        countLetters = 0;
                    }
                }
            }

            Console.WriteLine("Количество слов: " + countWords);


        }

        private static bool isLetter(char x)
        {
            if (x >= 'a' && x <= 'z')
            {
                return true;
            }

            if (x >= 'A' && x <= 'Z')
            {
                return true;
            }

            if (x >= 'а' && x <= 'я')
            {
                return true;
            }
            if (x >= 'А' && x <= 'Я')
            {
                return true;
            }
            return false;
        }



        public void StatisticTextStroke(string[] FArr, int Index)
        {
            var str = File.ReadLines(@$"{FArr[Index]}").Count();
            Console.WriteLine("Количество строк: " + str);
        }

        public void StatisticTextSymvol(string[] FArr, int Index)
        {
            string text = File.ReadAllText(@$"{FArr[Index]}");

            Console.WriteLine("Количество символов без пробелов: " + text.Replace(" ", "").Length);

        }


    }
}
