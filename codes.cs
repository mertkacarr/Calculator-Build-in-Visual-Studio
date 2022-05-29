using System;

namespace ConsoleApp2
{
	class Program
	{
		static void Main()
		{
			int number1, number2;

			double result;

			string process;

			Console.WriteLine("Please enter a number: ");
			number1 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Please enter the second number: ");
			number2 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Select an action(*,/,+,-): ");
			process = Console.ReadLine();

			if (process == "*")
			{
				result = number1 * number2;
				Console.WriteLine("Result: " + result);
			}

			if (process == "/")
			{
				result = number1 / number2;
				Console.WriteLine("Result: " + result);
			}

			if (process == "+")
			{
				result = number1 + number2;
				Console.WriteLine("Result: " + result);
			}

			if (process == "-")
			{
				result = number1 - number2;
				Console.WriteLine("Result: " + result);
			}
		}
	}
}
