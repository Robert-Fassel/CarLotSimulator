using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var lot = new CarLot();
            

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            var focus = new Car();
            focus.Make = "Ford";
            focus.Model = "Focus";
            focus.Year = 2013;
            focus.EngineNoise = "vroom";
            focus.HonkNoise = "beep";
            focus.IsDrivable= true;

            lot.Cars.Add(focus);

            var stevsCar = new Car()
            {
                Year = 2019,
                Make = "Tesla",
                Model = "Cyber Truck",
                EngineNoise = "hum",
                HonkNoise = "meepmeep",
                IsDrivable = false
            };
            lot.Cars.Add (stevsCar);
            var brettsCar = new Car(2013, "honda", "Civic", "Rar", "Oogah", true);
            lot.Cars.Add(brettsCar);

            //Call methods
            focus.MakeEngineNoise(focus.EngineNoise);
            stevsCar.MakeEngineNoise(stevsCar.EngineNoise);
            brettsCar.MakeEngineNoise(brettsCar.EngineNoise);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            Console.WriteLine($"Number of cars created {CarLot.numberOfCars}");
            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }
        }

    }
}
