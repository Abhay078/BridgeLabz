using System;

class Program2
{

    // Main Method
    public static void Main()
    {
        Console.WriteLine("Enter a place name you like to visit most ");
        string str1 = Console.ReadLine();

        string lowerstr1 = str1.ToLower();
        string Upperstr2 = str1.ToUpper();

        Console.WriteLine("LowerCase :- "+lowerstr1);
        Console.WriteLine("UpperCase :- "+Upperstr2);
    }
}

