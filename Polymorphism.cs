using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConstructions
{
    internal class Polymorphism
    {
        public void Start()
        {
            Console.WriteLine("PC INFO:");
            var PCinfo = new PCInformation();
            PCinfo.ShowInfo();

            Console.WriteLine("\nServer INFO:");
            var servInfo = new ServerInformation();
            servInfo.ShowInfo();

            var MyExampleClass = new AccessibleClass();
            Console.WriteLine(MyExampleClass.exampleField); // exampleField has declarated with 'new' keyword
        }
    }

    abstract class BaseInfoClass
    {
        protected readonly string classRole; // Role of class
        protected static readonly string PREFIX = $"[INFO - {DateTime.Now:h:m:ss tt}]:  ";

        public BaseInfoClass(string role)
        {
            classRole = role;
        }

        public virtual void ShowClassRole() // Show class role
        {
            Console.WriteLine(classRole);
        }

        public abstract void ShowInfo(); 
    }
    class PCInformation : BaseInfoClass
    {
        public PCInformation() : base("Show PC Infromation") // Constructor which takes role argument
        {
            
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"{PREFIX} PC Status: Good");
            Console.WriteLine($"{PREFIX} Free space: 120gb");
            Console.WriteLine($"{PREFIX} CPU temp: 50dg");
            Console.WriteLine($"{PREFIX} GPU temp: 60dg");
        }
    }
    class ServerInformation : BaseInfoClass
    {
        public ServerInformation() : base("Show Server Information") // Constructor which takes role argument
        {

        }

        readonly PCInformation PCInfo = new PCInformation();
        public override void ShowInfo()
        {
            PCInfo.ShowInfo();
            Console.WriteLine($"{PREFIX} Server Status: 20 TPS (Great)");
            Console.WriteLine($"{PREFIX} Server Online: 43 Players");
        }

        public override void ShowClassRole() // Overriding virtual method
        {
            base.ShowClassRole();
            Console.WriteLine("This method also shows PC info");
        }
    }


    class ConditionalyNotAccessibleClass // Class to show how to hide class members
    {
        protected readonly string exampleField = "Hello World";
    }
    class AccessibleClass : ConditionalyNotAccessibleClass
    {
        public new string exampleField = "My new string"; // Hiding parent class member
    }


}
