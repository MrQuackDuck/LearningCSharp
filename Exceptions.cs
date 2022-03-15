using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Numerics;
using System.Security.Cryptography;

namespace CSharpConstructions
{
    internal class Exceptions
    {
        public void Start()
        {
            try // Exception handling with 2 catch blocks
            {
                TooManySymbolsException symbolsException = new TooManySymbolsException();
                throw symbolsException;
            }
            catch (TooManySymbolsException e) when(e.Date.DayOfWeek != DayOfWeek.Friday) // 'when' block
            {
                Console.WriteLine("====First Block Catch");
                Console.WriteLine(ExceptionHandler(e));
            }
            catch (Exception e)
            {
                Console.WriteLine("====Second Block Catch");
                Console.WriteLine(ExceptionHandler(e));
            }
            finally // Block finally always executed. It can be used as end of program
            {
                Console.WriteLine("=====================\n  Block finally\n=====================");
            }

            Console.WriteLine("\n\n");
            string myString = "Yes yes yes yes yes yes yes yes yes yes yes";
            checkString(myString); // Demonstration work of own ApplicationExcpetion type (line 61)
        }

        static void checkString(string myStr)
        {
            TooManySymbolsException tooManySymbols = new TooManySymbolsException(40, myStr.Length);
            if (myStr.Length > 40)
            {
                throw tooManySymbols;
            }
        }
        static string ExceptionHandler(Exception e)
        {
            string message = $"Error occurred!\n |Message: {e.Message};\n |Source: {e.Source};\n |Data: {e.Data};\n |TargetSite: {e.TargetSite};\n |Stack trace: {e.StackTrace};";
            return message;
        }
    }

    [Serializable]
    class TooManySymbolsException : ApplicationException
    {
        string ErrorMessage;
        public DateTime Date { get; set; } = DateTime.Now;

        // Constructors
        public TooManySymbolsException()
        {
            ErrorMessage = "Too many symbols!";
        }
        public TooManySymbolsException(int maxSymbols)
        {
            ErrorMessage = $"Too many symbols! Max value: {maxSymbols}";
        }
        public TooManySymbolsException(int maxSymbols, int currentSymbols)
        {
            ErrorMessage = $"Too many symbols! Max value: {maxSymbols}. Current symbols: {currentSymbols}";
        }

        // Overriding message
        public override string Message => ErrorMessage;
    }
}
