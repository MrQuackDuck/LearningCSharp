using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConstructions
{
    public delegate void CheckHandler<T>(T Value);

    internal class GenericDelegates
    {
        public void Start()
        {
            PlaystationConsole PS5 = new PlaystationConsole();
            PS5.setRAMHandler(Checker.CheckFreeMemory);
            PS5.setGPUMemHandler(Checker.CheckFreeMemory);

            PS5.FreeRAM = 4200;
            PS5.FreeGPUMem = 200;

            PS5.CheckRAMhandler(PS5.FreeRAM);
            PS5.CheckRAMhandler(PS5.FreeGPUMem);

            Func<long, long> Fact = Factorial;
            Console.WriteLine(Fact(10));
        }

        static long Factorial(long x)
        {
            if (x == 1) 
                return 1;
            return x * Factorial(x - 1);
        }
    }

    class PlaystationConsole
    {
        private double freeRAM;
        public double FreeRAM
        {
            get
            {
                return freeRAM;
            }
            set
            {
                if(value >= 0)
                {
                    freeRAM = value;
                }
            }
        }

        private double freeGPUMem;
        public double FreeGPUMem
        {
            get
            {
                return freeGPUMem;
            }
            set
            {
                if (value >= 0)
                {
                    freeGPUMem = value;
                }
            }
        }

        public CheckHandler<double> CheckRAMhandler;
        public void setRAMHandler(CheckHandler<double> checkRAMHandler)
        {
            CheckRAMhandler = checkRAMHandler;
        }

        public CheckHandler<double> CheckGPUMemHandler;
        public void setGPUMemHandler(CheckHandler<double> checkGPUMemHandler)
        {
            CheckGPUMemHandler = checkGPUMemHandler;
        }
    }

    static class Checker
    {
        public static void CheckFreeMemory(double Value)
        {
            if (Value <= 200)
            {
                Console.WriteLine($"{Value} mb ree. Status: Very bad.");
            } 
            else if (Value >= 200 && Value <= 1000)
            {
                Console.WriteLine($"{Value} mb free. Status: Normal.");
            }
            else
            {
                Console.WriteLine($"{Value} mb free. Status: Good.");
            }
        }
    }
}
