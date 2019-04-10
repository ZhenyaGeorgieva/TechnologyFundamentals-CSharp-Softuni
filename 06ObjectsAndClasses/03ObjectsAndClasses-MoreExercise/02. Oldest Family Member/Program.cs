using System;
using System.Collections.Generic;
using System.Linq;

namespace _02OldestFamilyMember
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 1; i <= n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string name = tokens[0];
                int age = int.Parse(tokens[1]);

                family.Member = new Member();
                family.Member.Name = name;
                family.Member.Age = age;
                family.AddMember();
            }
            family.FindOldest();
        }
    }
    class Family
    {
        public Member Member;
        List<Member> listOfMember = new List<Member>();
        public List<Member> AddMember()
        {
            listOfMember.Add(Member);
            return listOfMember;
        }
        public void FindOldest()
        {
            Member oldestMember = listOfMember.OrderByDescending(x => x.Age).FirstOrDefault();
            Console.Write(oldestMember.Name + " ");
            Console.Write(oldestMember.Age);
            Console.WriteLine();
        }
    }
    class Member
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}