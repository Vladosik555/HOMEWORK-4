using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проект__1
{
    internal class Program
    {
        static int Comparison(int a, int b, int result = 0)
        {
            if (a > b)
            {
                result = a;
                return result;
            }
            else if (a < b)
            {
                result = b;
                return result;
            }
            else
            {
                result = a = b;
                return result;
            }
        }
        static void Moving(ref double num1, ref double num2)
        {
            double num3 = num1;
            num1 = num2;
            num2 = num3;
        }
        static int Factorial(int factor)
        {
            int result = 1;
            if (factor == 0)
            {
                return result;
            }
            for (int i = 1; i <= factor; i++)
            {
                result = checked((int)(result * i));
            }
            return result;
        }
        static int RecursiveFactorial(int fac)
        {
            if (fac == 0 || fac == 1)
            {
                return 1;
            }
            else
            {
                return checked(fac * RecursiveFactorial(fac - 1));
            }
        }
        static int TwoNOD(int a, int b) 
        {
            while (a != b) 
            {
                if (a > b) 
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
             int NOD = b;
            return NOD;
        }
        static int TrheeNOD(int a, int b, int c)
        {
            if (a != 0 && b != 0 && c != 0) 
            {
                return TwoNOD(TwoNOD(a, b), c);
            }
            else
            {
                return a + b + c;
            }
        }
        static int Fibanachi(int fib) 
        {
            if (fib < 3)
            {
                return 1;
            }
            else
            {
                return Fibanachi(fib - 2) + Fibanachi(fib - 1);
            }
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Упражнение 5.1");
            Console.WriteLine("Данная программа возращает наибольшее число");
            Console.Write("Напишите первое число: ");
            bool numb1 = int.TryParse(Console.ReadLine(), out int number1);
            Console.Write("Напишите второе число: ");
            bool numb2 = int.TryParse(Console.ReadLine(), out int number2);
            int otvet = Comparison(number1, number2);
            Console.Write("Наибольшее число: ");
            Console.WriteLine(otvet);
            Console.WriteLine("Для того чтобы продолжить, нажмите на любую клавишу");
            Console.ReadKey();
            
            Console.WriteLine("Упражнение 5.2");
            Console.WriteLine("Данная программа меняет значения двух передаваемых параметров");
            Console.Write("Напишите первое число: ");
            bool a = double.TryParse(Console.ReadLine(), out double num1);
            Console.Write("Напишите второе число: ");
            bool b = double.TryParse(Console.ReadLine(), out double num2);
            Moving(ref num1, ref num2);
            Console.WriteLine($"Первое значение: {num1}");
            Console.WriteLine($"Второе значение: {num2}");
            Console.WriteLine("Для того чтобы продолжить, нажмите на любую клавишу");
            Console.ReadKey();
            
            Console.WriteLine("Упражнение 5.3");
            Console.WriteLine("Данная программа считает факториал");
            Console.WriteLine("Напишите число факториала");
            bool tab = int.TryParse(Console.ReadLine(), out int factoriaal);
            try
            {
                Console.WriteLine($"Ответ: {Factorial(factoriaal)}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка переполнения");
            }
            Console.WriteLine("Для того чтобы продолжить, нажмите на любую клавишу");
            Console.ReadKey();
           
            Console.WriteLine("Упражнение 5.4");
            Console.WriteLine("Рекурсивный метод факториала");
            Console.Write("Введите число: ");
            bool nnumb = int.TryParse(Console.ReadLine(), out int nnumber);
            try
            {
                Console.WriteLine($"Ответ: {RecursiveFactorial(nnumber)}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка переполнения");
            }
            Console.WriteLine("Для того чтобы продолжить, нажмите на любую клавишу");
            Console.ReadKey();

            
            Console.WriteLine("Домашнее задание 5.1");
            Console.WriteLine("Данная программа вычисляет наибольший общий делитель для друх чисел");
            Console.Write("Введите первое число: ");
            bool ev = int.TryParse(Console.ReadLine(),out int one);
            Console.Write("Введите второе число: ");
            bool ew = int.TryParse(Console.ReadLine(), out int two);
            Console.WriteLine($"НОД чисел {one} и {two} это: {TwoNOD(one, two)}");
            Console.WriteLine("Для того чтобы закрыть программу, нажмите на любую клавишу");
            Console.ReadKey();
            
            Console.WriteLine("Данная программа вычисляет наибольший общий делитель для трёх чисел");
            Console.Write("Введите первое число: ");
            bool op_1 = int.TryParse(Console.ReadLine(), out int num_1);
            Console.Write("Введите второе число: ");
            bool op_2 = int.TryParse(Console.ReadLine(), out int num_2);
            Console.Write("Введите третье число: ");
            bool op_3 = int.TryParse(Console.ReadLine(), out int num_3);
            Console.WriteLine($"Наибольший делитель для чисел {num_1} и {num_2} и {num_3} это: {TrheeNOD(num_1, num_2, num_3)} ");
            Console.WriteLine("Для того чтобы закрыть программу, нажмите на любую клавишу");
            Console.ReadKey();
            
            Console.WriteLine("Домашнее задание 5.2");
            Console.WriteLine("Данная программа вычисляет ряд Фибаначи");
            Console.Write("Напишите порядковый номер ряда Фибаначи: ");
            bool qwerty = int.TryParse(Console.ReadLine(),out int  num);
            for (int i = 0; i < num; i++)
            {
                Fibanachi(i);
            }
            Console.WriteLine($"Ответ: {Fibanachi(num)}");
            Console.WriteLine("Для того чтобы закрыть программу, нажмите на любую клавишу");
            Console.ReadKey();
            
            





        }

    }
}
