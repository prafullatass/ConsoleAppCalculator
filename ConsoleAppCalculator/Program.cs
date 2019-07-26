using System;
using System.Text;

namespace ConsoleAppCalculator
{
    class Program
    {
        static void add(int n1, int n2)
        {
            Console.WriteLine("The Result is:{0}\n", n1 + n2);
        }
        static void sub(int n1, int n2)
        {
            Console.WriteLine("The Result is:{0}\n", n1 - n2);
        }
        static void mult(int n1, int n2)
        {
            Console.WriteLine("The Result is:{0}\n", n1 * n2);
        }
        static void div(int n1, int n2)
        {
            if (n2 == 0)
            {
                Console.WriteLine("ALERT: Division by zero is invalid!");

            }
            else
            {
                Console.WriteLine("The Result is:{0}\n", n1 / n2);
            }
        }
        static void Main(string[] args)
        {
            string choice = "";
            do
            {
                try
                {
                    Console.WriteLine("--- This is an arithmetic claculator ---");
                    Console.WriteLine("Enter two numbers:");
                    string n1 = Console.ReadLine();
                    string n2 = Console.ReadLine();
                    int num1 = int.Parse(n1);
                    int num2 = int.Parse(n2);
                    StringBuilder sb1 = new StringBuilder();
                    sb1.Append("add: Addition\n");
                    sb1.Append("sub:Subtraction\n");
                    sb1.Append("mult:Multiplication\n");
                    sb1.Append("div:Division\n");
                    sb1.Append("exit:Exit");
                    Console.WriteLine("Type your commands here:\n" + sb1.ToString());
                    Console.Write(">:");
                    choice = Console.ReadLine().ToString().ToLower();
                    switch (choice)
                    {
                        case "add":
                            add(num1, num2);
                            break;
                        case "sub":
                            sub(num1, num2);
                            break;
                        case "mult":
                            mult(num1, num2);
                            break;
                        case "div":
                            div(num1, num2);
                            break;
                        case "exit":
                            break;
                        default:
                            //default command error message 
                            Console.WriteLine("Bad Command");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Something is wrong!");
                }
            } while (choice != "exit");
        }
    }
}
