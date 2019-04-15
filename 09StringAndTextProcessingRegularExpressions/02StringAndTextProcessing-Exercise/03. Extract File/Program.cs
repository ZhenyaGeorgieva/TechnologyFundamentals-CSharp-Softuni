using System;
using System.Linq;

namespace _00
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            int lastIndexOfSlash = path.LastIndexOf('\\');
            string fileAndExtention = path.Substring(lastIndexOfSlash + 1);
            int indexOfDot = fileAndExtention.IndexOf('.');
            string file = fileAndExtention.Substring(0, indexOfDot);
            string extention = fileAndExtention.Substring(indexOfDot + 1);

            Console.WriteLine($"File name: {file}");
            Console.WriteLine($"File extension: {extention}");
        }
    }
}