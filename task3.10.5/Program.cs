using System;

internal class Program
{
    static void Main()
    {
        Console.WriteLine($"Добропожаловать в игру угадай число!");
        Console.WriteLine($"Введите максимальное число для диапазона рандома: ");
        int maxNumber = Convert.ToInt32(Console.ReadLine());

        Random random = new Random();
        int secretNumber = random.Next(0, maxNumber + 1);

        Console.WriteLine($"Программа загадала число. Попробуй угадай!");

        while (true)
        {
            Console.WriteLine($"Введите предполагаемое число (или нажмите Enter для завершения игры)");
            string userNumber = Console.ReadLine();

            if (string.IsNullOrEmpty(userNumber))

            {
                Console.WriteLine($"Игра завершена. Загаданное число было: {secretNumber}");
                break;
            }

            if (int.TryParse(userNumber, out int userGuess))
            {
                if (userGuess == secretNumber)
                {
                    Console.WriteLine($"Поздравляем вы угадали число было: {secretNumber}");
                    break;
                }
                else if (userGuess < secretNumber)
                {
                    Console.WriteLine($"Загаданное число больше. Попробуйте еще раз.");
                }
                else
                {
                    Console.WriteLine($"Загаданное число меньше. Попробуйте еще раз.");
                }

            }
            else
            {
                Console.WriteLine($"Введите корректное число.");
            }

        }
    }
}
