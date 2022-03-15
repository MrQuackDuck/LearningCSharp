using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConstructions
{
    class Constructors
    {
        public void Start()
        {
            var myNumManipulator = new NumberManipulation(2, 2);
            Console.WriteLine(myNumManipulator.Multiply());

            var myNumManipulator2 = new NumberManipulation() { firstValue = 4, secondValue = 10 };
            Console.WriteLine(myNumManipulator2.Add());
        }
    }

    class NumberManipulation
    {
        public int firstValue { get; set; }
        public int secondValue { get; set; }

        public NumberManipulation() { }
        public NumberManipulation(int FirstValue, int SecondValue) // Class constructor
        {
            firstValue = FirstValue;
            secondValue = SecondValue;
        }

        public int Add()
        {
            return firstValue + secondValue;
        }

        public int Substract()
        {
            return firstValue - secondValue;
        }

        public int Multiply()
        {
            return firstValue * secondValue;
        }

        public double Divide()
        {
            return firstValue / secondValue;
        }
    }
}
