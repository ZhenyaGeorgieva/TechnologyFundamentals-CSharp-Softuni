using System;
using System.Collections.Generic;
using System.Linq;

namespace _02SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> courses = Console.ReadLine().Split(new char[] { ',' }).Select(x => x.Trim()).ToList();
            string commands = Console.ReadLine();

            while (commands != "course start")
            {
                List<string> tokens = commands.Split(new char[] { ':' }).ToList();
                string action = tokens[0];

                if (action == "Add")
                {
                    string lesson = tokens[1];
                    if (!courses.Contains(lesson))
                    {
                        courses.Add(lesson);
                    }
                }
                else if (action == "Insert")
                {
                    string lesson = tokens[1];
                    int index = int.Parse(tokens[2]);
                    if (!courses.Contains(lesson) && (index >= 0 && index < courses.Count))
                    {
                        courses.Insert(index, lesson);
                    }
                }
                else if (action == "Remove")
                {
                    string lesson = tokens[1];
                    if (courses.Contains(lesson) || courses.Contains($"{lesson}-Exercise"))
                    {
                        courses.Remove(lesson);
                        courses.Remove($"{lesson}-Exercise");
                    }
                }
                else if (action == "Swap")
                {
                    string lessonTitle1 = tokens[1];
                    string lessonTitle2 = tokens[2];
                    if (courses.Contains(lessonTitle1) && courses.Contains(lessonTitle2))
                    {
                        int firstIndex = courses.IndexOf(lessonTitle1);
                        int secondIndex = courses.IndexOf(lessonTitle2);
                        courses.RemoveAt(firstIndex);
                        courses.Insert(firstIndex, lessonTitle2);
                        courses.RemoveAt(secondIndex);
                        courses.Insert(secondIndex, lessonTitle1);
                    }
                    if (courses.Contains($"{lessonTitle1}-Exercise"))
                    {
                        courses.Remove($"{ lessonTitle1}-Exercise");
                        int index = courses.IndexOf(lessonTitle1);
                        if (index == courses.Count - 1)
                        {
                            courses.Add($"{lessonTitle1}-Exercise");
                        }
                        else
                        {
                            courses.Insert(index + 1, $"{lessonTitle1}-Exercise");
                        }
                    }
                    if (courses.Contains($"{lessonTitle2}-Exercise"))
                    {
                        courses.Remove($"{ lessonTitle2}-Exercise");
                        int index = courses.IndexOf(lessonTitle2);
                        if (index == courses.Count - 1)
                        {
                            courses.Add($"{lessonTitle2}-Exercise");
                        }
                        else
                        {
                            courses.Insert(index + 1, $"{lessonTitle2}-Exercise");
                        }
                    }
                }
                else if (action == "Exercise")
                {
                    string lessonTitle = tokens[1];

                    if (courses.Contains(lessonTitle) && !courses.Contains($"{lessonTitle}-Exercise"))
                    {
                        int index = courses.IndexOf(lessonTitle);
                        if (index == courses.Count - 1)
                        {
                            courses.Add($"{lessonTitle}-Exercise");
                        }
                        else
                        {
                            courses.Insert(index + 1, $"{lessonTitle}-Exercise");
                        }
                    }
                    if (!courses.Contains(lessonTitle) && !courses.Contains($"{lessonTitle}-Exercise"))
                    {
                        courses.Add(lessonTitle);
                        courses.Add($"{lessonTitle}-Exercise");
                    }
                }
                commands = Console.ReadLine();
            }
            for (int i = 0; i < courses.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{courses[i]}");
            }
        }
    }
}