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
            //Урок 4.5. Практикум
            //Задача: Необходимо разработать методику анкетирования пользователей. Требуется сохранять информацию: об имени пользователя, фамилии, логине, длине логина, наличии/отсутствии у пользователя питомца, возрасте пользователя, трех любимых цветах пользователя.

            //Задание 4.5.1 - Задайте кортеж User, который описывает необходимую информацию.
            (string Name, string LastName, string Login, int LoginLength, bool HasPet, double Age, string[] favcolors) User;
            //Конец задания 4.5.1

            for (int j = 0; j < 3; j++)
            {

                //Задание 4.5.2 - Заполните кортеж User значениями с клавиатуры для полей: имя пользователя, фамилия, логин.
                Console.WriteLine("Введите имя");
                User.Name = Console.ReadLine();
                Console.WriteLine("Введите фамилию");
                User.LastName = Console.ReadLine();
                Console.WriteLine("Введите логин");
                User.Login = Console.ReadLine();
                //Конец задания 4.5.2

                //Задание 4.5.3 - Вычислите длину логина пользователя.
                User.LoginLength = User.Login.Length;
                //Конец задания 4.5.3

                //Задание 4.5.4 - Напишите условие, которое устанавливает значение ИСТИНА в поле наличие/отсутствие животных, если пользователь вводит "Да", и ЛОЖЬ при любом другом варианте.
                Console.WriteLine("Есть ли у вас животные? Да или Нет?");

                var result = Console.ReadLine();

                if (result == "Да")
                {
                    User.HasPet = true;
                }
                else
                {
                    User.HasPet = false;
                }
                //Конец задания 4.5.4

                //Задание 4.5.5 - Напишите код для ввода возраста пользователя и трех его любимых цветов.
                Console.WriteLine("Введите возраст");
                User.Age = Convert.ToDouble(Console.ReadLine());
                //или так:
                //User.Age = double.Parse(Console.ReadLine());

                User.favcolors = new string[3];

                Console.WriteLine("Введите три любимых цвета");

                for (int i = 0; i < User.favcolors.Length; i++)
                {
                    User.favcolors[i] = Console.ReadLine();
                }
                //Конец задания 4.5.5
            }
            //Задание 4.5.6 - Сделайте так, чтобы опрос повторялся для трех пользователей.
            //После объявления кортежа добавляем общий цикл и внутрь него весь написанный код.
            //Конец задания 4.5.6


            //Урок 4.4. Кортежи

            //Задание 4.4.5 - заполнить заданный кортеж значениями
            //(string Name, string Type, double Age, int NameCount) Pet;

            //Console.Write("Введите имя питомца: ");
            //Pet.Name = Console.ReadLine();
            //Console.Write("Введите тип питомца: ");
            //Pet.Type = Console.ReadLine();
            //Console.Write("Введите возраст питомца: ");
            //Pet.Age = Convert.ToDouble(Console.ReadLine());
            //Pet.NameCount = Pet.Name.Length;

            //Console.WriteLine();
            //Console.WriteLine("Имя вашего питомца: {0}", Pet.Name);
            //Console.WriteLine("Тип вашего питомца: {0}", Pet.Type);
            //Console.WriteLine("Возраст вашего питомца: {0}", Pet.Age);
            //Console.WriteLine("Длина имени вашего питомца: {0}", Pet.NameCount);

            //Console.ReadKey();
            //Конец задания 4.4.5

            //Задание 4.4.4 - задать кортеж с информацией о домашнем животном без начальных данных
            //(string Name, string Type, double Age) Pet;
            //Конец задания 4.4.4

            //Задание 4.4.3 - сначала вывести информацию на экран, затем запросить её ввод с клавиатуры
            //var (name, age) = ("Евгения", 27);
            //Console.WriteLine("Моё имя: {0}", name);
            //Console.WriteLine("Мой возраст: {0}", age);

            //Console.Write("Введите своё имя: ");
            //name = Console.ReadLine();
            //Console.Write("Введите свой возраст: ");
            //age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("Ваше имя: {0}", name);
            //Console.WriteLine("Ваш возраст: {0}", age);

            //Console.ReadKey();
            //Конец задания 4.4.3

            //Задание 4.4.2 - внести введённую информацию в кортеж
            //Console.Write("Введите своё имя: ");
            //var name = Console.ReadLine();
            //Console.Write("Введите свой возраст: ");
            //var age = Console.ReadLine();

            //Console.WriteLine();

            //var anketa = (name, age);

            //Console.WriteLine("Ваше имя: {0}", anketa.name);
            //Console.WriteLine("Ваш возраст: {0}", anketa.age);

            //ещё вариант, более логичный:
            //(string name, int age) anketa;

            //Console.Write("Введите своё имя: ");
            //anketa.name = Console.ReadLine();
            //Console.Write("Введите свой возраст: ");
            //anketa.age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine("Ваше имя: {0}", anketa.name);
            //Console.WriteLine("Ваш возраст: {0}", anketa.age);

            //Console.ReadKey();
            //Конец задания 4.4.2.


            //Урок 4.3 Массивы

            //Задание 4.3.17 - сортировка массива + вывод в порядке возрастания
            //int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };

            //Console.WriteLine("int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };");
            //Console.WriteLine();

            //for (int i = 0; i <= arr.GetUpperBound(0); i++)
            //{
            //    for (int j = 0; j <= arr.GetUpperBound(1); j++)
            //        Console.Write(arr[i, j] + " ");
            //        Console.WriteLine();
            //}

            //Console.WriteLine();

            //int temp;
            //for (int i = 0; i <= arr.GetUpperBound(0); i++)
            //{
            //    for (int j = 0; j <= arr.GetUpperBound(1); j++)
            //        for (int k = j + 1; k <= arr.GetUpperBound(1); k++)
            //            if (arr[i, j] > arr[i, k])
            //            {
            //                temp = arr[i, k];
            //                arr[i, k] = arr[i, j];
            //                arr[i, j] = temp;
            //            }
            //}
            //дублируем код для вывода результата, только уже после перестановки значений:
            //for (int i = 0; i <= arr.GetUpperBound(0); i++)
            //{
            //    for (int j = 0; j <= arr.GetUpperBound(1); j++)
            //        Console.Write(arr[i, j] + " ");
            //        Console.WriteLine();
            //}
            //Конец задания 4.3.17.

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
            //int[,] array = { { 1, 2, 3 }, { 5, 6, 7 }, { 8, 9, 10 }, { 11, 12, 13 } };

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

            //Console.WriteLine();
            //Console.WriteLine("Для продолжения нажмите любую кнопку");
            //Console.ReadKey();
        }
    }
}

