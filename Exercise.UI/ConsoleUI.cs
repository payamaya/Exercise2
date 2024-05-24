using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.UI
{
    //The Program konw that we work in the interface and not What the program should do and not how to do
    //talks about what needs to be done and cannot take intance of it
    public interface IUI
    {
        string GetInput();
        void Print(string message);
        void PrintWrite(string message);
    }

    // ConsoleUI Must Implement all teh methods() from IUI
    public class ConsoleUI : IUI
    {
        public void Print(string message)
        {
            Console.WriteLine(message);
        }

        public string GetInput()
        {
            return Console.ReadLine() ?? string.Empty;
        }
        public void PrintWrite(string message)
        {
            Console.Write(message);
        }
    }
}
