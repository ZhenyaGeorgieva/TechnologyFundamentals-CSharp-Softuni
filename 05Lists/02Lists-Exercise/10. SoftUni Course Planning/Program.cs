using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10SoftuniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> initialSchedule = Console.ReadLine()
                .Split(new char[] { ',' })
                .Select(x => x.Trim())
                .ToList();
            string line = Console.ReadLine();

            while (line != "course start")
            {
                List<string> commandLine = line
                    .Split(new char[] { ':' })
                    .ToList();

                string action = commandLine[0];

                if (action == "Add")
                {
                    string lessonName = commandLine[1];
                    if (!initialSchedule.Contains(lessonName))
                    {
                        initialSchedule.Add(lessonName);
                    }
                }
                if (action == "Insert")
                {
                    string lessonName = commandLine[1];
                    int index = int.Parse(commandLine[2]);
                    if (!initialSchedule.Contains(lessonName))
                    {
                        initialSchedule.Insert(index, lessonName);
                    }
                }
                if (action == "Remove")
                {
                    {
                        string lessonName = commandLine[1];

                        if (initialSchedule.Contains(lessonName))
                        {
                            initialSchedule.Remove(lessonName);
                        }
                        if (initialSchedule.Contains($"{lessonName}-Exercise"))
                        {
                            initialSchedule.Remove($"{lessonName}-Exercise");
                        }
                    }
                }
                if (action == "Swap")
                {
                    string lesson1 = commandLine[1];
                    string lesson2 = commandLine[2];

                    if (initialSchedule.Contains(lesson1) && initialSchedule.Contains(lesson2))
                    {
                        int indexLesson1 = initialSchedule.IndexOf(lesson1);
                        int indexLesson2 = initialSchedule.IndexOf(lesson2);

                        initialSchedule[indexLesson2] = lesson1;
                        initialSchedule[indexLesson1] = lesson2;


                        if (initialSchedule.Contains($"{lesson1}-Exercise")
                           || initialSchedule.Contains($"{lesson2}-Exercise"))
                        {

                            if (initialSchedule.Contains($"{lesson1}-Exercise"))
                            {
                                initialSchedule.Remove($"{lesson1}-Exercise");
                                if (indexLesson2 == initialSchedule.Count - 1)
                                {
                                    initialSchedule.Add($"{lesson1}-Exercise");
                                }
                                else
                                {
                                    initialSchedule.Insert(indexLesson2 + 1, $"{lesson1}-Exercise");
                                }
                            }
                            if (initialSchedule.Contains($"{lesson2}-Exercise"))
                            {
                                initialSchedule.Remove($"{lesson2}-Exercise");
                                if (indexLesson1 == initialSchedule.Count - 1)
                                {
                                    initialSchedule.Add($"{lesson2}-Exercise");
                                }
                                else
                                {
                                    initialSchedule.Insert(indexLesson1 + 1, $"{lesson2}-Exercise");
                                }
                            }
                        }
                    }
                }
                if (action == "Exercise")
                {
                    string lessonName = commandLine[1];
                    if (initialSchedule.Contains(lessonName) && !initialSchedule.Contains($"{lessonName}-Exercise"))
                    {
                        int indexOfLesson = initialSchedule.IndexOf(lessonName);
                        string exerciseName = $"{lessonName}-Exercise";
                        initialSchedule.Insert(indexOfLesson + 1, exerciseName);
                    }
                    if (!initialSchedule.Contains(lessonName))
                    {
                        initialSchedule.Add(lessonName);
                        initialSchedule.Add($"{lessonName}-Exercise");
                    }
                }
                line = Console.ReadLine();
            }
            for (int i = 0; i < initialSchedule.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{initialSchedule[i]}");
            }
        }
    }
}
