using System.Globalization;

namespace ConditionalStructure;

public class Exerc5
{
   public void getBillToPay()
   {
      int codigo1 = 1;
      double value1 = 4.00;
      string name1 = "Hot Dog";
      
      int codigo2 = 2;
      double value2 = 4.50;
      string name2 = "X-Salad";
      
      int codigo3 = 3;
      double value3 = 5.00;
      string name3 = "X-Bacon";
      
      int codigo4 = 4;
      double value4 = 2.00;
      string name4 = "Simple toast";
      
      int codigo5 = 5;
      double value5 = 1.50;
      string name5 = "Soda";
      
      Console.WriteLine("Menu: ");
      Console.WriteLine("----------------------------------");
      Console.Write("Code     ");
      Console.Write("Name           ");
      Console.WriteLine("Cost");
      Console.WriteLine("----------------------------------");
      Console.WriteLine($"{codigo1}        {name1}        {value1.ToString("F2", CultureInfo.InvariantCulture)}");
      Console.WriteLine($"{codigo2}        {name2}        {value2.ToString("F2", CultureInfo.InvariantCulture)}");
      Console.WriteLine($"{codigo3}        {name3}        {value3.ToString("F2", CultureInfo.InvariantCulture)}");
      Console.WriteLine($"{codigo4}        {name4}   {value4.ToString("F2", CultureInfo.InvariantCulture)}");
      Console.WriteLine($"{codigo5}        {name5}           {value5.ToString("F2", CultureInfo.InvariantCulture)}");
      Console.WriteLine("----------------------------------");
      
      Console.Write("Select an option by code: ");
      int option = int.Parse(Console.ReadLine());
      
      Console.Write("Write the amount of items: ");
      int amountItems = int.Parse(Console.ReadLine());

      if (option == 1)
      {
         Console.WriteLine($"Total: R$ {(value1 * amountItems).ToString("F2", CultureInfo.InvariantCulture)}");
      }
      else if(option == 2)
      {
         Console.WriteLine($"Total: R$ {(value2 * amountItems).ToString("F2", CultureInfo.InvariantCulture)}");         
      }
      else if(option == 3)
      {
         Console.WriteLine($"Total: R$ {(value3 * amountItems).ToString("F2", CultureInfo.InvariantCulture)}");         
      }
      else if(option == 4)
      {
         Console.WriteLine($"Total: R$ {(value4 * amountItems).ToString("F2", CultureInfo.InvariantCulture)}");         
      }
      else if(option == 5)
      {
         Console.WriteLine($"Total: R$ {(value5 * amountItems).ToString("F2", CultureInfo.InvariantCulture)}");         
      }
      else
      {
         Console.WriteLine("There isn't this option!");
      }
   }
}