using System;
using System.IO;


namespace _13lab
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter file = ADPLog.CreateStream("MainFile.txt");
            
            ADPDiskInfo.FreeSpace(file);
            ADPDiskInfo.FileSystemInfo(file);
            ADPDiskInfo.DiskInfo(file); Console.WriteLine();

            ADPFileInfo.FullDirection(file, "MainFile.txt");
            ADPFileInfo.FileInfo(file, "MainFile.txt");
            ADPFileInfo.CreationTime(file, "MainFile.txt"); Console.WriteLine();

            ADPDirInfo.CreationTime(file, "..");
            ADPDirInfo.FileCount(file, "..");
            ADPDirInfo.DirCount(file, "..");
            ADPDirInfo.ParentsCount(file, ".."); Console.WriteLine();

            try
            {
                ADPFileManager.DiskReader(file, "D://");
            }
            catch (IOException) { };
           // file.WriteLine("Hello world!");
            file.Close(); Console.WriteLine();

            StreamReader fileR = ADPLog.CreateStreamR("MainFile.txt");
            ADPFinder.SearcherWord(fileR, "Hello world!"); fileR.Close();
            Console.WriteLine();

            StreamReader fileR1 = ADPLog.CreateStreamR("MainFile.txt");
            ADPFinder.Searcher(fileR1, 1, 5); fileR1.Close();
            Console.WriteLine();

            StreamReader fileR2 = ADPLog.CreateStreamR("MainFile.txt");
            ADPFinder.SearcherDate(fileR2, 2, 10);
            fileR2.Close();
        }
    }
}
