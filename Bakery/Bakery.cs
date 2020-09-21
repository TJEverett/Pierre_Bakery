using System;
using Bakery;

namespace Bakery
{
  class Program
  {
    static void Main()
    {
      int orderOption = 0;
      int orderBread = 0;
      int orderPastries = 0;
      int orderPrice = 0;
      Console.WriteLine("Welcome to Pierre's Bakery Price Calculator");
      Console.WriteLine("");
      Console.WriteLine("While there are multiple varieties of products we sell,");
      Console.WriteLine("Lets just say Bread is $5 for 1 with a buy 2 get 1 free deal,");
      Console.WriteLine("And Pastries are $2 for 1 or $5 for 3.");
      Console.WriteLine("");
      Console.WriteLine("Please pick between: (1) Bread, (2) Pastries, or (3) Both");
      orderOption = int.Parse(Console.ReadLine());

      if(orderOption == 1)
      {
        orderBread = GetBread();
      }
      else if (orderOption == 2)
      {
        orderPastries = GetPastries();
      }
      else
      {
        orderBread = GetBread();
        orderPastries = GetPastries();
      }
      Bread breadOrder = new Bread(orderBread);
      breadOrder.CalculatePrice();
      Pastry pastriesOrder = new Pastry(orderPastries);
      pastriesOrder.CalculatePrice();
      orderPrice = breadOrder.Price + pastriesOrder.Price;

      Console.WriteLine("Your order of " + orderBread + " bread and " + orderPastries + " pastries comes out to $" + orderPrice);
    }

    static int GetBread()
    {
      Console.WriteLine("How many loafs of bread are you ordering today?");
      int value = int.Parse(Console.ReadLine());
      if (!(value >= 0))
      {
        Console.WriteLine("An Error Occurred Trying again.");
        value = GetBread();
      }
      return value;
    }

    static int GetPastries()
    {
      Console.WriteLine("How many pastries are you ordering today?");
      int value = int.Parse(Console.ReadLine());
      if (!(value >= 0))
      {
        Console.WriteLine("An Error Occurred Trying again.");
        value = GetPastries();
      }
      return value;
    }
  }
}