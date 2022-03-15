using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConstructions
{
    internal class Classes
    {
        public void Start()
        {
            var tema = new Cat("Тёма", 4);
            tema.feedCat(2);

            var vasya = new Cat("Вася", -2);
            vasya.showAge();

            Console.WriteLine(Cat.energy); // Show readonly static field
        }
    }

    class Cat
    {

        private string name;
        private int age = 1;
        private double foodCount;
        public static readonly int energy = 100;


        public Cat(string catName) => name = catName;

        public Cat() { }
        public Cat(string name, int age = 1) // Constructor
        {
            this.name = name;
            checkAge(age);

            foodCount = age / 2;
        }

        public void checkAge(int age) // Check for validity methon
        {
            if (age >= 0)
            {
                this.age = age;
            }
        }


        public void showAge() // Show age
        {
            Console.WriteLine(this.age);
        }


        public void feedCat(int bonus = 0)
        {
            for(int i = 0; i < foodCount + bonus; i++)
            {
                Console.WriteLine($"{name} съел {i + 1} банок корма");
         
            } 
        }

        ~Cat()
        {
            Console.WriteLine($"Removing {name} by garbage collector!");
        }
    }
}
