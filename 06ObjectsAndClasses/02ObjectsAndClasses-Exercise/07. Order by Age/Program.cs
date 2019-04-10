using System;
using System.Collections.Generic;
using System.Linq;

namespace _07OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<People> listOfPeople = new List<People>();

            while (command != "End")
            {
                string[] tokens = command.Split().ToArray();
                string name = tokens[0];
                string id = tokens[1];
                int age = int.Parse(tokens[2]);
                People people = new People(name, id, age);
                listOfPeople.Add(people);

                listOfPeople = listOfPeople
                    .OrderBy(x => x.Age)
                    .ToList();


                command = Console.ReadLine();
            }
            foreach (var x in listOfPeople)
            {
                Console.WriteLine($"{x.Name} with ID: {x.ID} is {x.Age} years old.");
            }
        }
        class People
        {
            public People(string name, string id, int age)
            {
                Name = name;
                ID = id;
                Age = age;
            }

            public string Name { get; set; }
            public string ID { get; set; }
            public int Age { get; set; }
        }
    }
}