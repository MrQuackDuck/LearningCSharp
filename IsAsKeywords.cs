using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConstructions
{
    internal class IsAsKeywords
    {

        public void Start()
        {
            Person Vasya = new Person("Vasya", 15);
            Person.ShowName(Vasya);
            Person.ShowAge(Vasya);

            Cat Barsik = new Cat("Barsik", 4); // class from file Classes.cs
            Person.ShowName(Barsik);
            Person.ShowAge(Barsik);

        }
    }

    class Person
    {
        public string name;
        public int age;

        public Person(string name_, int age_) // Person constructor
        {
            name = name_;
            age = age_;
        }
        
        public static void ShowName(object obj) // As keyword
        {
            Person person = obj as Person; // in result person will be Person or Null

            if (person != null)
            {
                Console.WriteLine(person.name);
            }
            else
            {
                Console.WriteLine($"{obj} is not person!");
            }
        }

        public static void ShowAge(object obj) // Is keyword
        {
            if (obj is Person p) // Assigning person 'p' in condition
            {
             // Person p = (Person)obj; Alternative form without assigning in condition
                Console.WriteLine(p.age);
            }
            else
            { 
                Console.WriteLine($"{obj} is not person!");
            }
        }
    }
}
