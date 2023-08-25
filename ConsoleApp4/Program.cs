using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ObjectiveC;

namespace ConsoleApp4
{
    class Program
    {
        static int row = 0;
        static public void print()
        {
            dynamic temp;

            while (true)
            {
                Console.Clear();

                Console.Write("\t\t\t      ");
                Console.WriteLine("CALCULATOR\n\n");

                Console.Write("\t\t\t\t");
                if (row == 0)
                    Console.Write("->");
                Console.WriteLine("ADD");


                Console.Write("\t\t\t\t");
                if (row == 1)
                    Console.Write("->");
                Console.WriteLine("MINUS");


                Console.Write("\t\t\t\t");
                if (row == 2)
                    Console.Write("->");
                Console.WriteLine("MULTIPLE");


                Console.Write("\t\t\t\t");
                if (row == 3)
                    Console.Write("->");
                Console.WriteLine("DIVIDE");

                temp = Console.ReadKey(true);

                if (temp.Key == ConsoleKey.UpArrow)
                {
                    if (row == 0)
                        row = 3;
                    else
                        row -= 1;
                }
                else if (temp.Key == ConsoleKey.DownArrow)
                {
                    if (row == 3)
                        row = 0;
                    else
                        row += 1;
                }
                else if (temp.Key == ConsoleKey.Enter)
                {
                    return;
                }

            }


        }
        static void Main(string[] args)
        {
            int secim;
            float num1, num2;
            while (true)
            {

                print();
                Console.Clear();

                Console.Write("Number 1: "); num1 = float.Parse(Console.ReadLine());
                Console.Write("Number 2: "); num2 = float.Parse(Console.ReadLine());
                Console.Clear();

                switch (row)
                {
                    case 0:
                        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                        break;
                    case 1:
                        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                        break;
                    case 2:
                        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                        break;
                    case 3:
                        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                        break;
                    default:
                        Console.WriteLine("Duzgun secim etmediniz!");
                        break;

                }
                Console.Write("\nEnter any button for Menu...");
                Console.ReadKey();
                row = 0;
            }
        }
    }
}
//ByVC