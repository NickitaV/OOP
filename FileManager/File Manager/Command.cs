using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace File_Manager
{
      class Command:Attribut
    {
        protected void KeyCommand(string[] FArr, string[] DirArr,int Index, int c)
        {
            Console.WriteLine("==================Введите команду:");
            string command = Console.ReadLine();
            switch (command)
            {

                case "cp":
                    Console.WriteLine("Копировать файл или директорию?(f-если файл, d-если директорию)");
                    string Str = Console.ReadLine();
                    if (((Str != "f") && (Str != "d")) || (string.IsNullOrEmpty(Str))) { Console.WriteLine("Введите f или d"); break; }
                    else
                    {

                        if (Str == "f")
                        {
                            try
                            {
                                string from = @$"{FArr[Index]}";
                                Console.WriteLine($"Сейчас файл в директории {DirArr[c]}.\nВведите новую директорию для файла {Path.GetFileName(FArr[Index])}");
                                string readAdress = Console.ReadLine(); string newAdress = @$"{readAdress}/{Path.GetFileName(FArr[Index])}";
                                File.Copy(from, newAdress, true); break;
                            }
                            catch (FileNotFoundException) { }
                            catch (UnauthorizedAccessException) { }
                        }
                        if (Str == "d")
                        {
                            try
                            {
                                Console.WriteLine($"Введите новую директорию для копирования {DirArr[c]}");
                                string oldAdresDir = DirArr[c];
                                string newAdressDir = Console.ReadLine();
                                static void RecursCopyDir(string oldAdresDir, string newAdressDir)
                                {

                                    DirectoryInfo CopyDir = new DirectoryInfo(oldAdresDir);
                                    foreach (DirectoryInfo copydir in CopyDir.GetDirectories())
                                    {
                                        if (Directory.Exists($"{newAdressDir}/{copydir.Name}") != true)
                                        {
                                            Directory.CreateDirectory($"{newAdressDir}/{copydir.Name}");
                                        }
                                        RecursCopyDir(copydir.FullName, $"{newAdressDir}/{copydir.Name}");
                                    }
                                    foreach (string copyfile in Directory.GetFiles(oldAdresDir))
                                    {
                                        string newNewAdress = @$"{newAdressDir}/{Path.GetFileName(copyfile)}";
                                        File.Copy(copyfile, newNewAdress, true);
                                    }
                                }

                                RecursCopyDir(oldAdresDir, newAdressDir);
                            }
                            catch (DirectoryNotFoundException) { }
                            catch (UnauthorizedAccessException) { }
                        }

                        break;
                    }

                case "crm":
                    Console.WriteLine("Создать файл или директорию?(f-если файл, d-если директорию)");
                    string StrCreate = Console.ReadLine();
                    if (((StrCreate != "f") && (StrCreate != "d")) || (string.IsNullOrEmpty(StrCreate))) { Console.WriteLine("Введите f или d"); break; }
                    else
                    {

                        if (StrCreate == "f")
                        {
                            try
                            {
                                Console.WriteLine($"Введите директорию для создания файла");

                                string AdressFDir =  DirArr[c];
                                Console.WriteLine($"Введите имя файла");
                                string nameFDir = Console.ReadLine();
                                CreateDir(AdressFDir, nameFDir);
                                static void CreateDir(string AdressFDir, string nameFDir)
                                {


                                    if (Directory.Exists($"{AdressFDir}/{nameFDir}") != true)
                                    {
                                        File.Create($"{AdressFDir}/{nameFDir}");
                                    }



                                }

                            }
                            catch (DirectoryNotFoundException) { }
                            catch (UnauthorizedAccessException) { }
                        }
                        if (StrCreate == "d")
                        {
                            try
                            {
                              /* Console.WriteLine($"Введите директорию для создания новой директории");*/
                                DirectoryInfo dirCreate = Directory.GetParent(DirArr[c]);
                                string AdressDir = @$"{dirCreate}";
                                Console.WriteLine($"Введите имя новой директории");
                                string nameDir = Console.ReadLine();
                                
                                CreateDir(AdressDir, nameDir);
                                Console.Clear();
                                
                                foreach (var item in dirCreate.GetDirectories())
                                {
                                    Console.WriteLine(item);
                                }

                                static void CreateDir(string AdressDir, string nameDir)
                                {
    
                                        if (Directory.Exists($"{AdressDir}/{nameDir}") != true)
                                        {
                                            Directory.CreateDirectory($"{AdressDir}/{nameDir}");
                                        }


                                    
                                }
                              

                            }
                            catch (DirectoryNotFoundException) { }
                            catch (UnauthorizedAccessException) { }
                        }

                        break;
                    }
                case "rm":
                    Console.WriteLine("Удалить файл или директорию?(f-если файл, d-если директорию)");
                    string StrRm = Console.ReadLine();
                    if (((StrRm != "f") && (StrRm != "d")) || (string.IsNullOrEmpty(StrRm))) { Console.WriteLine("Введите f или d"); break; }
                    else
                    {
                        if (StrRm == "f")
                        {
                            try
                            {
                                File.Delete(FArr[Index]); Console.WriteLine($"Файл {Path.GetFileName(FArr[Index])} удалён"); break;
                            }
                            catch (FileNotFoundException) { }
                            catch (UnauthorizedAccessException) { }
                        }


                        if (StrRm == "d")
                        {
                            try
                            {
                                string thisAdresDir = DirArr[c];
                                static void DeleteDir(string thisAdresDir)
                                {

                                    DirectoryInfo DelDir = new DirectoryInfo(thisAdresDir);
                                    foreach (DirectoryInfo DelFolder in DelDir.GetDirectories())
                                    {
                                        DeleteDir(DelFolder.FullName);
                                        if ((DelFolder.GetDirectories().Length == 0) && (DelFolder.GetFiles().Length == 0))
                                        {
                                            DelFolder.Delete();
                                        }

                                    }
                                    foreach (string Dfile in Directory.GetFiles(thisAdresDir))
                                    {

                                        File.Delete(Dfile);
                                    }

                                }
                                DeleteDir(thisAdresDir); Directory.Delete(DirArr[c], true);
                                Console.Clear();
                                for (int j = 0; j < DirArr.Length; j++) { if ((j >= c) && (j < DirArr.Length - 1)) { DirArr[j] = DirArr[j + 1]; } }
                            }
                            catch (DirectoryNotFoundException) { }
                            catch (UnauthorizedAccessException) { }
                            Console.WriteLine($"Папка {DirArr[c]} удалена полностью");
                        }
                        break;
                    }
                case "info":
                    Console.WriteLine("Инфо о файле или директории?(f-если о файле, d-если директории)");
                    string StrI = Console.ReadLine();
                    if (((StrI != "f") && (StrI != "d")) || (string.IsNullOrEmpty(StrI))) { Console.WriteLine("Введите f или d"); break; }
                    else
                    {
                        if (StrI == "f")
                        {
                            FileInfo fileI = new FileInfo(FArr[Index]);
                            Console.WriteLine($"Имя файла: {fileI.Name} ");
                            Console.WriteLine($"Время создания: {fileI.CreationTime}");
                            Console.WriteLine($"Размер:{fileI.Length}");
                            Console.WriteLine("Нажмите ENTER для продолжения:"); Console.ReadKey(); Console.Clear(); break;
                        }
                        if (StrI == "d")
                        {
                            DirectoryInfo dirI = new DirectoryInfo(DirArr[c]);
                            Console.WriteLine($"Название каталога: {dirI.Name}");
                            Console.WriteLine($"Полное название каталога: {dirI.FullName}");
                            Console.WriteLine($"Время создания каталога: {dirI.CreationTime}");
                            Console.WriteLine($"Корневой каталог: {dirI.Root}");
                            Console.WriteLine("Нажмите ENTER для продолжения:"); Console.ReadKey(); Console.Clear();
                        }
                        break;
                    }
                case "attrib":
                    Console.WriteLine("Какой атрибут файла поменять (h - если поменять параметр /скрытый/, r - если поменять параметр /только чтение/)");
                    string StrAttr = Console.ReadLine();
                    if (((StrAttr != "h") && (StrAttr != "r")) || (string.IsNullOrEmpty(StrAttr))) { Console.WriteLine("Введите h или r"); break; }
                    else { 
                        if (StrAttr == "f")
                    {
                        ChangeHiddenAttribute(FArr, Index); break;
                    }
                    if(StrAttr == "r")
                    {
                        ChangeReadOnlyAttribute(FArr, Index); 
                    }
                        break;
                    }
            }
        }
    }
}
