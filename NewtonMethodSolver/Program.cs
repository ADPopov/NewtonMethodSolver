using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtonMethodSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Решение уравнения x^3 + 0.4x + 2 методом Ньютона\n");

            while (true)
            {
                double epsilon, x0;
                Console.Write("Задайте точность вычисления: ");
                while (!double.TryParse(Console.ReadLine(), out epsilon)) ;

                Console.Write("Введите начальное приближение x0: ");
                while (!double.TryParse(Console.ReadLine(), out x0)) ;

                var equation = new Equation(x0, epsilon);
                Console.WriteLine("Ответ: {0}", equation.GetSolution());
            }
        }
    }
}
