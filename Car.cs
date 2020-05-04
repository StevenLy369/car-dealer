using System;
using System.Collections.Generic;

public class Car{
    public string MakeModel;
    public int Price;
    public int Miles;

    public bool Worthbuying(int maxPrice){
        return (Price < maxPrice);
    }

    public Car(string MakeModel, int price, int miles){
        MakeModel = MakeModel;
        Price = price;
        Miles = miles;
    }
    
}

public class Program{

    public static void Main(){
         Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792);
        Car yugo = new Car("1980 Yugo Koral", 700, 56000);
        Car ford = new Car("1988 Ford Country Squire", 1400, 239001);
      
        List<Car> Cars = new List<Car>() { volkswagen, yugo, ford };
        List<Car> CarsMatchingSearch = new List<Car>(0); 
        Console.WriteLine("Enter Maxium price:");
        string stringMaxPrice = Console.ReadLine();
        int maxPrice = int.Parse(stringMaxPrice);

        foreach(Car automobile in Cars){
            if (automobile.Worthbuying(maxPrice)){
                CarsMatchingSearch.Add(automobile);
            }
        }
        foreach(Car automobile in CarsMatchingSearch){
            Console.WriteLine(automobile.MakeModel);
        }

    }
}