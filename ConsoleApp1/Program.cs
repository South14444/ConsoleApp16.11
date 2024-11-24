using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Выберите задание:");
            Console.WriteLine("1. Задание 3: Ограничение на количество экземпляров приложения");
            Console.WriteLine("2. Задание 4: Генерация случайных чисел");
            Console.WriteLine("3. Задание 5: Анализ простых чисел");
            Console.WriteLine("4. Задание 6: Имитация казино");
            Console.WriteLine("0. Выход");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Task3();
                    break;
                case "2":
                    Task4();
                    break;
                case "3":
                    Task5();
                    break;
                case "4":
                    Task6();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Неверный ввод, попробуйте снова.");
                    break;
            }
        }
    }

    static void Task3()
    {
        Process currentProcess = Process.GetCurrentProcess();
        Process[] processes = Process.GetProcessesByName(currentProcess.ProcessName);

        if (processes.Length > 1)
        {
            Console.WriteLine("Приложение уже запущено.");
            return;
        }

        Console.WriteLine("Запуск приложения...");
    }

    static void Task4()
    {
        Random random = new Random();
        Console.WriteLine("Сколько случайных чисел вы хотите сгенерировать?");
        int count = int.Parse(Console.ReadLine());

        Console.WriteLine($"Сгенерированные случайные числа:");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(random.Next(1, 101));
        }
    }

    static void Task5()
    {
        Console.WriteLine("Введите число для проверки на простоту:");
        int number = int.Parse(Console.ReadLine());
        bool isPrime = true;

        if (number <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime)
        {
            Console.WriteLine($"{number} является простым числом.");
        }
        else
        {
            Console.WriteLine($"{number} не является простым числом.");
        }
    }

    static void Task6()
    {
        Random random = new Random();
        int winningNumber = random.Next(1, 101);
        int guess = 0;

        Console.WriteLine("Добро пожаловать в казино! Угадайте число от 1 до 100.");

        while (guess != winningNumber)
        {
            Console.WriteLine("Введите ваше предположение:");
            guess = int.Parse(Console.ReadLine());

            if (guess < winningNumber)
            {
                Console.WriteLine("Слишком низко! Попробуйте снова.");
            }
            else if (guess > winningNumber)
            {
                Console.WriteLine("Слишком высоко! Попробуйте снова.");
            }
            else
            {
                Console.WriteLine("Поздравляем! Вы угадали число!");
            }
        }
    }
}
