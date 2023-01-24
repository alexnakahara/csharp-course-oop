using System;
using System.IO;

namespace FileManager
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //ExemploFileInfo();
            // ExemploFileStream();
            //EnsureIDisposablesCloses();
            //WritingInFile();
            //ManageDirectories();  
            ManagePath(); 
            
        }

        private static void ManagePath()
        {
            string sourcePath = @"C:\Projetos\csharp-course-oop\myfolder\file1.txt";

            try
            {

                Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
                Console.WriteLine("PathSeparator: " + Path.PathSeparator);
                Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(sourcePath));
                Console.WriteLine("GetFileName: " + Path.GetFileName(sourcePath));
                Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(sourcePath));
                Console.WriteLine("GetExtension: " + Path.GetExtension(sourcePath));
                Console.WriteLine("GetFullPath: " + Path.GetFullPath(sourcePath));
                Console.WriteLine("GetTempPath: " + Path.GetTempPath());
            }
            catch (IOException e)
            {

                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
        }

        private static void ManageDirectories()
        {
            string sourcePath = @"C:\Projetos\csharp-course-oop\myfolder";

            try
            {
                string allFilesPatern = "*.*";
                var folders = Directory.EnumerateDirectories(sourcePath, allFilesPatern, SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS: ");
                foreach (var s in folders)
                {
                    Console.WriteLine(s);
                }

                var files = Directory.EnumerateFiles(sourcePath, allFilesPatern, SearchOption.AllDirectories);
                Console.WriteLine(" FILES: ");
                foreach (var s in files)
                {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(sourcePath + @"\newFolder");
            }
            catch (IOException e)
            {

                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
        }

        public static void ExemploFileInfo()
        {
            string sourcePath = @"C:\Projetos\file1.txt";
            string targetPath = @"C:\Projetos\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {

                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
        }

        public static void ExemploFileStream()
        {
            string sourcePath = @"C:\Projetos\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(sourcePath, FileMode.Open);
                sr = new StreamReader(fs);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {

                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) sr.Close();
            }
        }

        public static void EnsureIDisposablesCloses()
        {
            try
            {
                string path = @"C:\Projetos\file1.txt";

                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            catch (IOException e)
            {

                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
        }

        public static void WritingInFile()
        {
            string sourcePath = @"C:\Projetos\file1.txt";
            string targetPath = @"C:\Projetos\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using StreamWriter sw = File.AppendText(targetPath);
                foreach (var line in lines)
                {
                    sw.WriteLine(line.ToUpper());
                }
            }
            catch (IOException e)
            {

                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
        }

    }
}
