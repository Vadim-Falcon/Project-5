using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        //цикл while
        Console.WriteLine("Цикл while: ");

        Console.Write("Введіть перше число: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введіть друге число: ");
        int b = int.Parse(Console.ReadLine());

        int max = Math.Max(a, b);
        int nsk = max;

        while (true)
        {
            if (nsk % a == 0 && nsk % b == 0)
                break;
            nsk++;
        }

        Console.WriteLine("Найменше спільне кратне (НСК) чисел: " + nsk);

        //цикл for 
        Console.WriteLine("Цикл for: ");

        Console.Write("Введіть перше число: ");
        int a1 = int.Parse(Console.ReadLine());
        Console.Write("Введіть друге число: ");
        int b1 = int.Parse(Console.ReadLine());

        int max1 = Math.Max(a1, b1);
        int nsk1 = 0;

        for (int i = max1; ; i++)
        {
            if (i % a1 == 0 && i % b1 == 0)
            {
                nsk1 = i;
                break;
            }
        }

        Console.WriteLine("Найменше спільне кратне (НСК) чисел: " + nsk1);


    }
}
