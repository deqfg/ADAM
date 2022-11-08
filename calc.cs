 using System;
namespace Calc
{
	class Prog
	{
		
		static void Main()
		{
			double c = 0.0, a, b;
			string info = "Калькулятор\n";
			string actions = "  1 - сложение\n 2 - вычитание\n 3 - умножение\n 4 - деление\n 5 - степень\n 6 - квадратный корень\n 7 - выйти\n 8 - показать сообщение\n";
			Console.WriteLine(info, "\n");
			Console.WriteLine(actions, "\n");
			while (true) 
		{
			int act = Convert.ToInt32(Console.ReadLine());
			switch (act)
			{
				case 1:
					Console.Write("Введите первое число: ");
					a = Convert.ToInt32(Console.ReadLine());
					Console.Write("Введите второе число: ");
					b = Convert.ToInt32(Console.ReadLine());
					c = a + b;
					Console.WriteLine("Результат: "+c);
					break;
				case 2:
					
					Console.Write("Введите первое число: ");
					a = Convert.ToInt32(Console.ReadLine());
					Console.Write("Введите второе число: ");
					b = Convert.ToInt32(Console.ReadLine());
					c = a - b;
					Console.WriteLine("Результат: "+c);
					break;
				case 3:
					Console.Write("Введите первое число: ");
					a = Convert.ToInt32(Console.ReadLine());
					Console.Write("Введите второе число: ");
					b = Convert.ToInt32(Console.ReadLine());
					c = a * b;
					Console.WriteLine("Результат: "+c);
					break;
				case 4:
					Console.Write("Введите первое число: ");
					a = Convert.ToInt32(Console.ReadLine());
					Console.Write("Введите второе число: ");
					b = Convert.ToInt32(Console.ReadLine());
					c = a / b;
					Console.WriteLine("Результат: "+c);
					break;
				case 5:
					Console.Write("Введите первое число: ");
					a = Convert.ToInt32(Console.ReadLine());
					Console.Write("Введите степень: ");
					b = Convert.ToInt32(Console.ReadLine());
					double res = 1;
					for (int i = 1; i <=b; i++)
					{
						res = res * a;
					}
					Console.WriteLine("Результат: "+res);
					break;
				case 6:
					Console.Write("Введите число: ");
					a = Convert.ToInt32(Console.ReadLine());
					double res1 = Math.Sqrt(a);
					Console.WriteLine("Результат: "+res1);
					break;
				case 7:
					Environment.Exit(0);
					break;
				case 8:
					Console.WriteLine(info, "\n");
					Console.WriteLine(actions, "\n");
					break;
			}
		}
	}
	}
}
