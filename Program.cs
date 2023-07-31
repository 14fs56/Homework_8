using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите своё имя: ");
            string name = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Введите свой возраст: ");
            string age = Console.ReadLine();

            Console.WriteLine();
            Console.Write($"Благодарим, {name} ({age}), за введенную информацию! Очень важный спам будет отправляться вам на почту!");
        }
    }
}
