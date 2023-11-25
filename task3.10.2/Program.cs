using System;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("Добро пожаловать в игру '21'!");

        Console.Write("Сколько у вас карт на руках? ");
        int numberOfCards = Convert.ToInt32(Console.ReadLine());

        int totalSum = 0;

        for (int i = 1; i <= numberOfCards && totalSum < 21 + 1; i++)
        {
            Console.Write($"Введите номинал карты {i}: ");
            string cardValue = Console.ReadLine().ToUpper(); // Преобразуем введенное значение в верхний регистр для удобства сравнения

            int cardWeight;

            if (int.TryParse(cardValue, out int numericValue) && numericValue >= 2 && numericValue <= 10)
            {
                cardWeight = numericValue;
            }
            else
            {
                switch (cardValue)
                {
                    case "J":
                    case "Q":
                    case "K":
                        cardWeight = 10;
                        break;
                    case "T":
                        cardWeight = 11; // Вес туза равен 11
                        break;
                    default:
                        Console.WriteLine("Некорректный ввод. Введите числа от 2 до 10 или буквы J, Q, K, T.");
                        i--; // Уменьшаем счетчик, чтобы повторно запросить ввод для этой карты
                        continue; // Пропускаем остаток цикла и переходим к следующей итерации
                }
            }

            totalSum += cardWeight;
        }

        Console.WriteLine($"Сумма ваших карт: {totalSum}");
    }
}

