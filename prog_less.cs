using System;
using System.Linq;
using System.Text;

namespace Lesson
{
	class Program
	{
		static void Main(string[] args)
		{
			Random rand = new Random();
			Console.WriteLine("Сколько чисел вы хотите вывести?");
			string s = Console.ReadLine();
			int a = Convert.ToInt32(s);
			for (int i = 0; i<a; i++)
			{
				Console.WriteLine(rand.Next(100));
			}
		}
	}
}
