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
            //Урок 4.3

            //Задание 4.3.17 - сортировка массива + вывод в порядке возрастания
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

            int irow = arr.GetUpperBound(0) + 1;
            int icolumn = arr.GetUpperBound(1) + 1;

            Console.WriteLine("Количество строк массива: {0}", irow);
            Console.WriteLine("Количество столбцов массива: {0}", icolumn);
            Console.WriteLine("Вывод массива:");

            for (int i = 0; i < arr.GetUpperBound(1) + 1; i++)
            {
                //for (int k = 0; k < arr.GetUpperBound(0) + 1; k++)
                //{
                    Console.Write(arr[0, i] + " ");
                //}
            }


            //Задание 4.3.16 - найти количество положительных элементов массива
            //int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

            //int sumfor = 0;
            //int sumforeach = 0;

            ////через цикл for:
            //for (int i = 0; i <= arr.GetUpperBound(0); i++)
            //{
            //    for (int j = 0; j <= arr.GetUpperBound(1); j++)
            //    {
            //        if (arr[i, j] > 0)
            //        {
            //            sumfor++;
            //        }
            //    }
            //}

            //Console.WriteLine("Количество положительных элементов массива (цикл for): {0}", sumfor);

            ////через цикл foreach:
            //foreach (var item in arr)
            //{
            //    if (item > 0)
            //    {
            //        sumforeach++;
            //    }
            //}

            //Console.WriteLine("Количество положительных элементов массива (цикл foreach): {0}", sumforeach);


            //Задание 4.3.15 - задать одномерный массив и вычислить количество положительных чисел
            //var array = new int[] { 2, 5, -3, 0, -4, 7 };

            //int sum = 0;

            ////foreach (var item in array)
            ////{
            ////    if (item > 0)
            ////    {
            ////        sum++;
            ////    }
            ////}

            ////ещё вариант
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] > 0)
            //    {
            //        sum++;
            //    }
            //}

            //Console.Write(sum);


            //Задание 4.3.14 - сделать перебор массива
            //int[][] array = new int[3][];

            //array[0] = new int[2] { 1, 2 };
            //array[1] = new int[3] { 1, 2, 3 };
            //array[2] = new int[5] { 1, 2, 3, 4, 5 };

            //foreach (var item1 in array)
            //{
            //    foreach (var item2 in item1)
            //    {
            //        Console.Write(item2 + " ");
            //    }
            //}

            //пример зубчатого массива - вывод в одну строку введенных цветов
            //string[] favcolors = new string[3];

            //for (int i = 0; i < favcolors.Length; i++)
            //{
            //    Console.WriteLine("Введите любимый цвет номер {0}", i + 1);
            //    favcolors[i] = Console.ReadLine();
            //}

            //foreach (var color in favcolors)
            //{
            //    foreach (var item in color)
            //    {
            //        Console.Write(item + " ");
            //    }
            //}


            //Задание 4.3.13 - найти сумму всех элементов массива
            //var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

            //int sum = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    //sum = sum + arr[i];
            //    //вариант покороче:
            //    sum += arr[i];
            //}

            //Console.WriteLine("Сумма всех элементов массива: ");
            //Console.Write(sum);


            //Задание 4.3.12 - отсортировать массив в порядке возрастания цифр
            //var arr = new int[] { 5, 6, 9, 1, 2, 3, 4 };

            //for (int i = 0; i < arr.Length - 1; i++)
            //{
            //    for (int k = 0; k < arr.Length - i - 1; k++)
            //    {
            //        if (arr[k] > arr[k + 1])
            //        {
            //            int temp = arr[k];
            //            arr[k] = arr[k + 1];
            //            arr[k + 1] = temp;
            //        }
            //    }
            //}

            //Console.WriteLine("Сортировка массива в порядке возрастания цифр:");

            //foreach (int num in arr)
            //{
            //    Console.Write(num);
            //}

            //ещё вариант:
            //int temp;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] > arr[j])
            //        {
            //            temp = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = temp;
            //        }
            //    }
            //}

            //Console.WriteLine("Сортировка массива в порядке возрастания цифр:");

            //foreach (var item in arr)
            //{
            //    Console.Write(item);
            //}


            //int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

            //Задание 4.3.11 - перебор по столбцам
            //for (int k = 0; k < array.GetUpperBound(1) + 1; k++)
            //{
            //    for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            //        Console.Write(array[i, k] + " ");
            //    Console.WriteLine();
            //}
            //ещё вариант:
            //for (int i = 0; i < array.GetUpperBound(1) + 1; i++)
            //{
            //    for (int k = 0; k < array.GetUpperBound(0) + 1; k++)
            //        Console.Write(array[k, i] + " ");
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            //{
            //    for (int k = 0; k < array.GetUpperBound(1) + 1; k++)
            //        Console.Write(array[i, k] + " ");
            //    Console.WriteLine();
            //}

            //int[,] array = { { 1, 2, 3 }, { 4, 5, 6 } };

            //for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
            //{
            //    for (int k = 0; k < array.GetUpperBound(1) + 1; k++)
            //        Console.Write(array[i, k] + " ");
            //        Console.WriteLine();
            //}

            //определяем количество строк (индекс последнего элемента первой (0) размерности
            //Console.Write("Количество строк: ");
            //Console.WriteLine(array.GetUpperBound(0) + 1 + " ");

            //определяем количество колонок
            //Console.Write("Количество колонок: ");
            //Console.WriteLine(array.GetUpperBound(1) + 1 + " ");

            //ошибка, т.к. массив двумерный
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}

            //вывести первый элемент массива
            //Console.WriteLine(array[0, 0]);

            //вывод массива в одну строку
            //foreach (var item in array)
            //{
            //    Console.Write(item + " ");
            //}

            //вывести длину массива
            //Console.WriteLine(array.Length);


            //Задание 4.3.7
            //Console.WriteLine("Введите свое имя:");

            //var name = Console.ReadLine();

            //Console.Write("Ваше имя в обратном порядке: ");

            //for (int i = 1; i < name.Length + 1; i++)
            //{
            //    Console.Write(name[name.Length - i]);
            //}

            //Console.WriteLine();
            //Console.Write("Второй вариант: ");

            //for (int i = name.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(name[i] + " ");
            //}


            //Console.WriteLine("Введите свое имя:");

            //var name = Console.ReadLine();

            //Console.WriteLine("Ваше имя по буквам:");

            //foreach (var number in name)
            //{
            //    Console.Write(number + " ");
            //}

            //Console.WriteLine();
            //Console.WriteLine("Первая буква вашего имени: {0}", name[0]);
            //Console.WriteLine("Последняя буква вашего имени: {0}", name[name.Length - 1]);

            //string[] favcolors = new string[3];

            //for (int i = 0; i < favcolors.Length; i++)
            //{
            //    Console.WriteLine("Введите любимый цвет номер {0}", i + 1);
            //    favcolors[i] = Console.ReadLine();
            //}

            //Console.WriteLine(favcolors[3]); //будет ошибка, т.к. в массиве три элемента, а индекс ссылается на четвёртый (нумерация с 0)

            //var numbers = new int[] { 6, 30, 7, 14, 4, 15 };
            //int minValue = 100000,
            //    minIndex = -1,
            //    maxValue = 0,
            //    maxIndex = -1;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] < minValue)
            //    {
            //        minValue = numbers[i];
            //        minIndex = i;
            //    }
            //    if (numbers[i] > maxValue)
            //    {
            //        maxValue = numbers[i];
            //        maxIndex = i;
            //    }
            //}
            //Console.WriteLine("Наименьший элемент массива равен {0}, его индекс {1}", minValue /*numbers[minIndex]*/, minIndex);
            //Console.WriteLine("Наибольший элемент массива равен {0}, его индекс {1}", numbers[maxIndex], maxIndex);

            Console.WriteLine();
            Console.WriteLine("Для продолжения нажмите любую кнопку");
            Console.ReadKey();

            //string[] favcolors = new string[3];

            //for (int i = 0; i < favcolors.Length; i++)
            //{
            //    Console.WriteLine("Введите любимый цвет номер {0}", i + 1);
            //    favcolors[i] = Console.ReadLine();
            //}

            //foreach (var color in favcolors)
            //{
            //    switch (color)
            //    {
            //        case "red":
            //            Console.BackgroundColor = ConsoleColor.Red;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Ваш любимый цвет красный!");
            //            break;

            //        case "green":
            //            Console.BackgroundColor = ConsoleColor.Green;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Ваш любимый цвет зеленый!");
            //            break;

            //        case "cyan":
            //            Console.BackgroundColor = ConsoleColor.Cyan;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Ваш любимый цвет бирюзовый");
            //            break;

            //        default:
            //            Console.BackgroundColor = ConsoleColor.Yellow;
            //            Console.ForegroundColor = ConsoleColor.Red;

            //            Console.WriteLine("Ваш любимый цвет тот, который вы ввели!");
            //            break;
            //    }
            //}

            //Console.BackgroundColor = ConsoleColor.Black;
            //Console.ForegroundColor = ConsoleColor.White;


            //Урок 4.2.
            //программа будет считать сумму вводимых чисел, которые больше 0, и превётся при вводе числа 0
            //int sum = 0;

            //while (true)
            //{
            //    Console.WriteLine("Введите число");
            //    var number = Convert.ToInt32(Console.ReadLine());

            //    if (number < 0)
            //    {
            //        continue;
            //    }
            //    else if (number == 0)
            //    {
            //        break;
            //    }
            //    //number > 0
            //    sum += number;
            //}

            //Console.WriteLine("Итоговая сумма = {0}", sum);

            //for (int i = 0; i < 5; i++)
            //for (int i = 5; i > 1; i--)

            //Console.WriteLine("Цикл While");

            //int k = 0;

            //while (k < 5)
            //{
            //    Console.BackgroundColor = ConsoleColor.Black;
            //    Console.ForegroundColor = ConsoleColor.White;
            //    Console.WriteLine("Iteration {0}", k);
            //    Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы:");

            //    var text = Console.ReadLine();

            //    if (text == "stop")
            //    {
            //        Console.WriteLine("Цикл остановлен");
            //        break;
            //    }

            //switch (Console.ReadLine())
            //switch (text)
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

            //        Console.WriteLine("Ваш любимый цвет бирюзовый!");
            //        break;

            //    default:
            //        continue; //в этом случае номер итерации не меняется, если введен цвет, отличный от вышеуказанных
            //Console.BackgroundColor = ConsoleColor.Yellow;
            //Console.ForegroundColor = ConsoleColor.Red;

            //Console.WriteLine("Ваш любимый цвет тот, который вы ввели!");
            //break;
            //}

            //if (text == "stop")
            //{
            //    Console.WriteLine("Цикл остановлен");
            //    break;
            //}

            //    k++;
            //}

            //Console.BackgroundColor = ConsoleColor.Black;
            //Console.ForegroundColor = ConsoleColor.White;

            //Console.WriteLine("Цикл do ... while");

            //int t = 0;



            //do
            //{
            //    var text = Console.ReadLine();

            //    if (text == "stop")
            //    {
            //        Console.WriteLine("Цикл остановлен");
            //        break;
            //    }

            //    Console.BackgroundColor = ConsoleColor.Black;
            //    Console.ForegroundColor = ConsoleColor.White;
            //    Console.WriteLine();
            //    Console.WriteLine("Iteration {0}", t);
            //    Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы:");
            //    switch (Console.ReadLine())
            //    {

            //        case "red":
            //            Console.BackgroundColor = ConsoleColor.Red;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Ваш любимый цвет красный!");
            //            break;

            //        case "green":
            //            Console.BackgroundColor = ConsoleColor.Green;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Ваш любимый цвет зеленый!");
            //            break;

            //        case "cyan":
            //            Console.BackgroundColor = ConsoleColor.Cyan;
            //            Console.ForegroundColor = ConsoleColor.Black;

            //            Console.WriteLine("Ваш любимый цвет бирюзовый!");
            //            break;

            //        default:
            //            Console.BackgroundColor = ConsoleColor.Yellow;
            //            Console.ForegroundColor = ConsoleColor.Red;

            //            Console.WriteLine("Ваш любимый цвет тот, который вы ввели!");
            //            break;
            //    }
            //    t++;
            //}
            //while (t < 1);


            //Console.BackgroundColor = ConsoleColor.Black;
            //Console.ForegroundColor = ConsoleColor.White;


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

