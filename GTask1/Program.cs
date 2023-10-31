using GTask1Lib;

namespace GTask1
{
	/// <summary>
	/// Необходимо создать новое решение, состоящее из двух проектов:
	/// библиотека с классами; консольная утилита. 
	/// Написать функцию, формирующую и возвращающую строку вида 1, 2, 3, … N (положительное число).
	/// Значение N передаётся в функцию в качестве аргумента. Пример возвращаемого значения для N= 7: 1, 2, 3, 4, 5, 6, 7.
	/// Утилита должна принимать от пользователя параметр N.
	/// </summary>
	internal class Program
	{
		static void Main(string[] args)
		{
			try
			{
				// Создаем объект конвертера из библиотеки классов.
				var converter = new ArrayConverter();

				var numbers = InputData();

				converter.PrintArray(numbers.Where(number => number > 0).ToArray());
			}
			// Если ввели не числовые значения.
			catch (FormatException e)
			{
				Console.WriteLine("Ошибка ввода данных. Убедитесь, что вы ввели числовые значения.");
			}
			catch (Exception e)
			{
				Console.WriteLine($"Во время работы возникла ошибка: {e.Message}");
			}
		}

		/// <summary>
		/// Функция ввода данных.
		/// </summary>
		private static int[] InputData()
		{
			int[] numbers;
			
			var numbersCount = int.Parse(Console.ReadLine());

			if (numbersCount <= 0 ) 
			{
				throw new Exception("Введено неверное количество символов.");
			}

			numbers = new int[numbersCount];

			for (var i = 0; i <  numbersCount; i++) 
			{
				numbers[i] = int.Parse(Console.ReadLine());
			}

			return numbers;
		}
	}
}