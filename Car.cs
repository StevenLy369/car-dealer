using System;
using System.Collections.Generic;

public class Car
{
  public string MakeModel;
  public int Price;
  public int Miles;

  public string Info;

  public Car(string makeModel, int price, int miles, string info)
  {
    MakeModel = makeModel;
    Price = price;
    Miles = miles;
    Info = info;
  }

  public bool WorthBuying(int maxPrice)
  {
    return (Price < maxPrice);
  }
}

public class Program
{
  public static void Main()
  {
    Car audi = new Car("2015 Audi s4", 25000, 35000, "Very nice car. I like");
    Car yugo = new Car("1980 Yugo Koral", 9000, 56000, "Okay car, not bad.");
    Car ford = new Car("1988 Ford Country Squire", 7500, 176554, "Decent car");
    Car amc = new Car("1976 AMC Pacer",5000, 198000, "Okay car");

    List<Car> Cars = new List<Car>() { audi, yugo, ford, amc };

    Console.WriteLine("Enter maximum price: ");
    string stringMaxPrice = Console.ReadLine();
    int maxPrice = int.Parse(stringMaxPrice);
    Console.WriteLine("Enter Maximum amount of miles.");
    string maxMileageStr = Console.ReadLine();
    int maxMileage = int.Parse(maxMileageStr);
    List<Car> CarsMatchingSearch = new List<Car>(0);

    foreach (Car automobile in Cars)
    {
      if (automobile.WorthBuying(maxPrice) && automobile.Miles < maxMileage)
      {
        CarsMatchingSearch.Add(automobile);
      }
      if (maxPrice < 5000){
          Console.WriteLine("You too cheap, we dont sell cars that low");
      }
      if (maxMileage < 7500){
          Console.WriteLine("Sorry, We sell used cars here. Not new.");
      }
    }

    foreach(Car automobile in CarsMatchingSearch)
    {
      Console.WriteLine(automobile.MakeModel);
      Console.WriteLine(automobile.Info);
    }
  }
}