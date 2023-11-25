using System;

internal class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Переменная для отслеживания наличия делителя
        bool isPrime = true;

        // Проверка числа на простоту
        int divisor = 2;
        while (divisor < number)
        {
            if (number % divisor == 0)
            {
                isPrime = false; // Если нашли делитель, число не простое
                break; // Выход из цикла, так как уже известно, что число не простое
            }

            divisor++;
        }

        // Вывод результата
        if (isPrime)
        {
            Console.WriteLine($"{number} - простое число.");
        }
        else
        {
            Console.WriteLine($"{number} - не простое число.");
        }
    }
}

