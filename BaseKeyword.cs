using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConstructions
{
    internal class BaseKeyword
    {
        public void Start()
        {
            var myBuilding = new Building(50, 10);
            myBuilding.ShowBuildingStats();

            var SilpoStore = new Store(1000, 20, 400);
            SilpoStore.ShowStoreStats();
        }
    }

    class Building
    {
        protected int Width { get; set; }
        protected int Height { get; set; }

        public Building(int width, int height)
        {
            Width = width;
            Height = height;
        }


        public void ShowBuildingStats()
        {
            Console.WriteLine("");
            Console.WriteLine($"INFO: Building width: {Width}");
            Console.WriteLine($"INFO: Building width: {Height}");
        }
    }

    class Store : Building
    {
        private int Customers { get; set; }

        public Store(int width, int height, int customers) : base(width, height)
        {
            Customers = customers;
        }

        public void ShowStoreStats()
        {
            base.ShowBuildingStats();
            Console.WriteLine($"INFO: Customers per day: {Customers}");
        }
    }

}
