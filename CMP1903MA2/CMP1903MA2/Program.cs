using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CMP1903MA2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("diff ");
            string files = Console.ReadLine();
            string[] filenames = files.Split(' ');

            if (diff(filenames[0], filenames[1])) 
            { 
                Console.WriteLine($"{filenames[0]} and {filenames[1]} are not different."); 
            }
            else
            {
                Console.WriteLine($"{filenames[0]} and {filenames[1]} are different.");
            }

            Console.ReadLine();
        }
        public static string[] fileReader(string fileName)
        {
            string[] file = { };


            string Path = Directory.GetCurrentDirectory();
            string filepath = Path.Substring(0, Path.IndexOf("CMP")) + fileName;
            file = File.ReadAllLines(filepath);


            return file;
        }


        public static bool diff(string filename1,string filename2)
        {
            string[] file1 = fileReader(filename1);
            string[] file2 = fileReader(filename2);

            for (int i = 0; i < file1.Length && i < file2.Length; i++)
            {
                if (file1[i] != file2[i]) { return false; }
            }
            return true;
        }
    }
}
