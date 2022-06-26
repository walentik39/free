using System;

namespace project
{
	class Program {

		static void Main() {
			string word = "Hello";
			word += "!";

			System.Console.WriteLine(word.Trim()); // функция Trim() 
							       // убирает пробелы в строке.
			Console.WriteLine(word.Substring(0, word.Length - 1));//Обрезает символы в конце строки.				       
			Console.WriteLine(word.ToLower());//функция превращает текст к нижнему регистру
			Console.WriteLine(word.ToUpper());//функция приводит к верхнему регистру

		}
	}
}


