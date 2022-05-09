using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace File_Manager
{

    class ActionDir : Command
    {
        Search search = new Search();
        Statistic stat = new Statistic();

        Choice choice = new Choice();
        public string[] FoundDir(string NewDir)
        {

            string[] Arr = Directory.GetDirectories(NewDir);

            string[] DirArr = new string[Arr.Length + 1];
            for (int n = 0; n < Arr.Length; n++) { DirArr[n + 1] = Arr[n]; }

            DirArr[0] = "......";

            return DirArr;
        }



        public void GoDir(string[] DirArr, out ConsoleKeyInfo key, out int c)
        {
            c = 0;
            int Index = 0;
            int page = 0;
            int Fpage = 0;
            do
            {


                Console.WriteLine("[Tab] - стр. файлов, [Стрелки вправ, влево] - стр. директории, [Space] - пред./след. файл, \n[Стрелки вверх, вниз] - след./пред. директория, [Escape] - ввод команды, [Enter] - выбор директории");
                Console.WriteLine("============================== Directories ============================== [Backspace] - выход, [I] - стат. о текст. файле,[S]- поиск по маске");
                for (int i = page * 20; (i < (20 + (page * 20))) && (i < DirArr.Length); i++)
                {
                    c = choice.ColorChoice(i, c, DirArr);

                }
                string[] FArr = Directory.GetFiles(DirArr[c]);
                Console.WriteLine("========Files======[Esc] - ввести команду([cp]-копировать файл/дир.[rm]-удалить файл/дир.[crm]-создать файл/дир.[info]-инфо.[attrib]-поменять атрибуты файла");

                for (int i = Fpage * 8; (i < (8 + (Fpage * 8))) && (i < FArr.Length); i++) { Index = choice.ColorChoice(i, Index, FArr); }


                key = Console.ReadKey();

                if (key.Key == ConsoleKey.Tab)
                {


                    Console.Clear(); if ((Fpage * 8) < FArr.Length) { Fpage++; Index = Index + 8 * Fpage; } else { Fpage = 0; }
                }
                if (key.Key == ConsoleKey.Spacebar)
                {
                    Console.Clear();

                    Index++;
                    if ((Index > (8 * Fpage + 7)) || (Index > (FArr.Length - 1))) { Index = Fpage * 8; }
                }

                if (key.Key == ConsoleKey.RightArrow)
                {
                    c = c + 20;
                    page++; if ((page * 20) > DirArr.Length) { page = 0; c = 0; }

                    Console.Clear();

                }

                if (key.Key == ConsoleKey.LeftArrow)
                {
                    c = c - 20;
                    page--; if (page < 0) { page = 0; c = 0; }

                    Console.Clear();
                }

                if (key.Key == ConsoleKey.DownArrow)
                {
                    Console.Clear();
                    c++;
                    if ((c > 20 * page + 19) || (c > DirArr.Length - 1)) { c = page * 20; }

                }
                if (key.Key == ConsoleKey.UpArrow)
                {
                    Console.Clear();
                    c--; if (c < page * 20) { if ((page * 20 + 20) > (DirArr.Length - 1)) { c = (DirArr.Length - 1); } else { c = page * 20 + 19; } }

                }
                if (key.Key == ConsoleKey.Escape)
                {
                    KeyCommand(FArr, DirArr, Index, c);
                }
                if (key.Key == ConsoleKey.I)
                {
                    stat.StaticticTextWord(FArr, Index);
                    stat.StatisticTextStroke(FArr, Index);
                    stat.StatisticTextSymvol(FArr, Index);
                }
                if (key.Key == ConsoleKey.S)
                {

                    search.SearchFile();

                }

            } while ((key.Key != ConsoleKey.Enter) && (key.Key != ConsoleKey.Backspace));









        }

    }
}
