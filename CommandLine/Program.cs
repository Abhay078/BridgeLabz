using System;
namespace Program5;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Number of parts of name:" + args.Length);
        Console.WriteLine("The name is : ");
        String name = "";
        foreach (Object obj in args)
        {
            name += obj + " ";
        }
        Console.WriteLine(name);
    }
}