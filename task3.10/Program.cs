using System;



internal class Program
{
    static void Main()
    {
        Console.WriteLine($"Задание 1 \nопределение чётного или нечётного числа.");
        Console.Write($"Введите число");
        var num = Convert.ToInt32(Console.ReadLine());
        if(num % 2 == 0 ){
            Console.WriteLine($"Чётное {num}");
        }
        else{
            Console.WriteLine($"не чётное");
        }

    }
}

