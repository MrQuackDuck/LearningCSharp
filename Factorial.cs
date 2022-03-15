using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConstructions
{
    internal class Factorial
    {
        public void Start()
        {
            Console.WriteLine(Fact(10));
        }

        static int Fact(int x)
        {
            if (x == 1) return 1;
            return x * Fact(x - 1);
        }
    }
}
