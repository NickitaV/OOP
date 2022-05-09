using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace File_Manager
{
    class Choice
    {
        public int ColorChoice(int num, int c, string[] DirArr)
        {

            if (num != c)
            {
                Console.WriteLine(DirArr[num]);

            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(DirArr[c]);
                Console.ResetColor();
            }
            return c;
        }
        public void СhoiceDir(string[] Dir, int c, out string N)
        {
            DirectoryInfo Dc = new DirectoryInfo(Dir[c]);


            if (Dir[c] == "......")
            {

                Console.Clear();


                FileInfo fInfo1 = new FileInfo(Dir[c + 1]);

                string Pdir = fInfo1.DirectoryName;
                FileInfo fInfo2 = new FileInfo(Pdir);
                string ParentDir = fInfo2.DirectoryName;


                N = @$"{ParentDir}";



            }
            else
            {
                if (Dc.GetDirectories().Length == 0)
                {
                    FileInfo fInfo = new FileInfo(Dir[c]);

                    string dir = fInfo.DirectoryName; Console.Clear(); N = @$"{dir}";
                    Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("В этой директории нет директорий!"); Console.ResetColor();
                }
                else { Console.Clear(); N = Dir[c]; }
            }





        }

    }
}
