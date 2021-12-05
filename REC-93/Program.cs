using System;

namespace REC_93
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Rand = new Random();
            int Answer = Rand.Next(100);
            int Count = 1;
            Console.WriteLine("За 10 попыток отгадайте число от 1 до 100");
            Console.Write($"Попытка № {Count}: ");
            int Guess = Convert.ToInt32(Console.ReadLine());
            while (Count <= 10)
            {
                if (Answer == Guess)
                {
                    Console.WriteLine("Правильно!");
                    break;
                }
                else
                {
                    Count++;
                    if (Count == 11)
                    {
                        Console.WriteLine($"Попыток больше нет. Загаданное число - {Answer}");
                        break;
                    }
                    Console.WriteLine("Неверно, попробуйте снова!") ;
                    Console.Write($"Попытка № {Count} : ");
                    Guess = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.ReadLine();
        }
    }
}
