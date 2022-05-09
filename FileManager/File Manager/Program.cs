using System;
using System.IO;


namespace File_Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            ActionDir actionDir = new ActionDir();
            Choice choice = new Choice();
            bool ExitControl = true;
           
            Console.WriteLine("Введите название директории");
            string NewDir = @Console.ReadLine();
            while (ExitControl == true)
            {

                string[] Dir = actionDir.FoundDir(NewDir);
                actionDir.GoDir(Dir, out ConsoleKeyInfo key, out int c);
                if (key.Key == ConsoleKey.Backspace) { Console.Clear(); ExitControl = false; }
                NewDir = Dir[c];


                if (key.Key == ConsoleKey.Enter)
                {
                    choice.СhoiceDir(Dir, c, out string N);

                    NewDir = N;
                }




            }


        }
       


        
    }
}