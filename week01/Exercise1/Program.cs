using System;

class Program
{
    static void Main(string[] args)
    {
        //ask tthe user for their first and last name and then display the name in the format of last, first last
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Console.WriteLine("What is your first name?");
        string first = Console.ReadLine();

        Console.WriteLine("What is your last name?");
        string last = Console.ReadLine();

        Console.WriteLine($"your first and last name is {last},{first} {last}");
    }
}