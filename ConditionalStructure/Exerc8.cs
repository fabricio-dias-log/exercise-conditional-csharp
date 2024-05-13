using System.Globalization;

namespace ConditionalStructure;

public class Exerc8
{
    public void getTaxes()
    {
        double tax;
        double tax18;
        double tax08;
        double remainValue;
        double taxNotExempt;
        Console.WriteLine("Write your salary: ");
        double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        if (salary <= 2000.00)
        {
            Console.WriteLine("Exempt");
        } 
        else if (salary >= 2000.01 && salary <= 3000.00)
        {
            tax = salary * 0.8;
            Console.WriteLine($"Tax: R$ {tax}");
        } 
        else if (salary >= 3000.01 && salary <= 4500.00)
        {
            remainValue = salary - 3000.00;
            taxNotExempt = (salary - 2000.00) - remainValue;
            tax = (taxNotExempt * 0.08) + (remainValue * 0.18);

            Console.WriteLine($"Tax: R$ {tax}");
        }
        else
        {
            remainValue = salary - 4500.00;
            tax18 = (salary - 3000.00) - remainValue;
            tax08 = (salary - 2000.00 - remainValue) - tax18;
            tax = (tax08 * 0.08) + (tax18 * 0.18) + (remainValue * 0.28);
            
            Console.WriteLine($"Tax: R$ {tax.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}