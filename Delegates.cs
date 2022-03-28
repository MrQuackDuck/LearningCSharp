using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpConstructions
{
    public delegate void ShowMessageHandler(string str);

    internal class Delegates
    {
        public void Start()
        {
            var myCalc = new Calculator();
            myCalc.RegisterHandler(ShowConsoleMessage);
            myCalc.Add(1, 4);

            // Now we handling message in several methods.
            myCalc.msgHandler += ShowWindowMessage;
            myCalc.Add(2, 2);

            // Removing handler
            myCalc.msgHandler -= ShowConsoleMessage;
            myCalc.Add(1, 1);
        }

        public void ShowConsoleMessage(string message)
        {
            Console.WriteLine($"Result: {message}");
        }

        public static void ShowWindowMessage(string message)
        {
            MessageBox.Show($"Result: {message}");
        }
    }

    class Calculator
    {
        /* We are register functions to handle operations from this class.
        * It allows us to set flexible function which handle some operations.
        * For example if it was window app we could place here method to show message in new
        * window. */
        public ShowMessageHandler msgHandler;
        public void RegisterHandler(ShowMessageHandler handler)
        {
            msgHandler += handler;
        }

        public void Add(int a, int b)
        {
            int result = a + b;
            msgHandler(result.ToString());
        }

        public void Substract(int a, int b)
        {
            int result = a - b;
            msgHandler(result.ToString());
        }
    }
}
