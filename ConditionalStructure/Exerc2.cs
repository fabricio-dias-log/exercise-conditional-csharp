namespace ConditionalStructure;

public class Exerc2
{
    public void evenOddNumber()
    {
        Console.Write("Write some number: ");
        int numberToRead = int.Parse(Console.ReadLine());
        
        if (numberToRead % 2 == 0)
        {
            Console.WriteLine("Even number");
        }else
        {
            Console.WriteLine("Odd number");
        }
    }
}