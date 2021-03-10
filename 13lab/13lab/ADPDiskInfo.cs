using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

//2. Создать класс XXXDiskInfo c методами для вывода информации о
//a. свободном месте на диске
//b. Файловой системе
//c. Для каждого существующего диска - имя, объем, доступный
//объем, метка тома.
//d. Продемонстрируйте работу класса

namespace _13lab
{
    static class ADPDiskInfo
    {
        private static DriveInfo[] allDrives = DriveInfo.GetDrives();

        public static void FreeSpace(StreamWriter streamWriter)//вывод свободного места
        {
            ADPLog.ADPWriter(streamWriter, "Free space");
            for (int i = 0; i < allDrives.Length; i++)
            {
                if (allDrives[i].IsReady)
                {
                    Console.WriteLine($"[{allDrives[i].Name}]Avaible Free Space: {allDrives[i].AvailableFreeSpace}");
                }
            }
        }

        public static void FileSystemInfo(StreamWriter streamWriter)//вывод информации о файловой системе
        {
            ADPLog.ADPWriter(streamWriter, "System information");
            Console.WriteLine($"File System Info: {allDrives[0].DriveFormat}");
        }
        
        public static void DiskInfo(StreamWriter streamWriter)//имя, объем, доступный объем, метка тома каждого существующего диска
        {
            ADPLog.ADPWriter(streamWriter, "Disk information");
            for (int i = 0; i < allDrives.Length; i++)
            {
                if (allDrives[i].IsReady)
                {
                    Console.WriteLine($"[{allDrives[i].Name}] " +
                        $"Total Size: {allDrives[i].TotalSize}, " +
                        $"Avaible Free Space: {allDrives[i].AvailableFreeSpace}, " +
                        $"Label: {allDrives[i].VolumeLabel}");
                }
            }
        }
    }
}
