using System;
object random = null;
Random rnd = new Random();
int sum = 0;

Console.Write("Random Five numbers are:- ");
for (int i = 0; i < 5; i++)
{
    int r = rnd.Next(10,50);
    
    Console.Write(r + " ");
    sum += r;
}
Console.WriteLine();
Console.WriteLine(sum/5);
