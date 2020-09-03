using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property            


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//
            var JoesCars = new CarLot();

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            var CarOne = new Car();
            CarOne.Year = 2020;
            CarOne.Make = "Chevy";
            CarOne.Model = "Impala";
            CarOne.EngineNoise = "hummmmm";
            CarOne.HonkNoise = "hawwwwnk";
            CarOne.IsDriveable = true;
            Console.WriteLine($"What's that noise coming from the {CarOne.Year} {CarOne.Make} {CarOne.Model}?");
            CarOne.MakeEngineNoise(Console.ReadLine());
            Console.WriteLine("Let me hear the horn!");
            CarOne.MakeHonkNoise(Console.ReadLine());

            JoesCars.AddCar(CarOne);
            Console.WriteLine($"That makes {CarLot.numberOfCars} car{(CarLot.numberOfCars == 1 ? "" : "s")}.\n");

            var CarTwo = new Car()
            {
                Year = 2000,
                Make = "Crysler",
                Model = "PT Cruiser",
                EngineNoise = "put-put-put-put",
                HonkNoise = "ahh-OOO-gaa",
                IsDriveable = true
            };
            Console.WriteLine($"What's that noise coming from the {CarTwo.Year} {CarTwo.Make} {CarTwo.Model}?");
            CarTwo.MakeEngineNoise(Console.ReadLine());
            Console.WriteLine("Let me hear the horn!");
            CarTwo.MakeHonkNoise(Console.ReadLine());

            JoesCars.AddCar(CarTwo);
            Console.WriteLine($"That makes {CarLot.numberOfCars} car{(CarLot.numberOfCars == 1 ? "" : "s")}.\n");

            var CarThree = new Car(1985, "Ford", "Fairlane", "put-put-pffffft", "crackle", false);
            Console.WriteLine($"What's that noise coming from the {CarThree.Year} {CarThree.Make} {CarThree.Model}?");
            CarThree.MakeEngineNoise(Console.ReadLine());
            Console.WriteLine("Let me hear the horn!");
            CarThree.MakeHonkNoise(Console.ReadLine());

            JoesCars.AddCar(CarThree);
            Console.WriteLine($"That makes {CarLot.numberOfCars} car{(CarLot.numberOfCars==1? "":"s")}.\n");

            Console.WriteLine("Let's see what we've got...");
            foreach (var car in JoesCars.Inventory)
            {
                Console.WriteLine($"Here's a {car.Year} {car.Make} {car.Model} that goes {car.EngineNoise}");
            }

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
