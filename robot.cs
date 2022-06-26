using System;

namespace project
{
	class Program {

		static void Main(){
			//Print("Привет!");
			//string words = "Hello world";
			//Print(words);
			//Print("words'\v'words");
			float res1 = Fun(23, 444);
			float a =55, b = 12;
			float res2 = Fun(a, b);

			Print(res1.ToString());
			Print(res2.ToString());

		}

		public static void Print(string word){

			Console.WriteLine(word);
		}

		public static float Fun(float x, float y){
			return x / y;
		}

	}
}

