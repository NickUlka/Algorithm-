using System;

namespace Algorithm_N9
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeMas = 10;
            int n;
            do
            {
                Console.Write("Введите длину массива от 1 до " + sizeMas + " - ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            while ((n > sizeMas) || (n<1));
            int[]Mas = new int[n];
            Console.WriteLine("Введите элементы массива");
            for (int i = 0; i < n; i++)
            {
                Mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Вы ввели следующий массив");
            for (int i = 0; i < n; i++)
            {
                Console.Write(Mas[i] + "  ");
            } 
        }
    }
}
