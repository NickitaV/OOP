using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace File_Manager
{
    class Attribut
    {
        private static FileAttributes RemoveAttribute(FileAttributes attributes, FileAttributes attributesToRemove)
        {
            return attributes & ~attributesToRemove;
        }
        protected virtual void ChangeHiddenAttribute(string[] FArr, int Index)
        {
            
            FileAttributes attributes = File.GetAttributes(FArr[Index]);
            if ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
            {

                attributes = RemoveAttribute(attributes, FileAttributes.Hidden);
                File.SetAttributes(FArr[Index], attributes);
                Console.WriteLine("The {0} file is no longer hidden.", FArr[Index]);
            }
            else
            {

                File.SetAttributes(FArr[Index], File.GetAttributes(FArr[Index]) | FileAttributes.Hidden);
                Console.WriteLine("The {0} file is now hidden.", FArr[Index]);
            }
        }
        protected  void ChangeReadOnlyAttribute(string[] FArr, int Index)
        {
            
            FileAttributes attributes = File.GetAttributes(FArr[Index]);
            if ((attributes & FileAttributes.Hidden) == FileAttributes.ReadOnly)
            {

                attributes = RemoveAttribute(attributes, FileAttributes.ReadOnly);
                File.SetAttributes(FArr[Index], attributes);
                Console.WriteLine("The {0} file is no read only.", FArr[Index]);
            }
            else
            {

                File.SetAttributes(FArr[Index], File.GetAttributes(FArr[Index]) | FileAttributes.ReadOnly);
                Console.WriteLine("The {0} file is read only.", FArr[Index]);
            }
        }
    }
}
