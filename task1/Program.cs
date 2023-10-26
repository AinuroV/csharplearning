using System;

namespace yzech2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int tem = 0;
            int otr = -1;

            void chislo(params int[] numbers)
            {       
                
                var str = string.Join(" ", numbers); 
                Console.WriteLine("Вывод массива: " + str);
            }
            Console.WriteLine("Ввелите количество элементов массивва: ");
            int num = int.Parse(Console.ReadLine());
            int[] Array = new int[num];
            int[] Array2 = new int[num];
            Console.WriteLine("Введите элементы массива");
            for (int i = 0; i < Array.Length; i++)
            {

                Array[i] = Int32.Parse(Console.ReadLine());                
            }
            foreach(int numb in Array)
                if (numb > 0)
                    for(int j = 0; j < Array.Length; j++)
                        for(int t = 0; t < Array.Length-1; t++)
                        {
                            if(Array[t]*otr > Array[t+1]*otr)
                            tem = Array[t];
                            Array[t] = Array[t + 1];
                            Array[t + 1] = tem;
                        }
            chislo(Array);
           
            
            



           
        }
    }
}
