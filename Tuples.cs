using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConstructions
{
    internal class Tuples
    {
        public void Start()
        {
            int numberToExponite = Int32.Parse(Console.ReadLine());
            (int, double)[] ExponentiateValues = new (int, double)[10];
            for(int i = 0; i < ExponentiateValues.Length; i++)
            {
                ExponentiateValues[i] = (i, Math.Pow(numberToExponite, i));
            }

            for (int i = 0; i < ExponentiateValues.Length; i++)
            {
                Console.WriteLine($"{numberToExponite} в {ExponentiateValues[i].Item1 + 1} степени > {ExponentiateValues[i].Item2}");
            }
        }
    }
}
