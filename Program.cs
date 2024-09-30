using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var myapples = 5;
            var hisapples = 6;
            var hispeares = 5;

            var result = (myapples != hispeares) & (myapples < hisapples);

            Console.WriteLine(result);
            Console.ReadKey();*/

            //4.1.4
            /*string A;
            string B;
            bool C = A != B;
            Console.WriteLine(C);
            Console.ReadKey();

            int A;
            int B;
            double X;
            double Y;
            bool C = (A < B) | (X > Y);*/

            /*var a = 6;
		    var b = 7;

		    if (a == b)
		    {
			Console.WriteLine("Условие истинно");
		    }
		    else
		    {
			Console.WriteLine("Условие ложно");
		    }
            Console.ReadKey();*/

            /*var a = 6;
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
            Console.ReadKey();*/

            /*var a = 6;
		var b = 7;

		var c = a != b ? a + b : b;

		Console.WriteLine(c);
            Console.ReadKey();*/

            Console.WriteLine ("Напишите свой любимый цвет на английском с маленькой буквы");
		
		var color = Console.ReadLine();

		if (color == "red")
		{
			Console.BackgroundColor = ConsoleColor.Red;
			Console.ForegroundColor = ConsoleColor.Black;

			Console.WriteLine("Your color is red!");
		}

		else if (color == "green")
		{
			Console.BackgroundColor = ConsoleColor.Green;
			Console.ForegroundColor = ConsoleColor.Black;

			Console.WriteLine("Your color is green!");
		}
		else
		{
			Console.BackgroundColor = ConsoleColor.Cyan;
			Console.ForegroundColor = ConsoleColor.Black;

			Console.WriteLine("Your color is cyan!");
		}
		Console.ReadKey();

        }
    }
}
