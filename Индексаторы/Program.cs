using System;

namespace Индексаторы
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArr arr1 = new MyArr(2, 2);

            Console.WriteLine("Введите значения для массива:");
            for (int i = 0; i < arr1.ReturnRows; i++)
            {
                for (int h = 0; h < arr1.ReturnCols; h++)
                {
                    arr1[i, h] = int.Parse(Console.ReadLine());
                }

            }

            Console.WriteLine("---------******---------");
            for (int i = 0; i < arr1.ReturnRows; i++)
            {
                for (int h = 0; h < arr1.ReturnCols; h++)
                {
                    Console.Write($"arr[{i},{h}] = {arr1[i, h]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Введите номер столбца ({0} - {1})",1,arr1.ReturnCols);
            int j = int.Parse(Console.ReadLine());
            Console.WriteLine("Значения выбранного столбца:");
            for ( int i = 0 ; i < arr1.ReturnCols; i++)
            arr1[i,j-1] = int.Parse(Console.ReadLine());

            Console.WriteLine($"Размер массива:{arr1.ReturnLength}");

            Console.WriteLine();

            Console.WriteLine("---------******---------");
            for (int i = 0; i < arr1.ReturnRows; i++)
            {
                for (int h = 0; h < arr1.ReturnCols; h++)
                {
                    Console.Write($"arr[{i},{h}] = {arr1[i, h]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
