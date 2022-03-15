using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConstructions
{
    class TwoDimensionalArray
    {
        public void Start()
        {
            Console.Write("Введите величину двумерного массива по Y (этажи): ");
            int height = Int32.Parse(Console.ReadLine());

            Console.Write("Введите величину массива по X (ячейки): ");
            int width = Int32.Parse(Console.ReadLine());

            int[,] doubledArray = new int[height, width];

            for (int i = 0; i < height; i++)
            {
                for (int k = 0; k < width; k++)
                {
                    Console.Write($"Введите {k} значение {i} этажа: ");
                    doubledArray[i, k] = Int32.Parse(Console.ReadLine());
                }
            }


            for (int i = 0; i < height; i++)
            {
                for (int k = 0; k < width; k++)
                {
                    Console.WriteLine($"X: {i} Y: {k}. Value: {doubledArray[i, k]}\n");
                }
            }
        }
    }
}
