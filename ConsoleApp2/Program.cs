using System;
using System.Reflection;

class Program
{
    static void Main()
    {
        for (int i = 0; i < 3; i++)
        {
            Console.Write("> ");
            if (int.TryParse(Console.ReadLine(), out int prefInput))
            {
                
            }
            else
            {
                i--;
            }
        }

     
    }
}