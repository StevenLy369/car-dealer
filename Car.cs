using System;
using System.Collections.Generic;

public class Car{
    public string MakeModel;
    public int Price;
    public int Miles;

    public bool Worthbuying(int maxPrice){
        return (Price < maxPrice);
    }
    
}

public class Program{

    public static void Main(){
        Car audi = new Car();
        audi.MakeModel = "2015 Audi s4";
        audi.Price = 35000;
        audi.Miles = 37000;

        Car volkswagen = new Car();
        volkswagen.MakeModel = "1974 Volkswagen Thing";
        volkswagen.Price = 1100;
        volkswagen.Miles = 368792;

        Car ford = new Car();
        ford.MakeModel = "1988 Ford Country Squire";
        ford.Price = 1400;
        ford.Miles = 239001;
        List<Car> Cars = new List<Car>() { audi, volkswagen, ford };
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