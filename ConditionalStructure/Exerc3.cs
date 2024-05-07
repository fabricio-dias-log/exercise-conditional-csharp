namespace ConditionalStructure;

public class Exerc3
{
    public void setMutiples()
    {
        Console.WriteLine("Write first number: ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Write the second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        if (firstNumber % secondNumber == 0 || secondNumber % firstNumber == 0)
        {
            Console.WriteLine("Multiples");
        }
        else
        {
            Console.WriteLine("Not multiples");
        }
    }
}