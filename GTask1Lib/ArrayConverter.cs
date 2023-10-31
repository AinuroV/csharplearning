namespace GTask1Lib
{
	/// <summary>
	/// Класс преобразователя массива.
	/// </summary>
	public class ArrayConverter
	{
		/// <summary>
		/// Функция принимает на вход массив и выводит его значения элементов в строку.
		/// </summary>
		/// <param name="arr">Непосредственно массив</param>
		public void PrintArray(int[] arr)
		{
			var strArr = String.Join("", arr);
			Console.WriteLine(strArr);
		}
	}
}
