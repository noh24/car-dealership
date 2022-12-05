using System;
using System.Collections.Generic;

public class Car
{
  public string MakeModel;
  public int Price;
  public int Miles;
  
  public bool WorthBuying(int maxPrice)
  {
    return (Price <= maxPrice);
  }
}

public class Program
{
  public static void Main()
  {
    Car nissan = new Car();
    nissan.MakeModel = "2004 Murano";
    nissan.Price = 24000;
    nissan.Miles = 100000;

    Car honda = new Car();
    honda.MakeModel = "2017 Accord";
    honda.Price = 27000;
    honda.Miles = 50;

    Car mercedes = new Car();
    mercedes.MakeModel = "2020 GLE SUV";
    mercedes.Price = 56000;
    mercedes.Miles = 123;

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