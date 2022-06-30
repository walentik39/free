using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Triangle_1
{
	/*
	 *  треугольник в консоле c#
	 */
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Введите высоту треугольника: ");
			int height = int.Parse(Console.ReadLine());


			for(int i = 0; i<height; i++)
			{
				for (int j =0; j <= i; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
			for (int x = 0; x <height; x++)
			{
				for (int y = height; y > x; y--)
				{
					Console.Write("#");
				}
				Console.WriteLine();
			}
		}
	}
}
