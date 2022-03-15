using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConstructions
{
    internal class SwitchCase
    {
        public void Start()
        {
            var Michael = new Customer("Мишка", 18);
            ClubPass(Michael);

            var Vaska = new SecurityGuard("Васька", 200, 1);
            ClubPass(Vaska);
        }

        static void ClubPass(object obj)
        {
            if(obj is Person p)
            {
                switch (p)
                {
                    case Customer c when c.age >= 18:
                        Console.WriteLine("Проходите, {0}!", c.name);
                        break;
                    case Customer c when c.age < 18:
                        Console.WriteLine("Вы слишком молод!");
                        break;
                    case SecurityGuard sg:
                        Console.WriteLine("Привет. Теперь твоя смена работать, {0}!", sg.name);
                        break;
                }
            }
        }

        class SecurityGuard : Person
        {
            public int Salary { get; }
            public SecurityGuard(string name, int age, int salary_) : base(name, age)
            {
                Salary = salary_;
            }
        }
        class Customer : Person
        {
            public Customer(string name, int age) : base(name, age) { }
        }
    }
}
