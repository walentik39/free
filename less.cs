using System;

namespace project

{
	class Program
	{
		static void Main(){

			short[] nums = {5, 4, 6, 8, 12, 9, 2};
			foreach(short el in nums) {
				System.Console.WriteLine("Элемент: " + el);
			}
		}
	}
}
