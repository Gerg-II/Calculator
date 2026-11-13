using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Calculator
{
    internal class Program
    {
        static void Main()
        {
            float num1 = Number1();
            int operation = Operation(num1);
            char opSymb;
            switch (operation)
            {
                case 1:
                    opSymb = '+';
                    break;
                case 2:
                    opSymb = '-';
                    break;
                case 3:
                    opSymb = '*';
                    break;
                case 4:
                    opSymb = '÷';
                    break;
                case 5:
                    opSymb = '%';
                    break;
                case 6:
                    opSymb = '^';
                    break;
                default:
                    opSymb = '#';
                    break;
            } 
            float num2 = Number2(num1, opSymb);
        }

        static void Invalid() // generic invalid message
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid Input. Please try again");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            Console.Clear();
        } 
        static float Number1() // input for the first number
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter the your first number:");
                    float num1 = float.Parse(Console.ReadLine());
                    return num1;
                }
                catch
                {
                    Invalid();
                }
            }
        }
        static float Number2(float num1,char opSymb) // input for second number, uses the first number and operator used in message at the start.
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("First number:\t"+ num1);
                    Console.WriteLine("Operator:\t"+ opSymb);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("\nEnter the your second number:\n"); 
                    float num2 = float.Parse(Console.ReadLine());
                    return num2;
                }
                catch 
                {
                    Invalid();
                }
            }
        }
        static int Operation(float num1)
        {
            while(true)
            {
                try
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("First number:\t"+ num1); // prints the first number they input
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine("\nEnter the number for the operator you would like to use:");
                    Console.WriteLine(" 1. + \t 2. - \t 3. x \t 4. ÷ \t 5. % \t 6. ^\n");
                    int op = int.Parse(Console.ReadLine());
                    if (op > 0 && op  < 7) { return  op; }
                    else { Invalid(); }
                }
                catch{ Invalid(); }
            }            
        }
    }
}
