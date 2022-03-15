using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConstructions
{
    internal class Properties
    {
        public void Start()
        {
            var Ferrari = new Car("Pista 488") { FuelAmount = 10 };
            Ferrari.FuelAmount = -10; // In FuelAmount will be set 0 because of checking (line 29)

            Console.WriteLine(Ferrari.FuelAmount);
            Console.WriteLine(Ferrari.modelOfCar);
        }
    }

    class Car
    {
        public string modelOfCar { get; set; } = "noModel"; // Automatic property + (Default value)


        private int fuelAmount; // Using property
        public int FuelAmount
        {
            get 
            {
                return fuelAmount;
            }
            set 
            { 
                if (value >= 0) // Checking a value before assigning to variable
                {
                    fuelAmount = value;
                } else
                {
                    fuelAmount = 0;
                }
            }
        }

        public Car(string carModel) // Car constructor
        {
            modelOfCar = carModel; // Handling automatic property (line 23)
        }

        

    }
}
