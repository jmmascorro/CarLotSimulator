using System;

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

            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            Carlot lot = new Carlot();
            
      
            //Standard member initializer syntax
            Car chevy = new Car();
            lot.CarList.Add(chevy);

            chevy.Year = 2004;
            chevy.Make = "Chevrolet";
            chevy.Model = "Silverado";
            chevy.EngineNoise = "Vroom";
            chevy.HonkNoise = "Beep beep";
            chevy.IsDrivable = true;

            chevy.MakeEngineNoise(chevy.EngineNoise);
            chevy.MakeHonkNoise();

            //Object initializer syntax
            Car jeep = new Car() { Year = 2015, Make = "Jeep", Model = "Grand Cherokee", EngineNoise = "Vroom", HonkNoise = "BEEP BEEP", IsDrivable = true };
            lot.CarList.Add(jeep);

            jeep.MakeEngineNoise(jeep.EngineNoise);
            jeep.MakeHonkNoise();

            //Constructor initialization
            Car suv = new Car(2018, "Ford", "Escape", "vroom", "beep");
            lot.CarList.Add(suv);

            suv.MakeEngineNoise(suv.EngineNoise);
            suv.MakeHonkNoise();

            Console.WriteLine("--------------------");

            //*************BONUS X 2*************//

            foreach(var car in lot.CarList)
            {
                Console.WriteLine();
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");

            }

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

        }
    }
}
