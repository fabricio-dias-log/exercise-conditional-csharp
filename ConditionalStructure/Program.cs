using System;

namespace ConditionalStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? option;

            do
            {
                Console.WriteLine("Menu: ");
                Console.WriteLine("----------------------------------");
                Console.WriteLine("1 - Task 1: write if a number is negative");
                Console.WriteLine("2 - Task 2: write if a number is even or odd");
                
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Select an option: ");
                
                option = Console.ReadLine();
                Console.Clear();
                switch (option)
                {
                    case "1":
                        var exercise1 = new Exerc1();
                        exercise1.readNumber();
                        break;
                    case "2":
                        var excerise2 = new Exerc2();
                        excerise2.evenOddNumber();
                        break;
                    case "3":
                        
                        break;
                    
                    case "0":
                        break;
                }
                
                Console.WriteLine("----------------------------------");
            } while (option != "0");
            
        }
        
    }
}