namespace ConditionalStructure;

public class Exerc1
{
    public void readNumber()
    {
        Console.Write("Write some number: ");
        int numberToRead = int.Parse(Console.ReadLine());

        if (numberToRead >= 0)
        {
            Console.WriteLine("Not negative");
        }else
        {
            Console.WriteLine("Negative");
        }
    }
}