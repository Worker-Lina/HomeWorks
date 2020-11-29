using System;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Alina Chelovechkova!");
            Console.WriteLine("Введите первое число");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int secondNumber = int.Parse(Console.ReadLine());
            int summa = firstNumber + secondNumber;
            Console.WriteLine($" { firstNumber} + { secondNumber} = { summa}");
        }
    }
}
