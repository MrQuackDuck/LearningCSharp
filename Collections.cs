using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConstructions
{
    internal class Collections
    {
        public void Start()
        {
            YogurtShop YShop = new YogurtShop();
            YShop.AddYogurt(new Yogurt("Danone", 60));
            Console.WriteLine(YShop.GetYogurt(0));


            List<Milk> MShop = new List<Milk>() { new Milk("Milka", 1000), new Milk("Korowa", 2000) };
            foreach(Milk milk in MShop)
            {
                Console.WriteLine(milk);
            }
            MShop.Add(new Milk("Selyanske", 900));

            Console.WriteLine(MShop[2]);
            
        }
    }


    class Yogurt
    {
        readonly string name;
        readonly double weight;
        readonly DateTime dateOfManafacture;

        public Yogurt(string name_, double weight_)
        {
            name = name_;
            weight = weight_;
            dateOfManafacture = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{name}:\n\tDate of manafacture {dateOfManafacture}\n\tWeight: {weight} gr";
        }
    }
    // Own nongeneric collection
    class YogurtShop : IEnumerable
    {
        ArrayList Yogurts = new ArrayList();
        public Yogurt GetYogurt(int pos) => (Yogurt)Yogurts[pos];
        public IEnumerator GetEnumerator() => Yogurts.GetEnumerator();
        public void AddYogurt(Yogurt y)
        {
            Yogurts.Add(y);
        }

        public YogurtShop() { }
        public YogurtShop(Yogurt[] yogs)
        {
            foreach(Yogurt yogurt in yogs)
            {
                AddYogurt(yogurt);
            }
        }
    }


    class Milk
    {
        readonly string name;
        readonly double weight;
        readonly DateTime dateOfManafacture;

        public Milk(string name_, double weight_)
        {
            name = name_;
            weight = weight_;
            dateOfManafacture = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{name}:\n\tDate of manafacture {dateOfManafacture}\n\tWeight: {weight} gr";
        }
    }
}
