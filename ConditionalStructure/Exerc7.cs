using System.Globalization;

namespace ConditionalStructure;

public class Exerc7
{
    public void getQuadrant()
    {
        Console.WriteLine("Write the X value: ");
        double xValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Write the Y value: ");
        double yValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        if (xValue == 0.0 && yValue == 0.0) {
            Console.WriteLine("Origem");
        }
        else if (xValue == 0.0) {
            Console.WriteLine("Eixo Y");
        }
        else if (yValue == 0.0) {
            Console.WriteLine("Eixo X");
        }
        else if (xValue > 0.0 && yValue > 0.0) {
            Console.WriteLine("Q1");
        }
        else if (xValue < 0.0 && yValue > 0.0) {
            Console.WriteLine("Q2");
        }
        else if (xValue < 0.0 && yValue < 0.0) {
            Console.WriteLine("Q3");
        }
        else {
            Console.WriteLine("Q4");
        }
    }
}