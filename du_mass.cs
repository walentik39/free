using System;
using System.Collections;
using System.Linq;

namespace Lessons
{
	class Program
	{
		static void Main(string[] args)
		{
			int[,] myArray = new int[,]
			{
				{1,3,5,7,9},
				{2,4,6,8,10},
				{10,20,30,40,50}

			};
			//foreach(var item in myArray)
			//{
			//	Console.Write(item);
			//}

			//Console.WriteLine("***\t");
			//Console.WriteLine(myArray.Rank);
			//int heigth = myArray.GetLength(0);
			//int width = myArray.GetLength(1);
			for(int y = 0; y<myArray.GetLength(0); y++)
			{
				for(int x =0; x<myArray.GetLength(1);x++)
				{
					Console.Write(myArray[y,x]+"\t");
				}
				Console.WriteLine();
			}
		}
	}
}



