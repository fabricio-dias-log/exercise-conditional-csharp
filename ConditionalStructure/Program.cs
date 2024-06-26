﻿using System;

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
                Console.WriteLine("3 - Task 3: write if two numbers are multiples");
                Console.WriteLine("4 - Task 4: write duration of the game");
                Console.WriteLine("5 - Task 5: write the total of items cost");
                Console.WriteLine("6 - Task 6: write the interval of a number");
                Console.WriteLine("7 - Task 7: write numbers to get quadrant");
                Console.WriteLine("8 - Task 8: write salary to get tax");
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
                        var exercise2 = new Exerc2();
                        exercise2.evenOddNumber();
                        break;
                    case "3":
                        var exercise3 = new Exerc3();
                        exercise3.setMutiples();
                        break;
                    case "4":
                        var exercise4 = new Exerc4();
                        exercise4.gameHour();
                        break;
                    case "5":
                        var exercise5 = new Exerc5();
                        exercise5.getBillToPay();
                        break;
                    case "6":
                        var exercise6 = new Exerc6();
                        exercise6.getInterval();
                        break;
                    case "7":
                        var exercise7 = new Exerc7();
                        exercise7.getQuadrant();
                        break;
                    case "8":
                        var exercise8 = new Exerc8();
                        exercise8.getTaxes();
                        break;
                    
                    case "0":
                        break;
                }
                
                Console.WriteLine("----------------------------------");
            } while (option != "0");
            
        }
        
    }
}