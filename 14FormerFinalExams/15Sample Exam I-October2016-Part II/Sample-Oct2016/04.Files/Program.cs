using System;
using System.Collections.Generic;
using System.Linq;

namespace _16Files
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> rootFileSize = new Dictionary<string, Dictionary<string, long>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                if (command.Contains('\\'))
                {
                    string[] path = command.Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
                    string root = path[0];
                    int lastIndex = command.LastIndexOf('\\');
                    string fileExtentionSize = command.Substring(lastIndex + 1);
                    if (fileExtentionSize.Contains(';'))
                    {
                        string[] fileNameSize = fileExtentionSize.Split(new char[] { ';' });
                        string fileNameExtention = fileNameSize[0];
                        long fileSize = long.Parse(fileNameSize[1]);
                        if (!rootFileSize.ContainsKey(root))
                        {
                            rootFileSize[root] = new Dictionary<string, long>();
                            rootFileSize[root][fileNameExtention] = fileSize;
                        }
                        else
                        {
                            if (!rootFileSize[root].ContainsKey(fileNameExtention))
                            {
                                rootFileSize[root][fileNameExtention] = fileSize;
                            }
                            else
                            {
                                rootFileSize[root][fileNameExtention] = fileSize;
                            }
                        }
                    }
                }
            }
            string[] extractionCommand = Console.ReadLine().Split(new char[] { ' ' });
            string rootSearch = extractionCommand[2];
            string fileExtentionSearch = extractionCommand[0];

            if (!rootFileSize.ContainsKey(rootSearch))
            {
                Console.WriteLine("No");
            }
            else
            {
                var filesInRoot = rootFileSize[rootSearch];
                bool found = false;
                foreach (var kvp in filesInRoot.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    if (kvp.Key.Contains('.'))
                    {
                        int lastIndexOfDot = kvp.Key.LastIndexOf('.');
                        string extention = kvp.Key.Substring(lastIndexOfDot + 1);
                        string name = kvp.Key.Remove(lastIndexOfDot);
                        long size = kvp.Value;
                        if (extention == fileExtentionSearch)
                        {
                            found = true;
                            Console.WriteLine($"{name}.{extention} - {size} KB");
                        }
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No");
                }
            }
        }
    }
}