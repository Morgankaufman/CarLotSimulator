using Microsoft.VisualBasic;
using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //DONE Create a seperate class file called Car
            //DONE Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //DONE Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //DONE The methods should take one string parameter: the respective noise property


            //DONE Now that the Car class is created we can instanciate 3 new cars
            //DONE Set the properties for each of the cars
            //DONE Call each of the methods for each car

            var lot = new CarLot();


            var myCar = new Car();
            myCar.Year = 2001;
            myCar.Make = "Infiniti";
            myCar.Model = "G20";
            myCar.EngineNoise = "Vroom Vroom";
            myCar.HonkNoise = "Honk";
            myCar.IsDrivable = true;

            lot.Cars.Add(myCar);

            var firstCar = new Car()
            {
                Year = 1989,
                Make = "Plymouth",
                Model = "Sundance",
                EngineNoise = "Vroom",
                HonkNoise = "Beep",
                IsDrivable = false


            };
            lot.Cars.Add(firstCar);



            var secondCar = new Car(2012, "Chevy", "Traverse", "voom", "Brmp", true);

            lot.Cars.Add(secondCar);

            myCar.MakeEngineNoise(myCar.EngineNoise);
            myCar.MakeHonkNoise(myCar.HonkNoise);

            firstCar.MakeEngineNoise(firstCar.EngineNoise);
            firstCar.MakeHonkNoise(firstCar.HonkNoise);

            secondCar.MakeEngineNoise(secondCar.EngineNoise);
            secondCar.MakeHonkNoise(secondCar.HonkNoise);

              foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }
            


            //*************BONUS*************//

            //DONE Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //DONE Create a CarLot class
            //DONE It should have at least one property: a List of cars
            //DONE Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
