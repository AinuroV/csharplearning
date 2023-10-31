using System;

namespace yzech2._1
{
    class Program
    {
        static void Main(string[] args)
		{
			try
			{
				// Создаем объект конвертера из библиотеки классов.
				var converter = new ArrayConverter();

				var numbers = InputData();

				converter.PrintArray(numbers);
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
            Console.WriteLine("Введите количество элементов в массиве: ");

			var numbersCount = int.Parse(Console.ReadLine());

			if (numbersCount <= 0)
			{
                Console.WriteLine("Введено неверное количество символов.");
			}

			numbers = new int[numbersCount];
			Console.WriteLine("Введите элементы массива: ");
			for (var i = 0; i < numbers.Length; i++)// Заполнение элементов в массив
			{
               
				numbers[i] = int.Parse(Console.ReadLine());
			}

			return numbers;
		}
	}
	public class ArrayConverter
	{
		/// <summary>
		/// Функция принимает на вход массив и выводит его значения элементов в строку.
		/// </summary>
		/// <param name="arr">Непосредственно массив</param>
		public void PrintArray(int[] arr)
		{
			var strArr = String.Join("", arr);// конвертируем элементы массива в строку 
			Console.WriteLine(strArr);// Вывод массива
		}
	}
}
