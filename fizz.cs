//Thuy and Sarah FizzBuzz

using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Please input any number!");
		string input = Console.ReadLine();
		int user = int.Parse(input);
	for(int i = 0; i < user; i++)
	if (i % 3 == 0)
		{
			Console.WriteLine("fizz");
	}
		else if (i % 5 == 0)
		{
			Console.WriteLine("buzz");
	}
		else {
			Console.WriteLine(i);
		}
	}

}