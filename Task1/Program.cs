using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор");
            Console.WriteLine(' ');
            double x, y;
            Console.WriteLine("Введите первое число");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(' ');
            try
            {
                Console.WriteLine(@"Выбирете код операции");
                Console.WriteLine(@"1-сложение");
                Console.WriteLine(@"2-вычетание");
                Console.WriteLine(@"3-произведение");
                Console.WriteLine(@"4-частное");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message,"неверный код операции");
            }
            string q = Console.ReadLine();
            Console.WriteLine(' ');
            if (q == "1")
            {
                Console.WriteLine(" = {0}", x + y);
            }
            if (q == "2")
            {
                Console.WriteLine(" = {0}", x + y);
            }
            if (q == "3")
            { 
                 Console.WriteLine(" = {0}", x * y);
            }
            try
            {
                if (q == "4")
                    Console.WriteLine(" = {0}", x / y);
            }
            catch (DivideByZeroException ex) when (x==0 && y==00)
            {
                Console.WriteLine("Попытка деления на ноль!");
            }

                Console.ReadKey();
        }
    }
}
