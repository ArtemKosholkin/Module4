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
            var a = 6;
            var b = 7;

            if (a == b && b > 1)
            {
                Console.WriteLine("Условие истинно");
            }
            else if (b > 10 || b == 7)
            {
                Console.WriteLine("Значение b = {0} больше 10 или равно 7", b);
            }
            else
            {
                Console.WriteLine("Значение b = {0}", b);
            }
            

            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую кнопку");
            Console.ReadKey();
        }
    }
}
