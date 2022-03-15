using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConstructions
{
    internal class HowManyCores
    {
        public void Start()
        {
            Console.WriteLine($"У вас {Environment.ProcessorCount} ядер процессора");
        }
    }
}
