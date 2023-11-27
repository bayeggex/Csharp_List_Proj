using System;
using System.Reflection;

namespace ConsoleApp2; 
class Program
{
    static void Main()
    {
        CustomList<int> intList = new CustomList<int>();

        for (int i = 0; i < 3; i++)
        {
            Console.Write("> ");
            if (int.TryParse(Console.ReadLine(), out int prefInput))
            {
                intList.Add(prefInput);
            }
            else
            {
                i--;
            }
        }

        intList.Add(10);
        intList.Remove(1);

        Console.WriteLine("List:");
        intList.List();

        Console.WriteLine("Toplam List int:");
        Console.WriteLine(intList.Count);

        intList.Clear();
        Console.WriteLine("Temiz List Int:");
        Console.WriteLine(intList.Count);
    }
}