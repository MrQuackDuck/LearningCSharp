using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConstructions
{
    internal class NestedClasses
    {
        public void Start()
        {
            var myNestedClass = new ExampleClass.NestedClass();
            myNestedClass.SimpleMethod();
        }
    }

    class ExampleClass
    {
        public class NestedClass
        {
            public void SimpleMethod()
            {
                Console.WriteLine("Nested class method!");
            }
        }
    }
}
