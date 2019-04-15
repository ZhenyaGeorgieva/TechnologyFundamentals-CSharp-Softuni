using System;

namespace _05HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string content = Console.ReadLine();
            Console.WriteLine("<h1>");
            Console.WriteLine($"    {title}");
            Console.WriteLine("</h1>");
            Console.WriteLine("<article>");
            Console.WriteLine($"    {content}");
            Console.WriteLine("</article>");
            string command = Console.ReadLine();
            while (command != "end of comments")
            {
                string comments = command;
                Console.WriteLine("<div>");
                Console.WriteLine($"    {comments}");
                Console.WriteLine("</div>");
                command = Console.ReadLine();
            }
        }
    }
}
