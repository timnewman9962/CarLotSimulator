using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    class Car
    {
        public Car() { }

        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
        }

        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property            
        public void MakeEngineNoise(string noise)
        {
            EngineNoise = noise;
        }
        public void MakeHonkNoise(string noise)
        {
            HonkNoise = noise;
        }
    }

    class CarLot
    {
        private List<Car> inventory = new List<Car>();
        public List<Car> Inventory { get => inventory; }
        public void AddCar(Car someCar)
        {
            inventory.Add(someCar);
            numberOfCars++;
        }
        public static int numberOfCars;
    }

}
