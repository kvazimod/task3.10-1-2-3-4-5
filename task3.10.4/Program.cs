using System;

internal class Program
{
    static void Main()
    {
    Console.WriteLine($"Введите длинну последовательности");
    int length = Convert.ToInt32( Console.ReadLine());

    if ( length <= 0)
    {
        Console.WriteLine($"Длинна последовательности должна быть больше 0");
        return;
    }
        
    int MinElement = int.MaxValue;

    for (int i = 0; i < length; i++)
    {
        Console.WriteLine($"ВВедите число {i + 1}: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if ( number <= MinElement ) 
        {
        MinElement = number;
        }
    }

    Console.Clear();
    Console.WriteLine($"Ваше минимальное число {MinElement}");

    Console.ReadLine();
    }
}

