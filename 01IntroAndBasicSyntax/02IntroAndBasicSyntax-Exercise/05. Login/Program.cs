using System;
class Program
{
    static void Main()
    {
        string username = Console.ReadLine();
        string enteredPassword = Console.ReadLine();
        char[] charArray = username.ToCharArray();
        Array.Reverse(charArray);
        string truePassword = new string(charArray);

        int counter = 1;
        while (counter < 4 && enteredPassword != truePassword)
        {
            Console.WriteLine("Incorrect password. Try again.");
            counter += 1;
            enteredPassword = Console.ReadLine();
        }
        if (counter >= 4)
        {
            Console.WriteLine($"User {username} blocked!");

        }
        else
        {
            Console.WriteLine($"User { username} logged in.");
        }
    }
}
