using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть кількість років: ");
        int age = int.Parse(Console.ReadLine());

        if (age >= 12 && age <= 18)
        {
            Console.WriteLine("Ці роки є підлітковими.");
        }
        else
        {
            Console.WriteLine("Це не підліткові роки.");
        }
    }
}
