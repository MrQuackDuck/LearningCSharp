using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConstructions
{
    internal class Constants
    {
        public void Start()
        {
            Console.WriteLine(Formulas.PI);
            Console.WriteLine(Formulas.twoPlusTwo); // Constants are implicitly static
        }
    }

    class Formulas
    {
        public const float PI = 3.14F;
        public const int twoPlusTwo = 4;
    }
}
