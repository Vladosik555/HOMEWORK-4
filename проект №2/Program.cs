using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace проект__2
{
    internal class Program
    {
        static int Massiv(ref int mult, out double average, params int[] array1) 
        {
            mult = 1;
            int result = 0;
            for (int i = 0; i < array1.Length; i++) 
            {
                mult *= array1[i];
                result += array1[i];
            }
            average = (double)result / array1.Length;
            return result;
        }
        static void Value(int number)
        {
            switch (number)
            {
                case 0:
                    Console.WriteLine("####\n#  #\n#  #\n#  #\n####");
                    break; 
                case 1:
                    Console.WriteLine("#\n#\n#\n#");
                    break;
                case 2:
                    Console.WriteLine(" ## \n#  #\n  # \n # \n####");
                    break;
                case 3:
                    Console.WriteLine("####\n   #\n ###\n   #\n####");
                    break;
                case 4:
                    Console.WriteLine("#  #\n#  #\n#  #\n####\n   #\n   #\n   #");
                    break;
                case 5:
                    Console.WriteLine("####\n# \n####\n   #\n####");
                    break;
                case 6:
                    Console.WriteLine("####\n# \n####\n#  #\n####");
                    break;
                case 7:
                    Console.WriteLine("####\n   #\n  ###\n   #\n   #");
                    break;
                case 8:
                    Console.WriteLine(" ## \n#   #\n#   #\n ## \n#   #\n#   #\n ## ");
                    break;
                case 9:
                    Console.WriteLine("####\n#  #\n####\n   #\n####");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы не вошли в промежуток");
                    Thread.Sleep(3000);
                    Console.BackgroundColor = ConsoleColor.Black;
                    break;
            }
        }
        enum Level
        {
            Душнила,
            Ворчаливый,
            Спокойный
        }
        struct Grandfather
        {
            public string name;
            public Level level;
            public string[] phrases;
            public int bruises;
            public int Grandpa(params string[] bruises)
            {
                int count = 0;
                for (int i = 0; i < bruises.Length; i++)
                {
                    count++;
                }
                return count;
            }
        }
        

        static void Main(string[] args)
        {
            
            Console.WriteLine("Задание номер 1");
            Console.WriteLine("Данная програма меняет 2 числа местами");
            Console.WriteLine();
            Random random = new Random();
            int[] array = new int[20];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(10001);
                Console.WriteLine($"{i} элемент массива: {array[i]}");
            }
            Console.Write("Введите первое число, которое хотите поменять местами от 0 до 19: ");
            bool a = int.TryParse(Console.ReadLine(), out int num1);
            Console.Write("Введите второе число, которое хотите поменять местами от 0 до 19: ");
            bool b = int.TryParse(Console.ReadLine(), out int num2);
            if (a && b)
            {
                if (num1 == num2)
                {
                    Console.WriteLine("Вы ввели одинаковые числа");
                }
                else if (num1 > 19 || num2 > 19)
                {
                    Console.WriteLine("Вы не вошли в промежуток");
                }
                else
                {
                    int num3;
                    num3 = array[num1];
                    array[num1] = array[num2];
                    array[num2] = num3;
                    for (int i = 0; i < array.Length; i++)
                    {
                        Console.WriteLine($"{i} элемент массива: {array[i]}");
                    }
                }
            }
            else 
            {
                Console.WriteLine("Нельзя вводить символы");
            }
            Console.WriteLine("Для того чтобы продолжить, нажмите на любую клавишу");
            Console.ReadKey();
            
            Console.WriteLine("Задание номер 2");
            Console.WriteLine("Данная программа считает произведение и среднее арифметичесикое в массиве");
            int mult = 1;
            double average = 0;
            Console.Write("Введите длину массива: ");
            bool qq = int.TryParse(Console.ReadLine(), out int flag);
            int[] array1 = new int[flag];
            for (int i = 0; i < array1.Length ; i++) 
            {
                Console.Write("Введите число: ");
                array1[i] = int.Parse(Console.ReadLine());
            }
            Massiv(ref mult, out average, array1);
            Console.WriteLine($"Умножение: {mult}");
            Console.WriteLine($"Среднее арифметическое значение: {average}");
            Console.WriteLine("Для того чтобы продолжить, нажмите на любую клавишу");
            Console.ReadKey();
            
            Console.WriteLine("Задание номер 3");
            Console.WriteLine("Число от 0 до 9");
            Console.Write("Введите любое значение: ");
            while (true) 
            {
                string word = Console.ReadLine();
                bool ban = int.TryParse(word, out int num10);
                if (ban)
                {
                    Value(num10);
                }
                else if (word == "exit" || word == "закрыть")
                {
                    break;
                }
                else 
                {
                    try 
                    {
                        throw new Exception();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Исключение");
                    }

                }
            }
            Console.WriteLine("Для того чтобы продолжить, нажмите на любую клавишу");
            Console.ReadKey();
            
            Console.WriteLine("Задание номер 4");
            Console.WriteLine("Программа деды с матюками");
            string[] Ivan_phrases = new string[] { "Козлы вы ебу**е", "бл*ди драные", "уеб***те отсюда"};
            string[] Alexander_phrases = new string[] {"Вали на*** из моего дома"};
            string[] Mitrofan_phrases = new string[] {"ты че сидешь на***", "чтобы у тебя сарай сгорел к хер**"};
            string[] Vyacheslav_phrases = new string[] {};
            string[] Arcadiy_phrases = new string[] {"Вставай пизд**ыш"};
            
            Grandfather Ivan = new Grandfather();
            Ivan.name = "Иван";
            Ivan.level = Level.Душнила;
            Ivan.phrases = Ivan_phrases;
            Ivan.bruises = 3;
            Ivan.Grandpa(Ivan_phrases);

            Grandfather Alexander = new Grandfather();
            Alexander.name = "Александр";
            Alexander.level = Level.Ворчаливый;
            Alexander.phrases = Alexander_phrases;
            Alexander.bruises = 1;
            Alexander.Grandpa(Alexander_phrases);

            Grandfather Mitrofan = new Grandfather();
            Mitrofan.name = "Митрофан";
            Mitrofan.level = Level.Ворчаливый;
            Mitrofan.phrases = Mitrofan_phrases;
            Mitrofan.bruises = 2;
            Mitrofan.Grandpa(Mitrofan_phrases);

            Grandfather Vyacheslav = new Grandfather();
            Vyacheslav.name = "Вячеслав";
            Vyacheslav.level = Level.Спокойный;
            Vyacheslav.phrases = Vyacheslav_phrases;
            Vyacheslav.bruises = 0;
            Vyacheslav.Grandpa(Vyacheslav_phrases);

            Grandfather Arcadiy = new Grandfather();
            Arcadiy.name = "Аркадий";
            Arcadiy.level = Level.Ворчаливый;
            Arcadiy.phrases = Arcadiy_phrases;
            Arcadiy.bruises = 1;
            Arcadiy.Grandpa(Arcadiy_phrases);
            Console.WriteLine($"{Ivan.name} получил {Ivan.Grandpa(Ivan_phrases)} фингалов от бабки");
            Console.WriteLine($"{Alexander.name} получил {Alexander.Grandpa(Alexander_phrases)} фингалов от бабки");
            Console.WriteLine($"{Mitrofan.name} получил {Mitrofan.Grandpa(Mitrofan_phrases)} фингалов от бабки");
            Console.WriteLine($"{Mitrofan.name} получил {Vyacheslav.Grandpa(Vyacheslav_phrases)} фингалов от бабки");
            Console.WriteLine($"{Vyacheslav.name} получил {Arcadiy.Grandpa(Arcadiy_phrases)} фингалов от бабки");
            Console.ReadKey();




        }
    }
}
