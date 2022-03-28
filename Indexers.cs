using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConstructions
{
    internal class Indexers
    {
        public void Start()
        {
            Cats myCatZoo = new Cats();
            myCatZoo[0] = new Cat("Barsik", 4);
            myCatZoo[1] = new Cat("Tema", 5);
            myCatZoo[2] = new Cat("Barsik", 3);
            myCatZoo[3] = new Cat("Tolik", 6);
        }
    }

    class Cats
    {
        Cat[] cats = new Cat[4];

        public Cat this[int index]
        {
            get => cats[index];
            set => cats[index] = value;
        }
    }
}
