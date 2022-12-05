using System;
using System.Collections.Generic;
using Dealership.Models;

namespace Dealership
{
  public class Program
  {
    public static void Main()
    {
      Car nissan = new Car("2004 Murano", 24000, 100000);
      Car honda = new Car("2017 Accord", 27000, 50);
      Car mercedes = new Car("2020 GLE SUV", 56000, 123);

      List<Car> Cars = new List<Car>() { nissan, honda, mercedes };

      Console.WriteLine("Enter maximum price: ");
      string stringMaxPrice = Console.ReadLine();
      int maxPrice = int.Parse(stringMaxPrice);

      List<Car> CarsWithinBudget = new List<Car>(0);

      foreach (Car automobile in Cars)
      {
        if (automobile.WorthBuying(maxPrice))
        {
          CarsWithinBudget.Add(automobile);
        }
      }

      for (int i = 0; i < CarsWithinBudget.Count; i++)
      {
        Console.WriteLine($"{CarsWithinBudget[i].MakeModel}: ${CarsWithinBudget[i].Price}");
      }
    }
  }
}