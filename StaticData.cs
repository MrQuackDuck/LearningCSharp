using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConstructions
{
    internal class StaticData
    {
        public void Start()
        {
            var morshynska = new WaterBottle();
            var karptskaDjerelna = new WaterBottle();

            morshynska.showWaterCount();

            karptskaDjerelna.updateWaterCount(3);

            morshynska.showWaterCount();
            Console.WriteLine("Result: Static data is the same for all objects");

            int myValue = MathFunctions.Add(1, 2);  // Static method call of static class (line 48)
            Console.WriteLine(myValue);
        }
    }

    class WaterBottle
    {
        private static int waterCount = 10; // Static data (the same for all objects)

        static WaterBottle() // Static counstructor
        {
            waterCount = 5;
        }

        public void updateWaterCount(int liters)
        {
            waterCount = liters;
        }

        public void showWaterCount()
        {
            Console.WriteLine(waterCount);
        }
    }

    static class MathFunctions   // Static class with static methods and data
    {
        // Method overloading
        public static double Add(double firstValue, double secondValue)
        {
            return (firstValue + secondValue);
        }
        public static int Add(int firstValue, int secondValue)
        {
            return (firstValue + secondValue);
        }
    }
}
