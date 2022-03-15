using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConstructions
{
    internal class Inheritance
    {
        public void Start()
        {
            var myWolf = new Wolf(4);
            Console.WriteLine(myWolf.PawCount);

            var myOwl = new Owl(2);
            myOwl.makeSound();
        }
    }

    class Animal
    {
        private int pawCount;

        public int PawCount // Property
        {
            get
            {
                return pawCount;
            }

            set
            {
                if (value > 0)
                {
                    pawCount = value;
                }
            }
        }

        public Animal(int _pawCount)
        {
            PawCount = _pawCount;
        }
    }

    class Wolf : Animal
    {
        public Wolf(int _pawCount) : base(_pawCount)
        {
            PawCount = _pawCount;
            
        }


    }

    
    sealed class Owl : Animal // Sealed class means that it can't be as parent class
                              // But sealed classes can be inherited from another class
    {
        public Owl(int _pawCount) : base(_pawCount)
        {
            PawCount = _pawCount;
        }

        public void makeSound()
        {
            Console.WriteLine("Wooo! Woo!");
        }
    }

    
    /*  class Filin : Owl // Error! Any class cannot be inherited from Owl class
       {

       }   
    */
}
