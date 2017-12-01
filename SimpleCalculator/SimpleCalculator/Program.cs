using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в простой калькулятор!");
            Console.WriteLine("Напишите операцию, которую хотите выполнить (например, 5+1) и нажмите Enter.");

            while (true)
            {
                var userString = Console.ReadLine();

                var calc = new Calculator();
                var result = calc.Calculate(userString);

                if (!double.IsNaN(result))
                    Console.WriteLine($"Результат = {result}. Можете рассчитать что-нибудь еще :)");
                else
                    Console.WriteLine("Операция введена некорректно. Попробуйте снова.");
            }
        }
    }
}
