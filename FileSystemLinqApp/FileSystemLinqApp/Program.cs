using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSystemLinqApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //File
            DirectoryInfo filedir = new DirectoryInfo(@"C:\Windows\System32");
            
            var files = from file in filedir.GetFiles()
                        select new { fileName = file.Name, fileSize = (file.Length / 1024)};

            var Top10FilesBySize = files.OrderByDescending(f => f.fileSize)
                                        .Take(10);
            var Top10FilesByName = files.OrderBy(f => f.fileName)
                                        .Take(10);
            Console.WriteLine("-------Top 10 files by Name-------");
            foreach (var item in Top10FilesByName)
            {
                Console.WriteLine(item.fileName + "\t | " + item.fileSize);
            }
            Console.WriteLine("-------Top 10 files by Size-------");
            foreach (var item in Top10FilesBySize)
            {
                Console.WriteLine(item.fileName + "\t | " + item.fileSize);
            }



            //Folder
            string root = @"C:\Windows\System32";
            var dirs = from dir in Directory.EnumerateDirectories(root)
                       select new { folderName = dir.Substring(dir.LastIndexOf("\\") + 1) ,folderSize = FolderSize (dir)/1024};

            var Top10FoldersBySize = dirs.OrderByDescending(f => f.folderSize)
                                            .Take(10);

            var Top10FoldersByName = dirs.OrderBy(f => f.folderName)
                                            .Take(10);

            Console.WriteLine("-------Top 10 Folders by size------");
            foreach(var item in Top10FoldersBySize)
            {
                Console.WriteLine(item.folderName + " \t| " + item.folderSize);
            }
            Console.WriteLine("-------Top 10 Folders by Name------");
            foreach (var item in Top10FoldersByName)
            {
                Console.WriteLine(item.folderName + " \t| " + item.folderSize);
            }
        }


        private static long FolderSize(string dir)
        {
            try
            {
                DirectoryInfo info = new DirectoryInfo(@dir);
                long totalSize = info.EnumerateFiles().Sum(file => file.Length);
                
                return totalSize;
            }
            catch (Exception e)
            {
                Console.WriteLine("No access");
            }

            return 0;
        }
    }
}
