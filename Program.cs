using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Урок 4.2.
            //for (int i = 0; i < 5; i++)
            //for (int i = 5; i > 1; i--)

            Console.WriteLine("Цикл do ... while");

            int t = 0;

            do
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Iteration {0}", t);
                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы:");
                switch (Console.ReadLine())
                {

                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Ваш любимый цвет красный!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Ваш любимый цвет зеленый!");
                        break;

                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Ваш любимый цвет бирюзовый!");
                        break;

                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Ваш любимый цвет тот, который вы ввели!");
                        break;
                }
                t++;
            }
            while (t < 3);
        

            //Console.WriteLine("Цикл While");

            //int k = 0;

            //while (k < 3)
            //{
            //    Console.BackgroundColor = ConsoleColor.Black;
            //    Console.ForegroundColor = ConsoleColor.White;
            //    Console.WriteLine("Iteration {0}", k);
            //    Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы:");
            //    switch (Console.ReadLine())
            //    {
                    
            //    case "red":
            //        Console.BackgroundColor = ConsoleColor.Red;
            //    Console.ForegroundColor = ConsoleColor.Black;

            //    Console.WriteLine("Ваш любимый цвет красный!");
            //    break;

            //    case "green":
            //        Console.BackgroundColor = ConsoleColor.Green;
            //    Console.ForegroundColor = ConsoleColor.Black;

            //    Console.WriteLine("Ваш любимый цвет зеленый!");
            //    break;

            //    case "cyan":
            //        Console.BackgroundColor = ConsoleColor.Cyan;
            //    Console.ForegroundColor = ConsoleColor.Black;

            //    Console.WriteLine("Ваш любимый цвет бирюзовый!");
            //    break;

            //    default:
            //        Console.BackgroundColor = ConsoleColor.Yellow;
            //    Console.ForegroundColor = ConsoleColor.Red;

            //    Console.WriteLine("Ваш любимый цвет тот, который вы ввели!");
            //    break;
            //    }
            //    k++;
            //}
        

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую кнопку");
            Console.ReadKey();

            //Урок 4.1

            //var myapples = 5;
            //var hisapples = 6;
            //var hispeares = 5;
            //var result = (myapples != hispeares) & (myapples < hisapples);
            //Console.WriteLine(result);

            //int a;
            //int b;
            //double x;
            //double y;
            //bool c = (a < b) | (x > y);

            //var a = 5 + 6;
            //var b = 7 + 8;

            //var c = (b != a) & (b > a + 1);
            //var d = (b != a) && (b > a + 1);

            //Здесь в переменной d второе условие не будет вычисляться, т.к. первое уже будет false
            //var c = (b == a) & (b > a + 1);
            //var d = (b == a) && (b > a + 1);

            //Исключающее ИЛИ
            //var c = (a > b) ^ (a != b);

            //Console.WriteLine("c = {0}", c);
            //Console.WriteLine("d = {0}", d);

            //Задание 4.1.10
            //var inv = true;
            //var result = !inv;
            //Console.WriteLine(result);

            //Задание 4.1.14
            //var a = 6;
            //var b = 7;

            //if (a == b && b > 1)
            //{
            //    Console.WriteLine("Условие истинно");
            //}
            //else if (b > 10 || b == 7)
            //{
            //    Console.WriteLine("Значение b = {0} больше 10 или равно 7", b);
            //}
            //else
            //{
            //    Console.WriteLine("Значение b = {0}", b);
            //}

            //Задание 4.1.15
            //var a = 6;
            //var b = 7;
            //var c = a != b ? a + b : b;
            //Console.WriteLine(c);

            //Задание 4.1.16/4.1.17
            //Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы:");

            //var color = Console.ReadLine();

            //if (color == "red")
            //{
            //    Console.BackgroundColor = ConsoleColor.Red;
            //    Console.ForegroundColor = ConsoleColor.Black;

            //    Console.WriteLine("Ваш любимый цвет красный!");
            //}
            //else if (color == "green")
            //{
            //    Console.BackgroundColor = ConsoleColor.Green;
            //    Console.ForegroundColor = ConsoleColor.Black;

            //    Console.WriteLine("Ваш любимый цвет зеленый!");
            //}
            //else
            //{
            //    Console.BackgroundColor = ConsoleColor.Cyan;
            //    Console.ForegroundColor = ConsoleColor.Black;

            //    Console.WriteLine("Ваш любимый цвет бирюзовый!");
            //}

            //Задание 4.1.18
            //Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы:");

            //var color = Console.ReadLine();

            //switch (color)
            //{
            //    case "red":
            //        Console.BackgroundColor = ConsoleColor.Red;
            //        Console.ForegroundColor = ConsoleColor.Black;

            //        Console.WriteLine("Ваш любимый цвет красный!");
            //        break;

            //    case "green":
            //        Console.BackgroundColor = ConsoleColor.Green;
            //        Console.ForegroundColor = ConsoleColor.Black;

            //        Console.WriteLine("Ваш любимый цвет зеленый!");
            //        break;

            //    case "cyan":
            //        Console.BackgroundColor = ConsoleColor.Cyan;
            //        Console.ForegroundColor = ConsoleColor.Black;

            //        Console.WriteLine("Ваш любимый цвет бирюзовый");
            //        break;

            //    default:
            //        Console.BackgroundColor = ConsoleColor.Yellow;
            //        Console.ForegroundColor = ConsoleColor.Red;

            //        Console.WriteLine("Ваш любимый цвет тот, который вы ввели!");
            //        break;
            //}
        }
    }
}

