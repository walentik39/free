using System;

namespace project {

	class Program {

		static void Main(){
			string word = "Hello";
			word += "!!!";

			//System.Console.WriteLine(word.Length);
			//word = String.Concat(word, "??");
			//Console.WriteLine(String.Compare(word, "Hello"));
			//Console.WriteLine(String.Compare(word, "Hello!!"));
			//Console.WriteLine(String.Compare(word, "Hello!!!"));
			//Console.WriteLine(String.Compare(word, "Hello!!!!"));

			string people = "Валентин,Максим,Юля";
			string[] names = people.Split(new char[]{','});
			foreach(string el in names)
				System.Console.WriteLine(el);
			people = String.Join(" ", names);
			System.Console.WriteLine(people);
		}
	}
}


