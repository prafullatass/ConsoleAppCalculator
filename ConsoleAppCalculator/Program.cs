using System;
using System.Text;

namespace ConsoleAppCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- This is an arithmetic claculator ---");
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("add: Addition\n");
            sb1.Append("sub:Subtraction\n");
            sb1.Append("mult:Multiplication\n");
            sb1.Append("div:Division");
            Console.WriteLine("Type your commands here:\n" + sb1.ToString());
            Console.Write(">:");
            string choice = Console.ReadLine().ToString().ToLower();
        }
    }
}
