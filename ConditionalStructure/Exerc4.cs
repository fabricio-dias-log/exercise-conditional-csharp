namespace ConditionalStructure;

public class Exerc4
{
    public void gameHour()
    {
        int duration;
        
        Console.WriteLine("Write the game start hour: ");
        int startHour = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Write the game end hour: ");
        int endHour = int.Parse(Console.ReadLine());
       
        if (startHour < endHour) {
            duration = endHour - startHour;
        }
        else {
            duration = 24 - startHour + endHour;
        }

        Console.WriteLine($"The game lasted {duration} hours!");
    }
}